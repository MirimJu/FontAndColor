namespace FontAndColor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbtnFont = new System.Windows.Forms.ToolStripButton();
            this.tlsbtnColor = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(274, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsMenu
            // 
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbtnFont,
            this.tlsbtnColor});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(274, 25);
            this.tlsMenu.TabIndex = 1;
            this.tlsMenu.Text = "toolStrip1";
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 25);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(274, 226);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = resources.GetString("rtbText.Text");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "3118주미림-폰트 변경";
            // 
            // tslbtnFont
            // 
            this.tslbtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslbtnFont.Image = ((System.Drawing.Image)(resources.GetObject("tslbtnFont.Image")));
            this.tslbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslbtnFont.Name = "tslbtnFont";
            this.tslbtnFont.Size = new System.Drawing.Size(23, 22);
            this.tslbtnFont.Text = "toolStripButton1";
            this.tslbtnFont.Click += new System.EventHandler(this.TslBtnFont_Click);
            // 
            // tlsbtnColor
            // 
            this.tlsbtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnColor.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnColor.Image")));
            this.tlsbtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnColor.Name = "tlsbtnColor";
            this.tlsbtnColor.Size = new System.Drawing.Size(23, 22);
            this.tlsbtnColor.Text = "toolStripButton2";
            this.tlsbtnColor.Click += new System.EventHandler(this.TlsBtnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 273);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "3118주미림";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton tslbtnFont;
        private System.Windows.Forms.ToolStripButton tlsbtnColor;
    }
}

