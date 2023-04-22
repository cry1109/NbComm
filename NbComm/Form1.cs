using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace NbComm
{
    public partial class Form1 : Form
    {
        //Graphics myGraphics;
        private byte[] TxByte;              //发送字节
        private bool RxFlag = false;        //接收标志
        private UInt32 RxNumberCount = 0;   //接收字节
        private UInt32 TxNumberCount = 0;   //接收字节
        private int TxFileFrameCount = 0;   //文件发送帧数
        private int TxFileFrameIndex = 0;   //指向发送帧数
        private string RxFilePath = "";
        private FileStream fs;
        private StreamWriter sw;
        public bool form2Exist = false;
        public bool form3Exist = false;
        public bool form4Exist = false;

        private Queue<double> chartDataQueue = new Queue<double>(50);
        private void chart1DataUpdata(int data, int length)
        {
            if (chartDataQueue.Count > 50)
            {
                for (int i = 0; i < length; i++)
                {
                    chartDataQueue.Dequeue();    //先出列
                }
            }

            for (int i = 0; i < length; i++)
            {
                chartDataQueue.Enqueue(data);
            }
        }
        public void SYSTEM_LOG(string log)
        {
            string system_string = ">系统提示：" + log;

            richTextBoxInput.SelectionStart = richTextBoxInput.TextLength;
            richTextBoxInput.SelectionColor = Color.White;

            if (richTextBoxInput.InvokeRequired)
            {
                RxStringUpdata d = new RxStringUpdata(RxStringShow);
                this.Invoke(d, new object[] { system_string });
            }
            else
            {
                richTextBoxInput.AppendText(system_string);
                richTextBoxInput.ScrollToCaret();//滚动条滚到到最新插入行
            }

            richTextBoxInput.SelectionColor = Properties.Settings.Default.RxColor;
        }

        public bool GetSerialOpen()
        {
            return serialPort1.IsOpen;
        }

        public void ClearSerialRxFlag()
        {
            RxFlag = false;
        }

        public bool GetSerialRxFlag()
        {
            return RxFlag;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread ReadSerialPort = new Thread(new ParameterizedThreadStart(SerialPortReadThread));
            ReadSerialPort.IsBackground = true;
            ReadSerialPort.Start();

            Thread FieleSend = new Thread(new ParameterizedThreadStart(FieleSendThread));
            FieleSend.IsBackground = true;
            FieleSend.Start();

            Thread SerialPortCheck = new Thread(new ParameterizedThreadStart(SerialPortCheckThread));
            SerialPortCheck.IsBackground = true;
            SerialPortCheck.Start();

            richTextBoxInput.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.richTextBoxInput_MouseWheel);

            /*设置按钮背景图片格式*/
            BackgroundImageLayout = ImageLayout.Zoom;
            btClose.BackgroundImageLayout = ImageLayout.Zoom;
            btMin.BackgroundImageLayout = ImageLayout.Zoom;
            btCheck.BackgroundImageLayout = ImageLayout.Zoom;
            btOpen.BackgroundImageLayout = ImageLayout.Zoom;
            btUserPtl.BackgroundImageLayout = ImageLayout.Zoom;
            btRxSave.BackgroundImageLayout = ImageLayout.Zoom;
            btRxClear.BackgroundImageLayout = ImageLayout.Zoom;
            btRxFont.BackgroundImageLayout = ImageLayout.Zoom;
            btRxColor.BackgroundImageLayout = ImageLayout.Zoom;
            btTxSend.BackgroundImageLayout = ImageLayout.Zoom;
            btTxColor.BackgroundImageLayout = ImageLayout.Zoom;
            btTxClear.BackgroundImageLayout = ImageLayout.Zoom;
            btFileOpen.BackgroundImageLayout = ImageLayout.Zoom;
            btFileCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend.BackgroundImageLayout = ImageLayout.Zoom;
			btRxFind.BackgroundImageLayout = ImageLayout.Zoom;
            btExtrude.BackgroundImageLayout = ImageLayout.Zoom;
            btFindNext.BackgroundImageLayout = ImageLayout.Zoom;
            btFindLast.BackgroundImageLayout = ImageLayout.Zoom;
            btCheckCode.BackgroundImageLayout = ImageLayout.Zoom;
            btWave.BackgroundImageLayout = ImageLayout.Zoom;

            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;

            richTextBoxInput.AppendText("最新版本下载:https://github.com/cry1109/NbComm_App.git\r\n");
            richTextBoxInput.AppendText("作者小破站主页:https://space.bilibili.com/435336705?spm_id_from=333.1007.0.0\r\n");

            /*串口初始化*/
            serialPort1.BaudRate = 115200;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            comboBoxBoud.Text = "115200";
            comboStopbit.Text = "1";
            comboBoxJudge.Text = "无";
            comboDatalength.Text = "8";

            RxEncodingBox.Text = "Default";
            TxEncodingBox.Text = "Default";

            labelVersion.Text = "版本:" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            /*读取设置的字体颜色/字体*/
            richTextBoxInput.ForeColor = Properties.Settings.Default.RxColor;
            richTextBoxInput.Font = Properties.Settings.Default.RxTxFont;

            textBoxSend.ForeColor = Properties.Settings.Default.TxColor;
            textBoxSend.Font = Properties.Settings.Default.RxTxFont;
            textBoxSend.Text = Properties.Settings.Default.TxSend;
            if (Properties.Settings.Default.RxHex == true)
            {
                radioButtonRxHex.Checked = true;
                radioButtonRxAsc.Checked = false;
            }
            else
            {
                radioButtonRxHex.Checked = false;
                radioButtonRxAsc.Checked = true;
            }

            if (Properties.Settings.Default.TxHex == true)
            {
                radioButtonTxHex.Checked = true;
                radioButtonTxAsc.Checked = false;
            }
            else
            {
                radioButtonTxHex.Checked = false;
                radioButtonTxAsc.Checked = true;
            }
            this.radioButtonTxHex.CheckedChanged += new System.EventHandler(this.radioButtonTxHex_CheckedChanged);

            textBoxFind.ForeColor = Properties.Settings.Default.ExtrudeColor;

            labelChart.Visible = false;
            labelChart.BackColor = Color.Transparent;
            labelChart.Parent = chart1;
            labelChart.Location = new System.Drawing.Point(8, 8);

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 50;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
        }

        public delegate void TextInputDelegate();
        /**********************************************************************************
        *  函数名称：serialPort1_DataReceived()
        *  描    述：串口接收时间
        *  输    入：无
        *  输    出：无
        **********************************************************************************/
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        /**********************************************************************************
        *  函数名称：SerialPortRead()
        *  描    述：读取串口函数(串口接收)
        *  输    入：无
        *  输    出：无
        **********************************************************************************/
        private delegate void RxStringUpdata(string text);
        private delegate void RxStringWrite(string text);
        private delegate void RxNumberUpdata(UInt32 number);
        private delegate void TxNumberUpdata(UInt32 number);
        public void RxStringShow(string text)
        {
            if (richTextBoxInput.InvokeRequired)
            {
                RxStringUpdata d = new RxStringUpdata(RxStringShow);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (checkBoxDisplay.Checked == false)
                {
                    richTextBoxInput.AppendText(text);
                    richTextBoxInput.ScrollToCaret();//滚动条滚到到最新插入行
                }
                else
                {
                    richTextBoxInput.Text = text;
                }
            }
        }

        private void RxFileWrite(string text)
        {
            if (richTextBoxInput.InvokeRequired)
            {
                RxStringWrite d = new RxStringWrite(RxFileWrite);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (System.IO.File.Exists(RxFilePath) == true)
                {
                    try
                    {
                        fs = new FileStream(RxFilePath, FileMode.Append, FileAccess.Write);
                        sw = new StreamWriter(fs);

                        sw.Write(text);
                        sw.Close();
                        fs.Close();
                    }
                    catch
                    {
                        ;
                    }
                }
            }
        }

        private void RxNumberShow(UInt32 number)
        {
            if (RxNumber.InvokeRequired)
            {
                RxNumberUpdata d = new RxNumberUpdata(RxNumberShow);
                this.Invoke(d, new object[] { number });
            }
            else
            {
                RxNumber.Text = number.ToString();
            }
        }

        private void TxNumberShow(UInt32 number)
        {
            if (TxNumber.InvokeRequired)
            {
                TxNumberUpdata d = new TxNumberUpdata(TxNumberShow);
                this.Invoke(d, new object[] { number });
            }
            else
            {
                TxNumber.Text = number.ToString();
            }
        }

        public void SerialPortRead()
        {
            if (serialPort1.IsOpen)
            {
                string StringMessage = "";
                int RxLength = 0;

                try
                {
                    RxLength = serialPort1.BytesToRead;
                }
                catch
                {
                    RxLength = 0;
                }

                byte[] ReceiveData = new byte[RxLength];

                try
                {
                    serialPort1.Read(ReceiveData, 0, RxLength);
                }
                catch
                {
                    ;
                }

                if (RxLength != 0)
                {
                    RxFlag = true;

                    if (radioButtonRxAsc.Checked == true)
                    {
                        if (RxEncodingBox.Text == "Default")
                        {
                            StringMessage = System.Text.Encoding.Default.GetString(ReceiveData);
                        }
                        else if (RxEncodingBox.Text == "GBK")
                        {
                            StringMessage = System.Text.Encoding.GetEncoding("GBK").GetString(ReceiveData);
                        }
                        else if (RxEncodingBox.Text == "Unicode")
                        {
                            StringMessage = System.Text.Encoding.Unicode.GetString(ReceiveData);
                        }
                        else if (RxEncodingBox.Text == "UTF-8")
                        {
                            StringMessage = System.Text.Encoding.UTF8.GetString(ReceiveData);
                        }
                        else if (RxEncodingBox.Text == "UTF-32")
                        {
                            StringMessage = System.Text.Encoding.UTF32.GetString(ReceiveData);
                        }
                        else
                        {
                            StringMessage = System.Text.Encoding.Default.GetString(ReceiveData);
                        }
                    }
                    else
                    {
                        StringMessage = BitConverter.ToString(ReceiveData).Replace("-", " ") + " ";    //十六进制显示
                    }

                    if (TimestampcheckBox.Checked == true) //启用时间戳
                    {
                        StringMessage = "[" + DateTime.Now.ToLongTimeString().ToString() + ":" + DateTime.Now.Millisecond.ToString() + "]" + StringMessage;
                    }

                    if (RxCheckbox1.Checked == true) //启用帧换行
                    {
                        StringMessage += "\r\n";
                    }

                    RxNumberCount += ((UInt32)RxLength);
                    RxStringShow(StringMessage);
                    RxNumberShow(RxNumberCount);

                    if (checkBoxAutoSave.Checked == true)
                    {
                        RxFileWrite(StringMessage);
                    }

                    if (form4Exist == true)
                    {
                        form4.WaveUpdata(ReceiveData, RxLength);
                    }
                    else
                    {
                        chart1Updata(RxLength);
                    }
                }
            }
        }

        private delegate void SerialPortReDelegate();
        /**********************************************************************************
        *  函数名称：SerialPortReadThred()
        *  描    述：串口读取线程
        *  输    入：无
        *  输    出：无
        **********************************************************************************/
        private void SerialPortReadThread(object length)
        {
            while (true)
            {
                try
                {
                    this.Invoke(new SerialPortReDelegate(SerialPortRead));
                }
                catch
                {

                }

                Thread.Sleep(1);
            }
        }

        /* *********************************************************************************
        * 实现窗体拖动
        * *********************************************************************************/
        bool beginMove = false;//初始化鼠标位置
        int currentXPosition;
        int currentYPosition;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);     //this.Close();
        }

        private void btClose_MouseDown(object sender, MouseEventArgs e)
        {
            btClose.BackgroundImage = Properties.Resources.btClose03;
        }

        private void btClose_MouseEnter(object sender, EventArgs e)
        {
            btClose.BackgroundImage = Properties.Resources.btClose02;
        }

        private void btClose_MouseLeave(object sender, EventArgs e)
        {
            btClose.BackgroundImage = Properties.Resources.btClose01;
        }

        private void btClose_MouseUp(object sender, MouseEventArgs e)
        {
            btClose.BackgroundImage = Properties.Resources.btClose02;
        }

        private void btMin_MouseDown(object sender, MouseEventArgs e)
        {
            btMin.BackgroundImage = Properties.Resources.btMin03;
        }

        private void btMin_MouseEnter(object sender, EventArgs e)
        {
            btMin.BackgroundImage = Properties.Resources.btMin02;
        }

        private void btMin_MouseLeave(object sender, EventArgs e)
        {
            btMin.BackgroundImage = Properties.Resources.btMin01;
        }

        private void btMin_MouseUp(object sender, MouseEventArgs e)
        {
            btMin.BackgroundImage = Properties.Resources.btMin02;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            string[] ArryPort = System.IO.Ports.SerialPort.GetPortNames();

            if (btOpen.Text == "启    用")
            {
                comboBoxPort.Items.Clear();
            }

            if (ArryPort.Length != 0)
            {
                for (int i = 0; i < ArryPort.Length; i++)
                {
                    comboBoxPort.Items.Add(ArryPort[i]);
                }

                if (btOpen.Text == "启    用")
                {
                    comboBoxPort.Text = ArryPort[0];
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (btOpen.Text == "启    用")
            {
                try
                {
                    serialPort1.PortName = comboBoxPort.Text;
                    serialPort1.Open();

                    btOpen.Text = "关    闭";
                    btOpen.ForeColor = SystemColors.ControlLightLight;
                    btOpen.BackgroundImage = Properties.Resources.btCheckt042;

                    comboBoxPort.Enabled = false;
                    ChartTimer.Enabled = true;
                }
                catch
                {
                    System.Media.SystemSounds.Beep.Play();
                    //MessageBox.Show("端口打开失败！\r\n请检查端口连接是否正常以及是否选择了正确端口！", "错误提示：");
                    SYSTEM_LOG("端口打开失败！\r\n");
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    btCheck.Enabled = true;
                    comboBoxPort.Enabled = true;
                    btOpen.Text = "启    用";

                    ChartTimer.Enabled = false;
                }
                catch
                {
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show("端口关闭失败！\r\n请检查端口连接是否正常以及是否选择了正确端口！", "错误提示：");
                }
            }
        }

        private void btOpen_MouseDown(object sender, MouseEventArgs e)
        {
            if (btOpen.Text == "启    用")
            {
                btOpen.ForeColor = SystemColors.ControlDarkDark;
                btOpen.BackgroundImage = Properties.Resources.btCheckt031;
            }
        }

        private void btOpen_MouseEnter(object sender, EventArgs e)
        {
            if (btOpen.Text == "启    用")
            {
                btOpen.ForeColor = SystemColors.ControlLightLight;
                btOpen.BackgroundImage = Properties.Resources.btCheckt021;
            }
        }

        private void btOpen_MouseLeave(object sender, EventArgs e)
        {
            if (btOpen.Text == "启    用")
            {
                btOpen.ForeColor = SystemColors.ButtonFace;
                btOpen.BackgroundImage = Properties.Resources.btCheckt011;
            }
        }

        private void btOpen_MouseUp(object sender, MouseEventArgs e)
        {
            if (btOpen.Text == "启    用")
            {
                btOpen.ForeColor = SystemColors.ControlLightLight;
                btOpen.BackgroundImage = Properties.Resources.btCheckt021;
            }
        }

        private void btCheck_MouseDown(object sender, MouseEventArgs e)
        {
            btCheck.ForeColor = SystemColors.ControlDarkDark;
            btCheck.BackgroundImage = Properties.Resources.btCheckt031;
        }

        private void btCheck_MouseEnter(object sender, EventArgs e)
        {
            btCheck.ForeColor = SystemColors.ControlLightLight;
            btCheck.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void btCheck_MouseLeave(object sender, EventArgs e)
        {
            btCheck.ForeColor = SystemColors.ButtonFace;
            btCheck.BackgroundImage = Properties.Resources.btCheckt011;
        }

        private void btCheck_MouseUp(object sender, MouseEventArgs e)
        {
            btCheck.ForeColor = SystemColors.ControlLightLight;
            btCheck.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void checkBoxRts_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxRts.Checked == true)
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.RtsEnable = true;
                }
            }
            else
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.RtsEnable = false;
                }
            }
        }

        private void checkBoxDtr_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxDtr.Checked == true)
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.DtrEnable = true;
                }
            }
            else
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.DtrEnable = false;
                }
            }
        }

        private void btUserPtl_MouseDown(object sender, MouseEventArgs e)
        {
            btUserPtl.ForeColor = SystemColors.AppWorkspace;
            btUserPtl.BackgroundImage = Properties.Resources.bt180_40_pre;
        }

        private void btUserPtl_MouseEnter(object sender, EventArgs e)
        {
            btUserPtl.ForeColor = SystemColors.ButtonFace;
            btUserPtl.BackgroundImage = Properties.Resources.bt180_40_hig;
        }

        private void btUserPtl_MouseLeave(object sender, EventArgs e)
        {
            btUserPtl.ForeColor = SystemColors.ButtonFace;
            btUserPtl.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btUserPtl_MouseUp(object sender, MouseEventArgs e)
        {
            btUserPtl.ForeColor = SystemColors.ButtonFace;
            btUserPtl.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        /*
         * 打开自定义协议窗口
         */
        List<Form2> ListForm2 = new List<Form2>();   //创建窗体集合
        Form2 form2;
        private void btUserPtl_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Owner = this;

            if (ListForm2.Count != 0)
            {
                ListForm2[0].Close(); //防止创建多个Form2窗体
                ListForm2.Clear();
            }

            form2.Show();
            ListForm2.Add(form2);    //将更新进度窗体加入集合中

            form2Exist = true;
        }

        private void btRxColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBoxInput.ForeColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxInput.ForeColor = colorDialog1.Color;

                Properties.Settings.Default["RxColor"] = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void btRxFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBoxInput.Font;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBoxInput.Font = fontDialog1.Font;
                textBoxSend.Font = fontDialog1.Font;

                Properties.Settings.Default["RxTxFont"] = fontDialog1.Font;
                Properties.Settings.Default.Save();
            }
        }

        private void btRxFont_MouseDown(object sender, MouseEventArgs e)
        {
            btRxFont.ForeColor = SystemColors.AppWorkspace;
            btRxFont.BackgroundImage = Properties.Resources.bt180_40_pre;
        }

        private void btRxFont_MouseEnter(object sender, EventArgs e)
        {
            btRxFont.ForeColor = SystemColors.ButtonFace;
            btRxFont.BackgroundImage = Properties.Resources.bt180_40_hig;
        }

        private void btRxFont_MouseLeave(object sender, EventArgs e)
        {
            btRxFont.ForeColor = SystemColors.ButtonFace;
            btRxFont.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btRxFont_MouseUp(object sender, MouseEventArgs e)
        {
            btRxFont.ForeColor = SystemColors.ButtonFace;
            btRxFont.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btRxSave_MouseDown(object sender, MouseEventArgs e)
        {
            btRxSave.ForeColor = SystemColors.AppWorkspace;
            btRxSave.BackgroundImage = Properties.Resources.btCheckt031;
        }

        private void btRxSave_MouseEnter(object sender, EventArgs e)
        {
            btRxSave.ForeColor = SystemColors.ControlLightLight;
            btRxSave.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void btRxSave_MouseLeave(object sender, EventArgs e)
        {
            btRxSave.ForeColor = SystemColors.ControlLightLight;
            btRxSave.BackgroundImage = Properties.Resources.btCheckt011;
        }

        private void btRxSave_MouseUp(object sender, MouseEventArgs e)
        {
            btRxSave.ForeColor = SystemColors.ControlLightLight;
            btRxSave.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void btRxClear_MouseDown(object sender, MouseEventArgs e)
        {
            btRxClear.ForeColor = SystemColors.AppWorkspace;
            btRxClear.BackgroundImage = Properties.Resources.btCheckt031;
        }

        private void btRxClear_MouseEnter(object sender, EventArgs e)
        {
            btRxClear.ForeColor = SystemColors.ControlLightLight;
            btRxClear.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void btRxClear_MouseLeave(object sender, EventArgs e)
        {
            btRxClear.ForeColor = SystemColors.ControlLightLight;
            btRxClear.BackgroundImage = Properties.Resources.btCheckt011;
        }

        private void btRxClear_MouseUp(object sender, MouseEventArgs e)
        {
            btRxClear.ForeColor = SystemColors.ControlLightLight;
            btRxClear.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void btRxColor_MouseDown(object sender, MouseEventArgs e)
        {
            btRxColor.ForeColor = SystemColors.AppWorkspace;
            btRxColor.BackgroundImage = Properties.Resources.bt180_40_pre;
        }

        private void btRxColor_MouseEnter(object sender, EventArgs e)
        {
            btRxColor.ForeColor = SystemColors.ButtonFace;
            btRxColor.BackgroundImage = Properties.Resources.bt180_40_hig;
        }

        private void btRxColor_MouseLeave(object sender, EventArgs e)
        {
            btRxColor.ForeColor = SystemColors.ButtonFace;
            btRxColor.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btRxColor_MouseUp(object sender, MouseEventArgs e)
        {
            btRxColor.ForeColor = SystemColors.ButtonFace;
            btRxColor.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btTxColor_MouseDown(object sender, MouseEventArgs e)
        {
            btTxColor.ForeColor = SystemColors.AppWorkspace;
            btTxColor.BackgroundImage = Properties.Resources.bt180_40_pre;
        }

        private void btTxColor_MouseEnter(object sender, EventArgs e)
        {
            btTxColor.ForeColor = SystemColors.ButtonFace;
            btTxColor.BackgroundImage = Properties.Resources.bt180_40_hig;
        }

        private void btTxColor_MouseLeave(object sender, EventArgs e)
        {
            btTxColor.ForeColor = SystemColors.ButtonFace;
            btTxColor.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btTxColor_MouseUp(object sender, MouseEventArgs e)
        {
            btTxColor.ForeColor = SystemColors.ButtonFace;
            btTxColor.BackgroundImage = Properties.Resources.btSelect02;
        }

        /*
         定时查询可用串口
         */
        private delegate void comboBoxPortUpdataDelegate();

        void comboBoxPortUpdata()
        {
            if (serialPort1.IsOpen == false)
            {
                string[] ArryPort = System.IO.Ports.SerialPort.GetPortNames();

                if (ArryPort.Length != LastLength)
                {
                    LastLength = ArryPort.Length;

                    comboBoxPort.Items.Clear();

                    for (int i = 0; i < ArryPort.Length; i++)
                    {
                        comboBoxPort.Items.Add(ArryPort[i]);
                    }

                    btCheck.Enabled = true;
                    comboBoxPort.Enabled = true;
                    btOpen.Text = "启    用";
                    btOpen.ForeColor = SystemColors.ButtonFace;
                    btOpen.BackgroundImage = Properties.Resources.btCheckt011;
                }
            }
        }

        int LastLength = 0;
        public void SerialPortCheckThread(object obj)
        {
            while (true)
            {
                try
                {
                    this.Invoke(new comboBoxPortUpdataDelegate(comboBoxPortUpdata));
                }
                catch
                {
                    ;
                }

                Thread.Sleep(200);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (serialPort1.IsOpen == false)
            {
                string[] ArryPort = System.IO.Ports.SerialPort.GetPortNames();

                if (ArryPort.Length != LastLength)
                {
                    LastLength = ArryPort.Length;

                    comboBoxPort.Items.Clear();

                    for (int i = 0; i < ArryPort.Length; i++)
                    {
                        comboBoxPort.Items.Add(ArryPort[i]);
                    }

                    btCheck.Enabled = true;
                    comboBoxPort.Enabled = true;
                    btOpen.Text = "启    用";
                    btOpen.ForeColor = SystemColors.ButtonFace;
                    btOpen.BackgroundImage = Properties.Resources.btCheckt011;
                }
            }
            */
        }

        private void btRxSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            saveFileDialog1.FileName = "log_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btRxSave.ForeColor = SystemColors.ControlLightLight;
                btRxSave.BackgroundImage = Properties.Resources.btCheckt011;

                saveFileDialog1.RestoreDirectory = true;

                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName, true);
                streamWriter.Write(richTextBoxInput.Text);
                streamWriter.Close();
            }
        }

        private void btRxClear_Click(object sender, EventArgs e)
        {
            TxNumber.Text = "0";
            TxNumberCount = 0;

            RxNumber.Text = "0";
            RxNumberCount = 0;

            //textBoxInput.Clear();
            richTextBoxInput.Clear();
        }

        OpenFileDialog MyFileDialog;

        /*
         * 十六进制字符串转为byte
         * 字符串:string hexString = "00 11 22 FF";
         * byte : byte[] returnBytes = {0x00,0x11,0x11,0xFF}；
         */
        public void TxNumberLabelShow(int length)
        {
            TxNumberCount += ((UInt32)length);
            TxNumberShow(TxNumberCount);
        }
       public byte[] HexStringToBytes(string hexString)
        {
            hexString = hexString.Replace(" ", "");

            if ((hexString.Length % 2) != 0)
            {
                hexString = hexString.Insert(hexString.Length - 1,"0"); //多出的一个字节补0
            }

            byte[] returnBytes = new byte[hexString.Length / 2];

            for (int i = 0; i < returnBytes.Length; i++)
            {
                try
                {
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                }
                catch
                {
                    return returnBytes;
                }
            }

            return returnBytes;
        }

        private void SendData()
        {
            if (serialPort1.IsOpen == true)
            {
                if (radioButtonTxAsc.Checked == true)
                {
                    if (TxEncodingBox.Text == "Default")
                    {
                        TxByte = System.Text.Encoding.Default.GetBytes(textBoxSend.Text);
                    }
                    else if (TxEncodingBox.Text == "GBK")
                    {
                        TxByte = System.Text.Encoding.GetEncoding("GBK").GetBytes(textBoxSend.Text);
                    }
                    else if (TxEncodingBox.Text == "Unicode")
                    {
                        TxByte = System.Text.Encoding.Unicode.GetBytes(textBoxSend.Text);
                    }
                    else if (TxEncodingBox.Text == "UTF-8")
                    {
                        TxByte = System.Text.Encoding.UTF8.GetBytes(textBoxSend.Text);
                    }
                    else if (TxEncodingBox.Text == "UTF-32")
                    {
                        TxByte = System.Text.Encoding.UTF32.GetBytes(textBoxSend.Text);
                    }
                    else
                    {
                        TxByte = System.Text.Encoding.Default.GetBytes(textBoxSend.Text);
                    }
                }
                else if (radioButtonTxHex.Checked == true)
                {
                    TxByte = HexStringToBytes(textBoxSend.Text);
                }

                try
                {
                    serialPort1.Write(TxByte, 0, TxByte.Length);
                }
                catch
                { 
                
                }

                TxNumberCount += ((UInt32)TxByte.Length);
                TxNumberShow(TxNumberCount);
            }
        }
        
        private void btTxSend_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void btTxSend_MouseEnter(object sender, EventArgs e)
        {
            btTxSend.ForeColor = SystemColors.ControlLightLight;
            btTxSend.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void btTxSend_MouseDown(object sender, MouseEventArgs e)
        {
            btTxSend.ForeColor = SystemColors.AppWorkspace;
            btTxSend.BackgroundImage = Properties.Resources.btCheckt031;
        }

        private void btTxSend_MouseLeave(object sender, EventArgs e)
        {
            btTxSend.ForeColor = SystemColors.ControlLightLight;
            btTxSend.BackgroundImage = Properties.Resources.btCheckt011;
        }

        private void btTxSend_MouseUp(object sender, MouseEventArgs e)
        {
            btTxSend.ForeColor = SystemColors.ControlLightLight;
            btTxSend.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void btTxClear_Click(object sender, EventArgs e)
        {
            TxNumber.Text = "0";
            TxNumberCount = 0;
            textBoxSend.Clear();
        }

        private void btTxClear_MouseEnter(object sender, EventArgs e)
        {
            btTxClear.ForeColor = SystemColors.ControlLightLight;
            btTxClear.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void btTxClear_MouseDown(object sender, MouseEventArgs e)
        {
            btTxClear.ForeColor = SystemColors.AppWorkspace;
            btTxClear.BackgroundImage = Properties.Resources.btCheckt031;
        }

        private void btTxClear_MouseLeave(object sender, EventArgs e)
        {
            btTxClear.ForeColor = SystemColors.ControlLightLight;
            btTxClear.BackgroundImage = Properties.Resources.btCheckt011;
        }

        private void btTxClear_MouseUp(object sender, MouseEventArgs e)
        {
            btTxClear.ForeColor = SystemColors.ControlLightLight;
            btTxClear.BackgroundImage = Properties.Resources.btCheckt021;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SendData();
        }

        private void TimerSendcheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (TimerSendcheckBox.Checked == true)
            {
                if (TimerTx.Text != "")
                {
                    int tick = 0;
                    try { tick = Convert.ToInt32(TimerTx.Text); } catch { }

                    if (tick > 0)
                    {
                        TimerTx.Enabled = false;
                        timer2.Interval = tick;
                        timer2.Enabled = true;
                    }
                }
                else
                {
                    TimerTx.Enabled = true;
                    TimerSendcheckBox.Checked = false;

                    System.Media.SystemSounds.Beep.Play();
                    SYSTEM_LOG("请设置定时发送间隔\r\n");
                }

            }
            else
            {
                TimerTx.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void TimerTx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20)   //禁止空格键
            {
                e.KeyChar = (char)0;
            }

            //if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) //禁止负数
            if (e.KeyChar == 0x2D) //禁止负数
            {
                e.KeyChar = (char)0;
            } 

            if (e.KeyChar > 0x20)
            {
                try
                {
                    //double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                    double.Parse(e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void comboBoxBoud_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBoud.Text == "自定义")
            {
                comboBoxBoud.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBoud.Text);
                comboBoxBoud.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void comboBoxBoud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

            }
            else if ((e.KeyChar == (char)0x08)) //退格建
            {

            }
            else
            {
                e.KeyChar = (char)0;
            }
        }

        private void comboBoxBoud_KeyUp(object sender, KeyEventArgs e)
        {
            if (comboBoxBoud.Text != "")
            {
                try
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBoud.Text);
                }
                catch 
                {
                    SYSTEM_LOG("请输入正确波特率\r\n");
                }
            }
        }

        private void comboStopbit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStopbit.Text != "")
            {
                if (comboStopbit.Text != "1")
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                }
                else if (comboStopbit.Text != "1.2")
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                }
                else if (comboStopbit.Text != "2")
                {
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                }
            }
        }

        private void comboDatalength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDatalength.Text != "")
            {
                serialPort1.DataBits = Convert.ToInt32(comboDatalength.Text);
            }
        }

        private void comboBoxJudge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxJudge.Text != "")
            {
                if (comboBoxJudge.Text == "无")
                {
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                }
                else if (comboBoxJudge.Text == "奇校验")
                {
                    serialPort1.Parity = System.IO.Ports.Parity.Odd;
                }
                else if (comboBoxJudge.Text == "偶校验")
                {
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                }
            }
        }

        private void btTxColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBoxInput.ForeColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxSend.ForeColor = colorDialog1.Color;

                Properties.Settings.Default["TxColor"] = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        /*发送区将字符串转为hex显示*/
        private void radioButtonTxHex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTxHex.Checked == true)
            {
                if (TxEncodingBox.Text == "Default")
                {
                    TxByte = System.Text.Encoding.Default.GetBytes(textBoxSend.Text);
                }
                else if (TxEncodingBox.Text == "GBK")
                {
                    TxByte = System.Text.Encoding.GetEncoding("GBK").GetBytes(textBoxSend.Text);
                }
                else if (TxEncodingBox.Text == "Unicode")
                {
                    TxByte = System.Text.Encoding.Unicode.GetBytes(textBoxSend.Text);
                }
                else if (TxEncodingBox.Text == "UTF-8")
                {
                    TxByte = System.Text.Encoding.UTF8.GetBytes(textBoxSend.Text);
                }
                else if (TxEncodingBox.Text == "UTF-32")
                {
                    TxByte = System.Text.Encoding.UTF32.GetBytes(textBoxSend.Text);
                }
                else
                {
                    TxByte = System.Text.Encoding.Default.GetBytes(textBoxSend.Text);
                }

                textBoxSend.Text = BitConverter.ToString(TxByte).Replace("-", " ") + " ";    //十六进制显示

                Properties.Settings.Default.TxHex = true;
                Properties.Settings.Default.Save();
            }
        }

        /*发送区将hex转为字符串显示*/
        private void radioButtonTxAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTxAsc.Checked == true)
            {
                byte[] textBoxByte;
                textBoxByte = HexStringToBytes(textBoxSend.Text);
                
                if (TxEncodingBox.Text == "Default")
                {
                    textBoxSend.Text = System.Text.Encoding.Default.GetString(textBoxByte);
                }
                else if (TxEncodingBox.Text == "GBK")
                {
                    textBoxSend.Text = System.Text.Encoding.GetEncoding("GBK").GetString(textBoxByte);
                }
                else if (TxEncodingBox.Text == "Unicode")
                {
                    textBoxSend.Text = System.Text.Encoding.Unicode.GetString(textBoxByte);
                }
                else if (TxEncodingBox.Text == "UTF-8")
                {
                    textBoxSend.Text = System.Text.Encoding.UTF8.GetString(textBoxByte);
                }
                else if (TxEncodingBox.Text == "UTF-32")
                {
                    textBoxSend.Text = System.Text.Encoding.UTF32.GetString(textBoxByte);
                }
                else
                {
                    textBoxSend.Text = System.Text.Encoding.Default.GetString(textBoxByte);
                }

                Properties.Settings.Default.TxHex = false;
                Properties.Settings.Default.Save();
            }
        }

        /*HEX格式下只允许输入十六进制数据*/
        bool keyFlag = true;
        private void textBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonTxHex.Checked == true)
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    keyFlag = true;
                }
                else if ((e.KeyChar >= 'A') && (e.KeyChar <= 'F'))
                {
                    keyFlag = true;
                }
                else if ((e.KeyChar >= 'a') && (e.KeyChar <= 'f'))
                {
                    keyFlag = true;
                }
                else if ((e.KeyChar == ' ') || (e.KeyChar == (char)0x0a) || (e.KeyChar == (char)0x0d) || (e.KeyChar == (char)0x08))
                {
                    //允许 空格 换行 回车 退格 键入
                    keyFlag = true;
                }
                else if ((e.KeyChar == (char)0x01) || (e.KeyChar == (char)0x03))
                {
                    //允许 ctrl+A ctrl+C
                    keyFlag = true;
                }
                else
                {
                    if (keyFlag == true)
                    {
                        keyFlag = false;

                        SYSTEM_LOG("请输入十六进制数据\r\n");
                    }
                    
                    e.KeyChar = (char)0;
                }
            }
        }

        public delegate void ChartUpdata(int dataLength);
        private void chart1Updata(int dataLength)
        {
            if (serialPort1.IsOpen == true)
            {
                chart1DataUpdata(dataLength, 1);

                if (chart1.InvokeRequired)
                {
                    SYSTEM_LOG("\r\n委托\r\n");
                    ChartUpdata d = new ChartUpdata(chart1Updata);
                    this.Invoke(d, new object[] { dataLength });
                }
                else
                {
                    chart1.Series[0].Points.Clear();

                    for (int i = 0; i < chartDataQueue.Count; i++)
                    {
                        chart1.Series[0].Points.AddXY(i, chartDataQueue.ElementAt(i));
                    }
                }
            }
        }

        
        private void ChartTimer_Tick(object sender, EventArgs e)
        {
            //this.Invoke(new ChartUpdata(chart1Updata));
        }

        int labelChartX = 0;
        int labelChartY = 0;
        private void chart1_MouseEnter(object sender, EventArgs e)
        {
            labelChart.Visible = true;
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {
            labelChart.Visible = false;

            //chart1.ChartAreas[0].CursorX.Position = 400;
            //chart1.ChartAreas[0].CursorY.Position = 400;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(new PointF(e.X, e.Y), true);
            chart1.ChartAreas[0].CursorY.SetCursorPixelPosition(new PointF(e.X, e.Y), true);

            labelChart.Left += e.X - labelChartX;
            labelChart.Top += e.Y - labelChartY;

            labelChartX = e.X;
            labelChartY = e.Y;

            labelChart.Text = chart1.ChartAreas[0].CursorY.Position.ToString();
        }

        /*******************************************************************
         文件发送功能
         ******************************************************************/
        public delegate void UpdataSendProgressDel();
        public delegate void SendFileDel();
        private byte[] FileByte;           //发送文本字节

        void updataProgress()
        {
            if (FileByte.Length != 0)
            {
                int progressValue = 100 * TxFileFrameIndex * 512 / FileByte.Length;

                if (progressValue < progressBar1.Minimum)
                {
                    progressValue = progressBar1.Minimum;
                }
                else if (progressValue > progressBar1.Maximum)
                {
                    progressValue = progressBar1.Maximum;
                }

                if (TxFileFrameIndex == TxFileFrameCount)
                {
                    progressValue = progressBar1.Maximum;
                }

                progressBar1.Value = progressValue;
            }
        }

        void SendFile()
        {
            if (serialPort1.IsOpen)
            {
                int txCount = 0;
                int txNeed = 0;
                byte[] txBuff = new byte[512];

                txCount = 0;
                if (TxFileFrameIndex < TxFileFrameCount)
                {
                    for (int i = 0; i < 512; i++)
                    {
                        txBuff[i] = FileByte[TxFileFrameIndex * 512 + i];
                        txCount++;
                    }

                    TxFileFrameIndex++;
                }
                else
                {
                    txNeed = FileByte.Length - 512 * TxFileFrameIndex;

                    try
                    {
                        for (int i = 0; i < txNeed; i++)
                        {
                            txBuff[i] = FileByte[TxFileFrameIndex * 512 + i];
                            txCount++;
                        }

                        fileSendTimer.Enabled = false;
                    }
                    catch
                    {
                        fileSendTimer.Enabled = false;
                    }
                }

                try
                {
                    serialPort1.Write(txBuff, 0, txCount);
                }
                catch
                { 
                
                }

                TxNumberLabelShow(txCount);

                this.Invoke(new UpdataSendProgressDel(updataProgress));
            }
        }

        private void btFileOpen_Click(object sender, EventArgs e)
        {
            MyFileDialog = new OpenFileDialog();
            MyFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            MyFileDialog.Filter = @"|*.*";

            if (MyFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = MyFileDialog.FileName;
                FileStream Myfile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader str = new StreamReader(Myfile);

                MyFileDialog.RestoreDirectory = true;

                string ext = Path.GetExtension(MyFileDialog.FileName);
                string binName = ".bin";
                if (binName.Equals(ext, StringComparison.OrdinalIgnoreCase)) //.bin文件
                {
                    BinaryReader BinReader = new BinaryReader(Myfile);
                    FileByte = BinReader.ReadBytes((int)Myfile.Length);
                }
                else
                {
                    FileByte = System.Text.Encoding.Default.GetBytes(str.ReadToEnd());
                }

                TxFileFrameIndex = 0;
                TxFileFrameCount = FileByte.Length / 512;

                label11.Text = "文件发送:" + ((float)FileByte.Length / 1024).ToString("n") + "kB\r\n";
 
                str.Close();

                textBoxFileName.Text = MyFileDialog.SafeFileName;

                SYSTEM_LOG("文件大小:" + FileByte.Length.ToString() + "byte\r\n");
            }
        }

        private void btFileCancel_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            fileSendTimer.Enabled = false;
        }

        private void btFileSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                TxFileFrameIndex = 0;
                fileSendTimer.Enabled = true;
            }
        }

        private void fileSendTimer_Tick(object sender, EventArgs e)
        {
            SendFile();
        }

        public void FieleSendThread(object length)
        {
            while (true)
            {
                
                Thread.Sleep(1);
            }
        }

        private void btFileOpen_MouseDown(object sender, MouseEventArgs e)
        {
            btFileOpen.ForeColor = SystemColors.AppWorkspace;
            btFileOpen.BackgroundImage = Properties.Resources.bt22035Pres;
        }

        private void btFileOpen_MouseEnter(object sender, EventArgs e)
        {
            btFileOpen.ForeColor = SystemColors.ControlLightLight;
            btFileOpen.BackgroundImage = Properties.Resources.bt22035Rels;
        }

        private void btFileOpen_MouseLeave(object sender, EventArgs e)
        {
            btFileOpen.ForeColor = SystemColors.ControlLightLight;
            btFileOpen.BackgroundImage = Properties.Resources.bt22035Idle;
        }

        private void btFileOpen_MouseUp(object sender, MouseEventArgs e)
        {
            btFileOpen.ForeColor = SystemColors.ControlLightLight;
            btFileOpen.BackgroundImage = Properties.Resources.bt22035Rels;
        }

        private void btFileCancel_MouseDown(object sender, MouseEventArgs e)
        {
            btFileCancel.ForeColor = SystemColors.AppWorkspace;
            btFileCancel.BackgroundImage = Properties.Resources.bt11035Pres;
        }

        private void btFileCancel_MouseEnter(object sender, EventArgs e)
        {
            btFileCancel.ForeColor = SystemColors.ControlLightLight;
            btFileCancel.BackgroundImage = Properties.Resources.bt11035Rels;
        }

        private void btFileCancel_MouseLeave(object sender, EventArgs e)
        {
            btFileCancel.ForeColor = SystemColors.ControlLightLight;
            btFileCancel.BackgroundImage = Properties.Resources.bt11035Idle;
        }

        private void btFileCancel_MouseUp(object sender, MouseEventArgs e)
        {
            btFileCancel.ForeColor = SystemColors.ControlLightLight;
            btFileCancel.BackgroundImage = Properties.Resources.bt11035Rels;
        }

        private void btFileSend_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend.ForeColor = SystemColors.AppWorkspace;
            btFileSend.BackgroundImage = Properties.Resources.bt11035Pres;
        }

        private void btFileSend_MouseEnter(object sender, EventArgs e)
        {
            btFileSend.ForeColor = SystemColors.ControlLightLight;
            btFileSend.BackgroundImage = Properties.Resources.bt11035Rels;
        }

        private void btFileSend_MouseLeave(object sender, EventArgs e)
        {
            btFileSend.ForeColor = SystemColors.ControlLightLight;
            btFileSend.BackgroundImage = Properties.Resources.bt11035Idle;
        }

        private void btFileSend_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend.ForeColor = SystemColors.ControlLightLight;
            btFileSend.BackgroundImage = Properties.Resources.bt11035Rels;
        }

        private void checkBoxAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoSave.Checked == true)
            {
                saveFileDialog1.Filter = "(*.txt)|*.txt|(*.*)|*.*";
                saveFileDialog1.FileName = "file_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveFileDialog1.RestoreDirectory = true;

                    RxFilePath = saveFileDialog1.FileName;

                    fs = new FileStream(RxFilePath, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.Close();
                    fs.Close();
                }
                else
                {
                    checkBoxAutoSave.Checked = false;
                }
            }
        }

        private void textBoxSend_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TxSend = textBoxSend.Text;
            Properties.Settings.Default.Save();
        }

        /*
         在接收文本框内查找指定内容
         */
        private bool findDir = true;
        private string findText = "";
        private int findIndex = 0;
        private int indexLocate = 0;
        private int indexRecord = 0;
        Regex regex;
        MatchCollection Collection;
        
        private void ChangeKeyColor(string findText, Color color)
        {
            regex = new Regex(findText);//查找文本内容
            Collection = regex.Matches(richTextBoxInput.Text);//对查找到的内容进行颜色替换

            foreach (Match match in Collection)
            {
                //查找依据：开始位置、长度、颜色
                richTextBoxInput.SelectionStart = match.Index;
                richTextBoxInput.SelectionLength = findText.Length;
                richTextBoxInput.SelectionColor = color;
            }
        }

        private void btRxFind_Click(object sender, EventArgs e)
        {
            if (textBoxFind.Text != "")
            {
                indexLocate = 0;
                findText = textBoxFind.Text;
                findIndex = richTextBoxInput.Text.IndexOf(findText);

                if (findIndex == -1)
                {
                    System.Media.SystemSounds.Beep.Play();
                    SYSTEM_LOG("未找到指定内容\r\n");
                }
                else
                {
                    richTextBoxInput.Select(findIndex, findText.Length);
                    richTextBoxInput.ScrollToCaret();
                    richTextBoxInput.Focus();

                    ChangeKeyColor(textBoxFind.Text, textBoxFind.ForeColor);
                }
            }
        }

        private void btFindNext_Click(object sender, EventArgs e)
        {
            if (findIndex > 0)
            {
                if ((Collection.Count > 0) && (indexLocate < Collection.Count))
                {
                    if (findDir == false)
                    {
                        findDir = true;
                        indexLocate = indexRecord;

                        if (indexLocate == (Collection.Count - 1))
                        {
                            indexLocate = 0;
                        }
                        else
                        {
                            indexLocate++;
                        }

                    }

                    Match match = Collection[indexLocate];

                    richTextBoxInput.Select(match.Index, findText.Length);
                    richTextBoxInput.ScrollToCaret();
                    richTextBoxInput.Focus();

                    indexRecord = indexLocate;

                    if (indexLocate == (Collection.Count - 1))
                    {
                        indexLocate = 0;
                    }
                    else
                    {
                        indexLocate++;
                    }
                }
            }
        }

        private void btFindLast_Click(object sender, EventArgs e)
        {
            if (findIndex > 0)
            {
                if ((Collection.Count) > 0 && (indexLocate < Collection.Count))
                {
                    if (findDir == true)
                    {
                        findDir = false;
                        indexLocate = indexRecord;

                        if (indexLocate == 0)
                        {
                            indexLocate = (Collection.Count - 1);
                        }
                        else
                        {
                            if (indexLocate > 0)
                            {
                                indexLocate--;
                            }
                        }
                    }

                    Match match = Collection[indexLocate];

                    richTextBoxInput.Select(match.Index, findText.Length);
                    richTextBoxInput.ScrollToCaret();
                    richTextBoxInput.Focus();

                    indexRecord = indexLocate;

                    if (indexLocate == 0)
                    {
                        indexLocate = (Collection.Count - 1);
                    }
                    else
                    {
                        if (indexLocate > 0)
                        {
                            indexLocate--;
                        }
                    }
                }
            }
        }

        private void btExtrude_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFind.ForeColor = colorDialog1.Color;

                Properties.Settings.Default.ExtrudeColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void btRxFind_MouseDown(object sender, MouseEventArgs e)
        {
            btRxFind.ForeColor = SystemColors.ControlDark;
            btRxFind.BackgroundImage = Properties.Resources.btFind02;
        }

        private void btRxFind_MouseUp(object sender, MouseEventArgs e)
        {
            btRxFind.ForeColor = SystemColors.ControlLight;
            btRxFind.BackgroundImage = Properties.Resources.btFind01;
        }

        private void btExtrude_MouseDown(object sender, MouseEventArgs e)
        {
            btExtrude.ForeColor = SystemColors.ControlDark;
            btExtrude.BackgroundImage = Properties.Resources.btFind02;
        }

        private void btExtrude_MouseUp(object sender, MouseEventArgs e)
        {
            btExtrude.ForeColor = SystemColors.ControlLight;
            btExtrude.BackgroundImage = Properties.Resources.btFind01;
        }

        private void btFindNext_MouseDown(object sender, MouseEventArgs e)
        {
            btFindNext.ForeColor = SystemColors.ControlDark;
            btFindNext.BackgroundImage = Properties.Resources.btFind04;
        }

        private void btFindNext_MouseUp(object sender, MouseEventArgs e)
        {
            btFindNext.ForeColor = SystemColors.ControlLight;
            btFindNext.BackgroundImage = Properties.Resources.btFind03;
        }

        private void btFindLast_MouseDown(object sender, MouseEventArgs e)
        {
            btFindLast.ForeColor = SystemColors.ControlDark;
            btFindLast.BackgroundImage = Properties.Resources.btFind04;
        }

        private void btFindLast_MouseUp(object sender, MouseEventArgs e)
        {
            btFindLast.ForeColor = SystemColors.ControlLight;
            btFindLast.BackgroundImage = Properties.Resources.btFind03;
        }

        /*
         * Ctrl+鼠标滚轮实现接收字体放大缩小
         */
        private bool KeyCtrlFlag = false;
        private void richTextBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                KeyCtrlFlag = true;
            }
        }

        private void richTextBoxInput_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void richTextBoxInput_KeyUp(object sender, KeyEventArgs e)
        {
            KeyCtrlFlag = false;
        }

        private void richTextBoxInput_MouseWheel(object sender, MouseEventArgs e)
        {
            if (KeyCtrlFlag == true)
            {
                if (e.Delta > 0)
                {
                    float zoom = richTextBoxInput.ZoomFactor;

                    if (richTextBoxInput.ZoomFactor < 5)
                    {
                        richTextBoxInput.ZoomFactor = zoom + (float)0.1;
                    }
                }
                else if (e.Delta < 0)
                {
                    float zoom = richTextBoxInput.ZoomFactor;

                    if (richTextBoxInput.ZoomFactor >= 0.3)
                    {
                        richTextBoxInput.ZoomFactor = zoom - (float)0.1;
                    }
                }
            }
        }
 
        /*
         *打开校验码计算窗口
         */
        List<Form3> ListForm3 = new List<Form3>();   //创建窗体集合
        Form3 form3;
        private void btCheckCode_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            //form3.Owner = this;

            if (ListForm3.Count != 0)
            {
                ListForm3[0].Close();
                ListForm3.Clear();
            }

            form3.Show();
            ListForm3.Add(form3);

            form3Exist = true;

            if (form4Exist == true)
            {
                form4Exist = false;
                form4.Close();
            }
        }

        private void btCheckCode_MouseDown(object sender, MouseEventArgs e)
        {
            btCheckCode.ForeColor = SystemColors.AppWorkspace;
            btCheckCode.BackgroundImage = Properties.Resources.bt180_40_pre;
        }

        private void btCheckCode_MouseEnter(object sender, EventArgs e)
        {
            btCheckCode.ForeColor = SystemColors.ButtonFace;
            btCheckCode.BackgroundImage = Properties.Resources.bt180_40_hig;
        }

        private void btCheckCode_MouseLeave(object sender, EventArgs e)
        {
            btCheckCode.ForeColor = SystemColors.ButtonFace;
            btCheckCode.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btCheckCode_MouseUp(object sender, MouseEventArgs e)
        {
            btCheckCode.ForeColor = SystemColors.ButtonFace;
            btCheckCode.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btWave_MouseDown(object sender, MouseEventArgs e)
        {
            btWave.ForeColor = SystemColors.AppWorkspace;
            btWave.BackgroundImage = Properties.Resources.bt180_40_pre;
        }

        private void btWave_MouseEnter(object sender, EventArgs e)
        {
            btWave.ForeColor = SystemColors.ButtonFace;
            btWave.BackgroundImage = Properties.Resources.bt180_40_hig;
        }

        private void btWave_MouseLeave(object sender, EventArgs e)
        {
            btWave.ForeColor = SystemColors.ButtonFace;
            btWave.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        private void btWave_MouseUp(object sender, MouseEventArgs e)
        {
            btWave.ForeColor = SystemColors.ButtonFace;
            btWave.BackgroundImage = Properties.Resources.bt180_40_rel;
        }

        List<Form4> ListForm4 = new List<Form4>();   //创建窗体集合
        Form4 form4;
        private void btWave_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            form4.Owner = this;

            if (ListForm4.Count != 0)
            {
                ListForm4[0].Close(); //防止创建多个Form2窗体
                ListForm4.Clear();
            }

            form4.Show();
            ListForm4.Add(form4);    //将更新进度窗体加入集合中

            form4Exist = true;

            if (form3Exist == true)
            {
                form3Exist = false;
                form3.Close();
            }
        }

        private void radioButtonRxAsc_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RxHex = false;
            Properties.Settings.Default.Save();
        }

        private void radioButtonRxHex_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RxHex = true;
            Properties.Settings.Default.Save();
        }
    }
}
