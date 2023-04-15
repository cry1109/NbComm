namespace NbComm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExtrude = new System.Windows.Forms.Button();
            this.btFindLast = new System.Windows.Forms.Button();
            this.btFindNext = new System.Windows.Forms.Button();
            this.btRxFind = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ChartTimer = new System.Windows.Forms.Timer(this.components);
            this.fileSendTimer = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelVersion = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.myGroupBox6 = new NbComm.MyGroupBox(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btFileOpen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btFileCancel = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.btFileSend = new System.Windows.Forms.Button();
            this.myGroupBox5 = new NbComm.MyGroupBox(this.components);
            this.TxNumber = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RxNumber = new System.Windows.Forms.Label();
            this.labelChart = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.myGroupBox4 = new NbComm.MyGroupBox(this.components);
            this.btWave = new System.Windows.Forms.Button();
            this.btUserPtl = new System.Windows.Forms.Button();
            this.btCheckCode = new System.Windows.Forms.Button();
            this.btRxColor = new System.Windows.Forms.Button();
            this.btTxColor = new System.Windows.Forms.Button();
            this.btRxFont = new System.Windows.Forms.Button();
            this.myGroupBox3 = new NbComm.MyGroupBox(this.components);
            this.TxEncodingBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btTxClear = new System.Windows.Forms.Button();
            this.TimerTx = new System.Windows.Forms.TextBox();
            this.btTxSend = new System.Windows.Forms.Button();
            this.TimerSendcheckBox = new System.Windows.Forms.CheckBox();
            this.radioButtonTxAsc = new System.Windows.Forms.RadioButton();
            this.radioButtonTxHex = new System.Windows.Forms.RadioButton();
            this.myGroupBox2 = new NbComm.MyGroupBox(this.components);
            this.checkBoxDisplay = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RxEncodingBox = new System.Windows.Forms.ComboBox();
            this.btRxClear = new System.Windows.Forms.Button();
            this.RxCheckbox1 = new System.Windows.Forms.CheckBox();
            this.radioButtonRxAsc = new System.Windows.Forms.RadioButton();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.btRxSave = new System.Windows.Forms.Button();
            this.TimestampcheckBox = new System.Windows.Forms.CheckBox();
            this.radioButtonRxHex = new System.Windows.Forms.RadioButton();
            this.myGroupBox1 = new NbComm.MyGroupBox(this.components);
            this.comboDatalength = new System.Windows.Forms.ComboBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btCheck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboStopbit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxDtr = new System.Windows.Forms.CheckBox();
            this.comboBoxBoud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxJudge = new System.Windows.Forms.ComboBox();
            this.checkBoxRts = new System.Windows.Forms.CheckBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.myGroupBox6.SuspendLayout();
            this.myGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.myGroupBox4.SuspendLayout();
            this.myGroupBox3.SuspendLayout();
            this.myGroupBox2.SuspendLayout();
            this.myGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.myGroupBox6);
            this.panel1.Controls.Add(this.myGroupBox5);
            this.panel1.Controls.Add(this.myGroupBox4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 860);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.myGroupBox3);
            this.panel2.Controls.Add(this.myGroupBox2);
            this.panel2.Controls.Add(this.myGroupBox1);
            this.panel2.Controls.Add(this.btExtrude);
            this.panel2.Controls.Add(this.btFindLast);
            this.panel2.Controls.Add(this.btFindNext);
            this.panel2.Controls.Add(this.btRxFind);
            this.panel2.Controls.Add(this.textBoxFind);
            this.panel2.Controls.Add(this.richTextBoxInput);
            this.panel2.Controls.Add(this.textBoxSend);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1295, 860);
            this.panel2.TabIndex = 3;
            // 
            // btExtrude
            // 
            this.btExtrude.BackgroundImage = global::NbComm.Properties.Resources.btFind01;
            this.btExtrude.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btExtrude.FlatAppearance.BorderSize = 0;
            this.btExtrude.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btExtrude.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btExtrude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExtrude.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExtrude.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btExtrude.Location = new System.Drawing.Point(960, 594);
            this.btExtrude.Name = "btExtrude";
            this.btExtrude.Size = new System.Drawing.Size(80, 32);
            this.btExtrude.TabIndex = 39;
            this.btExtrude.Text = "突 出";
            this.btExtrude.UseVisualStyleBackColor = true;
            this.btExtrude.Click += new System.EventHandler(this.btExtrude_Click);
            this.btExtrude.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btExtrude_MouseDown);
            this.btExtrude.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btExtrude_MouseUp);
            // 
            // btFindLast
            // 
            this.btFindLast.BackgroundImage = global::NbComm.Properties.Resources.btFind03;
            this.btFindLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFindLast.FlatAppearance.BorderSize = 0;
            this.btFindLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFindLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFindLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindLast.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFindLast.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btFindLast.Location = new System.Drawing.Point(1174, 593);
            this.btFindLast.Name = "btFindLast";
            this.btFindLast.Size = new System.Drawing.Size(115, 32);
            this.btFindLast.TabIndex = 38;
            this.btFindLast.Text = "上 一 条";
            this.btFindLast.UseVisualStyleBackColor = true;
            this.btFindLast.Click += new System.EventHandler(this.btFindLast_Click);
            this.btFindLast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btFindLast_MouseDown);
            this.btFindLast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFindLast_MouseUp);
            // 
            // btFindNext
            // 
            this.btFindNext.BackgroundImage = global::NbComm.Properties.Resources.btFind03;
            this.btFindNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFindNext.FlatAppearance.BorderSize = 0;
            this.btFindNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFindNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindNext.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFindNext.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btFindNext.Location = new System.Drawing.Point(1049, 594);
            this.btFindNext.Name = "btFindNext";
            this.btFindNext.Size = new System.Drawing.Size(115, 32);
            this.btFindNext.TabIndex = 37;
            this.btFindNext.Text = "下 一 条";
            this.btFindNext.UseVisualStyleBackColor = true;
            this.btFindNext.Click += new System.EventHandler(this.btFindNext_Click);
            this.btFindNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btFindNext_MouseDown);
            this.btFindNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFindNext_MouseUp);
            // 
            // btRxFind
            // 
            this.btRxFind.BackgroundImage = global::NbComm.Properties.Resources.btFind01;
            this.btRxFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxFind.FlatAppearance.BorderSize = 0;
            this.btRxFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRxFind.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRxFind.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btRxFind.Location = new System.Drawing.Point(870, 594);
            this.btRxFind.Name = "btRxFind";
            this.btRxFind.Size = new System.Drawing.Size(80, 32);
            this.btRxFind.TabIndex = 36;
            this.btRxFind.Text = "查 找";
            this.btRxFind.UseVisualStyleBackColor = true;
            this.btRxFind.Click += new System.EventHandler(this.btRxFind_Click);
            this.btRxFind.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRxFind_MouseDown);
            this.btRxFind.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRxFind_MouseUp);
            // 
            // textBoxFind
            // 
            this.textBoxFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFind.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFind.ForeColor = System.Drawing.Color.White;
            this.textBoxFind.Location = new System.Drawing.Point(298, 594);
            this.textBoxFind.MaxLength = 1024;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(560, 31);
            this.textBoxFind.TabIndex = 35;
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxInput.Font = new System.Drawing.Font("等线", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxInput.ForeColor = System.Drawing.Color.Cyan;
            this.richTextBoxInput.Location = new System.Drawing.Point(298, 6);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.ReadOnly = true;
            this.richTextBoxInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxInput.Size = new System.Drawing.Size(995, 580);
            this.richTextBoxInput.TabIndex = 34;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxInput_LinkClicked);
            this.richTextBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxInput_KeyDown);
            this.richTextBoxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBoxInput_KeyUp);
            // 
            // textBoxSend
            // 
            this.textBoxSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSend.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))));
            this.textBoxSend.Location = new System.Drawing.Point(298, 633);
            this.textBoxSend.MaxLength = 10485760;
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSend.Size = new System.Drawing.Size(995, 215);
            this.textBoxSend.TabIndex = 18;
            this.textBoxSend.TextChanged += new System.EventHandler(this.textBoxSend_TextChanged);
            this.textBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSend_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("等线", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(67, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "NbComm";
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 5242880;
            this.serialPort1.WriteBufferSize = 5242880;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ChartTimer
            // 
            this.ChartTimer.Enabled = true;
            this.ChartTimer.Interval = 50;
            this.ChartTimer.Tick += new System.EventHandler(this.ChartTimer_Tick);
            // 
            // fileSendTimer
            // 
            this.fileSendTimer.Interval = 50;
            this.fileSendTimer.Tick += new System.EventHandler(this.fileSendTimer_Tick);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "请选择文件保存路径";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Black;
            this.labelVersion.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelVersion.Location = new System.Drawing.Point(191, 24);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(49, 19);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "版本:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pictureBox1.ErrorImage = global::NbComm.Properties.Resources.nb_logo;
            this.pictureBox1.Image = global::NbComm.Properties.Resources.nb_logo;
            this.pictureBox1.InitialImage = global::NbComm.Properties.Resources.nb_logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.btClose.Location = new System.Drawing.Point(1502, 8);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(36, 36);
            this.btClose.TabIndex = 1;
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
            this.btMin.Location = new System.Drawing.Point(1457, 8);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(36, 36);
            this.btMin.TabIndex = 0;
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            this.btMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMin_MouseDown);
            this.btMin.MouseEnter += new System.EventHandler(this.btMin_MouseEnter);
            this.btMin.MouseLeave += new System.EventHandler(this.btMin_MouseLeave);
            this.btMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMin_MouseUp);
            // 
            // myGroupBox6
            // 
            this.myGroupBox6.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myGroupBox6.Controls.Add(this.progressBar1);
            this.myGroupBox6.Controls.Add(this.btFileOpen);
            this.myGroupBox6.Controls.Add(this.label11);
            this.myGroupBox6.Controls.Add(this.btFileCancel);
            this.myGroupBox6.Controls.Add(this.textBoxFileName);
            this.myGroupBox6.Controls.Add(this.btFileSend);
            this.myGroupBox6.Location = new System.Drawing.Point(1301, 633);
            this.myGroupBox6.Name = "myGroupBox6";
            this.myGroupBox6.Size = new System.Drawing.Size(243, 216);
            this.myGroupBox6.TabIndex = 45;
            this.myGroupBox6.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 135);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(220, 16);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 34;
            // 
            // btFileOpen
            // 
            this.btFileOpen.BackgroundImage = global::NbComm.Properties.Resources.bt22035Idle;
            this.btFileOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileOpen.FlatAppearance.BorderSize = 0;
            this.btFileOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFileOpen.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFileOpen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btFileOpen.Location = new System.Drawing.Point(11, 47);
            this.btFileOpen.Name = "btFileOpen";
            this.btFileOpen.Size = new System.Drawing.Size(220, 35);
            this.btFileOpen.TabIndex = 43;
            this.btFileOpen.Text = "打  开  文  件";
            this.btFileOpen.UseVisualStyleBackColor = true;
            this.btFileOpen.Click += new System.EventHandler(this.btFileOpen_Click);
            this.btFileOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btFileOpen_MouseDown);
            this.btFileOpen.MouseEnter += new System.EventHandler(this.btFileOpen_MouseEnter);
            this.btFileOpen.MouseLeave += new System.EventHandler(this.btFileOpen_MouseLeave);
            this.btFileOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFileOpen_MouseUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(7, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "文件发送:0kB";
            // 
            // btFileCancel
            // 
            this.btFileCancel.BackgroundImage = global::NbComm.Properties.Resources.bt11035Idle;
            this.btFileCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileCancel.FlatAppearance.BorderSize = 0;
            this.btFileCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFileCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFileCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btFileCancel.Location = new System.Drawing.Point(11, 168);
            this.btFileCancel.Name = "btFileCancel";
            this.btFileCancel.Size = new System.Drawing.Size(100, 35);
            this.btFileCancel.TabIndex = 41;
            this.btFileCancel.Text = "取    消";
            this.btFileCancel.UseVisualStyleBackColor = true;
            this.btFileCancel.Click += new System.EventHandler(this.btFileCancel_Click);
            this.btFileCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btFileCancel_MouseDown);
            this.btFileCancel.MouseEnter += new System.EventHandler(this.btFileCancel_MouseEnter);
            this.btFileCancel.MouseLeave += new System.EventHandler(this.btFileCancel_MouseLeave);
            this.btFileCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFileCancel_MouseUp);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFileName.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxFileName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxFileName.Location = new System.Drawing.Point(11, 96);
            this.textBoxFileName.MaxLength = 5;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(220, 28);
            this.textBoxFileName.TabIndex = 41;
            // 
            // btFileSend
            // 
            this.btFileSend.BackgroundImage = global::NbComm.Properties.Resources.bt11035Idle;
            this.btFileSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileSend.FlatAppearance.BorderSize = 0;
            this.btFileSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFileSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFileSend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFileSend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btFileSend.Location = new System.Drawing.Point(131, 168);
            this.btFileSend.Name = "btFileSend";
            this.btFileSend.Size = new System.Drawing.Size(100, 35);
            this.btFileSend.TabIndex = 42;
            this.btFileSend.Text = "发    送";
            this.btFileSend.UseVisualStyleBackColor = true;
            this.btFileSend.Click += new System.EventHandler(this.btFileSend_Click);
            this.btFileSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btFileSend_MouseDown);
            this.btFileSend.MouseEnter += new System.EventHandler(this.btFileSend_MouseEnter);
            this.btFileSend.MouseLeave += new System.EventHandler(this.btFileSend_MouseLeave);
            this.btFileSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFileSend_MouseUp);
            // 
            // myGroupBox5
            // 
            this.myGroupBox5.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myGroupBox5.Controls.Add(this.TxNumber);
            this.myGroupBox5.Controls.Add(this.chart1);
            this.myGroupBox5.Controls.Add(this.RxNumber);
            this.myGroupBox5.Controls.Add(this.labelChart);
            this.myGroupBox5.Controls.Add(this.label12);
            this.myGroupBox5.Controls.Add(this.label13);
            this.myGroupBox5.Location = new System.Drawing.Point(1301, 363);
            this.myGroupBox5.Name = "myGroupBox5";
            this.myGroupBox5.Size = new System.Drawing.Size(243, 262);
            this.myGroupBox5.TabIndex = 44;
            this.myGroupBox5.TabStop = false;
            // 
            // TxNumber
            // 
            this.TxNumber.AutoSize = true;
            this.TxNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.TxNumber.Location = new System.Drawing.Point(42, 29);
            this.TxNumber.Name = "TxNumber";
            this.TxNumber.Size = new System.Drawing.Size(24, 27);
            this.TxNumber.TabIndex = 41;
            this.TxNumber.Text = "0";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            chartArea1.CursorX.Interval = 0.1D;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.LineColor = System.Drawing.Color.GreenYellow;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.LineColor = System.Drawing.Color.GreenYellow;
            chartArea1.CursorY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 98F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 2F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(4, 58);
            this.chart1.Name = "chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series1.BackSecondaryColor = System.Drawing.Color.DarkTurquoise;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.MediumTurquoise;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(236, 200);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseEnter += new System.EventHandler(this.chart1_MouseEnter);
            this.chart1.MouseLeave += new System.EventHandler(this.chart1_MouseLeave);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // RxNumber
            // 
            this.RxNumber.AutoSize = true;
            this.RxNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RxNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.RxNumber.Location = new System.Drawing.Point(42, 4);
            this.RxNumber.Name = "RxNumber";
            this.RxNumber.Size = new System.Drawing.Size(24, 27);
            this.RxNumber.TabIndex = 40;
            this.RxNumber.Text = "0";
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChart.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelChart.Location = new System.Drawing.Point(11, 69);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(18, 20);
            this.labelChart.TabIndex = 34;
            this.labelChart.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(7, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 27);
            this.label12.TabIndex = 39;
            this.label12.Text = "Rx:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(7, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 27);
            this.label13.TabIndex = 37;
            this.label13.Text = "Tx:";
            // 
            // myGroupBox4
            // 
            this.myGroupBox4.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myGroupBox4.Controls.Add(this.btWave);
            this.myGroupBox4.Controls.Add(this.btUserPtl);
            this.myGroupBox4.Controls.Add(this.btCheckCode);
            this.myGroupBox4.Controls.Add(this.btRxColor);
            this.myGroupBox4.Controls.Add(this.btTxColor);
            this.myGroupBox4.Controls.Add(this.btRxFont);
            this.myGroupBox4.Location = new System.Drawing.Point(1301, 5);
            this.myGroupBox4.Name = "myGroupBox4";
            this.myGroupBox4.Size = new System.Drawing.Size(243, 351);
            this.myGroupBox4.TabIndex = 43;
            this.myGroupBox4.TabStop = false;
            // 
            // btWave
            // 
            this.btWave.BackgroundImage = global::NbComm.Properties.Resources.bt180_40_rel;
            this.btWave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btWave.FlatAppearance.BorderSize = 0;
            this.btWave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btWave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWave.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btWave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btWave.Location = new System.Drawing.Point(33, 126);
            this.btWave.Name = "btWave";
            this.btWave.Size = new System.Drawing.Size(180, 40);
            this.btWave.TabIndex = 45;
            this.btWave.Text = "串口示波器";
            this.btWave.UseVisualStyleBackColor = true;
            this.btWave.Click += new System.EventHandler(this.btWave_Click);
            this.btWave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btWave_MouseDown);
            this.btWave.MouseEnter += new System.EventHandler(this.btWave_MouseEnter);
            this.btWave.MouseLeave += new System.EventHandler(this.btWave_MouseLeave);
            this.btWave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btWave_MouseUp);
            // 
            // btUserPtl
            // 
            this.btUserPtl.BackgroundImage = global::NbComm.Properties.Resources.bt180_40_rel;
            this.btUserPtl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btUserPtl.FlatAppearance.BorderSize = 0;
            this.btUserPtl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btUserPtl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btUserPtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUserPtl.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUserPtl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btUserPtl.Location = new System.Drawing.Point(33, 12);
            this.btUserPtl.Name = "btUserPtl";
            this.btUserPtl.Size = new System.Drawing.Size(180, 40);
            this.btUserPtl.TabIndex = 39;
            this.btUserPtl.Text = "自定义协议";
            this.btUserPtl.UseVisualStyleBackColor = true;
            this.btUserPtl.Click += new System.EventHandler(this.btUserPtl_Click);
            this.btUserPtl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btUserPtl_MouseDown);
            this.btUserPtl.MouseEnter += new System.EventHandler(this.btUserPtl_MouseEnter);
            this.btUserPtl.MouseLeave += new System.EventHandler(this.btUserPtl_MouseLeave);
            this.btUserPtl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btUserPtl_MouseUp);
            // 
            // btCheckCode
            // 
            this.btCheckCode.BackgroundImage = global::NbComm.Properties.Resources.bt180_40_rel;
            this.btCheckCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCheckCode.FlatAppearance.BorderSize = 0;
            this.btCheckCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCheckCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCheckCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckCode.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCheckCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCheckCode.Location = new System.Drawing.Point(33, 69);
            this.btCheckCode.Name = "btCheckCode";
            this.btCheckCode.Size = new System.Drawing.Size(180, 40);
            this.btCheckCode.TabIndex = 44;
            this.btCheckCode.Text = "校验码计算";
            this.btCheckCode.UseVisualStyleBackColor = true;
            this.btCheckCode.Click += new System.EventHandler(this.btCheckCode_Click);
            this.btCheckCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btCheckCode_MouseDown);
            this.btCheckCode.MouseEnter += new System.EventHandler(this.btCheckCode_MouseEnter);
            this.btCheckCode.MouseLeave += new System.EventHandler(this.btCheckCode_MouseLeave);
            this.btCheckCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btCheckCode_MouseUp);
            // 
            // btRxColor
            // 
            this.btRxColor.BackgroundImage = global::NbComm.Properties.Resources.bt180_40_rel;
            this.btRxColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxColor.FlatAppearance.BorderSize = 0;
            this.btRxColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRxColor.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRxColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRxColor.Location = new System.Drawing.Point(33, 240);
            this.btRxColor.Name = "btRxColor";
            this.btRxColor.Size = new System.Drawing.Size(180, 40);
            this.btRxColor.TabIndex = 41;
            this.btRxColor.Text = "接 收 颜 色";
            this.btRxColor.UseVisualStyleBackColor = true;
            this.btRxColor.Click += new System.EventHandler(this.btRxColor_Click);
            this.btRxColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRxColor_MouseDown);
            this.btRxColor.MouseEnter += new System.EventHandler(this.btRxColor_MouseEnter);
            this.btRxColor.MouseLeave += new System.EventHandler(this.btRxColor_MouseLeave);
            this.btRxColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRxColor_MouseUp);
            // 
            // btTxColor
            // 
            this.btTxColor.BackgroundImage = global::NbComm.Properties.Resources.bt180_40_rel;
            this.btTxColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxColor.FlatAppearance.BorderSize = 0;
            this.btTxColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTxColor.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTxColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btTxColor.Location = new System.Drawing.Point(33, 297);
            this.btTxColor.Name = "btTxColor";
            this.btTxColor.Size = new System.Drawing.Size(180, 40);
            this.btTxColor.TabIndex = 43;
            this.btTxColor.Text = "发 送 颜 色";
            this.btTxColor.UseVisualStyleBackColor = true;
            this.btTxColor.Click += new System.EventHandler(this.btTxColor_Click);
            this.btTxColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btTxColor_MouseDown);
            this.btTxColor.MouseEnter += new System.EventHandler(this.btTxColor_MouseEnter);
            this.btTxColor.MouseLeave += new System.EventHandler(this.btTxColor_MouseLeave);
            this.btTxColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRxColor_MouseUp);
            // 
            // btRxFont
            // 
            this.btRxFont.BackgroundImage = global::NbComm.Properties.Resources.bt180_40_rel;
            this.btRxFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxFont.FlatAppearance.BorderSize = 0;
            this.btRxFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRxFont.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRxFont.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRxFont.Location = new System.Drawing.Point(33, 183);
            this.btRxFont.Name = "btRxFont";
            this.btRxFont.Size = new System.Drawing.Size(180, 40);
            this.btRxFont.TabIndex = 42;
            this.btRxFont.Text = "字 体 设 置";
            this.btRxFont.UseVisualStyleBackColor = true;
            this.btRxFont.Click += new System.EventHandler(this.btRxFont_Click);
            this.btRxFont.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRxFont_MouseDown);
            this.btRxFont.MouseEnter += new System.EventHandler(this.btRxFont_MouseEnter);
            this.btRxFont.MouseLeave += new System.EventHandler(this.btRxFont_MouseLeave);
            this.btRxFont.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRxFont_MouseUp);
            // 
            // myGroupBox3
            // 
            this.myGroupBox3.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myGroupBox3.Controls.Add(this.TxEncodingBox);
            this.myGroupBox3.Controls.Add(this.label8);
            this.myGroupBox3.Controls.Add(this.label9);
            this.myGroupBox3.Controls.Add(this.btTxClear);
            this.myGroupBox3.Controls.Add(this.TimerTx);
            this.myGroupBox3.Controls.Add(this.btTxSend);
            this.myGroupBox3.Controls.Add(this.TimerSendcheckBox);
            this.myGroupBox3.Controls.Add(this.radioButtonTxAsc);
            this.myGroupBox3.Controls.Add(this.radioButtonTxHex);
            this.myGroupBox3.Location = new System.Drawing.Point(8, 633);
            this.myGroupBox3.Name = "myGroupBox3";
            this.myGroupBox3.Size = new System.Drawing.Size(282, 216);
            this.myGroupBox3.TabIndex = 42;
            this.myGroupBox3.TabStop = false;
            // 
            // TxEncodingBox
            // 
            this.TxEncodingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TxEncodingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxEncodingBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxEncodingBox.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxEncodingBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TxEncodingBox.FormattingEnabled = true;
            this.TxEncodingBox.Items.AddRange(new object[] {
            "Default",
            "GBK",
            "Unicode",
            "UTF-8",
            "UTF-32"});
            this.TxEncodingBox.Location = new System.Drawing.Point(129, 16);
            this.TxEncodingBox.Name = "TxEncodingBox";
            this.TxEncodingBox.Size = new System.Drawing.Size(140, 29);
            this.TxEncodingBox.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "发送区:编码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(229, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "ms";
            // 
            // btTxClear
            // 
            this.btTxClear.BackgroundImage = global::NbComm.Properties.Resources.btCheckt011;
            this.btTxClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxClear.FlatAppearance.BorderSize = 0;
            this.btTxClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTxClear.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTxClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btTxClear.Location = new System.Drawing.Point(10, 161);
            this.btTxClear.Name = "btTxClear";
            this.btTxClear.Size = new System.Drawing.Size(120, 40);
            this.btTxClear.TabIndex = 37;
            this.btTxClear.Text = "清    除";
            this.btTxClear.UseVisualStyleBackColor = true;
            this.btTxClear.Click += new System.EventHandler(this.btTxClear_Click);
            this.btTxClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btTxClear_MouseDown);
            this.btTxClear.MouseEnter += new System.EventHandler(this.btTxClear_MouseEnter);
            this.btTxClear.MouseLeave += new System.EventHandler(this.btTxClear_MouseLeave);
            this.btTxClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btTxClear_MouseUp);
            // 
            // TimerTx
            // 
            this.TimerTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TimerTx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimerTx.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerTx.ForeColor = System.Drawing.SystemColors.Window;
            this.TimerTx.Location = new System.Drawing.Point(156, 106);
            this.TimerTx.MaxLength = 5;
            this.TimerTx.Name = "TimerTx";
            this.TimerTx.Size = new System.Drawing.Size(70, 28);
            this.TimerTx.TabIndex = 39;
            this.TimerTx.Text = "1000";
            this.TimerTx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimerTx_KeyPress);
            // 
            // btTxSend
            // 
            this.btTxSend.BackgroundImage = global::NbComm.Properties.Resources.btCheckt011;
            this.btTxSend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxSend.FlatAppearance.BorderSize = 0;
            this.btTxSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btTxSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTxSend.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTxSend.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btTxSend.Location = new System.Drawing.Point(150, 161);
            this.btTxSend.Name = "btTxSend";
            this.btTxSend.Size = new System.Drawing.Size(120, 40);
            this.btTxSend.TabIndex = 38;
            this.btTxSend.Text = "发    送";
            this.btTxSend.UseVisualStyleBackColor = true;
            this.btTxSend.Click += new System.EventHandler(this.btTxSend_Click);
            this.btTxSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btTxSend_MouseDown);
            this.btTxSend.MouseEnter += new System.EventHandler(this.btTxSend_MouseEnter);
            this.btTxSend.MouseLeave += new System.EventHandler(this.btTxSend_MouseLeave);
            this.btTxSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btTxSend_MouseUp);
            // 
            // TimerSendcheckBox
            // 
            this.TimerSendcheckBox.AutoSize = true;
            this.TimerSendcheckBox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerSendcheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.TimerSendcheckBox.Location = new System.Drawing.Point(16, 110);
            this.TimerSendcheckBox.Name = "TimerSendcheckBox";
            this.TimerSendcheckBox.Size = new System.Drawing.Size(111, 24);
            this.TimerSendcheckBox.TabIndex = 37;
            this.TimerSendcheckBox.Text = "定时发送";
            this.TimerSendcheckBox.UseVisualStyleBackColor = true;
            this.TimerSendcheckBox.CheckedChanged += new System.EventHandler(this.TimerSendcheckBox_CheckStateChanged);
            // 
            // radioButtonTxAsc
            // 
            this.radioButtonTxAsc.AutoSize = true;
            this.radioButtonTxAsc.Checked = true;
            this.radioButtonTxAsc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonTxAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonTxAsc.Location = new System.Drawing.Point(16, 61);
            this.radioButtonTxAsc.Name = "radioButtonTxAsc";
            this.radioButtonTxAsc.Size = new System.Drawing.Size(84, 31);
            this.radioButtonTxAsc.TabIndex = 37;
            this.radioButtonTxAsc.TabStop = true;
            this.radioButtonTxAsc.Text = "ASCII";
            this.radioButtonTxAsc.UseVisualStyleBackColor = true;
            this.radioButtonTxAsc.CheckedChanged += new System.EventHandler(this.radioButtonTxAsc_CheckedChanged);
            // 
            // radioButtonTxHex
            // 
            this.radioButtonTxHex.AutoSize = true;
            this.radioButtonTxHex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonTxHex.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonTxHex.Location = new System.Drawing.Point(156, 61);
            this.radioButtonTxHex.Name = "radioButtonTxHex";
            this.radioButtonTxHex.Size = new System.Drawing.Size(72, 31);
            this.radioButtonTxHex.TabIndex = 38;
            this.radioButtonTxHex.Text = "HEX";
            this.radioButtonTxHex.UseVisualStyleBackColor = true;
            // 
            // myGroupBox2
            // 
            this.myGroupBox2.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myGroupBox2.Controls.Add(this.checkBoxDisplay);
            this.myGroupBox2.Controls.Add(this.label7);
            this.myGroupBox2.Controls.Add(this.RxEncodingBox);
            this.myGroupBox2.Controls.Add(this.btRxClear);
            this.myGroupBox2.Controls.Add(this.RxCheckbox1);
            this.myGroupBox2.Controls.Add(this.radioButtonRxAsc);
            this.myGroupBox2.Controls.Add(this.checkBoxAutoSave);
            this.myGroupBox2.Controls.Add(this.btRxSave);
            this.myGroupBox2.Controls.Add(this.TimestampcheckBox);
            this.myGroupBox2.Controls.Add(this.radioButtonRxHex);
            this.myGroupBox2.Location = new System.Drawing.Point(8, 376);
            this.myGroupBox2.Name = "myGroupBox2";
            this.myGroupBox2.Size = new System.Drawing.Size(282, 250);
            this.myGroupBox2.TabIndex = 41;
            this.myGroupBox2.TabStop = false;
            // 
            // checkBoxDisplay
            // 
            this.checkBoxDisplay.AutoSize = true;
            this.checkBoxDisplay.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxDisplay.Location = new System.Drawing.Point(156, 145);
            this.checkBoxDisplay.Name = "checkBoxDisplay";
            this.checkBoxDisplay.Size = new System.Drawing.Size(111, 24);
            this.checkBoxDisplay.TabIndex = 38;
            this.checkBoxDisplay.Text = "覆盖显示";
            this.checkBoxDisplay.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(3, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "接收区:编码";
            // 
            // RxEncodingBox
            // 
            this.RxEncodingBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RxEncodingBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RxEncodingBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RxEncodingBox.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RxEncodingBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RxEncodingBox.FormattingEnabled = true;
            this.RxEncodingBox.Items.AddRange(new object[] {
            "Default",
            "GBK",
            "Unicode",
            "UTF-8",
            "UTF-32"});
            this.RxEncodingBox.Location = new System.Drawing.Point(129, 16);
            this.RxEncodingBox.Name = "RxEncodingBox";
            this.RxEncodingBox.Size = new System.Drawing.Size(140, 29);
            this.RxEncodingBox.TabIndex = 31;
            // 
            // btRxClear
            // 
            this.btRxClear.BackgroundImage = global::NbComm.Properties.Resources.btCheckt011;
            this.btRxClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxClear.FlatAppearance.BorderSize = 0;
            this.btRxClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRxClear.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRxClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRxClear.Location = new System.Drawing.Point(10, 190);
            this.btRxClear.Name = "btRxClear";
            this.btRxClear.Size = new System.Drawing.Size(120, 40);
            this.btRxClear.TabIndex = 31;
            this.btRxClear.Text = "清    除";
            this.btRxClear.UseVisualStyleBackColor = true;
            this.btRxClear.Click += new System.EventHandler(this.btRxClear_Click);
            this.btRxClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRxClear_MouseDown);
            this.btRxClear.MouseEnter += new System.EventHandler(this.btRxClear_MouseEnter);
            this.btRxClear.MouseLeave += new System.EventHandler(this.btRxClear_MouseLeave);
            this.btRxClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRxClear_MouseUp);
            // 
            // RxCheckbox1
            // 
            this.RxCheckbox1.AutoSize = true;
            this.RxCheckbox1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RxCheckbox1.ForeColor = System.Drawing.SystemColors.Control;
            this.RxCheckbox1.Location = new System.Drawing.Point(156, 100);
            this.RxCheckbox1.Name = "RxCheckbox1";
            this.RxCheckbox1.Size = new System.Drawing.Size(111, 24);
            this.RxCheckbox1.TabIndex = 37;
            this.RxCheckbox1.Text = "帧 换 行";
            this.RxCheckbox1.UseVisualStyleBackColor = true;
            // 
            // radioButtonRxAsc
            // 
            this.radioButtonRxAsc.AutoSize = true;
            this.radioButtonRxAsc.Checked = true;
            this.radioButtonRxAsc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonRxAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonRxAsc.Location = new System.Drawing.Point(16, 55);
            this.radioButtonRxAsc.Name = "radioButtonRxAsc";
            this.radioButtonRxAsc.Size = new System.Drawing.Size(84, 31);
            this.radioButtonRxAsc.TabIndex = 34;
            this.radioButtonRxAsc.TabStop = true;
            this.radioButtonRxAsc.Text = "ASCII";
            this.radioButtonRxAsc.UseVisualStyleBackColor = true;
            this.radioButtonRxAsc.CheckedChanged += new System.EventHandler(this.radioButtonRxAsc_CheckedChanged);
            // 
            // checkBoxAutoSave
            // 
            this.checkBoxAutoSave.AutoSize = true;
            this.checkBoxAutoSave.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAutoSave.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxAutoSave.Location = new System.Drawing.Point(16, 145);
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.Size = new System.Drawing.Size(111, 24);
            this.checkBoxAutoSave.TabIndex = 36;
            this.checkBoxAutoSave.Text = "自动保存";
            this.checkBoxAutoSave.UseVisualStyleBackColor = true;
            this.checkBoxAutoSave.CheckedChanged += new System.EventHandler(this.checkBoxAutoSave_CheckedChanged);
            // 
            // btRxSave
            // 
            this.btRxSave.BackgroundImage = global::NbComm.Properties.Resources.btCheckt011;
            this.btRxSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxSave.FlatAppearance.BorderSize = 0;
            this.btRxSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btRxSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRxSave.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRxSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btRxSave.Location = new System.Drawing.Point(150, 190);
            this.btRxSave.Name = "btRxSave";
            this.btRxSave.Size = new System.Drawing.Size(120, 40);
            this.btRxSave.TabIndex = 33;
            this.btRxSave.Text = "保    存";
            this.btRxSave.UseVisualStyleBackColor = true;
            this.btRxSave.Click += new System.EventHandler(this.btRxSave_Click);
            this.btRxSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btRxSave_MouseDown);
            this.btRxSave.MouseEnter += new System.EventHandler(this.btRxSave_MouseEnter);
            this.btRxSave.MouseLeave += new System.EventHandler(this.btRxSave_MouseLeave);
            this.btRxSave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btRxSave_MouseUp);
            // 
            // TimestampcheckBox
            // 
            this.TimestampcheckBox.AutoSize = true;
            this.TimestampcheckBox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimestampcheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.TimestampcheckBox.Location = new System.Drawing.Point(16, 100);
            this.TimestampcheckBox.Name = "TimestampcheckBox";
            this.TimestampcheckBox.Size = new System.Drawing.Size(111, 24);
            this.TimestampcheckBox.TabIndex = 31;
            this.TimestampcheckBox.Text = "时 间 戳";
            this.TimestampcheckBox.UseVisualStyleBackColor = true;
            // 
            // radioButtonRxHex
            // 
            this.radioButtonRxHex.AutoSize = true;
            this.radioButtonRxHex.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonRxHex.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonRxHex.Location = new System.Drawing.Point(156, 55);
            this.radioButtonRxHex.Name = "radioButtonRxHex";
            this.radioButtonRxHex.Size = new System.Drawing.Size(72, 31);
            this.radioButtonRxHex.TabIndex = 35;
            this.radioButtonRxHex.Text = "HEX";
            this.radioButtonRxHex.UseVisualStyleBackColor = true;
            this.radioButtonRxHex.CheckedChanged += new System.EventHandler(this.radioButtonRxHex_CheckedChanged);
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.myGroupBox1.Controls.Add(this.comboDatalength);
            this.myGroupBox1.Controls.Add(this.btOpen);
            this.myGroupBox1.Controls.Add(this.btCheck);
            this.myGroupBox1.Controls.Add(this.label4);
            this.myGroupBox1.Controls.Add(this.label6);
            this.myGroupBox1.Controls.Add(this.comboStopbit);
            this.myGroupBox1.Controls.Add(this.label2);
            this.myGroupBox1.Controls.Add(this.label5);
            this.myGroupBox1.Controls.Add(this.checkBoxDtr);
            this.myGroupBox1.Controls.Add(this.comboBoxBoud);
            this.myGroupBox1.Controls.Add(this.label3);
            this.myGroupBox1.Controls.Add(this.comboBoxJudge);
            this.myGroupBox1.Controls.Add(this.checkBoxRts);
            this.myGroupBox1.Controls.Add(this.comboBoxPort);
            this.myGroupBox1.Location = new System.Drawing.Point(8, 5);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(282, 364);
            this.myGroupBox1.TabIndex = 40;
            this.myGroupBox1.TabStop = false;
            // 
            // comboDatalength
            // 
            this.comboDatalength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.comboDatalength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDatalength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDatalength.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboDatalength.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboDatalength.FormattingEnabled = true;
            this.comboDatalength.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.comboDatalength.Location = new System.Drawing.Point(129, 229);
            this.comboDatalength.Name = "comboDatalength";
            this.comboDatalength.Size = new System.Drawing.Size(140, 29);
            this.comboDatalength.TabIndex = 30;
            this.comboDatalength.SelectedIndexChanged += new System.EventHandler(this.comboDatalength_SelectedIndexChanged);
            // 
            // btOpen
            // 
            this.btOpen.BackgroundImage = global::NbComm.Properties.Resources.btCheckt011;
            this.btOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btOpen.FlatAppearance.BorderSize = 0;
            this.btOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btOpen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btOpen.Location = new System.Drawing.Point(150, 15);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(120, 40);
            this.btOpen.TabIndex = 18;
            this.btOpen.Text = "启    用";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            this.btOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btOpen_MouseDown);
            this.btOpen.MouseEnter += new System.EventHandler(this.btOpen_MouseEnter);
            this.btOpen.MouseLeave += new System.EventHandler(this.btOpen_MouseLeave);
            this.btOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btOpen_MouseUp);
            // 
            // btCheck
            // 
            this.btCheck.BackgroundImage = global::NbComm.Properties.Resources.btCheckt011;
            this.btCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCheck.FlatAppearance.BorderSize = 0;
            this.btCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheck.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btCheck.Location = new System.Drawing.Point(10, 15);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(120, 40);
            this.btCheck.TabIndex = 22;
            this.btCheck.Text = "搜    索";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            this.btCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btCheck_MouseDown);
            this.btCheck.MouseEnter += new System.EventHandler(this.btCheck_MouseEnter);
            this.btCheck.MouseLeave += new System.EventHandler(this.btCheck_MouseLeave);
            this.btCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btCheck_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(15, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "停止位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(15, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "数据位";
            // 
            // comboStopbit
            // 
            this.comboStopbit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.comboStopbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStopbit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboStopbit.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboStopbit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboStopbit.FormattingEnabled = true;
            this.comboStopbit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboStopbit.Location = new System.Drawing.Point(129, 178);
            this.comboStopbit.Name = "comboStopbit";
            this.comboStopbit.Size = new System.Drawing.Size(140, 29);
            this.comboStopbit.TabIndex = 24;
            this.comboStopbit.SelectedIndexChanged += new System.EventHandler(this.comboStopbit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "端  口";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(15, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "校  验";
            // 
            // checkBoxDtr
            // 
            this.checkBoxDtr.AutoSize = true;
            this.checkBoxDtr.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxDtr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxDtr.Location = new System.Drawing.Point(200, 326);
            this.checkBoxDtr.Name = "checkBoxDtr";
            this.checkBoxDtr.Size = new System.Drawing.Size(68, 27);
            this.checkBoxDtr.TabIndex = 28;
            this.checkBoxDtr.Text = "DTR";
            this.checkBoxDtr.UseVisualStyleBackColor = true;
            this.checkBoxDtr.CheckStateChanged += new System.EventHandler(this.checkBoxDtr_CheckStateChanged);
            // 
            // comboBoxBoud
            // 
            this.comboBoxBoud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.comboBoxBoud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBoud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBoud.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxBoud.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxBoud.FormattingEnabled = true;
            this.comboBoxBoud.Items.AddRange(new object[] {
            "自定义",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "76800",
            "115200",
            "128000",
            "230400",
            "256000",
            "460800",
            "921600",
            "1382400"});
            this.comboBoxBoud.Location = new System.Drawing.Point(129, 127);
            this.comboBoxBoud.MaxLength = 7;
            this.comboBoxBoud.Name = "comboBoxBoud";
            this.comboBoxBoud.Size = new System.Drawing.Size(140, 29);
            this.comboBoxBoud.TabIndex = 21;
            this.comboBoxBoud.SelectedIndexChanged += new System.EventHandler(this.comboBoxBoud_SelectedIndexChanged);
            this.comboBoxBoud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxBoud_KeyPress);
            this.comboBoxBoud.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxBoud_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "波特率";
            // 
            // comboBoxJudge
            // 
            this.comboBoxJudge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.comboBoxJudge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxJudge.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxJudge.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxJudge.FormattingEnabled = true;
            this.comboBoxJudge.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.comboBoxJudge.Location = new System.Drawing.Point(129, 280);
            this.comboBoxJudge.Name = "comboBoxJudge";
            this.comboBoxJudge.Size = new System.Drawing.Size(140, 29);
            this.comboBoxJudge.TabIndex = 26;
            this.comboBoxJudge.SelectedIndexChanged += new System.EventHandler(this.comboBoxJudge_SelectedIndexChanged);
            // 
            // checkBoxRts
            // 
            this.checkBoxRts.AutoSize = true;
            this.checkBoxRts.Font = new System.Drawing.Font("黑体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxRts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxRts.Location = new System.Drawing.Point(126, 326);
            this.checkBoxRts.Name = "checkBoxRts";
            this.checkBoxRts.Size = new System.Drawing.Size(68, 27);
            this.checkBoxRts.TabIndex = 27;
            this.checkBoxRts.Text = "RTS";
            this.checkBoxRts.UseVisualStyleBackColor = true;
            this.checkBoxRts.CheckStateChanged += new System.EventHandler(this.checkBoxRts_CheckStateChanged);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPort.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxPort.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(129, 76);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(140, 29);
            this.comboBoxPort.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1550, 910);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.myGroupBox6.ResumeLayout(false);
            this.myGroupBox6.PerformLayout();
            this.myGroupBox5.ResumeLayout(false);
            this.myGroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.myGroupBox4.ResumeLayout(false);
            this.myGroupBox3.ResumeLayout(false);
            this.myGroupBox3.PerformLayout();
            this.myGroupBox2.ResumeLayout(false);
            this.myGroupBox2.PerformLayout();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboDatalength;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDtr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxRts;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxJudge;
        private System.Windows.Forms.ComboBox comboBoxBoud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.ComboBox comboStopbit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btRxFont;
        private System.Windows.Forms.Button btRxColor;
        private System.Windows.Forms.Button btUserPtl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btTxColor;
        private System.Windows.Forms.ComboBox RxEncodingBox;
        private System.Windows.Forms.CheckBox RxCheckbox1;
        private System.Windows.Forms.CheckBox checkBoxAutoSave;
        private System.Windows.Forms.CheckBox TimestampcheckBox;
        private System.Windows.Forms.RadioButton radioButtonRxHex;
        private System.Windows.Forms.Button btRxSave;
        private System.Windows.Forms.RadioButton radioButtonRxAsc;
        private System.Windows.Forms.Button btRxClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TxEncodingBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TimerTx;
        private System.Windows.Forms.CheckBox TimerSendcheckBox;
        private System.Windows.Forms.RadioButton radioButtonTxHex;
        private System.Windows.Forms.RadioButton radioButtonTxAsc;
        private System.Windows.Forms.Button btTxSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btTxClear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer ChartTimer;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.Button btFileSend;
        private System.Windows.Forms.Button btFileCancel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button btFileOpen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer fileSendTimer;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label TxNumber;
        private System.Windows.Forms.Label RxNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxDisplay;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button btFindLast;
        private System.Windows.Forms.Button btFindNext;
        private System.Windows.Forms.Button btRxFind;
        private System.Windows.Forms.Button btExtrude;
        private System.Windows.Forms.Button btCheckCode;
        private System.Windows.Forms.Button btWave;
        private MyGroupBox myGroupBox1;
        private MyGroupBox myGroupBox2;
        private MyGroupBox myGroupBox6;
        private MyGroupBox myGroupBox5;
        private MyGroupBox myGroupBox4;
        private MyGroupBox myGroupBox3;
    }
}

