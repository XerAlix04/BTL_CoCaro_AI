namespace BTL
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.linkQMK = new System.Windows.Forms.LinkLabel();
            this.linkDK = new System.Windows.Forms.LinkLabel();
            this.btnDN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTDN
            // 
            this.txtTDN.Location = new System.Drawing.Point(305, 240);
            this.txtTDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(337, 26);
            this.txtTDN.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(305, 342);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(337, 26);
            this.txtMK.TabIndex = 3;
            // 
            // linkQMK
            // 
            this.linkQMK.AutoSize = true;
            this.linkQMK.Location = new System.Drawing.Point(258, 425);
            this.linkQMK.Name = "linkQMK";
            this.linkQMK.Size = new System.Drawing.Size(127, 20);
            this.linkQMK.TabIndex = 4;
            this.linkQMK.TabStop = true;
            this.linkQMK.Text = "Quên mật khẩu?";
            this.linkQMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQMK_LinkClicked);
            // 
            // linkDK
            // 
            this.linkDK.AutoSize = true;
            this.linkDK.Location = new System.Drawing.Point(568, 424);
            this.linkDK.Name = "linkDK";
            this.linkDK.Size = new System.Drawing.Size(67, 20);
            this.linkDK.TabIndex = 5;
            this.linkDK.TabStop = true;
            this.linkDK.Text = "Đăng ký";
            this.linkDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDK_LinkClicked);
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(389, 480);
            this.btnDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(145, 42);
            this.btnDN.TabIndex = 6;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.linkDK);
            this.Controls.Add(this.linkQMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.LinkLabel linkQMK;
        private System.Windows.Forms.LinkLabel linkDK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}