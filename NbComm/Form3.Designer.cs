namespace NbComm
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btClose = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.algBox = new System.Windows.Forms.ComboBox();
            this.btFile = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btCalcul = new System.Windows.Forms.Button();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.radioButtonAsc = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btClose.Location = new System.Drawing.Point(555, 6);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(36, 36);
            this.btClose.TabIndex = 5;
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
            this.btMin.Location = new System.Drawing.Point(510, 6);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(36, 36);
            this.btMin.TabIndex = 4;
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            this.btMin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMin_MouseDown);
            this.btMin.MouseEnter += new System.EventHandler(this.btMin_MouseEnter);
            this.btMin.MouseLeave += new System.EventHandler(this.btMin_MouseLeave);
            this.btMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMin_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.algBox);
            this.panel1.Controls.Add(this.btFile);
            this.panel1.Controls.Add(this.btClear);
            this.panel1.Controls.Add(this.btCalcul);
            this.panel1.Controls.Add(this.radioButtonHex);
            this.panel1.Controls.Add(this.radioButtonAsc);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(8, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 340);
            this.panel1.TabIndex = 6;
            // 
            // algBox
            // 
            this.algBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.algBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.algBox.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.algBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.algBox.FormattingEnabled = true;
            this.algBox.Items.AddRange(new object[] {
            "XOR",
            "CheckSum",
            "CRC4_ITU",
            "CRC5_EPC",
            "CRC5_ITU",
            "CRC5_USB",
            "CRC6_ITU",
            "CRC7_MMC",
            "CRC8",
            "CRC8_ITU",
            "CRC8_MAXIM",
            "CRC8_ROHC",
            "CRC16_CCITT",
            "CRC16_CCITT_FALSE",
            "CRC16_DNP",
            "CRC16_IBM",
            "CRC16_MODBUS",
            "CRC16_MAXIM",
            "CRC16_USB",
            "CRC16_X25",
            "CRC16_XMODEM",
            "CRC32",
            "CRC32_MPEG"});
            this.algBox.Location = new System.Drawing.Point(10, 269);
            this.algBox.Name = "algBox";
            this.algBox.Size = new System.Drawing.Size(257, 27);
            this.algBox.TabIndex = 43;
            // 
            // btFile
            // 
            this.btFile.BackgroundImage = global::NbComm.Properties.Resources.btFind03;
            this.btFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFile.FlatAppearance.BorderSize = 0;
            this.btFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFile.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btFile.Location = new System.Drawing.Point(452, 182);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(115, 32);
            this.btFile.TabIndex = 41;
            this.btFile.Text = "文    件";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            this.btFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btFile_MouseDown);
            this.btFile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFile_MouseUp);
            // 
            // btClear
            // 
            this.btClear.BackgroundImage = global::NbComm.Properties.Resources.btFind03;
            this.btClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btClear.Location = new System.Drawing.Point(452, 230);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(115, 32);
            this.btClear.TabIndex = 40;
            this.btClear.Text = "清    除";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            this.btClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btClear_MouseDown);
            this.btClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btClear_MouseUp);
            // 
            // btCalcul
            // 
            this.btCalcul.BackgroundImage = global::NbComm.Properties.Resources.btFind03;
            this.btCalcul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCalcul.FlatAppearance.BorderSize = 0;
            this.btCalcul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCalcul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btCalcul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcul.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCalcul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCalcul.Location = new System.Drawing.Point(452, 301);
            this.btCalcul.Name = "btCalcul";
            this.btCalcul.Size = new System.Drawing.Size(115, 32);
            this.btCalcul.TabIndex = 39;
            this.btCalcul.Text = "计    算";
            this.btCalcul.UseVisualStyleBackColor = true;
            this.btCalcul.Click += new System.EventHandler(this.btCalcul_Click);
            this.btCalcul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btCalcul_MouseDown);
            this.btCalcul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btCalcul_MouseUp);
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Checked = true;
            this.radioButtonHex.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonHex.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonHex.Location = new System.Drawing.Point(286, 271);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(67, 25);
            this.radioButtonHex.TabIndex = 37;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "HEX";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            this.radioButtonHex.CheckedChanged += new System.EventHandler(this.radioButtonRxHex_CheckedChanged);
            // 
            // radioButtonAsc
            // 
            this.radioButtonAsc.AutoSize = true;
            this.radioButtonAsc.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButtonAsc.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonAsc.Location = new System.Drawing.Point(365, 271);
            this.radioButtonAsc.Name = "radioButtonAsc";
            this.radioButtonAsc.Size = new System.Drawing.Size(76, 25);
            this.radioButtonAsc.TabIndex = 36;
            this.radioButtonAsc.Text = "ASCII";
            this.radioButtonAsc.UseVisualStyleBackColor = true;
            this.radioButtonAsc.CheckedChanged += new System.EventHandler(this.radioButtonRxAsc_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(10, 303);
            this.textBox2.MaxLength = 24;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(425, 28);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Cyan;
            this.textBox1.Location = new System.Drawing.Point(10, 10);
            this.textBox1.MaxLength = 10485760;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(425, 252);
            this.textBox1.TabIndex = 19;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "校验码计算";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.RadioButton radioButtonAsc;
        private System.Windows.Forms.Button btCalcul;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.ComboBox algBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}