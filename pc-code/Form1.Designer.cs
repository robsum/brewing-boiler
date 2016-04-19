namespace serial1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem1 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem2 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            this.comboBoxPortNames = new System.Windows.Forms.ComboBox();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.buttonClosePort = new System.Windows.Forms.Button();
            this.labelPortNames = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxKociolWartosciOtrzymane = new System.Windows.Forms.GroupBox();
            this.numericUpDownTemperaturaAktualna = new System.Windows.Forms.NumericUpDown();
            this.labelTemperaturaAktualna = new System.Windows.Forms.Label();
            this.numericUpDownStanGrzalek = new System.Windows.Forms.NumericUpDown();
            this.labelStanGrzalek = new System.Windows.Forms.Label();
            this.groupBoxKociolWartosciZadane = new System.Windows.Forms.GroupBox();
            this.numericUpDownStanMieszadla = new System.Windows.Forms.NumericUpDown();
            this.labelStanMieszadla = new System.Windows.Forms.Label();
            this.numericUpDownTemperaturaZadana = new System.Windows.Forms.NumericUpDown();
            this.labelTemperaturaZadana = new System.Windows.Forms.Label();
            this.buttonZmienStanMieszadla = new System.Windows.Forms.Button();
            this.numericUpDownStanGrzalekManualny = new System.Windows.Forms.NumericUpDown();
            this.labelStanGrzalekManualnie = new System.Windows.Forms.Label();
            this.groupBoxStanKotla = new System.Windows.Forms.GroupBox();
            this.labelStanKotla = new System.Windows.Forms.Label();
            this.buttonZmienStanKotla = new System.Windows.Forms.Button();
            this.numericUpDownStanKotla = new System.Windows.Forms.NumericUpDown();
            this.labelTrybManualny = new System.Windows.Forms.Label();
            this.buttonZmienTrybManualny = new System.Windows.Forms.Button();
            this.numericUpDownTrybManualny = new System.Windows.Forms.NumericUpDown();
            this.buttonAktualizujPorty = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageKontrolaProcesu = new System.Windows.Forms.TabPage();
            this.groupBoxTrybManualny = new System.Windows.Forms.GroupBox();
            this.groupBoxPolaczenie = new System.Windows.Forms.GroupBox();
            this.tabPageWykres = new System.Windows.Forms.TabPage();
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageTesty = new System.Windows.Forms.TabPage();
            this.groupBoxPodgladPortuSzeregowego = new System.Windows.Forms.GroupBox();
            this.labelTest3 = new System.Windows.Forms.Label();
            this.labelTest2 = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.textBoxTest3 = new System.Windows.Forms.TextBox();
            this.textBoxTest2 = new System.Windows.Forms.TextBox();
            this.groupBoxParametryRegulatora = new System.Windows.Forms.GroupBox();
            this.buttonZmienTestoweParametryPID = new System.Windows.Forms.Button();
            this.numericUpDownTestoweParametryPID = new System.Windows.Forms.NumericUpDown();
            this.labelTestoweParametryPID = new System.Windows.Forms.Label();
            this.numericUpDownStalaP = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStalaD = new System.Windows.Forms.NumericUpDown();
            this.labelStalaP = new System.Windows.Forms.Label();
            this.numericUpDownStalaI = new System.Windows.Forms.NumericUpDown();
            this.labelStalaI = new System.Windows.Forms.Label();
            this.labelStalaD = new System.Windows.Forms.Label();
            this.groupBoxKociolWartosciOtrzymane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperaturaAktualna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStanGrzalek)).BeginInit();
            this.groupBoxKociolWartosciZadane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStanMieszadla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperaturaZadana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStanGrzalekManualny)).BeginInit();
            this.groupBoxStanKotla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStanKotla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrybManualny)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageKontrolaProcesu.SuspendLayout();
            this.groupBoxTrybManualny.SuspendLayout();
            this.groupBoxPolaczenie.SuspendLayout();
            this.tabPageWykres.SuspendLayout();
            this.groupBoxChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageTesty.SuspendLayout();
            this.groupBoxPodgladPortuSzeregowego.SuspendLayout();
            this.groupBoxParametryRegulatora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestoweParametryPID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStalaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStalaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStalaI)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPortNames
            // 
            this.comboBoxPortNames.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPortNames.FormattingEnabled = true;
            this.comboBoxPortNames.Location = new System.Drawing.Point(32, 45);
            this.comboBoxPortNames.Name = "comboBoxPortNames";
            this.comboBoxPortNames.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPortNames.Sorted = true;
            this.comboBoxPortNames.TabIndex = 0;
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(296, 47);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(114, 23);
            this.progressBarStatus.TabIndex = 2;
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(446, 28);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(97, 23);
            this.buttonOpenPort.TabIndex = 7;
            this.buttonOpenPort.Text = "Połącz z kotłem";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // buttonClosePort
            // 
            this.buttonClosePort.Enabled = false;
            this.buttonClosePort.Location = new System.Drawing.Point(446, 57);
            this.buttonClosePort.Name = "buttonClosePort";
            this.buttonClosePort.Size = new System.Drawing.Size(97, 23);
            this.buttonClosePort.TabIndex = 8;
            this.buttonClosePort.Text = "Rozłącz kocioł";
            this.buttonClosePort.UseVisualStyleBackColor = true;
            this.buttonClosePort.Click += new System.EventHandler(this.buttonClosePort_Click);
            // 
            // labelPortNames
            // 
            this.labelPortNames.AutoSize = true;
            this.labelPortNames.Location = new System.Drawing.Point(29, 28);
            this.labelPortNames.Name = "labelPortNames";
            this.labelPortNames.Size = new System.Drawing.Size(79, 13);
            this.labelPortNames.TabIndex = 9;
            this.labelPortNames.Text = "Dostępne porty";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(293, 28);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status";
            // 
            // groupBoxKociolWartosciOtrzymane
            // 
            this.groupBoxKociolWartosciOtrzymane.Controls.Add(this.numericUpDownTemperaturaAktualna);
            this.groupBoxKociolWartosciOtrzymane.Controls.Add(this.labelTemperaturaAktualna);
            this.groupBoxKociolWartosciOtrzymane.Controls.Add(this.numericUpDownStanGrzalek);
            this.groupBoxKociolWartosciOtrzymane.Controls.Add(this.labelStanGrzalek);
            this.groupBoxKociolWartosciOtrzymane.Location = new System.Drawing.Point(6, 218);
            this.groupBoxKociolWartosciOtrzymane.Name = "groupBoxKociolWartosciOtrzymane";
            this.groupBoxKociolWartosciOtrzymane.Size = new System.Drawing.Size(282, 115);
            this.groupBoxKociolWartosciOtrzymane.TabIndex = 12;
            this.groupBoxKociolWartosciOtrzymane.TabStop = false;
            this.groupBoxKociolWartosciOtrzymane.Text = "Kocioł - wartości otrzymane";
            // 
            // numericUpDownTemperaturaAktualna
            // 
            this.numericUpDownTemperaturaAktualna.DecimalPlaces = 1;
            this.numericUpDownTemperaturaAktualna.Enabled = false;
            this.numericUpDownTemperaturaAktualna.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTemperaturaAktualna.InterceptArrowKeys = false;
            this.numericUpDownTemperaturaAktualna.Location = new System.Drawing.Point(155, 28);
            this.numericUpDownTemperaturaAktualna.Maximum = new decimal(new int[] {
            70000,
            0,
            0,
            0});
            this.numericUpDownTemperaturaAktualna.Name = "numericUpDownTemperaturaAktualna";
            this.numericUpDownTemperaturaAktualna.ReadOnly = true;
            this.numericUpDownTemperaturaAktualna.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownTemperaturaAktualna.TabIndex = 13;
            // 
            // labelTemperaturaAktualna
            // 
            this.labelTemperaturaAktualna.AutoSize = true;
            this.labelTemperaturaAktualna.Location = new System.Drawing.Point(24, 30);
            this.labelTemperaturaAktualna.Name = "labelTemperaturaAktualna";
            this.labelTemperaturaAktualna.Size = new System.Drawing.Size(114, 13);
            this.labelTemperaturaAktualna.TabIndex = 11;
            this.labelTemperaturaAktualna.Text = "Temperatura aktualna:";
            // 
            // numericUpDownStanGrzalek
            // 
            this.numericUpDownStanGrzalek.Enabled = false;
            this.numericUpDownStanGrzalek.InterceptArrowKeys = false;
            this.numericUpDownStanGrzalek.Location = new System.Drawing.Point(155, 54);
            this.numericUpDownStanGrzalek.Maximum = new decimal(new int[] {
            70000,
            0,
            0,
            0});
            this.numericUpDownStanGrzalek.Name = "numericUpDownStanGrzalek";
            this.numericUpDownStanGrzalek.ReadOnly = true;
            this.numericUpDownStanGrzalek.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownStanGrzalek.TabIndex = 14;
            // 
            // labelStanGrzalek
            // 
            this.labelStanGrzalek.AutoSize = true;
            this.labelStanGrzalek.Location = new System.Drawing.Point(24, 56);
            this.labelStanGrzalek.Name = "labelStanGrzalek";
            this.labelStanGrzalek.Size = new System.Drawing.Size(116, 13);
            this.labelStanGrzalek.TabIndex = 12;
            this.labelStanGrzalek.Text = "Stan grzałek (X/3000):";
            // 
            // groupBoxKociolWartosciZadane
            // 
            this.groupBoxKociolWartosciZadane.Controls.Add(this.numericUpDownStanMieszadla);
            this.groupBoxKociolWartosciZadane.Controls.Add(this.labelStanMieszadla);
            this.groupBoxKociolWartosciZadane.Controls.Add(this.numericUpDownTemperaturaZadana);
            this.groupBoxKociolWartosciZadane.Controls.Add(this.labelTemperaturaZadana);
            this.groupBoxKociolWartosciZadane.Controls.Add(this.buttonZmienStanMieszadla);
            this.groupBoxKociolWartosciZadane.Location = new System.Drawing.Point(294, 218);
            this.groupBoxKociolWartosciZadane.Name = "groupBoxKociolWartosciZadane";
            this.groupBoxKociolWartosciZadane.Size = new System.Drawing.Size(288, 115);
            this.groupBoxKociolWartosciZadane.TabIndex = 13;
            this.groupBoxKociolWartosciZadane.TabStop = false;
            this.groupBoxKociolWartosciZadane.Text = "Kocioł - wartości zadane";
            // 
            // numericUpDownStanMieszadla
            // 
            this.numericUpDownStanMieszadla.Enabled = false;
            this.numericUpDownStanMieszadla.Location = new System.Drawing.Point(124, 55);
            this.numericUpDownStanMieszadla.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStanMieszadla.Name = "numericUpDownStanMieszadla";
            this.numericUpDownStanMieszadla.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownStanMieszadla.TabIndex = 17;
            // 
            // labelStanMieszadla
            // 
            this.labelStanMieszadla.AutoSize = true;
            this.labelStanMieszadla.Location = new System.Drawing.Point(31, 57);
            this.labelStanMieszadla.Name = "labelStanMieszadla";
            this.labelStanMieszadla.Size = new System.Drawing.Size(83, 13);
            this.labelStanMieszadla.TabIndex = 16;
            this.labelStanMieszadla.Text = "Stan mieszadła:";
            // 
            // numericUpDownTemperaturaZadana
            // 
            this.numericUpDownTemperaturaZadana.DecimalPlaces = 1;
            this.numericUpDownTemperaturaZadana.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTemperaturaZadana.Location = new System.Drawing.Point(124, 28);
            this.numericUpDownTemperaturaZadana.Name = "numericUpDownTemperaturaZadana";
            this.numericUpDownTemperaturaZadana.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownTemperaturaZadana.TabIndex = 15;
            // 
            // labelTemperaturaZadana
            // 
            this.labelTemperaturaZadana.AutoSize = true;
            this.labelTemperaturaZadana.Location = new System.Drawing.Point(6, 31);
            this.labelTemperaturaZadana.Name = "labelTemperaturaZadana";
            this.labelTemperaturaZadana.Size = new System.Drawing.Size(108, 13);
            this.labelTemperaturaZadana.TabIndex = 14;
            this.labelTemperaturaZadana.Text = "Temperatura zadana:";
            // 
            // buttonZmienStanMieszadla
            // 
            this.buttonZmienStanMieszadla.Enabled = false;
            this.buttonZmienStanMieszadla.Location = new System.Drawing.Point(181, 49);
            this.buttonZmienStanMieszadla.Name = "buttonZmienStanMieszadla";
            this.buttonZmienStanMieszadla.Size = new System.Drawing.Size(99, 28);
            this.buttonZmienStanMieszadla.TabIndex = 6;
            this.buttonZmienStanMieszadla.Text = "Zmień";
            this.buttonZmienStanMieszadla.UseVisualStyleBackColor = true;
            this.buttonZmienStanMieszadla.Click += new System.EventHandler(this.buttonZmienStanMieszadla_Click);
            // 
            // numericUpDownStanGrzalekManualny
            // 
            this.numericUpDownStanGrzalekManualny.Location = new System.Drawing.Point(124, 65);
            this.numericUpDownStanGrzalekManualny.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownStanGrzalekManualny.Name = "numericUpDownStanGrzalekManualny";
            this.numericUpDownStanGrzalekManualny.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownStanGrzalekManualny.TabIndex = 17;
            // 
            // labelStanGrzalekManualnie
            // 
            this.labelStanGrzalekManualnie.AutoSize = true;
            this.labelStanGrzalekManualnie.Location = new System.Drawing.Point(43, 67);
            this.labelStanGrzalekManualnie.Name = "labelStanGrzalekManualnie";
            this.labelStanGrzalekManualnie.Size = new System.Drawing.Size(71, 13);
            this.labelStanGrzalekManualnie.TabIndex = 16;
            this.labelStanGrzalekManualnie.Text = "Stan grzałek:";
            // 
            // groupBoxStanKotla
            // 
            this.groupBoxStanKotla.Controls.Add(this.labelStanKotla);
            this.groupBoxStanKotla.Controls.Add(this.buttonZmienStanKotla);
            this.groupBoxStanKotla.Controls.Add(this.numericUpDownStanKotla);
            this.groupBoxStanKotla.Location = new System.Drawing.Point(6, 112);
            this.groupBoxStanKotla.Name = "groupBoxStanKotla";
            this.groupBoxStanKotla.Size = new System.Drawing.Size(282, 100);
            this.groupBoxStanKotla.TabIndex = 14;
            this.groupBoxStanKotla.TabStop = false;
            this.groupBoxStanKotla.Text = "Stan kotła";
            // 
            // labelStanKotla
            // 
            this.labelStanKotla.AutoSize = true;
            this.labelStanKotla.Location = new System.Drawing.Point(24, 32);
            this.labelStanKotla.Name = "labelStanKotla";
            this.labelStanKotla.Size = new System.Drawing.Size(63, 13);
            this.labelStanKotla.TabIndex = 15;
            this.labelStanKotla.Text = "Stan kotła: ";
            // 
            // buttonZmienStanKotla
            // 
            this.buttonZmienStanKotla.Enabled = false;
            this.buttonZmienStanKotla.Location = new System.Drawing.Point(160, 24);
            this.buttonZmienStanKotla.Name = "buttonZmienStanKotla";
            this.buttonZmienStanKotla.Size = new System.Drawing.Size(101, 28);
            this.buttonZmienStanKotla.TabIndex = 6;
            this.buttonZmienStanKotla.Text = "Zmień";
            this.buttonZmienStanKotla.UseVisualStyleBackColor = true;
            this.buttonZmienStanKotla.Click += new System.EventHandler(this.buttonZmienStanKotla_Click);
            // 
            // numericUpDownStanKotla
            // 
            this.numericUpDownStanKotla.Enabled = false;
            this.numericUpDownStanKotla.InterceptArrowKeys = false;
            this.numericUpDownStanKotla.Location = new System.Drawing.Point(93, 30);
            this.numericUpDownStanKotla.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStanKotla.Name = "numericUpDownStanKotla";
            this.numericUpDownStanKotla.ReadOnly = true;
            this.numericUpDownStanKotla.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownStanKotla.TabIndex = 16;
            // 
            // labelTrybManualny
            // 
            this.labelTrybManualny.AutoSize = true;
            this.labelTrybManualny.Location = new System.Drawing.Point(36, 32);
            this.labelTrybManualny.Name = "labelTrybManualny";
            this.labelTrybManualny.Size = new System.Drawing.Size(82, 13);
            this.labelTrybManualny.TabIndex = 15;
            this.labelTrybManualny.Text = "Tryb manualny: ";
            // 
            // buttonZmienTrybManualny
            // 
            this.buttonZmienTrybManualny.Enabled = false;
            this.buttonZmienTrybManualny.Location = new System.Drawing.Point(181, 24);
            this.buttonZmienTrybManualny.Name = "buttonZmienTrybManualny";
            this.buttonZmienTrybManualny.Size = new System.Drawing.Size(99, 28);
            this.buttonZmienTrybManualny.TabIndex = 6;
            this.buttonZmienTrybManualny.Text = "Zmień";
            this.buttonZmienTrybManualny.UseVisualStyleBackColor = true;
            this.buttonZmienTrybManualny.Click += new System.EventHandler(this.buttonZmienTrybManualny_Click);
            // 
            // numericUpDownTrybManualny
            // 
            this.numericUpDownTrybManualny.Enabled = false;
            this.numericUpDownTrybManualny.InterceptArrowKeys = false;
            this.numericUpDownTrybManualny.Location = new System.Drawing.Point(124, 30);
            this.numericUpDownTrybManualny.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTrybManualny.Name = "numericUpDownTrybManualny";
            this.numericUpDownTrybManualny.ReadOnly = true;
            this.numericUpDownTrybManualny.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownTrybManualny.TabIndex = 16;
            // 
            // buttonAktualizujPorty
            // 
            this.buttonAktualizujPorty.Location = new System.Drawing.Point(160, 45);
            this.buttonAktualizujPorty.Name = "buttonAktualizujPorty";
            this.buttonAktualizujPorty.Size = new System.Drawing.Size(98, 23);
            this.buttonAktualizujPorty.TabIndex = 21;
            this.buttonAktualizujPorty.Text = "Aktualizuj porty";
            this.buttonAktualizujPorty.UseVisualStyleBackColor = true;
            this.buttonAktualizujPorty.Click += new System.EventHandler(this.buttonAktualizujPorty_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageKontrolaProcesu);
            this.tabControlMain.Controls.Add(this.tabPageWykres);
            this.tabControlMain.Controls.Add(this.tabPageTesty);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(596, 365);
            this.tabControlMain.TabIndex = 22;
            // 
            // tabPageKontrolaProcesu
            // 
            this.tabPageKontrolaProcesu.Controls.Add(this.groupBoxTrybManualny);
            this.tabPageKontrolaProcesu.Controls.Add(this.groupBoxPolaczenie);
            this.tabPageKontrolaProcesu.Controls.Add(this.groupBoxStanKotla);
            this.tabPageKontrolaProcesu.Controls.Add(this.groupBoxKociolWartosciZadane);
            this.tabPageKontrolaProcesu.Controls.Add(this.groupBoxKociolWartosciOtrzymane);
            this.tabPageKontrolaProcesu.Location = new System.Drawing.Point(4, 22);
            this.tabPageKontrolaProcesu.Name = "tabPageKontrolaProcesu";
            this.tabPageKontrolaProcesu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKontrolaProcesu.Size = new System.Drawing.Size(588, 339);
            this.tabPageKontrolaProcesu.TabIndex = 0;
            this.tabPageKontrolaProcesu.Text = "Kontrola procesu";
            this.tabPageKontrolaProcesu.UseVisualStyleBackColor = true;
            // 
            // groupBoxTrybManualny
            // 
            this.groupBoxTrybManualny.Controls.Add(this.numericUpDownStanGrzalekManualny);
            this.groupBoxTrybManualny.Controls.Add(this.labelTrybManualny);
            this.groupBoxTrybManualny.Controls.Add(this.numericUpDownTrybManualny);
            this.groupBoxTrybManualny.Controls.Add(this.labelStanGrzalekManualnie);
            this.groupBoxTrybManualny.Controls.Add(this.buttonZmienTrybManualny);
            this.groupBoxTrybManualny.Location = new System.Drawing.Point(294, 112);
            this.groupBoxTrybManualny.Name = "groupBoxTrybManualny";
            this.groupBoxTrybManualny.Size = new System.Drawing.Size(288, 100);
            this.groupBoxTrybManualny.TabIndex = 23;
            this.groupBoxTrybManualny.TabStop = false;
            this.groupBoxTrybManualny.Text = "Tryb manualny - grzałki";
            // 
            // groupBoxPolaczenie
            // 
            this.groupBoxPolaczenie.Controls.Add(this.labelPortNames);
            this.groupBoxPolaczenie.Controls.Add(this.labelStatus);
            this.groupBoxPolaczenie.Controls.Add(this.buttonAktualizujPorty);
            this.groupBoxPolaczenie.Controls.Add(this.buttonClosePort);
            this.groupBoxPolaczenie.Controls.Add(this.comboBoxPortNames);
            this.groupBoxPolaczenie.Controls.Add(this.buttonOpenPort);
            this.groupBoxPolaczenie.Controls.Add(this.progressBarStatus);
            this.groupBoxPolaczenie.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPolaczenie.Name = "groupBoxPolaczenie";
            this.groupBoxPolaczenie.Size = new System.Drawing.Size(576, 100);
            this.groupBoxPolaczenie.TabIndex = 22;
            this.groupBoxPolaczenie.TabStop = false;
            this.groupBoxPolaczenie.Text = "Połączenie";
            // 
            // tabPageWykres
            // 
            this.tabPageWykres.Controls.Add(this.groupBoxChart);
            this.tabPageWykres.Location = new System.Drawing.Point(4, 22);
            this.tabPageWykres.Name = "tabPageWykres";
            this.tabPageWykres.Size = new System.Drawing.Size(588, 339);
            this.tabPageWykres.TabIndex = 2;
            this.tabPageWykres.Text = "Wykres";
            this.tabPageWykres.UseVisualStyleBackColor = true;
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.Controls.Add(this.chart1);
            this.groupBoxChart.Location = new System.Drawing.Point(5, 5);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Size = new System.Drawing.Size(577, 329);
            this.groupBoxChart.TabIndex = 21;
            this.groupBoxChart.TabStop = false;
            this.groupBoxChart.Text = "Wykres temperatury";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legendItem1.Enabled = false;
            legendItem1.Name = "temperatura aktualna";
            legendItem2.Enabled = false;
            legendItem2.Name = "temperatura zadana";
            legend1.CustomItems.Add(legendItem1);
            legend1.CustomItems.Add(legendItem2);
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-5, 9);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(590, 320);
            this.chart1.TabIndex = 19;
            // 
            // tabPageTesty
            // 
            this.tabPageTesty.Controls.Add(this.groupBoxPodgladPortuSzeregowego);
            this.tabPageTesty.Controls.Add(this.groupBoxParametryRegulatora);
            this.tabPageTesty.Location = new System.Drawing.Point(4, 22);
            this.tabPageTesty.Name = "tabPageTesty";
            this.tabPageTesty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTesty.Size = new System.Drawing.Size(588, 339);
            this.tabPageTesty.TabIndex = 1;
            this.tabPageTesty.Text = "Testy";
            this.tabPageTesty.UseVisualStyleBackColor = true;
            // 
            // groupBoxPodgladPortuSzeregowego
            // 
            this.groupBoxPodgladPortuSzeregowego.Controls.Add(this.labelTest3);
            this.groupBoxPodgladPortuSzeregowego.Controls.Add(this.labelTest2);
            this.groupBoxPodgladPortuSzeregowego.Controls.Add(this.labelTest);
            this.groupBoxPodgladPortuSzeregowego.Controls.Add(this.textBoxTest);
            this.groupBoxPodgladPortuSzeregowego.Controls.Add(this.textBoxTest3);
            this.groupBoxPodgladPortuSzeregowego.Controls.Add(this.textBoxTest2);
            this.groupBoxPodgladPortuSzeregowego.Location = new System.Drawing.Point(6, 125);
            this.groupBoxPodgladPortuSzeregowego.Name = "groupBoxPodgladPortuSzeregowego";
            this.groupBoxPodgladPortuSzeregowego.Size = new System.Drawing.Size(576, 208);
            this.groupBoxPodgladPortuSzeregowego.TabIndex = 19;
            this.groupBoxPodgladPortuSzeregowego.TabStop = false;
            this.groupBoxPodgladPortuSzeregowego.Text = "Podgląd portu szeregowego";
            // 
            // labelTest3
            // 
            this.labelTest3.AutoSize = true;
            this.labelTest3.Location = new System.Drawing.Point(14, 105);
            this.labelTest3.Name = "labelTest3";
            this.labelTest3.Size = new System.Drawing.Size(119, 13);
            this.labelTest3.TabIndex = 20;
            this.labelTest3.Text = "Stan zmiennych w kotle";
            // 
            // labelTest2
            // 
            this.labelTest2.AutoSize = true;
            this.labelTest2.Location = new System.Drawing.Point(15, 66);
            this.labelTest2.Name = "labelTest2";
            this.labelTest2.Size = new System.Drawing.Size(123, 13);
            this.labelTest2.TabIndex = 19;
            this.labelTest2.Text = "Bajty odbierane od kotła";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(14, 27);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(121, 13);
            this.labelTest.TabIndex = 18;
            this.labelTest.Text = "Bajty wysyłane do kotła";
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(17, 43);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.ReadOnly = true;
            this.textBoxTest.Size = new System.Drawing.Size(542, 20);
            this.textBoxTest.TabIndex = 15;
            // 
            // textBoxTest3
            // 
            this.textBoxTest3.Location = new System.Drawing.Point(18, 121);
            this.textBoxTest3.Multiline = true;
            this.textBoxTest3.Name = "textBoxTest3";
            this.textBoxTest3.ReadOnly = true;
            this.textBoxTest3.Size = new System.Drawing.Size(541, 76);
            this.textBoxTest3.TabIndex = 17;
            // 
            // textBoxTest2
            // 
            this.textBoxTest2.Location = new System.Drawing.Point(18, 82);
            this.textBoxTest2.Name = "textBoxTest2";
            this.textBoxTest2.ReadOnly = true;
            this.textBoxTest2.Size = new System.Drawing.Size(541, 20);
            this.textBoxTest2.TabIndex = 16;
            // 
            // groupBoxParametryRegulatora
            // 
            this.groupBoxParametryRegulatora.Controls.Add(this.buttonZmienTestoweParametryPID);
            this.groupBoxParametryRegulatora.Controls.Add(this.numericUpDownTestoweParametryPID);
            this.groupBoxParametryRegulatora.Controls.Add(this.labelTestoweParametryPID);
            this.groupBoxParametryRegulatora.Controls.Add(this.numericUpDownStalaP);
            this.groupBoxParametryRegulatora.Controls.Add(this.numericUpDownStalaD);
            this.groupBoxParametryRegulatora.Controls.Add(this.labelStalaP);
            this.groupBoxParametryRegulatora.Controls.Add(this.numericUpDownStalaI);
            this.groupBoxParametryRegulatora.Controls.Add(this.labelStalaI);
            this.groupBoxParametryRegulatora.Controls.Add(this.labelStalaD);
            this.groupBoxParametryRegulatora.Location = new System.Drawing.Point(6, 6);
            this.groupBoxParametryRegulatora.Name = "groupBoxParametryRegulatora";
            this.groupBoxParametryRegulatora.Size = new System.Drawing.Size(576, 113);
            this.groupBoxParametryRegulatora.TabIndex = 12;
            this.groupBoxParametryRegulatora.TabStop = false;
            this.groupBoxParametryRegulatora.Text = "Parametry regulatora PID - grzałki";
            // 
            // buttonZmienTestoweParametryPID
            // 
            this.buttonZmienTestoweParametryPID.Enabled = false;
            this.buttonZmienTestoweParametryPID.Location = new System.Drawing.Point(227, 27);
            this.buttonZmienTestoweParametryPID.Name = "buttonZmienTestoweParametryPID";
            this.buttonZmienTestoweParametryPID.Size = new System.Drawing.Size(99, 28);
            this.buttonZmienTestoweParametryPID.TabIndex = 18;
            this.buttonZmienTestoweParametryPID.Text = "Zmień";
            this.buttonZmienTestoweParametryPID.UseVisualStyleBackColor = true;
            this.buttonZmienTestoweParametryPID.Click += new System.EventHandler(this.buttonZmienTestoweParametryPID_Click);
            // 
            // numericUpDownTestoweParametryPID
            // 
            this.numericUpDownTestoweParametryPID.Enabled = false;
            this.numericUpDownTestoweParametryPID.InterceptArrowKeys = false;
            this.numericUpDownTestoweParametryPID.Location = new System.Drawing.Point(152, 33);
            this.numericUpDownTestoweParametryPID.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTestoweParametryPID.Name = "numericUpDownTestoweParametryPID";
            this.numericUpDownTestoweParametryPID.ReadOnly = true;
            this.numericUpDownTestoweParametryPID.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownTestoweParametryPID.TabIndex = 17;
            // 
            // labelTestoweParametryPID
            // 
            this.labelTestoweParametryPID.AutoSize = true;
            this.labelTestoweParametryPID.Location = new System.Drawing.Point(25, 35);
            this.labelTestoweParametryPID.Name = "labelTestoweParametryPID";
            this.labelTestoweParametryPID.Size = new System.Drawing.Size(121, 13);
            this.labelTestoweParametryPID.TabIndex = 11;
            this.labelTestoweParametryPID.Text = "Testowe parametry PID:";
            // 
            // numericUpDownStalaP
            // 
            this.numericUpDownStalaP.DecimalPlaces = 2;
            this.numericUpDownStalaP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownStalaP.Location = new System.Drawing.Point(77, 72);
            this.numericUpDownStalaP.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownStalaP.Name = "numericUpDownStalaP";
            this.numericUpDownStalaP.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownStalaP.TabIndex = 10;
            this.numericUpDownStalaP.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownStalaP.ValueChanged += new System.EventHandler(this.numericUpDownStalaP_ValueChanged);
            // 
            // numericUpDownStalaD
            // 
            this.numericUpDownStalaD.DecimalPlaces = 2;
            this.numericUpDownStalaD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownStalaD.Location = new System.Drawing.Point(428, 72);
            this.numericUpDownStalaD.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownStalaD.Name = "numericUpDownStalaD";
            this.numericUpDownStalaD.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownStalaD.TabIndex = 10;
            this.numericUpDownStalaD.ValueChanged += new System.EventHandler(this.numericUpDownStalaD_ValueChanged);
            // 
            // labelStalaP
            // 
            this.labelStalaP.AutoSize = true;
            this.labelStalaP.Location = new System.Drawing.Point(25, 74);
            this.labelStalaP.Name = "labelStalaP";
            this.labelStalaP.Size = new System.Drawing.Size(46, 13);
            this.labelStalaP.TabIndex = 9;
            this.labelStalaP.Text = "Stała P:";
            this.labelStalaP.Click += new System.EventHandler(this.labelStalaP_Click);
            // 
            // numericUpDownStalaI
            // 
            this.numericUpDownStalaI.DecimalPlaces = 2;
            this.numericUpDownStalaI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownStalaI.Location = new System.Drawing.Point(246, 72);
            this.numericUpDownStalaI.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownStalaI.Name = "numericUpDownStalaI";
            this.numericUpDownStalaI.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownStalaI.TabIndex = 10;
            this.numericUpDownStalaI.ValueChanged += new System.EventHandler(this.numericUpDownStalaI_ValueChanged);
            // 
            // labelStalaI
            // 
            this.labelStalaI.AutoSize = true;
            this.labelStalaI.Location = new System.Drawing.Point(198, 74);
            this.labelStalaI.Name = "labelStalaI";
            this.labelStalaI.Size = new System.Drawing.Size(42, 13);
            this.labelStalaI.TabIndex = 9;
            this.labelStalaI.Text = "Stała I:";
            this.labelStalaI.Click += new System.EventHandler(this.labelStalaI_Click);
            // 
            // labelStalaD
            // 
            this.labelStalaD.AutoSize = true;
            this.labelStalaD.Location = new System.Drawing.Point(375, 74);
            this.labelStalaD.Name = "labelStalaD";
            this.labelStalaD.Size = new System.Drawing.Size(47, 13);
            this.labelStalaD.TabIndex = 9;
            this.labelStalaD.Text = "Stała D:";
            this.labelStalaD.Click += new System.EventHandler(this.labelStalaD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 388);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Kocioł warzelny - komunikacja";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxKociolWartosciOtrzymane.ResumeLayout(false);
            this.groupBoxKociolWartosciOtrzymane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperaturaAktualna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStanGrzalek)).EndInit();
            this.groupBoxKociolWartosciZadane.ResumeLayout(false);
            this.groupBoxKociolWartosciZadane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStanMieszadla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperaturaZadana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStanGrzalekManualny)).EndInit();
            this.groupBoxStanKotla.ResumeLayout(false);
            this.groupBoxStanKotla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStanKotla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrybManualny)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageKontrolaProcesu.ResumeLayout(false);
            this.groupBoxTrybManualny.ResumeLayout(false);
            this.groupBoxTrybManualny.PerformLayout();
            this.groupBoxPolaczenie.ResumeLayout(false);
            this.groupBoxPolaczenie.PerformLayout();
            this.tabPageWykres.ResumeLayout(false);
            this.groupBoxChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageTesty.ResumeLayout(false);
            this.groupBoxPodgladPortuSzeregowego.ResumeLayout(false);
            this.groupBoxPodgladPortuSzeregowego.PerformLayout();
            this.groupBoxParametryRegulatora.ResumeLayout(false);
            this.groupBoxParametryRegulatora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTestoweParametryPID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStalaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStalaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStalaI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPortNames;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.Button buttonClosePort;
        private System.Windows.Forms.Label labelPortNames;
        private System.Windows.Forms.Label labelStatus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxKociolWartosciOtrzymane;
        private System.Windows.Forms.GroupBox groupBoxKociolWartosciZadane;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperaturaAktualna;
        private System.Windows.Forms.Label labelTemperaturaAktualna;
        private System.Windows.Forms.NumericUpDown numericUpDownStanGrzalek;
        private System.Windows.Forms.Label labelStanGrzalek;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperaturaZadana;
        private System.Windows.Forms.Label labelTemperaturaZadana;
        private System.Windows.Forms.NumericUpDown numericUpDownStanMieszadla;
        private System.Windows.Forms.Label labelStanMieszadla;
        private System.Windows.Forms.GroupBox groupBoxStanKotla;
        private System.Windows.Forms.NumericUpDown numericUpDownStanKotla;
        private System.Windows.Forms.Label labelStanKotla;
        private System.Windows.Forms.Button buttonZmienStanKotla;
        private System.Windows.Forms.Button buttonAktualizujPorty;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDownStanGrzalekManualny;
        private System.Windows.Forms.Label labelStanGrzalekManualnie;
        private System.Windows.Forms.Label labelTrybManualny;
        private System.Windows.Forms.Button buttonZmienTrybManualny;
        private System.Windows.Forms.NumericUpDown numericUpDownTrybManualny;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageKontrolaProcesu;
        private System.Windows.Forms.TabPage tabPageTesty;
        private System.Windows.Forms.Label labelStalaD;
        private System.Windows.Forms.Label labelStalaI;
        private System.Windows.Forms.NumericUpDown numericUpDownStalaI;
        private System.Windows.Forms.Label labelStalaP;
        private System.Windows.Forms.NumericUpDown numericUpDownStalaD;
        private System.Windows.Forms.NumericUpDown numericUpDownStalaP;
        private System.Windows.Forms.GroupBox groupBoxParametryRegulatora;
        private System.Windows.Forms.TabPage tabPageWykres;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.TextBox textBoxTest2;
        private System.Windows.Forms.TextBox textBoxTest3;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelTest2;
        private System.Windows.Forms.Label labelTest3;
        private System.Windows.Forms.GroupBox groupBoxPodgladPortuSzeregowego;
        private System.Windows.Forms.GroupBox groupBoxPolaczenie;
        private System.Windows.Forms.GroupBox groupBoxTrybManualny;
        private System.Windows.Forms.Button buttonZmienStanMieszadla;
        private System.Windows.Forms.NumericUpDown numericUpDownTestoweParametryPID;
        private System.Windows.Forms.Label labelTestoweParametryPID;
        private System.Windows.Forms.Button buttonZmienTestoweParametryPID;
    }
}

