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

namespace NbComm
{
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();

        public Form3()
        {
            InitializeComponent();
        }

        private delegate void textBox1ShowDel(string text);
        public void textBox1Show(string text)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1ShowDel d = new textBox1ShowDel(textBox1Show);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                textBox1.Text = text;
            }
        }

        /*
        private void textBox1Input_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (textBox1.SelectionStart > 10)
                { 
                    textBox1.SelectionStart -= 10;
                    textBox1.GetFirstCharIndexOfCurrentLine();
                    textBox1.GetLineFromCharIndex(textBox1.GetFirstCharIndexOfCurrentLine());
                    textBox1.ScrollToCaret();
                }
            }
            else if (e.Delta < 0)
            {
                textBox1.SelectionStart += 10; 
                textBox1.ScrollToCaret();
            }

            textBox2.Text = textBox1.GetLineFromCharIndex(textBox1.GetFirstCharIndexOfCurrentLine()).ToString();
        }
        */

        private void Form3_Load(object sender, EventArgs e)
        {
            btClose.BackgroundImageLayout = ImageLayout.Zoom;
            btMin.BackgroundImageLayout = ImageLayout.Zoom;

            btFile.BackgroundImageLayout = ImageLayout.Zoom;
            btClear.BackgroundImageLayout = ImageLayout.Zoom;
            btCalcul.BackgroundImageLayout = ImageLayout.Zoom;

            algBox.Text = "CRC8";

            //textBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.textBox1Input_MouseWheel);

            //form1 = (Form1)this.Owner;  //两个窗体之间传输数据
        }

        /* *********************************************************************************
        * 实现窗体拖动
        * *********************************************************************************/
        private bool beginMove = false;//初始化鼠标位置
        private int currentXPosition;
        private int currentYPosition;

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }

