namespace NbComm
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExport = new System.Windows.Forms.Button();
            this.radioBtSplitSrc = new System.Windows.Forms.RadioButton();
            this.radioBtSameSrc = new System.Windows.Forms.RadioButton();
            this.CH4Value = new System.Windows.Forms.Label();
            this.CH3Value = new System.Windows.Forms.Label();
            this.CH2Value = new System.Windows.Forms.Label();
            this.CH1Value = new System.Windows.Forms.Label();
            this.CH4Index = new System.Windows.Forms.Label();
            this.CH3Index = new System.Windows.Forms.Label();
            this.CH2Index = new System.Windows.Forms.Label();
            this.CH1Index = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxChNumber = new System.Windows.Forms.ComboBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.coBoxWaveType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coBoxDataType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart2CH4Data = new System.Windows.Forms.Label();
            this.chart2CH3Data = new System.Windows.Forms.Label();
            this.chart2CH2Data = new System.Windows.Forms.Label();
            this.chart2CH1Data = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelWaveData = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btClose = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "串口示波器";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.ScrollBar.Enabled = false;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MaximumAutoSize = 10F;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.ScrollBar.Enabled = false;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 92F;
            chartArea1.InnerPlotPosition.Width = 96F;
            chartArea1.InnerPlotPosition.X = 2F;
            chartArea1.InnerPlotPosition.Y = 2F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 99F;
            chartArea1.Position.Width = 99F;
            chartArea1.Position.X = 1F;
            chartArea1.Position.Y = 1F;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 6;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.LightGray;
            legend1.ItemColumnSpacing = 10;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 18F;
            legend1.Position.Width = 9F;
            legend1.Position.X = 90F;
            legend1.Position.Y = 4F;
            legend1.TitleForeColor = System.Drawing.Color.Silver;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Chartreuse;
            series1.CustomProperties = "LineTension=0";
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "CH1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.DeepSkyBlue;
            series2.CustomProperties = "LineTension=0";
            series2.Legend = "Legend1";
            series2.Name = "CH2";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Fuchsia;
            series3.CustomProperties = "LineTension=0";
            series3.Legend = "Legend1";
            series3.Name = "CH3";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Orange;
            series4.CustomProperties = "LineTension=0";
            series4.Legend = "Legend1";
            series4.Name = "CH4";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1047, 392);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chart1_KeyDown);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            this.chart1.MouseEnter += new System.EventHandler(this.chart1_MouseEnter);
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            this.chart1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btExport);
            this.panel2.Controls.Add(this.radioBtSplitSrc);
            this.panel2.Controls.Add(this.radioBtSameSrc);
            this.panel2.Controls.Add(this.CH4Value);
            this.panel2.Controls.Add(this.CH3Value);
            this.panel2.Controls.Add(this.CH2Value);
            this.panel2.Controls.Add(this.CH1Value);
            this.panel2.Controls.Add(this.CH4Index);
            this.panel2.Controls.Add(this.CH3Index);
            this.panel2.Controls.Add(this.CH2Index);
            this.panel2.Controls.Add(this.CH1Index);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comBoxChNumber);
            this.panel2.Controls.Add(this.btStart);
            this.panel2.Controls.Add(this.btClear);
            this.panel2.Controls.Add(this.coBoxWaveType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.coBoxDataType);
            this.panel2.Location = new System.Drawing.Point(1050, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 748);
            this.panel2.TabIndex = 48;
            // 
            // btExport
            // 
            this.btExport.BackgroundImage = global::NbComm.Properties.Resources.btExport_rel;
            this.btExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btExport.FlatAppearance.BorderSize = 0;
            this.btExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExport.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btExport.Location = new System.Drawing.Point(11, 380);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(188, 32);
            this.btExport.TabIndex = 66;
            this.btExport.Text = "导 出 数 据";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            this.btExport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btExport_MouseDown);
            this.btExport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btExport_MouseUp);
            // 
            // radioBtSplitSrc
            // 
            this.radioBtSplitSrc.AutoSize = true;
            this.radioBtSplitSrc.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtSplitSrc.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBtSplitSrc.Location = new System.Drawing.Point(122, 133);
            this.radioBtSplitSrc.Name = "radioBtSplitSrc";
            this.radioBtSplitSrc.Size = new System.Drawing.Size(76, 23);
            this.radioBtSplitSrc.TabIndex = 65;
            this.radioBtSplitSrc.Text = "分  屏";
            this.radioBtSplitSrc.UseVisualStyleBackColor = true;
            // 
            // radioBtSameSrc
            // 
            this.radioBtSameSrc.AutoSize = true;
            this.radioBtSameSrc.Checked = true;
            this.radioBtSameSrc.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioBtSameSrc.ForeColor = System.Drawing.SystemColors.Control;
            this.radioBtSameSrc.Location = new System.Drawing.Point(9, 133);
            this.radioBtSameSrc.Name = "radioBtSameSrc";
            this.radioBtSameSrc.Size = new System.Drawing.Size(76, 23);
            this.radioBtSameSrc.TabIndex = 51;
            this.radioBtSameSrc.TabStop = true;
            this.radioBtSameSrc.Text = "同  屏";
            this.radioBtSameSrc.UseVisualStyleBackColor = true;
            // 
            // CH4Value
            // 
            this.CH4Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CH4Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH4Value.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CH4Value.ForeColor = System.Drawing.SystemColors.Control;
            this.CH4Value.Location = new System.Drawing.Point(69, 340);
            this.CH4Value.Name = "CH4Value";
            this.CH4Value.Size = new System.Drawing.Size(130, 25);
            this.CH4Value.TabIndex = 64;
            this.CH4Value.Text = "0";
            this.CH4Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CH3Value
            // 
            this.CH3Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CH3Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH3Value.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CH3Value.ForeColor = System.Drawing.SystemColors.Control;
            this.CH3Value.Location = new System.Drawing.Point(69, 300);
            this.CH3Value.Name = "CH3Value";
            this.CH3Value.Size = new System.Drawing.Size(130, 25);
            this.CH3Value.TabIndex = 63;
            this.CH3Value.Text = "0";
            this.CH3Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CH2Value
            // 
            this.CH2Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CH2Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH2Value.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CH2Value.ForeColor = System.Drawing.SystemColors.Control;
            this.CH2Value.Location = new System.Drawing.Point(69, 260);
            this.CH2Value.Name = "CH2Value";
            this.CH2Value.Size = new System.Drawing.Size(130, 25);
            this.CH2Value.TabIndex = 62;
            this.CH2Value.Text = "0";
            this.CH2Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CH1Value
            // 
            this.CH1Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CH1Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CH1Value.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CH1Value.ForeColor = System.Drawing.SystemColors.Control;
            this.CH1Value.Location = new System.Drawing.Point(69, 220);
            this.CH1Value.Name = "CH1Value";
            this.CH1Value.Size = new System.Drawing.Size(130, 25);
            this.CH1Value.TabIndex = 61;
            this.CH1Value.Text = "0";
            this.CH1Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CH4Index
            // 
            this.CH4Index.AutoSize = true;
            this.CH4Index.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CH4Index.ForeColor = System.Drawing.SystemColors.Control;
            this.CH4Index.Location = new System.Drawing.Point(5, 343);
            this.CH4Index.Name = "CH4Index";
            this.CH4Index.Size = new System.Drawing.Size(59, 19);
            this.CH4Index.TabIndex = 60;
            this.CH4Index.Text = "CH4值";
            // 
            // CH3Index
            // 
            this.CH3Index.AutoSize = true;
            this.CH3Index.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CH3Index.ForeColor = System.Drawing.SystemColors.Control;
            this.CH3Index.Location = new System.Drawing.Point(5, 303);
            this.CH3Index.Name = "CH3Index";
            this.CH3Index.Size = new System.Drawing.Size(59, 19);
            this.CH3Index.TabIndex = 59;
            this.CH3Index.Text = "CH3值";
            // 
            // CH2Index
            // 
            this.CH2Index.AutoSize = true;
            this.CH2Index.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CH2Index.ForeColor = System.Drawing.SystemColors.Control;
            this.CH2Index.Location = new System.Drawing.Point(5, 263);
            this.CH2Index.Name = "CH2Index";
            this.CH2Index.Size = new System.Drawing.Size(59, 19);
            this.CH2Index.TabIndex = 58;
            this.CH2Index.Text = "CH2值";
            // 
            // CH1Index
            // 
            this.CH1Index.AutoSize = true;
            this.CH1Index.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CH1Index.ForeColor = System.Drawing.SystemColors.Control;
            this.CH1Index.Location = new System.Drawing.Point(5, 223);
            this.CH1Index.Name = "CH1Index";
            this.CH1Index.Size = new System.Drawing.Size(59, 19);
            this.CH1Index.TabIndex = 57;
            this.CH1Index.Text = "CH1值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "通道个数";
            // 
            // comBoxChNumber
            // 
            this.comBoxChNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comBoxChNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxChNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comBoxChNumber.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comBoxChNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comBoxChNumber.FormattingEnabled = true;
            this.comBoxChNumber.Items.AddRange(new object[] {
            "1通道",
            "2通道",
            "3通道",
            "4通道"});
            this.comBoxChNumber.Location = new System.Drawing.Point(98, 10);
            this.comBoxChNumber.Name = "comBoxChNumber";
            this.comBoxChNumber.Size = new System.Drawing.Size(100, 27);
            this.comBoxChNumber.TabIndex = 55;
            this.comBoxChNumber.SelectedIndexChanged += new System.EventHandler(this.comBoxChNumber_SelectedIndexChanged);
            // 
            // btStart
            // 
            this.btStart.BackgroundImage = global::NbComm.Properties.Resources.btBlue80_32_rel;
            this.btStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btStart.FlatAppearance.BorderSize = 0;
            this.btStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btStart.Location = new System.Drawing.Point(118, 168);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(80, 32);
            this.btStart.TabIndex = 54;
            this.btStart.Text = "开  启";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            this.btStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseDown);
            this.btStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseUp);
            // 
            // btClear
            // 
            this.btClear.BackgroundImage = global::NbComm.Properties.Resources.btBlue80_32_rel;
            this.btClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClear.Location = new System.Drawing.Point(9, 168);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(80, 32);
            this.btClear.TabIndex = 53;
            this.btClear.Text = "清  除";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            this.btClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btClear_MouseDown);
            this.btClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btClear_MouseUp);
            // 
            // coBoxWaveType
            // 
            this.coBoxWaveType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.coBoxWaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxWaveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coBoxWaveType.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coBoxWaveType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.coBoxWaveType.FormattingEnabled = true;
            this.coBoxWaveType.Items.AddRange(new object[] {
            "曲线",
            "折线",
            "打点"});
            this.coBoxWaveType.Location = new System.Drawing.Point(98, 90);
            this.coBoxWaveType.Name = "coBoxWaveType";
            this.coBoxWaveType.Size = new System.Drawing.Size(100, 27);
            this.coBoxWaveType.TabIndex = 44;
            this.coBoxWaveType.SelectedIndexChanged += new System.EventHandler(this.coBoxWaveType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "波形模式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "数据类型";
            // 
            // coBoxDataType
            // 
            this.coBoxDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.coBoxDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBoxDataType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coBoxDataType.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coBoxDataType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.coBoxDataType.FormattingEnabled = true;
            this.coBoxDataType.Items.AddRange(new object[] {
            "int8",
            "uint8",
            "int16",
            "uint16",
            "int32",
            "uint32"});
            this.coBoxDataType.Location = new System.Drawing.Point(98, 50);
            this.coBoxDataType.Name = "coBoxDataType";
            this.coBoxDataType.Size = new System.Drawing.Size(100, 27);
            this.coBoxDataType.TabIndex = 45;
            this.coBoxDataType.SelectedIndexChanged += new System.EventHandler(this.coBoxDataType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.chart2CH4Data);
            this.panel1.Controls.Add(this.chart2CH3Data);
            this.panel1.Controls.Add(this.chart2CH2Data);
            this.panel1.Controls.Add(this.chart2CH1Data);
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Controls.Add(this.labelWaveData);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 748);
            this.panel1.TabIndex = 4;
            // 
            // chart2CH4Data
            // 
            this.chart2CH4Data.AutoSize = true;
            this.chart2CH4Data.BackColor = System.Drawing.Color.Transparent;
            this.chart2CH4Data.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chart2CH4Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart2CH4Data.Location = new System.Drawing.Point(546, 589);
            this.chart2CH4Data.Name = "chart2CH4Data";
            this.chart2CH4Data.Size = new System.Drawing.Size(23, 15);
            this.chart2CH4Data.TabIndex = 54;
            this.chart2CH4Data.Text = "00";
            // 
            // chart2CH3Data
            // 
            this.chart2CH3Data.AutoSize = true;
            this.chart2CH3Data.BackColor = System.Drawing.Color.Transparent;
            this.chart2CH3Data.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chart2CH3Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart2CH3Data.Location = new System.Drawing.Point(546, 414);
            this.chart2CH3Data.Name = "chart2CH3Data";
            this.chart2CH3Data.Size = new System.Drawing.Size(23, 15);
            this.chart2CH3Data.TabIndex = 53;
            this.chart2CH3Data.Text = "00";
            // 
            // chart2CH2Data
            // 
            this.chart2CH2Data.AutoSize = true;
            this.chart2CH2Data.BackColor = System.Drawing.Color.Transparent;
            this.chart2CH2Data.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chart2CH2Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart2CH2Data.Location = new System.Drawing.Point(35, 589);
            this.chart2CH2Data.Name = "chart2CH2Data";
            this.chart2CH2Data.Size = new System.Drawing.Size(23, 15);
            this.chart2CH2Data.TabIndex = 52;
            this.chart2CH2Data.Text = "00";
            // 
            // chart2CH1Data
            // 
            this.chart2CH1Data.AutoSize = true;
            this.chart2CH1Data.BackColor = System.Drawing.Color.Transparent;
            this.chart2CH1Data.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chart2CH1Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart2CH1Data.Location = new System.Drawing.Point(35, 414);
            this.chart2CH1Data.Name = "chart2CH1Data";
            this.chart2CH1Data.Size = new System.Drawing.Size(23, 15);
            this.chart2CH1Data.TabIndex = 51;
            this.chart2CH1Data.Text = "00";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea2.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.ScrollBar.Enabled = false;
            chartArea2.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.ScrollBar.Enabled = false;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea2.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea2.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 82F;
            chartArea2.InnerPlotPosition.Width = 95F;
            chartArea2.InnerPlotPosition.X = 5F;
            chartArea2.InnerPlotPosition.Y = 5F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 50F;
            chartArea2.Position.Width = 48.5F;
            chartArea2.Position.X = 0.5F;
            chartArea2.Position.Y = 1F;
            chartArea3.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisX.ScrollBar.Enabled = false;
            chartArea3.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.ScrollBar.Enabled = false;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea3.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.CursorY.IsUserEnabled = true;
            chartArea3.CursorY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea3.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 82F;
            chartArea3.InnerPlotPosition.Width = 95F;
            chartArea3.InnerPlotPosition.X = 5F;
            chartArea3.InnerPlotPosition.Y = 5F;
            chartArea3.Name = "ChartArea2";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 50F;
            chartArea3.Position.Width = 48.5F;
            chartArea3.Position.X = 0.5F;
            chartArea3.Position.Y = 50F;
            chartArea4.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea4.AxisX.ScrollBar.Enabled = false;
            chartArea4.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea4.AxisY.ScrollBar.Enabled = false;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea4.CursorX.IsUserEnabled = true;
            chartArea4.CursorX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea4.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.CursorY.IsUserEnabled = true;
            chartArea4.CursorY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea4.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.InnerPlotPosition.Auto = false;
            chartArea4.InnerPlotPosition.Height = 82F;
            chartArea4.InnerPlotPosition.Width = 95F;
            chartArea4.InnerPlotPosition.X = 5F;
            chartArea4.InnerPlotPosition.Y = 5F;
            chartArea4.Name = "ChartArea3";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 50F;
            chartArea4.Position.Width = 48.5F;
            chartArea4.Position.X = 49.5F;
            chartArea4.Position.Y = 1F;
            chartArea5.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea5.AxisX.ScrollBar.Enabled = false;
            chartArea5.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea5.AxisY.LabelStyle.Enabled = false;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea5.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea5.AxisY.MajorTickMark.Enabled = false;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea5.AxisY.ScrollBar.Enabled = false;
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            chartArea5.CursorX.IsUserEnabled = true;
            chartArea5.CursorX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea5.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.CursorY.IsUserEnabled = true;
            chartArea5.CursorY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea5.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.InnerPlotPosition.Auto = false;
            chartArea5.InnerPlotPosition.Height = 82F;
            chartArea5.InnerPlotPosition.Width = 95F;
            chartArea5.InnerPlotPosition.X = 5F;
            chartArea5.InnerPlotPosition.Y = 5F;
            chartArea5.Name = "ChartArea4";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 50F;
            chartArea5.Position.Width = 48.5F;
            chartArea5.Position.X = 49.5F;
            chartArea5.Position.Y = 50F;
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.ChartAreas.Add(chartArea5);
            legend2.AutoFitMinFontSize = 6;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.LightGray;
            legend2.ItemColumnSpacing = 10;
            legend2.MaximumAutoSize = 10F;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 8F;
            legend2.Position.Width = 8F;
            legend2.Position.X = 42F;
            legend2.Position.Y = 4F;
            legend2.TitleForeColor = System.Drawing.Color.Silver;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.ForeColor = System.Drawing.Color.LightGray;
            legend3.Name = "Legend2";
            legend3.Position.Auto = false;
            legend3.Position.Height = 8F;
            legend3.Position.Width = 8F;
            legend3.Position.X = 42F;
            legend3.Position.Y = 53F;
            legend3.TitleForeColor = System.Drawing.Color.Silver;
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.ForeColor = System.Drawing.Color.LightGray;
            legend4.Name = "Legend3";
            legend4.Position.Auto = false;
            legend4.Position.Height = 8F;
            legend4.Position.Width = 8F;
            legend4.Position.X = 91F;
            legend4.Position.Y = 4F;
            legend4.TitleForeColor = System.Drawing.Color.Silver;
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.ForeColor = System.Drawing.Color.LightGray;
            legend5.Name = "Legend4";
            legend5.Position.Auto = false;
            legend5.Position.Height = 8F;
            legend5.Position.Width = 8F;
            legend5.Position.X = 91F;
            legend5.Position.Y = 53F;
            legend5.TitleForeColor = System.Drawing.Color.Silver;
            this.chart2.Legends.Add(legend2);
            this.chart2.Legends.Add(legend3);
            this.chart2.Legends.Add(legend4);
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(0, 395);
            this.chart2.Name = "chart2";
            series5.BorderColor = System.Drawing.Color.White;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Chartreuse;
            series5.CustomProperties = "LineTension=0";
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "CH1";
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea2";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.DeepSkyBlue;
            series6.CustomProperties = "LineTension=0";
            series6.Legend = "Legend2";
            series6.Name = "CH2";
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea3";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Fuchsia;
            series7.CustomProperties = "LineTension=0";
            series7.Legend = "Legend3";
            series7.Name = "CH3";
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea4";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.Orange;
            series8.CustomProperties = "LineTension=0";
            series8.Legend = "Legend4";
            series8.Name = "CH4";
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(1047, 353);
            this.chart2.TabIndex = 50;
            this.chart2.Text = "chart2";
            this.chart2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseDown);
            this.chart2.MouseEnter += new System.EventHandler(this.chart2_MouseEnter);
            this.chart2.MouseLeave += new System.EventHandler(this.chart2_MouseLeave);
            this.chart2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseMove);
            this.chart2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseUp);
            // 
            // labelWaveData
            // 
            this.labelWaveData.AutoSize = true;
            this.labelWaveData.BackColor = System.Drawing.Color.Transparent;
            this.labelWaveData.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWaveData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelWaveData.Location = new System.Drawing.Point(35, 18);
            this.labelWaveData.Name = "labelWaveData";
            this.labelWaveData.Size = new System.Drawing.Size(23, 15);
            this.labelWaveData.TabIndex = 49;
            this.labelWaveData.Text = "00";
            // 
            // btClose
            // 
            this.btClose.BackgroundImage = global::NbComm.Properties.Resources.btClose01;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(1211, 6);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(36, 36);
            this.btClose.TabIndex = 3;
            this.btClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btClose_MouseDown);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            this.btClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btClose_MouseUp);
            // 
            // btMin
            // 
            this.btMin.BackgroundImage = global::NbComm.Properties.Resources.btMin01;
            this.btMin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Location = new System.Drawing.Point(1166, 6);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(36, 36);
            this.btMin.TabIndex = 2;
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            this.btMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMin_MouseDown);
            this.btMin.MouseEnter += new System.EventHandler(this.btMin_MouseEnter);
            this.btMin.MouseLeave += new System.EventHandler(this.btMin_MouseLeave);
            this.btMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMin_MouseUp);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1260, 800);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form4_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxChNumber;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.ComboBox coBoxWaveType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox coBoxDataType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CH4Index;
        private System.Windows.Forms.Label CH3Index;
        private System.Windows.Forms.Label CH2Index;
        private System.Windows.Forms.Label CH1Index;
        private System.Windows.Forms.Label CH1Value;
        private System.Windows.Forms.Label CH4Value;
        private System.Windows.Forms.Label CH3Value;
        private System.Windows.Forms.Label CH2Value;
        private System.Windows.Forms.Label labelWaveData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.RadioButton radioBtSplitSrc;
        private System.Windows.Forms.RadioButton radioBtSameSrc;
        private System.Windows.Forms.Label chart2CH4Data;
        private System.Windows.Forms.Label chart2CH3Data;
        private System.Windows.Forms.Label chart2CH2Data;
        private System.Windows.Forms.Label chart2CH1Data;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}