using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows;
using System.IO.Ports;


namespace serial1
{
    public partial class FormMain : Form
    {
        // This method that will be called when the thread is started

        const int baudrate = 9600;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static volatile int komunikacjaWTrakcie = 0;
        static Series seriesTemperaturaAktualna;
        static Series seriesTemperaturaZadana;
        static DateTime czasRozpoczeciaKomunikacji;
        static volatile int czasZainicjalizowany = 0;
        static int timerEventCounter = 0;
        static int rozpoczynamRysowanieWykresu = 1;

        public FormMain()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBoxPortNames.Items.Clear();
            comboBoxPortNames.Items.AddRange(ports);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            seriesTemperaturaAktualna = this.chart1.Series.Add("Temperatura aktualna");
            seriesTemperaturaZadana = this.chart1.Series.Add("Temperatura zadana");

            seriesTemperaturaAktualna.ChartType = seriesTemperaturaZadana.ChartType = SeriesChartType.Line; // sensowne rodzaje: Area, Line, Range, StackedArea
            seriesTemperaturaAktualna.XValueType = seriesTemperaturaZadana.XValueType = ChartValueType.Time;
            seriesTemperaturaAktualna.Color = Color.Blue;
            seriesTemperaturaZadana.Color = Color.Red;

            this.chart1.ChartAreas[0].AxisY.Title = "Temperatura [°C]";
            this.chart1.ChartAreas[0].AxisY.Interval = 5;
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 100;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;

            this.chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine());
            this.chart1.ChartAreas[0].AxisY.StripLines[0].BackColor = Color.LightGoldenrodYellow;//Color.LemonChiffon;
            this.chart1.ChartAreas[0].AxisY.StripLines[0].StripWidth = 5;
            this.chart1.ChartAreas[0].AxisY.StripLines[0].Interval = 10;
            this.chart1.ChartAreas[0].AxisY.StripLines[0].IntervalOffset = 0;

