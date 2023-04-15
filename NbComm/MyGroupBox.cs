    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Drawing;

namespace NbComm
{
    public partial class MyGroupBox : GroupBox
    {
        public MyGroupBox()
        {
            InitializeComponent();
        }

        public MyGroupBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private Color _BorderColor = Color.Black;

        [Browsable(true), Description("边框颜色"), Category("自定义分组")]

        public Color BorderColor
        {
            get { return _BorderColor; }
            set
            {
                _BorderColor = value;
                this.Invalidate();
            }
        }
        
        //设置控件的字体和size
        protected override void OnPaint(PaintEventArgs e)
        {
            var vSize = e.Graphics.MeasureString(this.Text, this.Font);
            // e.Graphics.Clear(this.BackColor);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 10, 1);
            Pen vPen = new Pen(this._BorderColor);
            e.Graphics.DrawLine(vPen, 1, vSize.Height / 2, 8, vSize.Height / 2);
            e.Graphics.DrawLine(vPen, vSize.Width + 8, vSize.Height / 2, this.Width - 2, vSize.Height / 2);
            e.Graphics.DrawLine(vPen, 1, vSize.Height / 2, 1, this.Height - 2);
            e.Graphics.DrawLine(vPen, 1, this.Height - 2, this.Width - 2, this.Height - 2);
            e.Graphics.DrawLine(vPen, this.Width - 2, vSize.Height / 2, this.Width - 2, this.Height - 2);

        }
        

    }
}