/* *********************************************************************************
* 校验码算法
* *********************************************************************************/
        private byte CRC8_Calculate(byte[] data, int len)
        {
            byte temp;

            byte crc = 0x00;//CRC 初始值
            byte crc_poly = 0x07;//CRC Ploy值

            for (int i = 0; i < len; i++)
            {
                temp = data[i];
                crc = (byte)(crc ^ temp);//CRC的高八位异或输入数据
                                 //判断8次CRC的做高位，并左移
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x80) != 0)//最高位为1
                    {
                        crc = (byte)((crc << 1) ^ crc_poly);
                    }
                    else //最高位为0
                    {
                        crc = (byte)(crc << 1);
                    }
                }
            }

            return (byte)(crc ^ 0x00);
        }

        /*CRC16_Modbus计算公式*/
        public ushort CRC16_Modbus_Calculate(byte[] data, int length)
        {
            int len = length - 2;
            ushort crc_value = 0xFFFF;

            for (int i = 0; i < len; i++)
            {
                crc_value ^= (ushort)data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc_value & 0x0001) != 0)
                    {
                        crc_value >>= 1;
                        crc_value ^= 0xA001;
                    }
                    else
                    {
                        crc_value >>= 1;
                    }
                }
            }

            return crc_value = (ushort)(((crc_value & 0x00ff) << 8) | ((crc_value & 0xff00) >> 8));
        }

        public void btClose_Click(object sender, EventArgs e)
        {
            //form1.form3Exist = false;
            this.Close();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void radioButtonRxAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAsc.Checked == true)
            {
                byte[] textBoxByte;
                textBoxByte = form1.HexStringToBytes(textBox1.Text);

                textBox1.Text = System.Text.Encoding.Default.GetString(textBoxByte);
            }
        }

        private void radioButtonRxHex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHex.Checked == true)
            {
                byte[] textBoxByte;
                textBoxByte = System.Text.Encoding.Default.GetBytes(textBox1.Text);

                textBox1.Text = BitConverter.ToString(textBoxByte).Replace("-", " ") + " "; 
            }
        }

        /*
         * CRC校验类型
         */
        public struct CRC_INFO
        {
            public byte width; //CRC位数
            public UInt32 poly; //CRC多项式
            public UInt32 initREG; //CRC初始值
            public bool refin; //输入数据反转
            public bool refout; //输出数据反转
            public UInt32 xorout; //结果异或值
        };

        public readonly CRC_INFO CRC4_ITU = new CRC_INFO
        {
            width = 4,
            poly = 0x03,
            initREG = 0x00,
            refin = true,
            refout = true,
            xorout = 0x00
        };

        public readonly CRC_INFO CRC5_EPC = new CRC_INFO
        {
            width = 5,
            poly = 0x09,
            initREG = 0x09,
            refin = false,
            refout = false,
            xorout = 0x00
        };

        public readonly CRC_INFO CRC5_ITU = new CRC_INFO
        {
            width = 5,
            poly = 0x15,
            initREG = 0x00,
            refin = true,
            refout = true,
            xorout = 0x00
        };

        public readonly CRC_INFO CRC5_USB = new CRC_INFO
        {
            width = 5,
            poly = 0x05,
            initREG = 0x1f,
            refin = true,
            refout = true,
            xorout = 0x1f
        };

        public readonly CRC_INFO CRC6_ITU = new CRC_INFO
        {
            width = 6,
            poly = 0x03,
            initREG = 0x00,
            refin = true,
            refout = true,
            xorout = 0x00
        };

        public readonly CRC_INFO CRC7_MMC = new CRC_INFO
        {
            width = 7,
            poly = 0x09,
            initREG = 0x00,
            refin = false,
            refout = false,
            xorout = 0x00
        };

        public readonly CRC_INFO CRC8 = new CRC_INFO
        {
            width = 8,
            poly = 0x07,
            initREG = 0x00,
            refin = false,
            refout = false,
            xorout = 0x00
        };

        public readonly CRC_INFO CRC8_ITU = new CRC_INFO
        {
            width = 8,
            poly = 0x07,
            initREG = 0x00,
            refin = false,
            refout = false,
            xorout = 0x55
        };

        public readonly CRC_INFO CRC8_ROHC = new CRC_INFO
        {
            width = 8,
            poly = 0x07,
            initREG = 0xff,
            refin = true,
            refout = true,
            xorout = 0x00
        };

        public readonly CRC_INFO CRC8_MAXIM = new CRC_INFO
        {
            width = 8,
            poly = 0x31,
            initREG = 0x00,
            refin = true,
            refout = true,
            xorout = 0x00
        };

        public readonly CRC_INFO CRC16_IBM = new CRC_INFO
        {
            width = 16,
            poly = 0x8005,
            initREG = 0x0000,
            refin = true,
            refout = true,
            xorout = 0x0000
        };

        public readonly CRC_INFO CRC16_MAXIM = new CRC_INFO
        {
            width = 16,
            poly = 0x8005,
            initREG = 0x0000,
            refin = true,
            refout = true,
            xorout = 0xffff
        };

        public readonly CRC_INFO CRC16_USB = new CRC_INFO
        {
            width = 16,
            poly = 0x8005,
            initREG = 0xffff,
            refin = true,
            refout = true,
            xorout = 0xffff
        };

        public readonly CRC_INFO CRC16_MODBUS = new CRC_INFO
        {
            width = 16,
            poly = 0x8005,
            initREG = 0xffff,
            refin = true,
            refout = true,
            xorout = 0x0000
        };

        public readonly CRC_INFO CRC16_CCITT = new CRC_INFO
        {
            width = 16,
            poly = 0x1021,
            initREG = 0x0000,
            refin = true,
            refout = true,
            xorout = 0x0000
        };

        public readonly CRC_INFO CRC16_CCITT_FALSE = new CRC_INFO
        {
            width = 16,
            poly = 0x1021,
            initREG = 0xffff,
            refin = false,
            refout = false,
            xorout = 0x0000
        };

        public readonly CRC_INFO CRC16_X25 = new CRC_INFO
        {
            width = 16,
            poly = 0x1021,
            initREG = 0xffff,
            refin = true,
            refout = true,
            xorout = 0xffff
        };

        public readonly CRC_INFO CRC16_XMODEM = new CRC_INFO
        {
            width = 16,
            poly = 0x1021,
            initREG = 0x0000,
            refin = false,
            refout = false,
            xorout = 0x0000
        };

        public readonly CRC_INFO CRC16_DNP = new CRC_INFO
        {
            width = 16,
            poly = 0x3d65,
            initREG = 0x0000,
            refin = true,
            refout = true,
            xorout = 0xffff
        };

        public readonly CRC_INFO CRC32 = new CRC_INFO
        {
            width = 32,
            poly = 0x04c11db7,
            initREG = 0xffffffff,
            refin = true,
            refout = true,
            xorout = 0xffffffff
        };

        public readonly CRC_INFO CRC32_MPEG = new CRC_INFO
        {
            width = 32,
            poly = 0x04c11db7,
            initREG = 0xffffffff,
            refin = false,
            refout = false,
            xorout = 0x00000000
        };

        private UInt32[] CRC_Table = new UInt32[256];

        private UInt32 BitReflected(UInt32 input, byte bits)
        {
            UInt32 res = 0;
            while (bits-- > 0)
            {
                res <<= 1;
                if ((input & 0x01) != 0)
                    res |= 1;
                input >>= 1;
            }
            return res;
        }

        public void CRC_Table_Init(CRC_INFO crc_info)
        {
            UInt32 poly, value = 0;
            UInt32 valid_bits = ((UInt32)2 << (crc_info.width - 1)) - 1;

            if (crc_info.refin)
            {
                poly = BitReflected(crc_info.poly, crc_info.width);

                for (UInt32 i = 0; i < 256; i++)
                {
                    value = i;
                    for (UInt32 j = 0; j < 8; j++)
                    {
                        if ((value & 0x0001) != 0)
                            value = (value >> 1) ^ poly;
                        else
                            value >>= 1;
                    }

                    CRC_Table[i] = value & valid_bits;
                }
            }
            else
            {
                poly = crc_info.width < 8 ? crc_info.poly << (8 - crc_info.width) : crc_info.poly;
                UInt32 bit = crc_info.width > 8 ? (UInt32)1 << (crc_info.width - 1) : 0x80;

                for (UInt32 i = 0; i < 256; i++)
                {
                    value = crc_info.width > 8 ? i << (crc_info.width - 8) : i;

                    for (UInt32 j = 0; j < 8; j++)
                    {
                        if ((value & bit) != 0)
                            value = (value << 1) ^ poly;
                        else
                            value <<= 1;
                    }

                    CRC_Table[i] = value & (crc_info.width < 8 ? 0xff : valid_bits);
                }
            }
        }

        public UInt32 CRC_Calculate(CRC_INFO info, byte[] memBlock, int length)
        {
            UInt32 memBlockLen = (UInt32)length;
            UInt32 value;
            byte high;

            if (info.refin)
            {
                value = BitReflected(info.initREG, info.width);
                if (info.width > 8)
                {
                    int i = 0;
                    while ((memBlockLen--) != 0)
                    {
                        value = (value >> 8) ^ CRC_Table[value & 0xff ^ memBlock[i++]];
                    }
                }
                else
                {
                    int i = 0;
                    while ((memBlockLen--) != 0)
                    {
                        value = CRC_Table[value ^ memBlock[i++]];
                    }
                }
            }
            else
            {
                if (info.width > 8)
                {
                    value = info.initREG;
                    int i = 0;
                    while ((memBlockLen--) != 0)
                    {
                        high = (byte)(value >> (info.width - 8));
                        value = (value << 8) ^ CRC_Table[high ^ memBlock[i++]];
                    }
                }
                else
                {
                    value = info.initREG << (8 - info.width);
                    int i = 0;
                    while ((memBlockLen--) != 0)
                    {
                        value = CRC_Table[value ^ memBlock[i++]];
                    }
                    value >>= 8 - info.width;
                }
            }
            if (info.refout != info.refin)
            {
                value = BitReflected(value, info.width);
            }
            value ^= info.xorout;
            return value & (((UInt32)2 << (info.width - 1)) - 1);
        }

        private UInt32 CRC_GetResult(byte[] memBlock, int length)
        { 
            UInt32 result = 0;

            switch (algBox.Text)
            {
                case "XOR":
                    {
                        for (int i = 0; i < length; i++)
                        {
                            result ^= memBlock[i];
                        }
                    }
                    break;

                case "CheckSum":
                    {
                        int sum = 0;

                        for (int i = 0; i < length; i++)
                        {
                            sum += memBlock[i];
                        }

                        if (sum > 0xff)
                        {
                            sum = ~sum;
                            sum += 1;
                        }

                        result = (UInt32)(sum & 0xff);
                    }
                    break;

                case "CRC4_ITU":
                    {
                        CRC_Table_Init(CRC4_ITU);
                        result = CRC_Calculate(CRC4_ITU, memBlock, length);
                    }
                    break;

                case "CRC5_EPC":
                    {
                        CRC_Table_Init(CRC5_EPC);
                        result = CRC_Calculate(CRC5_EPC, memBlock, length);
                    }
                    break;

                case "CRC5_ITU":
                    {
                        CRC_Table_Init(CRC5_ITU);
                        result = CRC_Calculate(CRC5_ITU, memBlock, length);
                    }
                    break;

                case "CRC5_USB":
                    {
                        CRC_Table_Init(CRC5_USB);
                        result = CRC_Calculate(CRC5_USB, memBlock, length);
                    }
                    break;

                case "CRC6_ITU":
                    {
                        CRC_Table_Init(CRC6_ITU);
                        result = CRC_Calculate(CRC6_ITU, memBlock, length);
                    }
                    break;

                case "CRC7_MMC":
                    {
                        CRC_Table_Init(CRC7_MMC);
                        result = CRC_Calculate(CRC7_MMC, memBlock, length);
                    }
                    break;

                case "CRC8":
                    {
                        CRC_Table_Init(CRC8);
                        result = CRC_Calculate(CRC8, memBlock, length);
                    }
                    break;

                case "CRC8_ITU":
                    {
                        CRC_Table_Init(CRC8_ITU);
                        result = CRC_Calculate(CRC8_ITU, memBlock, length);
                    }
                    break;

                case "CRC8_ROHC":
                    {
                        CRC_Table_Init(CRC8_ROHC);
                        result = CRC_Calculate(CRC8_ROHC, memBlock, length);
                    }
                    break;

                case "CRC8_MAXIM":
                    {
                        CRC_Table_Init(CRC8_MAXIM);
                        result = CRC_Calculate(CRC8_MAXIM, memBlock, length);
                    }
                    break;

                case "CRC16_IBM":
                    {
                        CRC_Table_Init(CRC16_IBM);
                        result = CRC_Calculate(CRC16_IBM, memBlock, length);
                    }
                    break;

                case "CRC16_MAXIM":
                    {
                        CRC_Table_Init(CRC16_MAXIM);
                        result = CRC_Calculate(CRC16_MAXIM, memBlock, length);
                    }
                    break;

                case "CRC16_USB":
                    {
                        CRC_Table_Init(CRC16_USB);
                        result = CRC_Calculate(CRC16_USB, memBlock, length);
                    }
                    break;

                case "CRC16_MODBUS":
                    {
                        CRC_Table_Init(CRC16_MODBUS);
                        result = CRC_Calculate(CRC16_MODBUS, memBlock, length);
                    }
                    break;

                case "CRC16_CCITT":
                    {
                        CRC_Table_Init(CRC16_CCITT);
                        result = CRC_Calculate(CRC16_CCITT, memBlock, length);
                    }
                    break;

                case "CRC16_CCITT_FALSE":
                    {
                        CRC_Table_Init(CRC16_CCITT_FALSE);
                        result = CRC_Calculate(CRC16_CCITT_FALSE, memBlock, length);
                    }
                    break;

                case "CRC16_X25":
                    {
                        CRC_Table_Init(CRC16_X25);
                        result = CRC_Calculate(CRC16_X25, memBlock, length);
                    }
                    break;

                case "CRC16_XMODEM":
                    {
                        CRC_Table_Init(CRC16_XMODEM);
                        result = CRC_Calculate(CRC16_XMODEM, memBlock, length);
                    }
                    break;

                case "CRC16_DNP":
                    {
                        CRC_Table_Init(CRC16_DNP);
                        result = CRC_Calculate(CRC16_DNP, memBlock, length);
                    }
                    break;

                case "CRC32":
                    {
                        CRC_Table_Init(CRC32);
                        result = CRC_Calculate(CRC32, memBlock, length);
                    }
                    break;

                case "CRC32_MPEG":
                    {
                        CRC_Table_Init(CRC32_MPEG);
                        result = CRC_Calculate(CRC32_MPEG,memBlock, length);
                    }
                    break;

                default:
                    break;

            }

            return result;
        }

        private byte[] inputByte;
        private void btCalcul_Click(object sender, EventArgs e)
        {
            if (radioButtonAsc.Checked == true)
            {
                inputByte = System.Text.Encoding.Default.GetBytes(textBox1.Text);
            }
            else
            {
                inputByte = form1.HexStringToBytes(textBox1.Text);
            }

            UInt32 CRC_Result = CRC_GetResult(inputByte, inputByte.Length);

            if (CRC_Result <= 0xff)
            {
                byte[] byte1 = new byte[1];
                byte1[0] = (byte)(CRC_Result & 0xff);
                textBox2.Text = BitConverter.ToString(byte1).Replace("-", " ") + " ";
            }
            else if (CRC_Result <= 0xffff)
            {
                byte[] byte2 = new byte[2];

                byte2[0] = (byte)((CRC_Result & 0xff00) >> 8);
                byte2[1] = (byte)(CRC_Result & 0xff);

                textBox2.Text = BitConverter.ToString(byte2).Replace("-", " ") + " ";
            }
            else if (CRC_Result <= 0xffffffff)
            {
                byte[] byte3 = new byte[4];

                byte3[0] = (byte)((CRC_Result & 0xff000000) >> 24);
                byte3[1] = (byte)((CRC_Result & 0xff0000) >> 16);

                byte3[2] = (byte)((CRC_Result & 0xff00) >> 8);
                byte3[3] = (byte)(CRC_Result & 0xff);

                textBox2.Text = BitConverter.ToString(byte3).Replace("-", " ") + " ";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btClear_MouseDown(object sender, MouseEventArgs e)
        {
            btClear.ForeColor = SystemColors.ControlDark;
            btClear.BackgroundImage = Properties.Resources.btFind04;
        }

        private void btClear_MouseUp(object sender, MouseEventArgs e)
        {
            btClear.ForeColor = SystemColors.ControlLight;
            btClear.BackgroundImage = Properties.Resources.btFind03;
        }

        private void btCalcul_MouseDown(object sender, MouseEventArgs e)
        {
            btCalcul.ForeColor = SystemColors.ControlDark;
            btCalcul.BackgroundImage = Properties.Resources.btFind04;
        }

        private void btCalcul_MouseUp(object sender, MouseEventArgs e)
        {
            btCalcul.ForeColor = SystemColors.ControlLight;
            btCalcul.BackgroundImage = Properties.Resources.btFind03;
        }

        private OpenFileDialog MyFileDialog;
        
        private void btFile_Click(object sender, EventArgs e)
        {
            string textBox1String = "";
            byte[] textBox1Byte;

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
                    textBox1Byte = BinReader.ReadBytes((int)Myfile.Length);

                    if (radioButtonHex.Checked == false)
                    {
                        radioButtonHex.Checked = true;
                    }
                }
                else
                {
                    textBox1String = str.ReadToEnd();
                    textBox1Byte = System.Text.Encoding.Default.GetBytes(textBox1String);
                }
                
                if (radioButtonHex.Checked == true)
                {
                    textBox1String = BitConverter.ToString(textBox1Byte).Replace("-", " ") + " "; //十六进制显示
                }

                textBox1Show(textBox1String);

                str.Close();
            }
        }

        private void btFile_MouseDown(object sender, MouseEventArgs e)
        {
            btFile.ForeColor = SystemColors.ControlDark;
            btFile.BackgroundImage = Properties.Resources.btFind04;
        }

        private void btFile_MouseUp(object sender, MouseEventArgs e)
        {
            btFile.ForeColor = SystemColors.ControlLight;
            btFile.BackgroundImage = Properties.Resources.btFind03;
        }

        private bool keyFlag = true;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonHex.Checked == true)
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

                        form1.SYSTEM_LOG("请输入十六进制数据\r\n");
                    }

                    e.KeyChar = (char)0;
                }
            }
        }
    }
}
