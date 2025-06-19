namespace BTL
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            this.btnDK = new System.Windows.Forms.Button();
            this.txtMKDK = new System.Windows.Forms.TextBox();
            this.txtTTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(340, 369);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(129, 34);
            this.btnDK.TabIndex = 14;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // txtMKDK
            // 
            this.txtMKDK.Location = new System.Drawing.Point(278, 225);
            this.txtMKDK.Name = "txtMKDK";
            this.txtMKDK.Size = new System.Drawing.Size(300, 22);
            this.txtMKDK.TabIndex = 11;
            // 
            // txtTTK
            // 
            this.txtTTK.Location = new System.Drawing.Point(278, 190);
            this.txtTTK.Name = "txtTTK";
            this.txtTTK.Size = new System.Drawing.Size(300, 22);
            this.txtTTK.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(278, 263);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.Size = new System.Drawing.Size(300, 22);
            this.txtXNMK.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(278, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtXNMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.txtMKDK);
            this.Controls.Add(this.txtTTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDangKy";
            this.Text = "FormDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.TextBox txtMKDK;
        private System.Windows.Forms.TextBox txtTTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
    }
}