
using System.Windows.Forms.DataVisualization.Charting;

namespace FNCE631 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.btnGetCsvData = new System.Windows.Forms.Button();
			this.CsvFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.tbFilePath = new System.Windows.Forms.TextBox();
			this.tbMovingAverageDays = new System.Windows.Forms.TextBox();
			this.btnPlotData = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblDates = new System.Windows.Forms.Label();
			this.lblSymbol = new System.Windows.Forms.Label();
			this.lblSource = new System.Windows.Forms.Label();
			this.lblParseProgress = new System.Windows.Forms.Label();
			this.lblMovingAverage = new System.Windows.Forms.Label();
			this.chrtCoinAndMa = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chrtPortfolio = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tbSeedMoney = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabMovingAverage = new System.Windows.Forms.TabControl();
			this.MovingAverage = new System.Windows.Forms.TabPage();
			this.btnMaMethodCalculate = new System.Windows.Forms.Button();
			this.MovingAverageNM = new System.Windows.Forms.TabPage();
			this.btnNMCalculate = new System.Windows.Forms.Button();
			this.tbNMSeed = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbMValue = new System.Windows.Forms.TextBox();
			this.tbNValue = new System.Windows.Forms.TextBox();
			this.ExpMovingAverage = new System.Windows.Forms.TabPage();
			this.btnExpCalculate = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbExpDays = new System.Windows.Forms.TextBox();
			this.tbExpSmoothing = new System.Windows.Forms.TextBox();
			this.tbOutputPath = new System.Windows.Forms.TextBox();
			this.btnOutPutDialog = new System.Windows.Forms.Button();
			this.OutputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.label8 = new System.Windows.Forms.Label();
			this.tbExpSeed = new System.Windows.Forms.TextBox();
			this.dgResults = new System.Windows.Forms.DataGridView();
			this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Seed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Days1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Days2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Smoothing = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Return = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbExportData = new System.Windows.Forms.CheckBox();
			this.tbExportFileName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tbBuyHoldSeed = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnBuyHoldCalculate = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chrtCoinAndMa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chrtPortfolio)).BeginInit();
			this.tabMovingAverage.SuspendLayout();
			this.MovingAverage.SuspendLayout();
			this.MovingAverageNM.SuspendLayout();
			this.ExpMovingAverage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGetCsvData
			// 
			this.btnGetCsvData.Location = new System.Drawing.Point(259, 65);
			this.btnGetCsvData.Name = "btnGetCsvData";
			this.btnGetCsvData.Size = new System.Drawing.Size(192, 32);
			this.btnGetCsvData.TabIndex = 0;
			this.btnGetCsvData.Text = "Get CSV Data";
			this.btnGetCsvData.UseVisualStyleBackColor = true;
			this.btnGetCsvData.Click += new System.EventHandler(this.button1_Click);
			// 
			// CsvFileDialog
			// 
			this.CsvFileDialog.FileName = "openFileDialog1";
			// 
			// tbFilePath
			// 
			this.tbFilePath.Location = new System.Drawing.Point(19, 28);
			this.tbFilePath.Name = "tbFilePath";
			this.tbFilePath.Size = new System.Drawing.Size(432, 20);
			this.tbFilePath.TabIndex = 1;
			// 
			// tbMovingAverageDays
			// 
			this.tbMovingAverageDays.Location = new System.Drawing.Point(268, 51);
			this.tbMovingAverageDays.Name = "tbMovingAverageDays";
			this.tbMovingAverageDays.Size = new System.Drawing.Size(52, 20);
			this.tbMovingAverageDays.TabIndex = 2;
			// 
			// btnPlotData
			// 
			this.btnPlotData.Location = new System.Drawing.Point(326, 95);
			this.btnPlotData.Name = "btnPlotData";
			this.btnPlotData.Size = new System.Drawing.Size(121, 22);
			this.btnPlotData.TabIndex = 3;
			this.btnPlotData.Text = "Plot Data";
			this.btnPlotData.UseVisualStyleBackColor = true;
			this.btnPlotData.Click += new System.EventHandler(this.btnPlotData_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblDates);
			this.groupBox1.Controls.Add(this.lblSymbol);
			this.groupBox1.Controls.Add(this.lblSource);
			this.groupBox1.Controls.Add(this.btnPlotData);
			this.groupBox1.Controls.Add(this.lblParseProgress);
			this.groupBox1.Location = new System.Drawing.Point(1011, 150);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(457, 123);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Settings";
			// 
			// lblDates
			// 
			this.lblDates.AutoSize = true;
			this.lblDates.Location = new System.Drawing.Point(36, 70);
			this.lblDates.Name = "lblDates";
			this.lblDates.Size = new System.Drawing.Size(80, 13);
			this.lblDates.TabIndex = 9;
			this.lblDates.Text = "Effective Dates";
			// 
			// lblSymbol
			// 
			this.lblSymbol.AutoSize = true;
			this.lblSymbol.Location = new System.Drawing.Point(36, 48);
			this.lblSymbol.Name = "lblSymbol";
			this.lblSymbol.Size = new System.Drawing.Size(41, 13);
			this.lblSymbol.TabIndex = 8;
			this.lblSymbol.Text = "Symbol";
			// 
			// lblSource
			// 
			this.lblSource.AutoSize = true;
			this.lblSource.Location = new System.Drawing.Point(36, 26);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(67, 13);
			this.lblSource.TabIndex = 7;
			this.lblSource.Text = "Data Source";
			// 
			// lblParseProgress
			// 
			this.lblParseProgress.AutoSize = true;
			this.lblParseProgress.Location = new System.Drawing.Point(36, 95);
			this.lblParseProgress.Name = "lblParseProgress";
			this.lblParseProgress.Size = new System.Drawing.Size(0, 13);
			this.lblParseProgress.TabIndex = 6;
			// 
			// lblMovingAverage
			// 
			this.lblMovingAverage.AutoSize = true;
			this.lblMovingAverage.Location = new System.Drawing.Point(132, 54);
			this.lblMovingAverage.Name = "lblMovingAverage";
			this.lblMovingAverage.Size = new System.Drawing.Size(116, 13);
			this.lblMovingAverage.TabIndex = 5;
			this.lblMovingAverage.Text = "Moving Average (days)";
			// 
			// chrtCoinAndMa
			// 
			chartArea9.AxisX.Title = "Date";
			chartArea9.AxisY.Title = "Coin Value $";
			chartArea9.Name = "ChartArea1";
			this.chrtCoinAndMa.ChartAreas.Add(chartArea9);
			legend9.Alignment = System.Drawing.StringAlignment.Center;
			legend9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend9.Name = "Legend1";
			this.chrtCoinAndMa.Legends.Add(legend9);
			this.chrtCoinAndMa.Location = new System.Drawing.Point(12, 21);
			this.chrtCoinAndMa.Name = "chrtCoinAndMa";
			series25.ChartArea = "ChartArea1";
			series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series25.Legend = "Legend1";
			series25.Name = "Value";
			series25.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			series26.ChartArea = "ChartArea1";
			series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series26.IsVisibleInLegend = false;
			series26.Legend = "Legend1";
			series26.Name = "Moving Average";
			series27.ChartArea = "ChartArea1";
			series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series27.IsVisibleInLegend = false;
			series27.Legend = "Legend1";
			series27.Name = "N-MA";
			series28.ChartArea = "ChartArea1";
			series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series28.IsVisibleInLegend = false;
			series28.Legend = "Legend1";
			series28.Name = "M-MA";
			series29.ChartArea = "ChartArea1";
			series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series29.IsVisibleInLegend = false;
			series29.Legend = "Legend1";
			series29.Name = "Exp-MA";
			this.chrtCoinAndMa.Series.Add(series25);
			this.chrtCoinAndMa.Series.Add(series26);
			this.chrtCoinAndMa.Series.Add(series27);
			this.chrtCoinAndMa.Series.Add(series28);
			this.chrtCoinAndMa.Series.Add(series29);
			this.chrtCoinAndMa.Size = new System.Drawing.Size(976, 344);
			this.chrtCoinAndMa.TabIndex = 5;
			this.chrtCoinAndMa.Text = "chart1";
			title9.Name = "Title";
			title9.Text = "Coin Value vs. Time";
			this.chrtCoinAndMa.Titles.Add(title9);
			// 
			// chrtPortfolio
			// 
			chartArea10.AxisX.Title = "Date";
			chartArea10.AxisY.Title = "Portfolio Value $";
			chartArea10.Name = "ChartArea1";
			this.chrtPortfolio.ChartAreas.Add(chartArea10);
			legend10.Alignment = System.Drawing.StringAlignment.Center;
			legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend10.Name = "Legend1";
			this.chrtPortfolio.Legends.Add(legend10);
			this.chrtPortfolio.Location = new System.Drawing.Point(12, 396);
			this.chrtPortfolio.Name = "chrtPortfolio";
			series30.ChartArea = "ChartArea1";
			series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
			series30.Legend = "Legend1";
			series30.Name = "Portfolio Value";
			series30.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
			this.chrtPortfolio.Series.Add(series30);
			this.chrtPortfolio.Size = new System.Drawing.Size(976, 294);
			this.chrtPortfolio.TabIndex = 6;
			this.chrtPortfolio.Text = "Portfolio Value";
			title10.Name = "Title";
			title10.Text = "Portfolio Value vs. Time";
			this.chrtPortfolio.Titles.Add(title10);
			// 
			// tbSeedMoney
			// 
			this.tbSeedMoney.Location = new System.Drawing.Point(237, 11);
			this.tbSeedMoney.Name = "tbSeedMoney";
			this.tbSeedMoney.Size = new System.Drawing.Size(84, 20);
			this.tbSeedMoney.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(155, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Seed Money";
			// 
			// tabMovingAverage
			// 
			this.tabMovingAverage.Controls.Add(this.MovingAverage);
			this.tabMovingAverage.Controls.Add(this.MovingAverageNM);
			this.tabMovingAverage.Controls.Add(this.ExpMovingAverage);
			this.tabMovingAverage.Controls.Add(this.tabPage1);
			this.tabMovingAverage.Location = new System.Drawing.Point(1011, 289);
			this.tabMovingAverage.Name = "tabMovingAverage";
			this.tabMovingAverage.SelectedIndex = 0;
			this.tabMovingAverage.Size = new System.Drawing.Size(457, 162);
			this.tabMovingAverage.TabIndex = 8;
			this.tabMovingAverage.Tag = "";
			// 
			// MovingAverage
			// 
			this.MovingAverage.BackColor = System.Drawing.SystemColors.Control;
			this.MovingAverage.Controls.Add(this.btnMaMethodCalculate);
			this.MovingAverage.Controls.Add(this.lblMovingAverage);
			this.MovingAverage.Controls.Add(this.tbMovingAverageDays);
			this.MovingAverage.Controls.Add(this.label1);
			this.MovingAverage.Controls.Add(this.tbSeedMoney);
			this.MovingAverage.Location = new System.Drawing.Point(4, 22);
			this.MovingAverage.Name = "MovingAverage";
			this.MovingAverage.Padding = new System.Windows.Forms.Padding(3);
			this.MovingAverage.Size = new System.Drawing.Size(449, 136);
			this.MovingAverage.TabIndex = 0;
			this.MovingAverage.Text = "Moving Average";
			// 
			// btnMaMethodCalculate
			// 
			this.btnMaMethodCalculate.Location = new System.Drawing.Point(215, 97);
			this.btnMaMethodCalculate.Name = "btnMaMethodCalculate";
			this.btnMaMethodCalculate.Size = new System.Drawing.Size(104, 23);
			this.btnMaMethodCalculate.TabIndex = 6;
			this.btnMaMethodCalculate.Text = "Calculate Return";
			this.btnMaMethodCalculate.UseVisualStyleBackColor = true;
			this.btnMaMethodCalculate.Click += new System.EventHandler(this.btnMaMethodCalculate_Click);
			// 
			// MovingAverageNM
			// 
			this.MovingAverageNM.BackColor = System.Drawing.SystemColors.Control;
			this.MovingAverageNM.Controls.Add(this.btnNMCalculate);
			this.MovingAverageNM.Controls.Add(this.tbNMSeed);
			this.MovingAverageNM.Controls.Add(this.label5);
			this.MovingAverageNM.Controls.Add(this.label4);
			this.MovingAverageNM.Controls.Add(this.label3);
			this.MovingAverageNM.Controls.Add(this.tbMValue);
			this.MovingAverageNM.Controls.Add(this.tbNValue);
			this.MovingAverageNM.Location = new System.Drawing.Point(4, 22);
			this.MovingAverageNM.Name = "MovingAverageNM";
			this.MovingAverageNM.Padding = new System.Windows.Forms.Padding(3);
			this.MovingAverageNM.Size = new System.Drawing.Size(449, 136);
			this.MovingAverageNM.TabIndex = 1;
			this.MovingAverageNM.Text = "N-M MA";
			// 
			// btnNMCalculate
			// 
			this.btnNMCalculate.Location = new System.Drawing.Point(215, 104);
			this.btnNMCalculate.Name = "btnNMCalculate";
			this.btnNMCalculate.Size = new System.Drawing.Size(116, 23);
			this.btnNMCalculate.TabIndex = 6;
			this.btnNMCalculate.Text = "Calculate Return";
			this.btnNMCalculate.UseVisualStyleBackColor = true;
			this.btnNMCalculate.Click += new System.EventHandler(this.btnNMCalculate_Click);
			// 
			// tbNMSeed
			// 
			this.tbNMSeed.Location = new System.Drawing.Point(267, 16);
			this.tbNMSeed.Name = "tbNMSeed";
			this.tbNMSeed.Size = new System.Drawing.Size(65, 20);
			this.tbNMSeed.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(190, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Seed Money";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(212, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "M Value";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(212, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "N Value";
			// 
			// tbMValue
			// 
			this.tbMValue.Location = new System.Drawing.Point(267, 68);
			this.tbMValue.Name = "tbMValue";
			this.tbMValue.Size = new System.Drawing.Size(65, 20);
			this.tbMValue.TabIndex = 5;
			// 
			// tbNValue
			// 
			this.tbNValue.Location = new System.Drawing.Point(267, 42);
			this.tbNValue.Name = "tbNValue";
			this.tbNValue.Size = new System.Drawing.Size(65, 20);
			this.tbNValue.TabIndex = 4;
			// 
			// ExpMovingAverage
			// 
			this.ExpMovingAverage.BackColor = System.Drawing.SystemColors.Control;
			this.ExpMovingAverage.Controls.Add(this.tbExpSeed);
			this.ExpMovingAverage.Controls.Add(this.label8);
			this.ExpMovingAverage.Controls.Add(this.btnExpCalculate);
			this.ExpMovingAverage.Controls.Add(this.label7);
			this.ExpMovingAverage.Controls.Add(this.label6);
			this.ExpMovingAverage.Controls.Add(this.tbExpDays);
			this.ExpMovingAverage.Controls.Add(this.tbExpSmoothing);
			this.ExpMovingAverage.Location = new System.Drawing.Point(4, 22);
			this.ExpMovingAverage.Name = "ExpMovingAverage";
			this.ExpMovingAverage.Size = new System.Drawing.Size(449, 136);
			this.ExpMovingAverage.TabIndex = 2;
			this.ExpMovingAverage.Text = "Exp MA";
			// 
			// btnExpCalculate
			// 
			this.btnExpCalculate.Location = new System.Drawing.Point(327, 95);
			this.btnExpCalculate.Name = "btnExpCalculate";
			this.btnExpCalculate.Size = new System.Drawing.Size(106, 23);
			this.btnExpCalculate.TabIndex = 4;
			this.btnExpCalculate.Text = "Calculate Return";
			this.btnExpCalculate.UseVisualStyleBackColor = true;
			this.btnExpCalculate.Click += new System.EventHandler(this.btnExpCalculate_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(312, 63);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Days";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(293, 37);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Smoothing";
			// 
			// tbExpDays
			// 
			this.tbExpDays.Location = new System.Drawing.Point(355, 60);
			this.tbExpDays.Name = "tbExpDays";
			this.tbExpDays.Size = new System.Drawing.Size(78, 20);
			this.tbExpDays.TabIndex = 8;
			// 
			// tbExpSmoothing
			// 
			this.tbExpSmoothing.Location = new System.Drawing.Point(354, 34);
			this.tbExpSmoothing.Name = "tbExpSmoothing";
			this.tbExpSmoothing.Size = new System.Drawing.Size(78, 20);
			this.tbExpSmoothing.TabIndex = 7;
			// 
			// tbOutputPath
			// 
			this.tbOutputPath.Location = new System.Drawing.Point(19, 60);
			this.tbOutputPath.Name = "tbOutputPath";
			this.tbOutputPath.Size = new System.Drawing.Size(432, 20);
			this.tbOutputPath.TabIndex = 9;
			// 
			// btnOutPutDialog
			// 
			this.btnOutPutDialog.Location = new System.Drawing.Point(259, 19);
			this.btnOutPutDialog.Name = "btnOutPutDialog";
			this.btnOutPutDialog.Size = new System.Drawing.Size(192, 35);
			this.btnOutPutDialog.TabIndex = 10;
			this.btnOutPutDialog.Text = "Select Output Path";
			this.btnOutPutDialog.UseVisualStyleBackColor = true;
			this.btnOutPutDialog.Click += new System.EventHandler(this.btnOutPutDialog_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(276, 11);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Seed Money";
			// 
			// tbExpSeed
			// 
			this.tbExpSeed.Location = new System.Drawing.Point(354, 8);
			this.tbExpSeed.Name = "tbExpSeed";
			this.tbExpSeed.Size = new System.Drawing.Size(79, 20);
			this.tbExpSeed.TabIndex = 6;
			// 
			// dgResults
			// 
			this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Method,
            this.StartDate,
            this.EndDate,
            this.Seed,
            this.Days1,
            this.Days2,
            this.Smoothing,
            this.Return});
			this.dgResults.Location = new System.Drawing.Point(12, 716);
			this.dgResults.Name = "dgResults";
			this.dgResults.Size = new System.Drawing.Size(976, 223);
			this.dgResults.TabIndex = 0;
			// 
			// Symbol
			// 
			this.Symbol.HeaderText = "Symbol";
			this.Symbol.Name = "Symbol";
			this.Symbol.ReadOnly = true;
			// 
			// Method
			// 
			this.Method.HeaderText = "Method";
			this.Method.Name = "Method";
			this.Method.ReadOnly = true;
			// 
			// StartDate
			// 
			this.StartDate.HeaderText = "StartDate";
			this.StartDate.Name = "StartDate";
			this.StartDate.ReadOnly = true;
			// 
			// EndDate
			// 
			this.EndDate.HeaderText = "EndDate";
			this.EndDate.Name = "EndDate";
			this.EndDate.ReadOnly = true;
			// 
			// Seed
			// 
			this.Seed.HeaderText = "Seed";
			this.Seed.Name = "Seed";
			this.Seed.ReadOnly = true;
			// 
			// Days1
			// 
			this.Days1.HeaderText = "Days1";
			this.Days1.Name = "Days1";
			this.Days1.ReadOnly = true;
			// 
			// Days2
			// 
			this.Days2.HeaderText = "Days2";
			this.Days2.Name = "Days2";
			this.Days2.ReadOnly = true;
			// 
			// Smoothing
			// 
			this.Smoothing.HeaderText = "Smoothing";
			this.Smoothing.Name = "Smoothing";
			this.Smoothing.ReadOnly = true;
			// 
			// Return
			// 
			this.Return.HeaderText = "Return";
			this.Return.Name = "Return";
			this.Return.ReadOnly = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnGetCsvData);
			this.groupBox2.Controls.Add(this.tbFilePath);
			this.groupBox2.Location = new System.Drawing.Point(1011, 21);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(457, 123);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Input Data";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.tbExportFileName);
			this.groupBox3.Controls.Add(this.cbExportData);
			this.groupBox3.Controls.Add(this.btnOutPutDialog);
			this.groupBox3.Controls.Add(this.tbOutputPath);
			this.groupBox3.Location = new System.Drawing.Point(1011, 481);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(457, 138);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Output Data";
			// 
			// cbExportData
			// 
			this.cbExportData.AutoSize = true;
			this.cbExportData.Location = new System.Drawing.Point(21, 29);
			this.cbExportData.Name = "cbExportData";
			this.cbExportData.Size = new System.Drawing.Size(82, 17);
			this.cbExportData.TabIndex = 11;
			this.cbExportData.Text = "Export Data";
			this.cbExportData.UseVisualStyleBackColor = true;
			// 
			// tbExportFileName
			// 
			this.tbExportFileName.Location = new System.Drawing.Point(205, 101);
			this.tbExportFileName.Name = "tbExportFileName";
			this.tbExportFileName.Size = new System.Drawing.Size(246, 20);
			this.tbExportFileName.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(142, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "File Name:";
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.btnBuyHoldCalculate);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.tbBuyHoldSeed);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(449, 136);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Buy & Hold";
			// 
			// tbBuyHoldSeed
			// 
			this.tbBuyHoldSeed.Location = new System.Drawing.Point(322, 15);
			this.tbBuyHoldSeed.Name = "tbBuyHoldSeed";
			this.tbBuyHoldSeed.Size = new System.Drawing.Size(100, 20);
			this.tbBuyHoldSeed.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(231, 18);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Seed Money";
			// 
			// btnBuyHoldCalculate
			// 
			this.btnBuyHoldCalculate.Location = new System.Drawing.Point(293, 60);
			this.btnBuyHoldCalculate.Name = "btnBuyHoldCalculate";
			this.btnBuyHoldCalculate.Size = new System.Drawing.Size(128, 23);
			this.btnBuyHoldCalculate.TabIndex = 2;
			this.btnBuyHoldCalculate.Text = "Calculate Returns";
			this.btnBuyHoldCalculate.UseVisualStyleBackColor = true;
			this.btnBuyHoldCalculate.Click += new System.EventHandler(this.btnBuyHoldCalculate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1495, 988);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dgResults);
			this.Controls.Add(this.tabMovingAverage);
			this.Controls.Add(this.chrtPortfolio);
			this.Controls.Add(this.chrtCoinAndMa);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "FNCE631-O-Matic";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chrtCoinAndMa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chrtPortfolio)).EndInit();
			this.tabMovingAverage.ResumeLayout(false);
			this.MovingAverage.ResumeLayout(false);
			this.MovingAverage.PerformLayout();
			this.MovingAverageNM.ResumeLayout(false);
			this.MovingAverageNM.PerformLayout();
			this.ExpMovingAverage.ResumeLayout(false);
			this.ExpMovingAverage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGetCsvData;
		private System.Windows.Forms.OpenFileDialog CsvFileDialog;
		private System.Windows.Forms.TextBox tbFilePath;
		private System.Windows.Forms.TextBox tbMovingAverageDays;
		private System.Windows.Forms.Button btnPlotData;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblMovingAverage;
		private System.Windows.Forms.Label lblParseProgress;
		private System.Windows.Forms.DataVisualization.Charting.Chart chrtCoinAndMa;
		private Chart chrtPortfolio;
		private System.Windows.Forms.TextBox tbSeedMoney;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabMovingAverage;
		private System.Windows.Forms.TabPage MovingAverage;
		private System.Windows.Forms.TabPage MovingAverageNM;
		private System.Windows.Forms.TextBox tbOutputPath;
		private System.Windows.Forms.Button btnOutPutDialog;
		private System.Windows.Forms.FolderBrowserDialog OutputFolderDialog;
		private System.Windows.Forms.Label lblDates;
		private System.Windows.Forms.Label lblSymbol;
		private System.Windows.Forms.Label lblSource;
		private System.Windows.Forms.Button btnMaMethodCalculate;
		private System.Windows.Forms.Button btnNMCalculate;
		private System.Windows.Forms.TextBox tbNMSeed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbMValue;
		private System.Windows.Forms.TextBox tbNValue;
		private System.Windows.Forms.TabPage ExpMovingAverage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbExpDays;
		private System.Windows.Forms.TextBox tbExpSmoothing;
		private System.Windows.Forms.Button btnExpCalculate;
		private System.Windows.Forms.TextBox tbExpSeed;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dgResults;
		private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
		private System.Windows.Forms.DataGridViewTextBoxColumn Method;
		private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Seed;
		private System.Windows.Forms.DataGridViewTextBoxColumn Days1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Days2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Smoothing;
		private System.Windows.Forms.DataGridViewTextBoxColumn Return;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbExportFileName;
		private System.Windows.Forms.CheckBox cbExportData;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnBuyHoldCalculate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbBuyHoldSeed;
	}
}