            this.chart1.ChartAreas[0].AxisX.Title = "Czas [s]";
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPortNames.Text == "")
                {
                    //textBoxReceived.Text = "Please select port settings.";
                }
                else
                {
                    serialPort1.PortName = comboBoxPortNames.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baudrate);
                    serialPort1.Open();
                    progressBarStatus.Value = 100;
                    buttonOpenPort.Enabled = false;
                    buttonClosePort.Enabled = true;

                    buttonZmienStanKotla.Enabled = true;
                    buttonZmienTrybManualny.Enabled = true;
                    buttonZmienStanMieszadla.Enabled = true;
                    buttonZmienTestoweParametryPID.Enabled = true;

                    if (czasZainicjalizowany == 0)
                    {
                        czasRozpoczeciaKomunikacji = DateTime.Now;
                    }

                    czasZainicjalizowany = 1;

                    /* Adds the event and the event handler for the method that will process the timer event to the timer. */
                    myTimer.Tick += new EventHandler(TimerEventProcessor);

                    // Sets the timer interval to 200 miliseconds.
                    myTimer.Interval = 200;
                    myTimer.Start();
                }
            }
            catch (UnauthorizedAccessException)
            {
                //textBoxReceived.Text = "ERROR: Unauthorized access.";
            }
        }

        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            while (Convert.ToBoolean(komunikacjaWTrakcie))
            {
                continue;
            }
            myTimer.Stop();

            serialPort1.Close();
            progressBarStatus.Value = 0;
            buttonOpenPort.Enabled = true;
            buttonClosePort.Enabled = false;

            buttonZmienStanKotla.Enabled = false;
            buttonZmienTrybManualny.Enabled = false;
            buttonZmienStanMieszadla.Enabled = false;
            buttonZmienTestoweParametryPID.Enabled = false;

        }

        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            komunikacjaWTrakcie = 1;
            myTimer.Stop();

            // wysylanie
            const int numberOfBytesToWrite = 20;
            byte[] bytesToWrite = new byte[numberOfBytesToWrite];
            const int temperatureMultiplier = 10;
            const int regulatorVariablesMultiplier = 100;

            bytesToWrite[0] = Convert.ToByte(0xFF & Convert.ToUInt32(this.numericUpDownStanKotla.Value)); // stan_kotla
            bytesToWrite[1] = Convert.ToByte(0x00FF & Convert.ToUInt16(this.numericUpDownTemperaturaZadana.Value * temperatureMultiplier)); // temp_zadana
            bytesToWrite[2] = Convert.ToByte((0xFF00 & Convert.ToUInt16(this.numericUpDownTemperaturaZadana.Value * temperatureMultiplier)) >> 8); // temp_zadana
            bytesToWrite[3] = Convert.ToByte(0xFF & Convert.ToUInt32(this.numericUpDownStanMieszadla.Value)); // stan_mieszadla

            bytesToWrite[4] = Convert.ToByte(0xFF & Convert.ToUInt32(this.numericUpDownTestoweParametryPID.Value)); // testowe_parametry_pid

            bytesToWrite[5] = Convert.ToByte(0x000000FF & Convert.ToUInt32(this.numericUpDownStalaP.Value * regulatorVariablesMultiplier)); // stala_p
            bytesToWrite[6] = Convert.ToByte((0x0000FF00 & Convert.ToUInt32(this.numericUpDownStalaP.Value * regulatorVariablesMultiplier)) >> 8); // stala_p
            bytesToWrite[7] = Convert.ToByte((0x00FF0000 & Convert.ToUInt32(this.numericUpDownStalaP.Value * regulatorVariablesMultiplier)) >> 16); // stala_p
            bytesToWrite[8] = Convert.ToByte((0xFF000000 & Convert.ToUInt32(this.numericUpDownStalaP.Value * regulatorVariablesMultiplier)) >> 24); // stala_p

            bytesToWrite[9] = Convert.ToByte(0x000000FF & Convert.ToUInt32(this.numericUpDownStalaI.Value * regulatorVariablesMultiplier)); // stala_i
            bytesToWrite[10] = Convert.ToByte((0x0000FF00 & Convert.ToUInt32(this.numericUpDownStalaI.Value * regulatorVariablesMultiplier)) >> 8); // stala_i
            bytesToWrite[11] = Convert.ToByte((0x00FF0000 & Convert.ToUInt32(this.numericUpDownStalaI.Value * regulatorVariablesMultiplier)) >> 16); // stala_i
            bytesToWrite[12] = Convert.ToByte((0xFF000000 & Convert.ToUInt32(this.numericUpDownStalaI.Value * regulatorVariablesMultiplier)) >> 24); // stala_i

            bytesToWrite[13] = Convert.ToByte(0x000000FF & Convert.ToUInt32(this.numericUpDownStalaD.Value * regulatorVariablesMultiplier)); // stala_d
            bytesToWrite[14] = Convert.ToByte((0x0000FF00 & Convert.ToUInt32(this.numericUpDownStalaD.Value * regulatorVariablesMultiplier)) >> 8); // stala_d
            bytesToWrite[15] = Convert.ToByte((0x00FF0000 & Convert.ToUInt32(this.numericUpDownStalaD.Value * regulatorVariablesMultiplier)) >> 16); // stala_d
            bytesToWrite[16] = Convert.ToByte((0xFF000000 & Convert.ToUInt32(this.numericUpDownStalaD.Value * regulatorVariablesMultiplier)) >> 24); // stala_d

            bytesToWrite[17] = Convert.ToByte(0xFF & Convert.ToUInt32(this.numericUpDownTrybManualny.Value)); // tryb_manualny_grzalek
            bytesToWrite[18] = Convert.ToByte(0x00FF & Convert.ToUInt16(this.numericUpDownStanGrzalekManualny.Value)); // stan_grzalek_manualny
            bytesToWrite[19] = Convert.ToByte((0xFF00 & Convert.ToUInt16(this.numericUpDownStanGrzalekManualny.Value)) >> 8); // stan_grzalek_manualny

            byte[] bajty = new byte[4];
            for (int i = 0; i < 4; ++i)
            {
                bajty[i] = 0xFF;
            }
            serialPort1.Write(bajty, 0, 4);
            serialPort1.Write(bytesToWrite, 0, numberOfBytesToWrite);

            // czytanie
            const int numberOfBytesToRead = 4;
            byte[] bytesToRead = new byte[numberOfBytesToRead];

            Thread.Sleep(20);
            serialPort1.Read(bytesToRead, 0, 4);
            // bytesToRead[0] <-> temp_aktualna LSB
            // bytesToRead[1] <-> temp_aktualna MSB
            // bytesToRead[2] <-> stan_grzalek LSB
            // bytesToRead[3] <-> stan_grzalek MSB

            UInt16 tempUInt16;
            decimal tempDecimal;
            const decimal tempMaxValue = ((decimal)100.0000000);
            const decimal tempMinValue = ((decimal)0.0000000);
            const decimal stanGrzalekMaxValue = ((decimal)3000);
            const decimal stanGrzalekMinValue = ((decimal)0);

            tempUInt16 = Convert.ToUInt16(bytesToRead[0]);
            tempUInt16 += Convert.ToUInt16(Convert.ToUInt16(bytesToRead[1]) << 8);
            tempDecimal = Convert.ToDecimal((Convert.ToDouble(tempUInt16)) / temperatureMultiplier);
            if (tempDecimal <= tempMaxValue && tempDecimal >= tempMinValue)
            {
                this.numericUpDownTemperaturaAktualna.Value = tempDecimal;
            }

            tempUInt16 = Convert.ToUInt16(bytesToRead[2]);
            tempUInt16 += Convert.ToUInt16((Convert.ToUInt16(bytesToRead[3])) << 8);
            tempDecimal = Convert.ToDecimal(tempUInt16);
            if (tempDecimal <= stanGrzalekMaxValue && tempDecimal >= stanGrzalekMinValue)
            {
                this.numericUpDownStanGrzalek.Value = tempDecimal;
            }

            textBoxTest.Text = BitConverter.ToString(bytesToWrite);
            textBoxTest2.Text = BitConverter.ToString(bytesToRead);
            textBoxTest3.Text = serialPort1.ReadLine();

            komunikacjaWTrakcie = 0;

            if (++timerEventCounter >= 4 || rozpoczynamRysowanieWykresu == 1) // co okolo 1 sekunde
            {
                seriesTemperaturaAktualna.Points.AddXY(DateTime.Now, this.numericUpDownTemperaturaAktualna.Value);
                seriesTemperaturaZadana.Points.AddXY(DateTime.Now, this.numericUpDownTemperaturaZadana.Value);
                //seriesTemperaturaAktualna.Points.AddXY((DateTime.Now - czasRozpoczeciaKomunikacji).TotalSeconds, this.numericUpDownTemperaturaAktualna.Value);
                //seriesTemperaturaZadana.Points.AddXY((DateTime.Now - czasRozpoczeciaKomunikacji).TotalSeconds, this.numericUpDownTemperaturaZadana.Value);
                rozpoczynamRysowanieWykresu = 0;
                timerEventCounter = 0;
            }

            myTimer.Enabled = true;
        }

        private void buttonZmienStanKotla_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownStanKotla.Value == 1)
            {
                this.numericUpDownStanKotla.Value = 0;
            }
            else
            {
                this.numericUpDownStanKotla.Value = 1;
            }
        }

        private void buttonZmienTrybManualny_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownTrybManualny.Value == 1)
            {
                this.numericUpDownTrybManualny.Value = 0;
            }
            else
            {
                this.numericUpDownTrybManualny.Value = 1;
            }
        }

        private void buttonZmienStanMieszadla_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownStanMieszadla.Value == 1)
            {
                this.numericUpDownStanMieszadla.Value = 0;
            }
            else
            {
                this.numericUpDownStanMieszadla.Value = 1;
            }
        }

        private void buttonAktualizujPorty_Click(object sender, EventArgs e)
        {
            getAvailablePorts();
        }

        private void labelStalaP_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownStalaP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelStalaI_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownStalaI_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelStalaD_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownStalaD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonZmienTestoweParametryPID_Click(object sender, EventArgs e)
        {
            if (this.numericUpDownTestoweParametryPID.Value == 1)
            {
                this.numericUpDownTestoweParametryPID.Value = 0;
            }
            else
            {
                this.numericUpDownTestoweParametryPID.Value = 1;
            }
        }
    }
}
