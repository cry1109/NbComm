using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Reflection;
using Excel;
using Microsoft.Office.Interop.Excel;

namespace NbComm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Form1 form1 = new Form1();

        public enum ChannelEnum : int
        {
            CH1 = 0,
            CH2 = 1,
            CH3 = 2,
            CH4 = 3,
            CH_MAX = 4,
        };

        private enum DataTypeEnum : int
        {
            DataUint8 = 0,
            DataInt8 = 1,
            DataUint16 = 2,
            DataInt16 = 3,
            DataUint32 = 4,
            DataInt32 = 5,
        };

        ChannelEnum ChannelMax = (ChannelEnum)1;
        ChannelEnum ChannelIndex = ChannelEnum.CH1;
        DataTypeEnum WaveDataType = DataTypeEnum.DataUint8;

        private const int CH_QUEUE_SIZE = 1000;
        private Queue<Int64> Ch1Queue = new Queue<Int64>(CH_QUEUE_SIZE);
        private Queue<Int64> Ch2Queue = new Queue<Int64>(CH_QUEUE_SIZE);
        private Queue<Int64> Ch3Queue = new Queue<Int64>(CH_QUEUE_SIZE);
        private Queue<Int64> Ch4Queue = new Queue<Int64>(CH_QUEUE_SIZE);
        private bool KeyXDown = false;
        private bool KeyYDown = false;
        private bool Chart1MouseIn = false;
        private bool Chart2MouseIn = false;
        private bool WaveStartFlag = false;

        /*
         * 通过鼠标滚轮实现波形缩放
         */
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                //if (KeyXDown == true)
                {
                    int delta = (int)(chart1.ChartAreas[0].AxisX.ScaleView.Size / 100 + 1);

                    if (e.Delta > 0)
                    {
                        if ((chart1.ChartAreas[0].AxisX.ScaleView.Position + chart1.ChartAreas[0].AxisX.ScaleView.Size + delta) < chart1.ChartAreas[0].AxisX.Maximum)
                        {
                            chart1.ChartAreas[0].AxisX.ScaleView.Size += delta;
                        }
                        else
                        {
                            if (chart1.ChartAreas[0].AxisX.ScaleView.Position > delta)
                            {
                                chart1.ChartAreas[0].AxisX.ScaleView.Position -= delta;
                            }
                            else if (chart1.ChartAreas[0].AxisX.ScaleView.Position > 0)
                            {
                                chart1.ChartAreas[0].AxisX.ScaleView.Position -= 1;
                            }

                            chart1.ChartAreas[0].AxisX.ScaleView.Size = chart1.ChartAreas[0].AxisX.Maximum - chart1.ChartAreas[0].AxisX.ScaleView.Position;
                        }
                    }
                    else
                    {
                        if (chart1.ChartAreas[0].AxisX.ScaleView.Size > delta)
                        {
                            chart1.ChartAreas[0].AxisX.ScaleView.Size -= delta;
                        }
                    }

                    if (chart1.ChartAreas[0].AxisX.ScaleView.Size < 2)
                    {
                        chart1.ChartAreas[0].AxisX.ScaleView.Size = 2;
                    }
                }
                /*
                else if (KeyYDown == true)
                {
                    int delta = (int)(chart1.ChartAreas[0].AxisY.ScaleView.Size / 100 + 1);

                    if (e.Delta > 0)
                    {
                        if ((chart1.ChartAreas[0].AxisY.ScaleView.Position + chart1.ChartAreas[0].AxisY.ScaleView.Size + delta) < chart1.ChartAreas[0].AxisY.Maximum)
                        {

                            chart1.ChartAreas[0].AxisY.ScaleView.Size += delta;
                        }
                        else
                        {
                            chart1.ChartAreas[0].AxisY.ScaleView.Size = chart1.ChartAreas[0].AxisY.Maximum - chart1.ChartAreas[0].AxisY.ScaleView.Position;
                        }
                    }
                    else
                    {
                        if (chart1.ChartAreas[0].AxisX.ScaleView.Size > delta)
                        {
                            chart1.ChartAreas[0].AxisY.ScaleView.Size -= delta;
                        }
                    }
                }
                */
            }
            catch
            { 
            
            }
        }

        private void chart2_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (KeyXDown == true)
                {

                }
                else
                {
                    if ((e.X < (chart2.Size.Width / 2)) && (e.Y < (chart2.Size.Height / 2)))
                    {
                        int delta = (int)(chart2.ChartAreas[0].AxisX.ScaleView.Size / 100 + 1);

                        if (e.Delta > 0)
                        {
                            if ((chart2.ChartAreas[0].AxisX.ScaleView.Position + chart2.ChartAreas[0].AxisX.ScaleView.Size + delta) < chart2.ChartAreas[0].AxisX.Maximum)
                            {
                                chart2.ChartAreas[0].AxisX.ScaleView.Size += delta;
                            }
                            else
                            {
                                if (chart2.ChartAreas[0].AxisX.ScaleView.Position > delta)
                                {
                                    chart2.ChartAreas[0].AxisX.ScaleView.Position -= delta;
                                }
                                else if (chart1.ChartAreas[0].AxisX.ScaleView.Position > 0)
                                {
                                    chart2.ChartAreas[0].AxisX.ScaleView.Position -= 1;
                                }

                                chart2.ChartAreas[0].AxisX.ScaleView.Size = chart2.ChartAreas[0].AxisX.Maximum - chart2.ChartAreas[0].AxisX.ScaleView.Position;
                            }
                        }
                        else
                        {
                            if (chart2.ChartAreas[0].AxisX.ScaleView.Size > delta)
                            {
                                chart2.ChartAreas[0].AxisX.ScaleView.Size -= delta;
                            }
                        }

                        if (chart2.ChartAreas[0].AxisX.ScaleView.Size < 2)
                        {
                            chart2.ChartAreas[0].AxisX.ScaleView.Size = 2;
                        }
                    }
                    else if ((e.X < (chart2.Size.Width / 2)) && (e.Y > (chart2.Size.Height / 2)))
                    {
                        int delta = (int)(chart2.ChartAreas[1].AxisX.ScaleView.Size / 100 + 1);

                        if (e.Delta > 0)
                        {
                            if ((chart2.ChartAreas[1].AxisX.ScaleView.Position + chart2.ChartAreas[1].AxisX.ScaleView.Size + delta) < chart2.ChartAreas[1].AxisX.Maximum)
                            {
                                chart2.ChartAreas[1].AxisX.ScaleView.Size += delta;
                            }
                            else
                            {
                                if (chart2.ChartAreas[1].AxisX.ScaleView.Position > delta)
                                {
                                    chart2.ChartAreas[1].AxisX.ScaleView.Position -= delta;
                                }
                                else if (chart1.ChartAreas[1].AxisX.ScaleView.Position > 0)
                                {
                                    chart2.ChartAreas[1].AxisX.ScaleView.Position -= 1;
                                }

                                chart2.ChartAreas[1].AxisX.ScaleView.Size = chart2.ChartAreas[1].AxisX.Maximum - chart2.ChartAreas[1].AxisX.ScaleView.Position;
                            }
                        }
                        else
                        {
                            if (chart2.ChartAreas[1].AxisX.ScaleView.Size > delta)
                            {
                                chart2.ChartAreas[1].AxisX.ScaleView.Size -= delta;
                            }
                        }

                        if (chart2.ChartAreas[1].AxisX.ScaleView.Size < 2)
                        {
                            chart2.ChartAreas[1].AxisX.ScaleView.Size = 2;
                        }
                    }
                    else if ((e.X > (chart2.Size.Width / 2)) && (e.Y < (chart2.Size.Height / 2)))
                    {
                        int delta = (int)(chart2.ChartAreas[2].AxisX.ScaleView.Size / 100 + 1);

                        if (e.Delta > 0)
                        {
                            if ((chart2.ChartAreas[2].AxisX.ScaleView.Position + chart2.ChartAreas[2].AxisX.ScaleView.Size + delta) < chart2.ChartAreas[2].AxisX.Maximum)
                            {
                                chart2.ChartAreas[2].AxisX.ScaleView.Size += delta;
                            }
                            else
                            {
                                if (chart2.ChartAreas[2].AxisX.ScaleView.Position > delta)
                                {
                                    chart2.ChartAreas[2].AxisX.ScaleView.Position -= delta;
                                }
                                else if (chart1.ChartAreas[2].AxisX.ScaleView.Position > 0)
                                {
                                    chart2.ChartAreas[2].AxisX.ScaleView.Position -= 1;
                                }

                                chart2.ChartAreas[2].AxisX.ScaleView.Size = chart2.ChartAreas[2].AxisX.Maximum - chart2.ChartAreas[2].AxisX.ScaleView.Position;
                            }
                        }
                        else
                        {
                            if (chart2.ChartAreas[2].AxisX.ScaleView.Size > delta)
                            {
                                chart2.ChartAreas[2].AxisX.ScaleView.Size -= delta;
                            }
                        }

                        if (chart2.ChartAreas[2].AxisX.ScaleView.Size < 2)
                        {
                            chart2.ChartAreas[2].AxisX.ScaleView.Size = 2;
                        }
                    }
                    else if ((e.X > (chart2.Size.Width / 2)) && (e.Y > (chart2.Size.Height / 2)))
                    {
                        int delta = (int)(chart2.ChartAreas[3].AxisX.ScaleView.Size / 100 + 1);

                        if (e.Delta > 0)
                        {
                            if ((chart2.ChartAreas[3].AxisX.ScaleView.Position + chart2.ChartAreas[3].AxisX.ScaleView.Size + delta) < chart2.ChartAreas[3].AxisX.Maximum)
                            {
                                chart2.ChartAreas[3].AxisX.ScaleView.Size += delta;
                            }
                            else
                            {
                                if (chart2.ChartAreas[3].AxisX.ScaleView.Position > delta)
                                {
                                    chart2.ChartAreas[3].AxisX.ScaleView.Position -= delta;
                                }
                                else if (chart1.ChartAreas[3].AxisX.ScaleView.Position > 0)
                                {
                                    chart2.ChartAreas[3].AxisX.ScaleView.Position -= 1;
                                }

                                chart2.ChartAreas[3].AxisX.ScaleView.Size = chart2.ChartAreas[3].AxisX.Maximum - chart2.ChartAreas[3].AxisX.ScaleView.Position;
                            }
                        }
                        else
                        {
                            if (chart2.ChartAreas[3].AxisX.ScaleView.Size > delta)
                            {
                                chart2.ChartAreas[3].AxisX.ScaleView.Size -= delta;
                            }
                        }

                        if (chart2.ChartAreas[3].AxisX.ScaleView.Size < 2)
                        {
                            chart2.ChartAreas[3].AxisX.ScaleView.Size = 2;
                        }
                    }
                }
            }
            catch
            { 
            
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            form1 = (Form1)this.Owner;  //两个窗体之间传输数据

            btClose.BackgroundImageLayout = ImageLayout.Zoom;
            btMin.BackgroundImageLayout = ImageLayout.Zoom;
            btStart.BackgroundImageLayout = ImageLayout.Zoom;
            btClear.BackgroundImageLayout = ImageLayout.Zoom;
            btExport.BackgroundImageLayout = ImageLayout.Zoom;

            labelWaveData.Parent = chart1;

            chart2CH1Data.Parent = chart2;
            chart2CH2Data.Parent = chart2;
            chart2CH3Data.Parent = chart2;
            chart2CH4Data.Parent = chart2;

            labelWaveData.Left = 10;
            labelWaveData.Top = 10;

            chart2CH1Data.Left = 10;
            chart2CH1Data.Top = 10;

            chart2CH2Data.Left = 10;
            chart2CH2Data.Top = 10;

            chart2CH3Data.Left = 10;
            chart2CH3Data.Top = 10;

            chart2CH4Data.Left = 10;
            chart2CH4Data.Top = 10;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = CH_QUEUE_SIZE;

            /*
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 0xff + 10;
            */

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = CH_QUEUE_SIZE;

            chart2.ChartAreas[1].AxisX.Minimum = 0;
            chart2.ChartAreas[1].AxisX.Maximum = CH_QUEUE_SIZE;

            chart2.ChartAreas[2].AxisX.Minimum = 0;
            chart2.ChartAreas[2].AxisX.Maximum = CH_QUEUE_SIZE;

            chart2.ChartAreas[3].AxisX.Minimum = 0;
            chart2.ChartAreas[3].AxisX.Maximum = CH_QUEUE_SIZE;

            chart1.ChartAreas[0].AxisX.ScaleView.Size = 100;
            //chart1.ChartAreas[0].AxisY.ScaleView.Size = 0xff;

            chart2.ChartAreas[0].AxisX.ScaleView.Size = 100;
            chart2.ChartAreas[1].AxisX.ScaleView.Size = 100;
            chart2.ChartAreas[2].AxisX.ScaleView.Size = 100;
            chart2.ChartAreas[3].AxisX.ScaleView.Size = 100;

            comBoxChNumber.Text = "1通道";
            coBoxDataType.Text = "uint8";
            coBoxWaveType.Text = "曲线";

            chart1.Series[0].Enabled = true;
            chart1.Series[1].Enabled = false;
            chart1.Series[2].Enabled = false;
            chart1.Series[3].Enabled = false;

            ChannelMax = ChannelEnum.CH1 + 1;
            ChannelIndex = ChannelEnum.CH1;
            WaveDataType = DataTypeEnum.DataUint8;

            this.chart1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseWheel);
            this.chart2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart2_MouseWheel);


            form1.SYSTEM_LOG("\r\n<串口示波器使用说明>\r\n" +
                            "1.串口示波器不对数据进行协议解析，NbComm接收的任何十六进制数据将直接作为波形显示；\r\n" +
                            "2.NbComm根据设定的通道个数以及数据类型，将接收的数据轮流分配至不同通道进行波形绘制；" +
                            " 数据分配规则如下:\r\n" +
                            " 1).例如设定3通道，数据类型为int16，下位机发送一帧6字节数据data:\r\n" +
                            " 通道1数据 = (data[0] << 8) | data[1],data[0]的最高位为符号位(1为负数，0为正数)\r\n" +
                            " 通道2数据 = (data[2] << 8) | data[3],data[2]的最高位为符号位(1为负数，0为正数)\r\n" +
                            " 通道3数据 = (data[4] << 8) | data[5],data[4]的最高位为符号位(1为负数，0为正数)\r\n" +
                            " 2).例如设定4通道，数据类型为uint32，下位机发送第一帧6字节数据data1:\r\n" +
                            " 通道1数据 = (data1[0] << 24) | (data1[1] << 16) | (data1[2] << 8) | data1[3]\r\n" +
                            " 剩余2字节不够组合成一位无符号32位整型数据，NbComm将等待下位机发送第二帧数据data2\r\n" +
                            " 通道2数据 = (data1[4] << 24) | (data1[5] << 16) | (data2[0] << 8) | data2[1]\r\n" +
                            "3.快捷键的使用:\r\n" +
                            " 1).使用滚轮进行波形放大缩小；\r\n" +
                            " 2).点击鼠标滚轮，波形复位至原始位置；\r\n" +
                            " 3).鼠标左键拖住波形显示区进行平移；\r\n"
                );

        }

        private void QueueUpdata(ChannelEnum ch, byte[] data, int len)
        {
            switch (ch)
            {
                case ChannelEnum.CH1:
                    {
                        if (Ch1Queue.Count > CH_QUEUE_SIZE)
                        {
                            for (int i = 0; i < len; i++)
                            {
                                Ch1Queue.Dequeue(); //先出列
                            }
                        }

                        for (int i = 0; i < len; i++)
                        {
                            Ch1Queue.Enqueue(data[i]); //再入列
                        }
                    }
                    break;

                case ChannelEnum.CH2:
                    {
                        if (Ch2Queue.Count > CH_QUEUE_SIZE)
                        {
                            for (int i = 0; i < len; i++)
                            {
                                Ch2Queue.Dequeue(); //先出列
                            }
                        }

                        for (int i = 0; i < len; i++)
                        {
                            Ch2Queue.Enqueue(data[i]); //再入列
                        }
                    }
                    break;

                case ChannelEnum.CH3:
                    {
                        if (Ch3Queue.Count > CH_QUEUE_SIZE)
                        {
                            for (int i = 0; i < len; i++)
                            {
                                Ch3Queue.Dequeue(); //先出列
                            }
                        }

                        for (int i = 0; i < len; i++)
                        {
                            Ch1Queue.Enqueue(data[i]); //再入列
                        }
                    }
                    break;

                case ChannelEnum.CH4:
                    {
                        if (Ch3Queue.Count > CH_QUEUE_SIZE)
                        {
                            for (int i = 0; i < len; i++)
                            {
                                Ch3Queue.Dequeue(); //先出列
                            }
                        }

                        for (int i = 0; i < len; i++)
                        {
                            Ch3Queue.Enqueue(data[i]); //再入列
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private delegate void CH1ValueDel(string text);
        private delegate void CH2ValueDel(string text);
        private delegate void CH3ValueDel(string text);
        private delegate void CH4ValueDel(string text);
        public void CH1ValueUpdata(string text)
        {
            if (WaveStartFlag == true)
            {
                if (CH1Value.InvokeRequired)
                {
                    CH1ValueDel d = new CH1ValueDel(CH1ValueUpdata);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    CH1Value.Text = text;
                }
            }
        }

        public void CH2ValueUpdata(string text)
        {
            if (WaveStartFlag == true)
            {
                if (CH1Value.InvokeRequired)
                {
                    CH1ValueDel d = new CH1ValueDel(CH2ValueUpdata);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    CH2Value.Text = text;
                }
            }
        }

        public void CH3ValueUpdata(string text)
        {
            if (WaveStartFlag == true)
            {
                if (CH1Value.InvokeRequired)
                {
                    CH1ValueDel d = new CH1ValueDel(CH3ValueUpdata);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    CH3Value.Text = text;
                }
            }
        }

        public void CH4ValueUpdata(string text)
        {
            if (WaveStartFlag == true)
            {
                if (CH1Value.InvokeRequired)
                {
                    CH1ValueDel d = new CH1ValueDel(CH4ValueUpdata);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    CH4Value.Text = text;
                }
            }
        }

        private void ChannelQueueUpdata(ChannelEnum ch, Int64 data)
        {
            switch (ch)
            {
                case ChannelEnum.CH1:
                    {
                        if (Ch1Queue.Count > CH_QUEUE_SIZE)
                        {
                            Ch1Queue.Dequeue(); //先出列
                        }

                        Ch1Queue.Enqueue(data); //再入列

                        CH1ValueUpdata(data.ToString());
                    }
                    break;

                case ChannelEnum.CH2:
                    {
                        if (Ch2Queue.Count > CH_QUEUE_SIZE)
                        {
                            Ch2Queue.Dequeue();
                        }

                        Ch2Queue.Enqueue(data);

                        CH2ValueUpdata(data.ToString());
                    }
                    break;

                case ChannelEnum.CH3:
                    {
                        if (Ch3Queue.Count > CH_QUEUE_SIZE)
                        {
                            Ch3Queue.Dequeue();
                        }

                        Ch3Queue.Enqueue(data);

                        CH3ValueUpdata(data.ToString());
                    }
                    break;

                case ChannelEnum.CH4:
                    {
                        if (Ch4Queue.Count > CH_QUEUE_SIZE)
                        {
                            Ch4Queue.Dequeue();
                        }

                        Ch4Queue.Enqueue(data);

                        CH4ValueUpdata(data.ToString());
                    }
                    break;

                default:
                    break;
            }
        }

        private byte[] DataByte = new byte[4];
        private UInt16 DataIndex = 0;
        public delegate void ChartUpdataDel(byte[] data, int len);
        public void WaveUpdata(byte[] data, int len)
        {
            int QueueDataCount = 0;
            Int64 QueueData = 0;

            for (int i = 0; i < len; i++)
            {
                QueueData = 0;

                if (WaveDataType == DataTypeEnum.DataInt8)
                {
                    if ((data[i] & 0x80) != 0)
                    {
                        QueueData = (Int16)(-(data[i] & 0x7F));
                    }
                    else
                    {
                        QueueData = data[i];
                    }

                    ChannelQueueUpdata(ChannelIndex, QueueData);
                    QueueDataCount++;

                    ChannelIndex++;
                    if (ChannelIndex >= ChannelMax)
                    {
                        ChannelIndex = ChannelEnum.CH1;
                    }
                }
                else if (WaveDataType == DataTypeEnum.DataUint8)
                {
                    QueueData = data[i];

                    ChannelQueueUpdata(ChannelIndex, QueueData);
                    QueueDataCount++;

                    ChannelIndex++;
                    if (ChannelIndex >= ChannelMax)
                    {
                        ChannelIndex = ChannelEnum.CH1;
                    }
                }
                else if (WaveDataType == DataTypeEnum.DataInt16)
                {
                    DataByte[DataIndex++] = data[i];

                    if (DataIndex >= 2)
                    {
                        DataIndex = 0;

                        if ((DataByte[0] & 0x80) != 0)
                        {
                            QueueData = -(((DataByte[0] << 8) | DataByte[1]) & 0x7fff);
                        }
                        else
                        {
                            QueueData = (DataByte[0] << 8) | DataByte[1];
                        }

                        ChannelQueueUpdata(ChannelIndex, QueueData);
                        QueueDataCount++;

                        ChannelIndex++;
                        if (ChannelIndex >= ChannelMax)
                        {
                            ChannelIndex = ChannelEnum.CH1;
                        }
                    }
                }
                else if (WaveDataType == DataTypeEnum.DataUint16)
                {
                    DataByte[DataIndex++] = data[i];

                    if (DataIndex >= 2)
                    {
                        DataIndex = 0;
                        QueueData = ((UInt16)DataByte[0] << 8) | (UInt16)DataByte[1];

                        ChannelQueueUpdata(ChannelIndex, QueueData);
                        QueueDataCount++;

                        ChannelIndex++;
                        if (ChannelIndex >= ChannelMax)
                        {
                            ChannelIndex = ChannelEnum.CH1;
                        }
                    }
                }
                else if (WaveDataType == DataTypeEnum.DataInt32)
                {
                    DataByte[DataIndex++] = data[i];

                    if (DataIndex >= 4)
                    {
                        DataIndex = 0;

                        if ((DataByte[0] & 0x80) != 0)
                        {
                            QueueData = -(((DataByte[0] << 24) | (DataByte[1] << 16) | (DataByte[2] << 8) | DataByte[3]) & 0x7fffffff);
                        }
                        else
                        {
                            QueueData = ((DataByte[0] << 24) | (DataByte[1] << 16) | (DataByte[2] << 8) | DataByte[3]);
                        }

                        ChannelQueueUpdata(ChannelIndex, QueueData);
                        QueueDataCount++;

                        ChannelIndex++;
                        if (ChannelIndex >= ChannelMax)
                        {
                            ChannelIndex = ChannelEnum.CH1;
                        }
                    }
                }
                else if (WaveDataType == DataTypeEnum.DataUint32)
                {
                    DataByte[DataIndex++] = data[i];

                    if (DataIndex >= 4)
                    {
                        DataIndex = 0;
                        QueueData = (((UInt32)DataByte[0] << 24) | ((UInt32)DataByte[1] << 16) | ((UInt32)DataByte[2] << 8) | (UInt32)DataByte[3]);

                        ChannelQueueUpdata(ChannelIndex, QueueData);
                        QueueDataCount++;

                        ChannelIndex++;
                        if (ChannelIndex >= ChannelMax)
                        {
                            ChannelIndex = ChannelEnum.CH1;
                        }
                    }
                }
            }

            if (WaveStartFlag == true)
            {
                if (radioBtSameSrc.Checked == true)
                {
                    chrt1WaveUpdata();

                }
                else
                {
                    chrt2WaveUpdata();
                }
            }
        }

        private delegate void chrt1WaveUpdataDelegate();
        private delegate void chrt2WaveUpdataDelegate();
        private void chrt1WaveUpdata()
        {
            if (chart1.InvokeRequired)
            {
                this.Invoke(new chrt1WaveUpdataDelegate(chrt1WaveUpdata));
            }
            else
            {
                if (chart1.Series[0].Enabled == true)
                {
                    chart1.Series[0].Points.Clear();
                    for (int i = 0; i < Ch1Queue.Count; i++)
                    {
                        chart1.Series[0].Points.AddXY(i, Ch1Queue.ElementAt(i));
                    }
                }

                if (chart1.Series[1].Enabled == true)
                {
                    chart1.Series[1].Points.Clear();
                    for (int i = 0; i < Ch2Queue.Count; i++)
                    {
                        chart1.Series[1].Points.AddXY(i, Ch2Queue.ElementAt(i));
                    }
                }

                if (chart1.Series[2].Enabled == true)
                {
                    chart1.Series[2].Points.Clear();
                    for (int i = 0; i < Ch3Queue.Count; i++)
                    {
                        chart1.Series[2].Points.AddXY(i, Ch3Queue.ElementAt(i));
                    }
                }

                if (chart1.Series[3].Enabled == true)
                {
                    chart1.Series[3].Points.Clear();
                    for (int i = 0; i < Ch4Queue.Count; i++)
                    {
                        chart1.Series[3].Points.AddXY(i, Ch4Queue.ElementAt(i));
                    }
                }

                /*X坐标轴随动*/
                if (Ch1Queue.Count >= (chart1.ChartAreas[0].AxisX.ScaleView.Position + chart1.ChartAreas[0].AxisX.ScaleView.Size))
                {
                    chart1.ChartAreas[0].AxisX.ScaleView.Position = Ch1Queue.Count - chart1.ChartAreas[0].AxisX.ScaleView.Size;
                }
                else
                {
                    if (Ch1Queue.Count < chart1.ChartAreas[0].AxisX.ScaleView.Size)
                    {
                        chart1.ChartAreas[0].AxisX.ScaleView.Position = 0;
                    }
                    else if (Ch1Queue.Count < chart1.ChartAreas[0].AxisX.ScaleView.Position)
                    {
                        chart1.ChartAreas[0].AxisX.ScaleView.Position = Ch1Queue.Count;
                    }
                }
            }
        }

        private void chrt2WaveUpdata()
        {
            if (chart2.InvokeRequired)
            {
                this.Invoke(new chrt2WaveUpdataDelegate(chrt2WaveUpdata));
            }
            else
            {
                if (chart2.Series[0].Enabled == true)
                {
                    chart2.Series[0].Points.Clear();
                    for (int i = 0; i < Ch1Queue.Count; i++)
                    {
                        chart2.Series[0].Points.AddXY(i, Ch1Queue.ElementAt(i));
                    }

                    if (Ch1Queue.Count >= (chart2.ChartAreas[0].AxisX.ScaleView.Position + chart2.ChartAreas[0].AxisX.ScaleView.Size))
                    {
                        chart2.ChartAreas[0].AxisX.ScaleView.Position = Ch1Queue.Count - chart2.ChartAreas[0].AxisX.ScaleView.Size;
                    }
                    else
                    {
                        if (Ch1Queue.Count < chart2.ChartAreas[0].AxisX.ScaleView.Size)
                        {
                            chart2.ChartAreas[0].AxisX.ScaleView.Position = 0;
                        }
                        else if (Ch1Queue.Count < chart2.ChartAreas[0].AxisX.ScaleView.Position)
                        {
                            chart2.ChartAreas[0].AxisX.ScaleView.Position = Ch1Queue.Count;
                        }
                    }
                }

                if (chart2.Series[1].Enabled == true)
                {
                    chart2.Series[1].Points.Clear();
                    for (int i = 0; i < Ch2Queue.Count; i++)
                    {
                        chart2.Series[1].Points.AddXY(i, Ch2Queue.ElementAt(i));
                    }

                    if (Ch2Queue.Count > (chart2.ChartAreas[1].AxisX.ScaleView.Position + chart2.ChartAreas[1].AxisX.ScaleView.Size))
                    {
                        chart2.ChartAreas[1].AxisX.ScaleView.Position = Ch2Queue.Count - chart2.ChartAreas[1].AxisX.ScaleView.Size;
                    }
                    else
                    {
                        if (Ch2Queue.Count < chart2.ChartAreas[1].AxisX.ScaleView.Size)
                        {
                            chart2.ChartAreas[1].AxisX.ScaleView.Position = 0;
                        }
                        else if (Ch2Queue.Count < chart2.ChartAreas[1].AxisX.ScaleView.Position)
                        {
                            chart2.ChartAreas[1].AxisX.ScaleView.Position = Ch2Queue.Count;
                        }
                    }
                }

                if (chart2.Series[2].Enabled == true)
                {
                    chart2.Series[2].Points.Clear();
                    for (int i = 0; i < Ch3Queue.Count; i++)
                    {
                        chart2.Series[2].Points.AddXY(i, Ch3Queue.ElementAt(i));
                    }

                    if (Ch3Queue.Count > (chart2.ChartAreas[2].AxisX.ScaleView.Position + chart2.ChartAreas[2].AxisX.ScaleView.Size))
                    {
                        chart2.ChartAreas[2].AxisX.ScaleView.Position = Ch3Queue.Count - chart2.ChartAreas[2].AxisX.ScaleView.Size;
                    }
                    else
                    {
                        if (Ch3Queue.Count < chart2.ChartAreas[2].AxisX.ScaleView.Size)
                        {
                            chart2.ChartAreas[2].AxisX.ScaleView.Position = 0;
                        }
                        else if (Ch3Queue.Count < chart2.ChartAreas[2].AxisX.ScaleView.Position)
                        {
                            chart2.ChartAreas[2].AxisX.ScaleView.Position = Ch3Queue.Count;
                        }
                    }
                }

                if (chart2.Series[3].Enabled == true)
                {
                    chart2.Series[3].Points.Clear();
                    for (int i = 0; i < Ch4Queue.Count; i++)
                    {
                        chart2.Series[3].Points.AddXY(i, Ch4Queue.ElementAt(i));
                    }

                    if (Ch4Queue.Count > (chart2.ChartAreas[3].AxisX.ScaleView.Position + chart2.ChartAreas[3].AxisX.ScaleView.Size))
                    {
                        chart2.ChartAreas[3].AxisX.ScaleView.Position = Ch4Queue.Count - chart2.ChartAreas[3].AxisX.ScaleView.Size;
                    }
                    else
                    {
                        if (Ch4Queue.Count < chart2.ChartAreas[3].AxisX.ScaleView.Size)
                        {
                            chart2.ChartAreas[3].AxisX.ScaleView.Position = 0;
                        }
                        else if (Ch4Queue.Count < chart2.ChartAreas[3].AxisX.ScaleView.Position)
                        {
                            chart2.ChartAreas[3].AxisX.ScaleView.Position = Ch4Queue.Count;
                        }
                    }
                }
            }
        }

        /* *********************************************************************************
        * 实现窗体拖动
        * *********************************************************************************/
        private bool beginMove = false;//初始化鼠标位置
        private int currentXPosition;
        private int currentYPosition;

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
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
            form1.form4Exist = false;
            this.Close();
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

        private void comBoxChNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxChNumber.Text == "1通道")
            {
                chart1.Series[0].Enabled = true;
                chart1.Series[1].Enabled = false;
                chart1.Series[2].Enabled = false;
                chart1.Series[3].Enabled = false;

                chart2.Series[0].Enabled = true;
                chart2.Series[1].Enabled = false;
                chart2.Series[2].Enabled = false;
                chart2.Series[3].Enabled = false;

                ChannelMax = (ChannelEnum)1;
            }
            else if (comBoxChNumber.Text == "2通道")
            {
                chart1.Series[0].Enabled = true;
                chart1.Series[1].Enabled = true;
                chart1.Series[2].Enabled = false;
                chart1.Series[3].Enabled = false;

                chart2.Series[0].Enabled = true;
                chart2.Series[1].Enabled = true;
                chart2.Series[2].Enabled = false;
                chart2.Series[3].Enabled = false;

                ChannelMax = (ChannelEnum)2;
            }
            else if (comBoxChNumber.Text == "3通道")
            {
                chart1.Series[0].Enabled = true;
                chart1.Series[1].Enabled = true;
                chart1.Series[2].Enabled = true;
                chart1.Series[3].Enabled = false;

                chart2.Series[0].Enabled = true;
                chart2.Series[1].Enabled = true;
                chart2.Series[2].Enabled = true;
                chart2.Series[3].Enabled = false;

                ChannelMax = (ChannelEnum)3;
            }
            else if (comBoxChNumber.Text == "4通道")
            {
                chart1.Series[0].Enabled = true;
                chart1.Series[1].Enabled = true;
                chart1.Series[2].Enabled = true;
                chart1.Series[3].Enabled = true;

                chart2.Series[0].Enabled = true;
                chart2.Series[1].Enabled = true;
                chart2.Series[2].Enabled = true;
                chart2.Series[3].Enabled = true;

                ChannelMax = (ChannelEnum)4;
            }
        }

        private void coBoxDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxDataType.Text == "int8")
            {
                WaveDataType = DataTypeEnum.DataInt8;
            }
            else if (coBoxDataType.Text == "uint8")
            {
                WaveDataType = DataTypeEnum.DataUint8;
            }
            else if (coBoxDataType.Text == "int16")
            {
                WaveDataType = DataTypeEnum.DataInt16;
            }
            else if (coBoxDataType.Text == "uint16")
            {
                WaveDataType = DataTypeEnum.DataUint16;
            }
            else if (coBoxDataType.Text == "int32")
            {
                WaveDataType = DataTypeEnum.DataInt32;
            }
            else if (coBoxDataType.Text == "uint32")
            {
                WaveDataType = DataTypeEnum.DataUint32;
            }
        }

        private void coBoxWaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxWaveType.Text == "曲线")
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart2.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart2.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            else if (coBoxWaveType.Text == "折线")
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart2.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart2.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            }
            else if (coBoxWaveType.Text == "打点")
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;

                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                chart2.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
                chart2.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            }
        }

        private bool mouseDowmFlag = false;
        private int labelChartX = 0;
        private int labelChartY = 0;
        private int LastXValue = 0;
        private int LastYValue = 0;

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDowmFlag = true;
            }
        }

        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDowmFlag = false;

            if (e.Button == MouseButtons.Middle)
            {
                chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset(0);
                chart1.ChartAreas[0].AxisX.ScaleView.Size = 100;
            }
        }

        private void chart1_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void chart1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDowmFlag == true)
            {
                //if (KeyXDown == true)
                {
                    int delta = (int)(chart1.ChartAreas[0].AxisX.ScaleView.Size / 100 + 1);

                    if ((LastXValue != 0) && ((e.X - LastXValue)) > 0)
                    {
                        if (chart1.ChartAreas[0].AxisX.ScaleView.Position > (delta - 1))
                        {
                            chart1.ChartAreas[0].AxisX.ScaleView.Position -= delta;
                        }
                        else
                        {
                            if (chart1.ChartAreas[0].AxisX.ScaleView.Position > chart1.ChartAreas[0].AxisX.Minimum)
                            {
                                chart1.ChartAreas[0].AxisX.ScaleView.Position -= 1;
                            }
                        }
                    }
                    else if ((LastXValue != 0) && ((e.X - LastXValue) < 0))
                    {
                        if ((chart1.ChartAreas[0].AxisX.ScaleView.Position + delta) < (chart1.ChartAreas[0].AxisX.Maximum - chart1.ChartAreas[0].AxisX.ScaleView.Size))
                        {
                            chart1.ChartAreas[0].AxisX.ScaleView.Position += delta;
                        }
                        else
                        {
                            chart1.ChartAreas[0].AxisX.ScaleView.Position = chart1.ChartAreas[0].AxisX.Maximum - chart1.ChartAreas[0].AxisX.ScaleView.Size;
                        }
                    }

                    LastXValue = e.X;
                }
                /*
                else if (KeyYDown == true)
                {
                    int delta = (int)(chart1.ChartAreas[0].AxisX.ScaleView.Size / 100 + 1);

                    if ((LastYValue != 0) && ((e.Y - LastYValue)) < 0)
                    {
                        if (chart1.ChartAreas[0].AxisY.ScaleView.Position > (delta - 1))
                        {
                            chart1.ChartAreas[0].AxisY.ScaleView.Position -= delta;
                        }
                        else
                        {
                            if (chart1.ChartAreas[0].AxisX.ScaleView.Position > 0)
                            {
                                chart1.ChartAreas[0].AxisX.ScaleView.Position -= 1;
                            }
                        }
                    }
                    else if ((LastYValue != 0) && ((e.Y - LastYValue) > 0))
                    {
                        if ((chart1.ChartAreas[0].AxisY.ScaleView.Position + delta) < (chart1.ChartAreas[0].AxisY.Maximum - chart1.ChartAreas[0].AxisY.ScaleView.Size))
                        {
                            chart1.ChartAreas[0].AxisY.ScaleView.Position += delta;
                        }
                        else
                        {
                            chart1.ChartAreas[0].AxisY.ScaleView.Position = chart1.ChartAreas[0].AxisY.Maximum - chart1.ChartAreas[0].AxisY.ScaleView.Size;
                        }
                    }

                    LastYValue = e.Y;
                }
                */
            }
            else
            {
                chart1.ChartAreas[0].CursorX.SetCursorPixelPosition(new PointF(e.X, e.Y), true);
                chart1.ChartAreas[0].CursorY.SetCursorPixelPosition(new PointF(e.X, e.Y), true);

                labelWaveData.Left += e.X - labelChartX;
                labelWaveData.Top += e.Y - labelChartY;

                labelChartX = e.X;
                labelChartY = e.Y;

                labelWaveData.Text = "X:" + chart1.ChartAreas[0].CursorX.Position.ToString() + "\r\n" +
                                     "Y:" + chart1.ChartAreas[0].CursorY.Position.ToString();
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "开  启")
            {
                btStart.Text = "关  闭";
                WaveStartFlag = true;

                btStart.BackgroundImage = Properties.Resources.btGreen80_32_rel;
            }
            else if (btStart.Text == "关  闭")
            {
                btStart.Text = "开  启";
                WaveStartFlag = false;

                btStart.BackgroundImage = Properties.Resources.btBlue80_32_rel;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            DataIndex = 0;
            ChannelIndex = 0;

            Ch1Queue.Clear();
            Ch2Queue.Clear();
            Ch3Queue.Clear();
            Ch4Queue.Clear();

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();

            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart2.Series[2].Points.Clear();
            chart2.Series[3].Points.Clear();

            CH1ValueUpdata("0");
            CH2ValueUpdata("0");
            CH3ValueUpdata("0");
            CH4ValueUpdata("0");
        }

        private void btStart_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btStart_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btClear_MouseDown(object sender, MouseEventArgs e)
        {
            btClear.ForeColor = SystemColors.ControlDark;
            btClear.BackgroundImage = Properties.Resources.btBlue80_32_pre;
        }

        private void btClear_MouseUp(object sender, MouseEventArgs e)
        {
            btClear.ForeColor = SystemColors.ControlLightLight;
            btClear.BackgroundImage = Properties.Resources.btBlue80_32_rel;
        }

        private void chart1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            KeyXDown = false;
            KeyYDown = false;
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'x') || (e.KeyChar == 'X'))
            {
                KeyXDown = true;
            }
            else if ((e.KeyChar == 'y') || (e.KeyChar == 'Y'))
            {
                KeyYDown = true;
            }
            else
            {
                KeyXDown = false;
                KeyYDown = false;
            }
        }

        private bool mouseChart2DowmFlag = false;
        private int labelCH1ChartX = 0;
        private int labelCH1ChartY = 0;
        private int labelCH2ChartX = 0;
        private int labelCH2ChartY = 0;
        private int labelCH3ChartX = 0;
        private int labelCH3ChartY = 0;
        private int labelCH4ChartX = 0;
        private int labelCH4ChartY = 0;
        private int Chart2CH1LastXValue = 0;
        private int Chart2CH2LastXValue = 0;
        private int Chart2CH3LastXValue = 0;
        private int Chart2CH4LastXValue = 0;
        private void chart2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseChart2DowmFlag = true;
            }
        }

        private void chart2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void chart2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void chart2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.X < (chart2.Size.Width / 2)) && (e.Y < (chart2.Size.Height / 2)))
            {
                if (mouseChart2DowmFlag == true)
                {
                    int delta = (int)(chart2.ChartAreas[0].AxisX.ScaleView.Size / 100 + 1);

                    if ((Chart2CH1LastXValue != 0) && ((e.X - Chart2CH1LastXValue)) > 0)
                    {
                        if (chart2.ChartAreas[0].AxisX.ScaleView.Position > (delta - 1))
                        {
                            chart2.ChartAreas[0].AxisX.ScaleView.Position -= delta;
                        }
                        else
                        {
                            if (chart2.ChartAreas[0].AxisX.ScaleView.Position > 0)
                            {
                                chart2.ChartAreas[0].AxisX.ScaleView.Position -= 1;
                            }
                        }
                    }
                    else if ((Chart2CH1LastXValue != 0) && ((e.X - Chart2CH1LastXValue) < 0))
                    {
                        if ((chart2.ChartAreas[0].AxisX.ScaleView.Position + delta) < (chart2.ChartAreas[0].AxisX.Maximum - chart2.ChartAreas[0].AxisX.ScaleView.Size))
                        {
                            chart2.ChartAreas[0].AxisX.ScaleView.Position += delta;
                        }
                        else
                        {
                            chart2.ChartAreas[0].AxisX.ScaleView.Position = chart2.ChartAreas[0].AxisX.Maximum - chart2.ChartAreas[0].AxisX.ScaleView.Size;
                        }
                    }

                    Chart2CH1LastXValue = e.X;
                }
                else
                {
                    chart2.ChartAreas[1].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[1].CursorY.IsUserEnabled = false;
                    chart2.ChartAreas[2].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[2].CursorY.IsUserEnabled = false;
                    chart2.ChartAreas[3].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[3].CursorY.IsUserEnabled = false;

                    chart2.ChartAreas[0].CursorX.SetCursorPixelPosition(new PointF(e.X, e.Y), true);
                    chart2.ChartAreas[0].CursorY.SetCursorPixelPosition(new PointF(e.X, e.Y), true);

                    chart2CH1Data.Left += e.X - labelCH1ChartX;
                    chart2CH1Data.Top += e.Y - labelCH1ChartY;

                    labelCH1ChartX = e.X;
                    labelCH1ChartY = e.Y;

                    chart2CH1Data.Visible = true;
                    chart2CH2Data.Visible = false;
                    chart2CH3Data.Visible = false;
                    chart2CH4Data.Visible = false;

                    chart2CH1Data.Text = "X:" + chart2.ChartAreas[0].CursorX.Position.ToString() + "\r\n" +
                                         "Y:" + chart2.ChartAreas[0].CursorY.Position.ToString();
                }
            }
            else if ((e.X < (chart2.Size.Width / 2)) && (e.Y > (chart2.Size.Height / 2)))
            {
                if (mouseChart2DowmFlag == true)
                {
                    int delta = (int)(chart2.ChartAreas[1].AxisX.ScaleView.Size / 100 + 1);

                    if ((Chart2CH2LastXValue != 0) && ((e.X - Chart2CH2LastXValue)) > 0)
                    {
                        if (chart2.ChartAreas[1].AxisX.ScaleView.Position > (delta - 1))
                        {
                            chart2.ChartAreas[1].AxisX.ScaleView.Position -= delta;
                        }
                        else
                        {
                            if (chart2.ChartAreas[1].AxisX.ScaleView.Position > 0)
                            {
                                chart2.ChartAreas[1].AxisX.ScaleView.Position -= 1;
                            }
                        }
                    }
                    else if ((Chart2CH2LastXValue != 0) && ((e.X - Chart2CH2LastXValue) < 0))
                    {
                        if ((chart2.ChartAreas[1].AxisX.ScaleView.Position + delta) < (chart2.ChartAreas[1].AxisX.Maximum - chart2.ChartAreas[1].AxisX.ScaleView.Size))
                        {
                            chart2.ChartAreas[1].AxisX.ScaleView.Position += delta;
                        }
                        else
                        {
                            chart2.ChartAreas[1].AxisX.ScaleView.Position = chart2.ChartAreas[1].AxisX.Maximum - chart2.ChartAreas[1].AxisX.ScaleView.Size;
                        }
                    }

                    Chart2CH2LastXValue = e.X;
                }
                else
                {
                    chart2.ChartAreas[0].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[0].CursorY.IsUserEnabled = false;
                    chart2.ChartAreas[2].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[2].CursorY.IsUserEnabled = false;
                    chart2.ChartAreas[3].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[3].CursorY.IsUserEnabled = false;

                    chart2.ChartAreas[1].CursorX.SetCursorPixelPosition(new PointF(e.X, e.Y), true);
                    chart2.ChartAreas[1].CursorY.SetCursorPixelPosition(new PointF(e.X, e.Y), true);

                    chart2CH2Data.Left += e.X - labelCH2ChartX;
                    chart2CH2Data.Top += e.Y - labelCH2ChartY;

                    labelCH2ChartX = e.X;
                    labelCH2ChartY = e.Y;

                    chart2CH1Data.Visible = false;
                    chart2CH2Data.Visible = true;
                    chart2CH3Data.Visible = false;
                    chart2CH4Data.Visible = false;

                    chart2CH2Data.Text = "X:" + chart2.ChartAreas[1].CursorX.Position.ToString() + "\r\n" +
                                         "Y:" + chart2.ChartAreas[1].CursorY.Position.ToString();
                }
            }
            else if ((e.X > (chart2.Size.Width / 2)) && (e.Y < (chart2.Size.Height / 2)))
            {
                if (mouseChart2DowmFlag == true)
                {
                    int delta = (int)(chart2.ChartAreas[2].AxisX.ScaleView.Size / 100 + 1);

                    if ((Chart2CH3LastXValue != 0) && ((e.X - Chart2CH3LastXValue)) > 0)
                    {
                        if (chart2.ChartAreas[2].AxisX.ScaleView.Position > (delta - 1))
                        {
                            chart2.ChartAreas[2].AxisX.ScaleView.Position -= delta;
                        }
                        else
                        {
                            if (chart2.ChartAreas[2].AxisX.ScaleView.Position > 0)
                            {
                                chart2.ChartAreas[2].AxisX.ScaleView.Position -= 1;
                            }
                        }
                    }
                    else if ((Chart2CH3LastXValue != 0) && ((e.X - Chart2CH3LastXValue) < 0))
                    {
                        if ((chart2.ChartAreas[2].AxisX.ScaleView.Position + delta) < (chart2.ChartAreas[2].AxisX.Maximum - chart2.ChartAreas[2].AxisX.ScaleView.Size))
                        {
                            chart2.ChartAreas[2].AxisX.ScaleView.Position += delta;
                        }
                        else
                        {
                            chart2.ChartAreas[2].AxisX.ScaleView.Position = chart2.ChartAreas[2].AxisX.Maximum - chart2.ChartAreas[2].AxisX.ScaleView.Size;
                        }
                    }

                    Chart2CH3LastXValue = e.X;
                }
                else
                {
                    chart2.ChartAreas[0].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[0].CursorY.IsUserEnabled = false;
                    chart2.ChartAreas[1].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[1].CursorY.IsUserEnabled = false;
                    chart2.ChartAreas[3].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[3].CursorY.IsUserEnabled = false;

                    chart2.ChartAreas[2].CursorX.SetCursorPixelPosition(new PointF(e.X, e.Y), true);
                    chart2.ChartAreas[2].CursorY.SetCursorPixelPosition(new PointF(e.X, e.Y), true);

                    chart2CH3Data.Left += e.X - labelCH3ChartX;
                    chart2CH3Data.Top += e.Y - labelCH3ChartY;

                    labelCH3ChartX = e.X;
                    labelCH3ChartY = e.Y;

                    chart2CH1Data.Visible = false;
                    chart2CH2Data.Visible = false;
                    chart2CH3Data.Visible = true;
                    chart2CH4Data.Visible = false;

                    chart2CH3Data.Text = "X:" + chart2.ChartAreas[2].CursorX.Position.ToString() + "\r\n" +
                                         "Y:" + chart2.ChartAreas[2].CursorY.Position.ToString();
                }
            }
            else if ((e.X > (chart2.Size.Width / 2)) && (e.Y > (chart2.Size.Height / 2)))
            {
                if (mouseChart2DowmFlag == true)
                {
                    int delta = (int)(chart2.ChartAreas[3].AxisX.ScaleView.Size / 100 + 1);

                    if ((Chart2CH4LastXValue != 0) && ((e.X - Chart2CH4LastXValue)) > 0)
                    {
                        if (chart2.ChartAreas[3].AxisX.ScaleView.Position > (delta - 1))
                        {
                            chart2.ChartAreas[3].AxisX.ScaleView.Position -= delta;
                        }
                        else
                        {
                            if (chart2.ChartAreas[3].AxisX.ScaleView.Position > 0)
                            {
                                chart2.ChartAreas[3].AxisX.ScaleView.Position -= 1;
                            }
                        }
                    }
                    else if ((Chart2CH4LastXValue != 0) && ((e.X - Chart2CH4LastXValue) < 0))
                    {
                        if ((chart2.ChartAreas[3].AxisX.ScaleView.Position + delta) < (chart2.ChartAreas[3].AxisX.Maximum - chart2.ChartAreas[3].AxisX.ScaleView.Size))
                        {
                            chart2.ChartAreas[3].AxisX.ScaleView.Position += delta;
                        }
                        else
                        {
                            chart2.ChartAreas[3].AxisX.ScaleView.Position = chart2.ChartAreas[3].AxisX.Maximum - chart2.ChartAreas[3].AxisX.ScaleView.Size;
                        }
                    }

                    Chart2CH4LastXValue = e.X;
                }
                else
                {
                    chart2.ChartAreas[0].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[0].CursorY.IsUserEnabled = false;
                    chart2.ChartAreas[1].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[1].CursorY.IsUserEnabled = false;
                    chart2.ChartAreas[2].CursorX.IsUserEnabled = false;
                    chart2.ChartAreas[2].CursorY.IsUserEnabled = false;

                    chart2.ChartAreas[3].CursorX.SetCursorPixelPosition(new PointF(e.X, e.Y), true);
                    chart2.ChartAreas[3].CursorY.SetCursorPixelPosition(new PointF(e.X, e.Y), true);

                    chart2CH4Data.Left += e.X - labelCH4ChartX;
                    chart2CH4Data.Top += e.Y - labelCH4ChartY;

                    labelCH4ChartX = e.X;
                    labelCH4ChartY = e.Y;

                    chart2CH1Data.Visible = false;
                    chart2CH2Data.Visible = false;
                    chart2CH3Data.Visible = false;
                    chart2CH4Data.Visible = true;

                    chart2CH4Data.Text = "X:" + chart2.ChartAreas[3].CursorX.Position.ToString() + "\r\n" +
                                         "Y:" + chart2.ChartAreas[3].CursorY.Position.ToString();
                }
            }
        }

        private void chart2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseChart2DowmFlag = false;
        }

        private class Supply
        {
            public string CH1Value { get; set; }
            public string CH2Value { get; set; }
            public string CH3Value { get; set; }
            public string CH4Value { get; set; }
        }

        private void WaveWriteExcelNpoi()
        {
            IWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1"); //创建一个名称为Sheet的表;
            IRow row = sheet.CreateRow(0); //第一行写标题名称

            List<Supply> WaveData = new List<Supply>();

            if (ChannelMax == (ChannelEnum)1)
            {
                row.CreateCell(0).SetCellValue("通道1"); //第一列标题

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    WaveData.Add(new Supply
                    {
                        CH1Value = Ch1Queue.ElementAt(i).ToString(),
                    });
                }
            }
            else if (ChannelMax == (ChannelEnum)2)
            {
                row.CreateCell(0).SetCellValue("通道1"); //第一列标题
                row.CreateCell(1).SetCellValue("通道2"); //第一列标题

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch2Queue.Count)
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                            CH2Value = Ch2Queue.ElementAt(i).ToString(),
                        });
                    }
                    else
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                        });
                    }
                }
            }
            else if (ChannelMax == (ChannelEnum)3)
            {
                row.CreateCell(0).SetCellValue("通道1"); //第一列标题
                row.CreateCell(1).SetCellValue("通道2"); //第一列标题
                row.CreateCell(2).SetCellValue("通道3"); //第一列标题

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch3Queue.Count)
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                            CH2Value = Ch2Queue.ElementAt(i).ToString(),
                            CH3Value = Ch3Queue.ElementAt(i).ToString(),
                        });
                    }
                    else if (i < Ch2Queue.Count)
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                            CH2Value = Ch2Queue.ElementAt(i).ToString(),
                        });
                    }
                    else
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                        });
                    }
                }
            }
            else if (ChannelMax == (ChannelEnum)4)
            {
                row.CreateCell(0).SetCellValue("通道1"); //第一列标题
                row.CreateCell(1).SetCellValue("通道2"); //第一列标题
                row.CreateCell(2).SetCellValue("通道3"); //第一列标题
                row.CreateCell(3).SetCellValue("通道4"); //第一列标题

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch4Queue.Count)
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                            CH2Value = Ch2Queue.ElementAt(i).ToString(),
                            CH3Value = Ch3Queue.ElementAt(i).ToString(),
                            CH4Value = Ch4Queue.ElementAt(i).ToString(),
                        });
                    }
                    else if (i < Ch3Queue.Count)
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                            CH2Value = Ch2Queue.ElementAt(i).ToString(),
                            CH3Value = Ch3Queue.ElementAt(i).ToString(),
                        });
                    }
                    else if (i < Ch2Queue.Count)
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                            CH2Value = Ch2Queue.ElementAt(i).ToString(),
                        });
                    }
                    else
                    {
                        WaveData.Add(new Supply
                        {
                            CH1Value = Ch1Queue.ElementAt(i).ToString(),
                        });
                    }
                }
            }

            for (int i = 0; i < WaveData.Count; i++) //每一行依次写入
            {
                row = sheet.CreateRow(i + 1);//写入的行号递加
                if (ChannelMax == (ChannelEnum)1)
                {
                    row.CreateCell(0).SetCellValue(WaveData[i].CH1Value);//通道1数据
                }
                else if (ChannelMax == (ChannelEnum)2)
                {
                    row.CreateCell(0).SetCellValue(WaveData[i].CH1Value);//通道1数据
                    row.CreateCell(1).SetCellValue(WaveData[i].CH2Value);//通道2数据
                }
                else if (ChannelMax == (ChannelEnum)3)
                {
                    row.CreateCell(0).SetCellValue(WaveData[i].CH1Value);//通道1数据
                    row.CreateCell(1).SetCellValue(WaveData[i].CH2Value);//通道2数据
                    row.CreateCell(2).SetCellValue(WaveData[i].CH3Value);//通道3数据
                }
                else if (ChannelMax == (ChannelEnum)4)
                {
                    row.CreateCell(0).SetCellValue(WaveData[i].CH1Value);//通道1数据
                    row.CreateCell(1).SetCellValue(WaveData[i].CH2Value);//通道2数据
                    row.CreateCell(2).SetCellValue(WaveData[i].CH3Value);//通道3数据
                    row.CreateCell(3).SetCellValue(WaveData[i].CH4Value);//通道4数据
                }
            }

            FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Append, FileAccess.Write); //文件写入的位置
            workbook.Write(fs); //向打开的这个xls文件中写入数据 
            workbook.Close();
            fs.Close();
        }

        private bool WaveWriteExcelOffice()
        {
            Microsoft.Office.Interop.Excel.Application xls = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook book = xls.Workbooks.Add(Missing.Value); //创建一张表，一张表可以包含多个sheet

            //如果表已经存在，可以用下面的命令打开
            //_Workbook book = xls.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);

            Microsoft.Office.Interop.Excel._Worksheet sheet;           //定义sheet变量
            xls.Visible = false;        //Excel后台运行
            xls.DisplayAlerts = false;  //不显示确认修改提示

            try
            {
                sheet = book.Worksheets.get_Item(1); //获得第1个sheet，准备写入
            }
            catch (Exception ex) //不存在就增加一个sheet
            {
                sheet = book.Worksheets.Add(Missing.Value, book.Worksheets[book.Sheets.Count], 1, Missing.Value);
            }
            sheet.Name = "Sheet1"; //设置当前sheet的Name

            if (ChannelMax == (ChannelEnum)1)
            {
                sheet.Cells[1, 1] = "CH1";

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                }

            }
            else if (ChannelMax == (ChannelEnum)2)
            {
                sheet.Cells[1, 1] = "CH1";
                sheet.Cells[1, 2] = "CH2";

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch2Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                    }
                    else
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                    }
                }
            }
            else if (ChannelMax == (ChannelEnum)3)
            {
                sheet.Cells[1, 1] = "CH1";
                sheet.Cells[1, 2] = "CH2";
                sheet.Cells[1, 3] = "CH3";

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch3Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 3] = Ch3Queue.ElementAt(i).ToString();
                    }
                    else if (i < Ch2Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                    }
                    else
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                    }
                }
            }
            else if (ChannelMax == (ChannelEnum)4)
            {
                sheet.Cells[1, 1] = "CH1";
                sheet.Cells[1, 2] = "CH2";
                sheet.Cells[1, 3] = "CH3";
                sheet.Cells[1, 4] = "CH4";

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch4Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 3] = Ch3Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 4] = Ch4Queue.ElementAt(i).ToString();
                    }
                    else if (i < Ch3Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 3] = Ch3Queue.ElementAt(i).ToString();
                    }
                    else if (i < Ch2Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                    }
                    else
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                    }
                }
            }

            //将表另存为
            book.SaveAs(saveFileDialog1.FileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            //如果表已经存在，直接用下面的命令保存即可
            //book.Save();

            book.Close(false, Missing.Value, Missing.Value);//关闭打开的表
            xls.Quit();//Excel程序退出
            //sheet,book,xls设置为null，防止内存泄露
            sheet = null;
            book = null;
            xls = null;
            GC.Collect();//系统回收资源

            return true;
        }

        private bool WaveWriteExcelWps()
        {
            Excel.Application xls = new Excel.Application();
            Excel._Workbook book = xls.Workbooks.Add(Missing.Value);

            Excel._Worksheet sheet;     //定义sheet变量
            xls.Visible = false;        //Excel后台运行
            xls.DisplayAlerts = false;  //不显示确认修改提示

            try
            {
                sheet = book.Worksheets.get_Item(1); //获得第1个sheet，准备写入
            }
            catch (Exception ex) //不存在就增加一个sheet
            {
                sheet = book.Worksheets.Add(Missing.Value, book.Worksheets[book.Sheets.Count], 1, Missing.Value);
            }
            sheet.Name = "Sheet1"; //设置当前sheet的Name

            if (ChannelMax == (ChannelEnum)1)
            {
                sheet.Cells[1, 1] = "CH1";

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                }

            }
            else if (ChannelMax == (ChannelEnum)2)
            {
                sheet.Cells[1, 1] = "CH1";
                sheet.Cells[1, 2] = "CH2";

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch2Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                    }
                    else
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                    }
                }
            }
            else if (ChannelMax == (ChannelEnum)3)
            {
                sheet.Cells[1, 1] = "CH1";
                sheet.Cells[1, 2] = "CH2";
                sheet.Cells[1, 3] = "CH3";

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch3Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 3] = Ch3Queue.ElementAt(i).ToString();
                    }
                    else if (i < Ch2Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                    }
                    else
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                    }
                }
            }
            else if (ChannelMax == (ChannelEnum)4)
            {
                sheet.Cells[1, 1] = "CH1";
                sheet.Cells[1, 2] = "CH2";
                sheet.Cells[1, 3] = "CH3";
                sheet.Cells[1, 4] = "CH4";

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch4Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 3] = Ch3Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 4] = Ch4Queue.ElementAt(i).ToString();
                    }
                    else if (i < Ch3Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 3] = Ch3Queue.ElementAt(i).ToString();
                    }
                    else if (i < Ch2Queue.Count)
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                        sheet.Cells[i + 2, 2] = Ch2Queue.ElementAt(i).ToString();
                    }
                    else
                    {
                        sheet.Cells[i + 2, 1] = Ch1Queue.ElementAt(i).ToString();
                    }
                }
            }

            //将表另存为
            book.SaveAs(saveFileDialog1.FileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            book.Close(false, Missing.Value, Missing.Value);//关闭打开的表
            xls.Quit();//Excel程序退出

            sheet = null;
            book = null;
            xls = null;
            GC.Collect();//系统回收资源

            return true;
        }

        private void WaveDataWriteExcel()
        {
            try
            {
                WaveWriteExcelWps();
            }
            catch
            {
                try
                {
                    WaveWriteExcelOffice();
                }
                catch
                {
                    try
                    {
                        WaveWriteExcelNpoi();
                    }
                    catch 
                    {
                        form1.SYSTEM_LOG("缺少Excel组件\r\n");
                    }
                }
            }
        }

        private void WaveDataWriteText()
        {
            string WaveText = "";
            string str = "";
            int TextLength = 0;

            if (ChannelMax == (ChannelEnum)1)
            {
                WaveText += "CH1\r\n";

                TextLength = Ch1Queue.Max().ToString().Length;

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                    WaveText += str + ",\r\n";
                }
            }
            else if (ChannelMax == (ChannelEnum)2)
            {
                WaveText += "CH1,CH2\r\n";

                TextLength = Ch1Queue.Max().ToString().Length;
                if (TextLength < Ch2Queue.Max().ToString().Length)
                {
                    TextLength = Ch2Queue.Max().ToString().Length;
                }

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch2Queue.Count)
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch2Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                    else
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                }
            }
            else if (ChannelMax == (ChannelEnum)3)
            {
                WaveText += "CH1,CH2,CH3\r\n";

                TextLength = Ch1Queue.Max().ToString().Length;
                if (TextLength < Ch2Queue.Max().ToString().Length)
                {
                    TextLength = Ch2Queue.Max().ToString().Length;
                }
                if (TextLength < Ch3Queue.Max().ToString().Length)
                {
                    TextLength = Ch3Queue.Max().ToString().Length;
                }

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch3Queue.Count)
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch2Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch3Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                    else if (i < Ch2Queue.Count)
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch2Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                    else
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                }
            }
            else if (ChannelMax == (ChannelEnum)4)
            {
                WaveText += "CH1,CH2,CH3,CH4\r\n";

                TextLength = Ch1Queue.Max().ToString().Length;
                if (TextLength < Ch2Queue.Max().ToString().Length)
                {
                    TextLength = Ch2Queue.Max().ToString().Length;
                }
                if (TextLength < Ch3Queue.Max().ToString().Length)
                {
                    TextLength = Ch3Queue.Max().ToString().Length;
                }
                if (TextLength < Ch4Queue.Max().ToString().Length)
                {
                    TextLength = Ch4Queue.Max().ToString().Length;
                }

                for (int i = 0; i < Ch1Queue.Count; i++)
                {
                    if (i < Ch4Queue.Count)
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch2Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch3Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch4Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                    else if (i < Ch3Queue.Count)
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch2Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch3Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                    else if (i < Ch2Queue.Count)
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0') + ",";
                        str += Ch2Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                    else
                    {
                        str = Ch1Queue.ElementAt(i).ToString().PadLeft(TextLength, '0');

                        WaveText += str + ",\r\n";
                    }
                }
            }

            StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName, true);
            streamWriter.Write(WaveText);
            streamWriter.Close();
        }

        private string WaveFilePath = "";

        private void btExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.xlsx)|*.xlsx|(*.txt)|*.txt|(*.*)|*.*";
            saveFileDialog1.FileName = "WaveData_" + DateTime.Now.ToString("yyyyMMddHHmm");// ".xlsx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.RestoreDirectory = true;

                WaveFilePath = saveFileDialog1.FileName;

                string ext = Path.GetExtension(saveFileDialog1.FileName);
                string txtName = ".txt";
                string xlsxName = ".xlsx";

                if (txtName.Equals(ext, StringComparison.OrdinalIgnoreCase))
                {
                    WaveDataWriteText();
                }
                else if (xlsxName.Equals(ext, StringComparison.OrdinalIgnoreCase))
                {
                    WaveDataWriteExcel();
                }
            }
        }

        private void btExport_MouseDown(object sender, MouseEventArgs e)
        {
            btExport.ForeColor = SystemColors.ControlDark;
            btExport.BackgroundImage = Properties.Resources.btExport_pre;
        }

        private void btExport_MouseUp(object sender, MouseEventArgs e)
        {
            btExport.ForeColor = SystemColors.ControlLightLight;
            btExport.BackgroundImage = Properties.Resources.btExport_rel;
        }
    }
}
