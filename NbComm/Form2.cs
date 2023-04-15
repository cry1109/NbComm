using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Threading;

namespace NbComm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 form1 = new Form1();

        private byte[] TxByte; //发送字节

        private delegate void PtlLogUpdata(string text);
        private void PTL_LOG(string log)
        {
            log = DateTime.Now.ToLongTimeString().ToString() + ":" + log;

            if (textBoxLog.InvokeRequired)
            {
                PtlLogUpdata d = new PtlLogUpdata(PTL_LOG);
                this.Invoke(d, new object[] { log });
            }
            else
            {
                textBoxLog.AppendText(log);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btClose.BackgroundImageLayout = ImageLayout.Zoom;
            btMin.BackgroundImageLayout = ImageLayout.Zoom;

            btFileSend1.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend2.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend3.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend4.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend5.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend6.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend7.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend8.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend9.BackgroundImageLayout = ImageLayout.Zoom;
            btFileSend10.BackgroundImageLayout = ImageLayout.Zoom;

            btPtlStart.BackgroundImageLayout = ImageLayout.Zoom;
            btClearLog.BackgroundImageLayout = ImageLayout.Zoom;

            btMin.BackgroundImageLayout = ImageLayout.Zoom;
            btClose.BackgroundImageLayout = ImageLayout.Zoom;

            textBoxLog.Text = "自定义协议:\r\n" +
                              "1.允许存放10条自定义的协议，可单独发送或多协议循环发送；\r\n" +
                              "2.开启协议传输后，将按照协议序号依次发送所选中的协议；\r\n" +
                              "3.传输间隔：每条协议发的发送间隔；\r\n" +
                              "4.闭环协议：主机发送的每条协议均需要等待从机返回数据，NbComm只有在接收到从机返回的数据后才继续下一动作；\r\n" +
                              "5.等待超时：开启闭环协议后若从机在该时间内未返回数据，NbComm继续发送下一条协议；\r\n" +
                              "6.超时退出：开启闭环协议后若从机在该时间内未返回数据，NbComm退出协议流程；\r\n" +
                              "7.自动重发：开启闭环协议后若从机在该时间内未返回数据，NbComm重复发送本次指令；\r\n" +
                              "8.重发次数：NbComm重复发送指令的次数；\r\n";

            if (Properties.Settings.Default.UserPtl01Hex == true)
            {
                radioButtonTxHex01.Checked = true;
                radioButtonTxAsc01.Checked = false;
            }
            else
            {
                radioButtonTxHex01.Checked = false;
                radioButtonTxAsc01.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl02Hex == true)
            {
                radioButtonTxHex02.Checked = true;
                radioButtonTxAsc02.Checked = false;
            }
            else
            {
                radioButtonTxHex02.Checked = false;
                radioButtonTxAsc02.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl03Hex == true)
            {
                radioButtonTxHex03.Checked = true;
                radioButtonTxAsc03.Checked = false;
            }
            else
            {
                radioButtonTxHex03.Checked = false;
                radioButtonTxAsc03.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl04Hex == true)
            {
                radioButtonTxHex04.Checked = true;
                radioButtonTxAsc04.Checked = false;
            }
            else
            {
                radioButtonTxHex04.Checked = false;
                radioButtonTxAsc04.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl05Hex == true)
            {
                radioButtonTxHex05.Checked = true;
                radioButtonTxAsc05.Checked = false;
            }
            else
            {
                radioButtonTxHex05.Checked = false;
                radioButtonTxAsc05.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl06Hex == true)
            {
                radioButtonTxHex06.Checked = true;
                radioButtonTxAsc06.Checked = false;
            }
            else
            {
                radioButtonTxHex06.Checked = false;
                radioButtonTxAsc06.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl07Hex == true)
            {
                radioButtonTxHex07.Checked = true;
                radioButtonTxAsc07.Checked = false;
            }
            else
            {
                radioButtonTxHex07.Checked = false;
                radioButtonTxAsc07.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl08Hex == true)
            {
                radioButtonTxHex08.Checked = true;
                radioButtonTxAsc08.Checked = false;
            }
            else
            {
                radioButtonTxHex08.Checked = false;
                radioButtonTxAsc08.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl09Hex == true)
            {
                radioButtonTxHex09.Checked = true;
                radioButtonTxAsc09.Checked = false;
            }
            else
            {
                radioButtonTxHex09.Checked = false;
                radioButtonTxAsc09.Checked = true;
            }

            if (Properties.Settings.Default.UserPtl10Hex == true)
            {
                radioButtonTxHex10.Checked = true;
                radioButtonTxAsc10.Checked = false;
            }
            else
            {
                radioButtonTxHex10.Checked = false;
                radioButtonTxAsc10.Checked = true;
            }

            UserPtl01.Text = Properties.Settings.Default.UserPtl01;
            UserPtl02.Text = Properties.Settings.Default.UserPtl02;
            UserPtl03.Text = Properties.Settings.Default.UserPtl03;
            UserPtl04.Text = Properties.Settings.Default.UserPtl04;
            UserPtl05.Text = Properties.Settings.Default.UserPtl05;
            UserPtl06.Text = Properties.Settings.Default.UserPtl06;
            UserPtl07.Text = Properties.Settings.Default.UserPtl07;
            UserPtl08.Text = Properties.Settings.Default.UserPtl08;
            UserPtl09.Text = Properties.Settings.Default.UserPtl09;
            UserPtl10.Text = Properties.Settings.Default.UserPtl10;

            textBox1.Text = Properties.Settings.Default.UserPtl01Not;
            textBox3.Text = Properties.Settings.Default.UserPtl02Not;
            textBox5.Text = Properties.Settings.Default.UserPtl03Not;
            textBox7.Text = Properties.Settings.Default.UserPtl04Not;
            textBox9.Text = Properties.Settings.Default.UserPtl05Not;
            textBox11.Text = Properties.Settings.Default.UserPtl06Not;
            textBox13.Text = Properties.Settings.Default.UserPtl07Not;
            textBox15.Text = Properties.Settings.Default.UserPtl08Not;
            textBox17.Text = Properties.Settings.Default.UserPtl09Not;
            textBox19.Text = Properties.Settings.Default.UserPtl10Not;

            form1 = (Form1)this.Owner;  //两个窗体之间传输数据
        }

        /**********************************************************************************
        *  函数名称：UserPtlFunction()
        *  描    述：用户自定义协议功能
        *  输    入：cmdIndex:指定的命令
        *  输    出：无
        **********************************************************************************/
        private void PtlCmdSend(int cmdIndex)
        {
            if (form1.serialPort1.IsOpen == true)
            {
                switch (cmdIndex)
                {
                    case 1:
                        {
                            if (radioButtonTxAsc01.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl01.Text);
                            }
                            else if (radioButtonTxHex01.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl01.Text);
                            }
                        }
                        break;

                    case 2:
                        {
                            if (radioButtonTxAsc02.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl02.Text);
                            }
                            else if (radioButtonTxHex02.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl02.Text);
                            }
                        }
                        break;

                    case 3:
                        {
                            if (radioButtonTxAsc03.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl03.Text);
                            }
                            else if (radioButtonTxHex03.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl03.Text);
                            }
                        }
                        break;

                    case 4:
                        {
                            if (radioButtonTxAsc04.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl04.Text);
                            }
                            else if (radioButtonTxHex04.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl04.Text);
                            }
                        }
                        break;

                    case 5:
                        {
                            if (radioButtonTxAsc05.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl05.Text);
                            }
                            else if (radioButtonTxHex05.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl05.Text);
                            }
                        }
                        break;

                    case 6:
                        {
                            if (radioButtonTxAsc06.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl06.Text);
                            }
                            else if (radioButtonTxHex06.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl06.Text);
                            }
                        }
                        break;

                    case 7:
                        {
                            if (radioButtonTxAsc07.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl07.Text);
                            }
                            else if (radioButtonTxHex07.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl07.Text);
                            }
                        }
                        break;

                    case 8:
                        {
                            if (radioButtonTxAsc08.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl08.Text);
                            }
                            else if (radioButtonTxHex08.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl08.Text);
                            }
                        }
                        break;

                    case 9:
                        {
                            if (radioButtonTxAsc09.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl09.Text);
                            }
                            else if (radioButtonTxHex09.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl09.Text);
                            }
                        }
                        break;

                    case 10:
                        {
                            if (radioButtonTxAsc10.Checked == true)
                            {
                                TxByte = System.Text.Encoding.Default.GetBytes(UserPtl10.Text);
                            }
                            else if (radioButtonTxHex03.Checked == true)
                            {
                                TxByte = form1.HexStringToBytes(UserPtl10.Text);
                            }
                        }
                        break;

                    default:
                        break;
                }

                try
                {
                    form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                }
                catch
                { 
                
                }
            }
        }

        /**********************************************************************************
        *  函数名称：UserPtlFunction()
        *  描    述：用户自定义协议功能
        *  输    入：无
        *  输    出：无
        **********************************************************************************/
        private enum UserPtlStageEnum:int
        { 
            PTL_IDLE = 0,
            PTL_START,
            PTL_CMD_RESEND,
            PTL_CMD_SELECT,
            PTL_SEND_DELAY,
            PTL_WAIT_RECEIVE,
            PTL_OVER
        };

        public bool PtlStatus = false;

        private void PtlStart()
        {
            PtlStatus = true;
            PtlTimer.Enabled = true;

            PTL_LOG("开启自定义协议传输\r\n");
                
            UserPtlSstage = UserPtlStageEnum.PTL_START;
        }

        public void PtlStop()
        {

            if (PtlTimer.Enabled == true)
            {
                PTL_LOG("关闭自定义协议传输\r\n");
            }

            PtlStatus = false; 
            PtlTimer.Enabled = false;

            UserPtlSstage = UserPtlStageEnum.PTL_IDLE;
        }

        private int PtlCmdSelect(int cmdIndex)
        {
            int cmdSendFlag = 0;

            switch (cmdIndex)
            {
                case 1:
                    {
                        if (Ptl01CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc01.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl01.Text);
                                }
                                else if (radioButtonTxHex01.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl01.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 2:
                    {
                        if (Ptl02CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc02.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl02.Text);
                                }
                                else if (radioButtonTxHex02.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl02.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 3:
                    {
                        if (Ptl03CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc03.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl03.Text);
                                }
                                else if (radioButtonTxHex03.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl03.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 4:
                    {
                        if (Ptl04CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc04.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl04.Text);
                                }
                                else if (radioButtonTxHex04.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl04.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 5:
                    {
                        if (Ptl05CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc05.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl05.Text);
                                }
                                else if (radioButtonTxHex05.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl05.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 6:
                    {
                        if (Ptl06CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc06.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl06.Text);
                                }
                                else if (radioButtonTxHex06.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl06.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 7:
                    {
                        if (Ptl07CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc07.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl07.Text);
                                }
                                else if (radioButtonTxHex07.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl07.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 8:
                    {
                        if (Ptl08CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc08.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl08.Text);
                                }
                                else if (radioButtonTxHex08.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl08.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 9:
                    {
                        if (Ptl09CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc09.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl09.Text);
                                }
                                else if (radioButtonTxHex09.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl09.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;
                        }
                    }
                    break;

                case 10:
                    {
                        if (Ptl10CheckBox.Checked == true)
                        {
                            if (form1.serialPort1.IsOpen == true)
                            {
                                if (radioButtonTxAsc10.Checked == true)
                                {
                                    TxByte = System.Text.Encoding.Default.GetBytes(UserPtl10.Text);
                                }
                                else if (radioButtonTxHex10.Checked == true)
                                {
                                    TxByte = form1.HexStringToBytes(UserPtl10.Text);
                                }

                                form1.serialPort1.Write(TxByte, 0, TxByte.Length);
                            }

                            cmdSendFlag = 1;

                            
                        }
                    }
                    break;

                default:
                    break;
            }

            if (cmdSendFlag == 1)
            {
                form1.TxNumberLabelShow(TxByte.Length);
                PTL_LOG("PtlSend:" + cmdIndex.ToString() + "\r\n");
            }

            return cmdSendFlag;
        }

        UserPtlStageEnum UserPtlSstage = 0;

        private int CmdIndex = 0;
        private int CmdIndexRecord = 0;
        private int SendCount = 0;
        private int SendDelay = 0;
        private int WaitCount = 0;
        
        private void UserPtlFunction()
        {
            switch (UserPtlSstage)
            {
                /*空闲状态*/
                case UserPtlStageEnum.PTL_IDLE:
                    {
                        PtlTimer.Enabled = false;

                        btPtlStart.Text = "开启传输";
                        btClearLog.BackgroundImage = Properties.Resources.btCheckt011;
                    }
                    break;

                /*开启协议传输*/
                case UserPtlStageEnum.PTL_START:
                    {
                        CmdIndex = 0;
                        SendCount = 0;
                        WaitCount = 0;

                        UserPtlSstage = UserPtlStageEnum.PTL_CMD_SELECT;
                    }
                    break;

                /*选择指定指令*/
                case UserPtlStageEnum.PTL_CMD_SELECT:
                    {
                        SendCount = 0;
                        WaitCount = 0;
                        SendDelay = 0;

                        CmdIndex++;

                        for (int count = CmdIndex; count <= 10; count++)
                        {
                            if (PtlCmdSelect(count) == 1)
                            {
                                if (checkBoxBiHuan.Checked == true) //闭环传输开启
                                {
                                    UserPtlSstage = UserPtlStageEnum.PTL_WAIT_RECEIVE;
                                }
                                else
                                {
                                    SendDelay = 0;
                                    UserPtlSstage = UserPtlStageEnum.PTL_SEND_DELAY;
                                }

                                CmdIndex = count;
                                CmdIndexRecord = count;

                                break;
                            }
                        }

                        CmdIndex %= 10;
                    }
                    break;

                /*指令重发*/
                case UserPtlStageEnum.PTL_CMD_RESEND:
                    {
                        int CountTemp = 0;

                        try
                        {
                            CountTemp = Convert.ToInt32(textReSendCount.Text);
                        }
                        catch 
                        {
                            CountTemp = 0;
                        }

                        if (SendCount < CountTemp)
                        {
                            SendCount++;
                            PtlCmdSend(CmdIndexRecord);

                            if (checkBoxBiHuan.Checked == true)
                            {
                                WaitCount = 0;
                                UserPtlSstage = UserPtlStageEnum.PTL_WAIT_RECEIVE;
                            }
                            else
                            {
                                SendDelay = 0;
                                UserPtlSstage = UserPtlStageEnum.PTL_SEND_DELAY;
                            }

                            PTL_LOG("重发次数：" + SendCount.ToString() + "\r\n");
                        }
                        else
                        {
                            if (checkBoxTimeOut.Checked == true) //超时退出开启
                            {
                                UserPtlSstage = UserPtlStageEnum.PTL_OVER;
                            }
                            else
                            {
                                SendDelay = 0;
                                UserPtlSstage = UserPtlStageEnum.PTL_SEND_DELAY;
                            }

                            PTL_LOG("重发完毕\r\n");
                        }
                    }
                    break;

                /*发送延时*/
                case UserPtlStageEnum.PTL_SEND_DELAY:
                    {
                        int Delay = 0;

                        try
                        {
                            Delay = Convert.ToInt32(textSendDelay.Text);
                        }
                        catch
                        {
                            Delay = 0;
                        }

                        SendDelay++;
                        if (SendDelay >= Delay)
                        {
                            SendDelay = 0;

                            UserPtlSstage = UserPtlStageEnum.PTL_CMD_SELECT;
                        }
                    }
                    break;

                /*等待接收*/
                case UserPtlStageEnum.PTL_WAIT_RECEIVE:
                    {
                        if (form1.GetSerialRxFlag() == true) //串口接收到数据
                        {
                            form1.ClearSerialRxFlag();

                            SendDelay = 0;
                            UserPtlSstage = UserPtlStageEnum.PTL_SEND_DELAY;
                        }
                        else
                        {
                            int Count = 0;

                            try
                            {
                                Count = Convert.ToInt32(textWaitTime.Text);
                            }
                            catch
                            {
                                Count = 0;
                            }

                            WaitCount++;

                            if (WaitCount >= Count) //等待超时
                            {
                                if (checkBoxReSend.Checked == true) //自动重发开启
                                {
                                    PTL_LOG("等待超时：指令重发" + CmdIndex.ToString() + "\r\n");

                                    UserPtlSstage = UserPtlStageEnum.PTL_CMD_RESEND;
                                }
                                else
                                {
                                    if (checkBoxTimeOut.Checked == true) //超时退出开启
                                    {
                                        UserPtlSstage = UserPtlStageEnum.PTL_OVER;
                                    }
                                    else
                                    {
                                        SendDelay = 0;
                                        UserPtlSstage = UserPtlStageEnum.PTL_SEND_DELAY;
                                    }

                                    PTL_LOG("等待超时：未回复指令" + CmdIndex.ToString() + "\r\n");
                                }
                            }
                        }
                    }
                    break;

                /*协议传输结束*/
                case UserPtlStageEnum.PTL_OVER:
                    {
                        PtlTimer.Enabled = false;

                        btPtlStart.Text = "开启传输";
                        btPtlStart.BackgroundImage = Properties.Resources.btCheckt011;

                        UserPtlSstage = UserPtlStageEnum.PTL_IDLE;

                        PTL_LOG("自定义协议结束\r\n");
                    }
                    break;

                default:
                    break;
            }

            if (form1.serialPort1.IsOpen == false)
            {
                btPtlStart.Text = "开启传输";

                btPtlStart.BackgroundImage = Properties.Resources.btCheckt011;

                PtlStop();
            }
        }
        /**********************************************************************************
        *  函数名称：PtlTimer_Tick()
        *  描    述：用户自定义协议定时任务
        *  输    入：无
        *  输    出：无
        **********************************************************************************/
        private delegate void UserPtlDelegate();

        private void PtlTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Invoke(new UserPtlDelegate(UserPtlFunction));
            }
            catch
            { 
            
            }
        }

        /* *********************************************************************************
        * 实现窗体拖动
        * *********************************************************************************/
        private bool beginMove = false;//初始化鼠标位置
        private int currentXPosition;
        private int currentYPosition;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
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
            form1.form2Exist = false;
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

        private void btFileSend1_Click(object sender, EventArgs e)
        {
            PtlCmdSend(1);
        }

        private void btFileSend2_Click(object sender, EventArgs e)
        {
            PtlCmdSend(2);
        }

        private void btFileSend3_Click(object sender, EventArgs e)
        {
            PtlCmdSend(3);
        }

        private void btFileSend4_Click(object sender, EventArgs e)
        {
            PtlCmdSend(4);
        }

        private void btFileSend5_Click(object sender, EventArgs e)
        {
            PtlCmdSend(5);
        }

        private void btFileSend6_Click(object sender, EventArgs e)
        {
            PtlCmdSend(6);
        }

        private void btFileSend7_Click(object sender, EventArgs e)
        {
            PtlCmdSend(7);
        }

        private void btFileSend8_Click(object sender, EventArgs e)
        {
            PtlCmdSend(8);
        }

        private void btFileSend9_Click(object sender, EventArgs e)
        {
            PtlCmdSend(9);
        }

        private void btFileSend10_Click(object sender, EventArgs e)
        {
            PtlCmdSend(10);
        }

        private void btPtlStart_Click(object sender, EventArgs e)
        {
            if (btPtlStart.Text == "开启传输")
            {
                if (form1.GetSerialOpen() == true)
                {
                    btPtlStart.Text = "关闭传输";

                    btPtlStart.BackgroundImage = Properties.Resources.btRedRel;

                    PtlStart();
                }
            }
            else if(btPtlStart.Text == "关闭传输")
            {
                btPtlStart.Text = "开启传输";

                btPtlStart.BackgroundImage = Properties.Resources.btCheckt011;

                PtlStop();
            }
        }

        private void btClearLog_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = "";
        }

        private void btFileSend1_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend1.ForeColor = SystemColors.AppWorkspace;
            btFileSend1.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend1_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend1.ForeColor = SystemColors.HighlightText;
            btFileSend1.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend2_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend2.ForeColor = SystemColors.AppWorkspace;
            btFileSend2.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend2_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend2.ForeColor = SystemColors.HighlightText;
            btFileSend2.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend3_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend3.ForeColor = SystemColors.AppWorkspace;
            btFileSend3.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend3_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend3.ForeColor = SystemColors.HighlightText;
            btFileSend3.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend4_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend4.ForeColor = SystemColors.AppWorkspace;
            btFileSend4.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend4_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend4.ForeColor = SystemColors.HighlightText;
            btFileSend4.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend5_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend5.ForeColor = SystemColors.AppWorkspace;
            btFileSend5.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend5_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend5.ForeColor = SystemColors.HighlightText;
            btFileSend5.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend6_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend6.ForeColor = SystemColors.AppWorkspace;
            btFileSend6.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend6_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend6.ForeColor = SystemColors.HighlightText;
            btFileSend6.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend7_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend7.ForeColor = SystemColors.AppWorkspace;
            btFileSend7.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend7_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend7.ForeColor = SystemColors.HighlightText;
            btFileSend7.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend8_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend8.ForeColor = SystemColors.AppWorkspace;
            btFileSend8.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend8_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend8.ForeColor = SystemColors.HighlightText;
            btFileSend8.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend9_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend9.ForeColor = SystemColors.AppWorkspace;
            btFileSend9.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend9_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend9.ForeColor = SystemColors.HighlightText;
            btFileSend9.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btFileSend10_MouseDown(object sender, MouseEventArgs e)
        {
            btFileSend10.ForeColor = SystemColors.AppWorkspace;
            btFileSend10.BackgroundImage = Properties.Resources.btTxSendMinPre;
        }

        private void btFileSend10_MouseUp(object sender, MouseEventArgs e)
        {
            btFileSend10.ForeColor = SystemColors.ButtonHighlight;
            btFileSend10.BackgroundImage = Properties.Resources.btTxSendMinRel;
        }

        private void btPtlStart_MouseDown(object sender, MouseEventArgs e)
        {
            if (btPtlStart.Text == "开启传输")
            {
                btPtlStart.ForeColor = SystemColors.ControlLightLight;
                btPtlStart.BackgroundImage = Properties.Resources.btCheckt031;
            }

        }

        private void btPtlStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (btPtlStart.Text == "开启传输")
            {
                btPtlStart.ForeColor = SystemColors.ControlLightLight;
                btPtlStart.BackgroundImage = Properties.Resources.btCheckt011;
            }
        }

        private void btClearLog_MouseDown(object sender, MouseEventArgs e)
        {
            btClearLog.ForeColor = SystemColors.AppWorkspace;
            btClearLog.BackgroundImage = Properties.Resources.btCheckt031;
        }

        private void btClearLog_MouseUp(object sender, MouseEventArgs e)
        {
            btClearLog.ForeColor = SystemColors.ControlLightLight;
            btClearLog.BackgroundImage = Properties.Resources.btCheckt011;
        }

        private void radioButtonTxAsc01_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl01Hex = !radioButtonTxAsc01.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex01_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl01Hex = radioButtonTxHex01.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc02_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl02Hex = !radioButtonTxAsc02.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex02_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl02Hex = radioButtonTxHex02.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc03_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl03Hex = !radioButtonTxAsc03.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex03_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl03Hex = radioButtonTxHex03.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc04_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl04Hex = !radioButtonTxAsc04.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex04_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl04Hex = radioButtonTxHex04.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc05_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl05Hex = !radioButtonTxAsc05.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex05_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl05Hex = radioButtonTxHex05.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc06_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl06Hex = !radioButtonTxAsc06.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex06_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl06Hex = radioButtonTxHex06.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc07_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl07Hex = !radioButtonTxAsc07.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex07_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl07Hex = radioButtonTxHex07.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc08_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl08Hex = !radioButtonTxAsc08.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex08_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl08Hex = radioButtonTxHex08.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc09_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl09Hex = !radioButtonTxAsc09.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex09_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl09Hex = radioButtonTxHex09.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxAsc10_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl10Hex = !radioButtonTxAsc10.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButtonTxHex10_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl10Hex = radioButtonTxHex10.Checked;
            Properties.Settings.Default.Save();
        }

        private void UserPtl01_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl01 = UserPtl01.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl02_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl02 = UserPtl02.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl03_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl03 = UserPtl03.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl04_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl04 = UserPtl04.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl05_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl05 = UserPtl05.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl06_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl06 = UserPtl06.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl07_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl07 = UserPtl07.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl08_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl08 = UserPtl08.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl09_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl09 = UserPtl09.Text;
            Properties.Settings.Default.Save();
        }

        private void UserPtl10_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl10 = UserPtl10.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl01Not = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl02Not = textBox3.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl03Not = textBox5.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl04Not = textBox7.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl05Not = textBox9.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl06Not = textBox11.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl07Not = textBox13.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl08Not = textBox15.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl09Not = textBox17.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPtl10Not = textBox19.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20)   //禁止空格键
            {
                e.KeyChar = (char)0;
            }
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) //禁止负数
            {
                e.KeyChar = (char)0;
            }

            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20)   //禁止空格键
            {
                e.KeyChar = (char)0;
            }
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) //禁止负数
            {
                e.KeyChar = (char)0;
            }

            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20)   //禁止空格键
            {
                e.KeyChar = (char)0;
            }
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) //禁止负数
            {
                e.KeyChar = (char)0;
            }

            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }
    }
}
