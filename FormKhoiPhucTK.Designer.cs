namespace BTL
{
    partial class FormKhoiPhucTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoiPhucTK));
            this.btnLLMK = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtEmailKP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLLMK
            // 
            this.btnLLMK.Location = new System.Drawing.Point(347, 360);
            this.btnLLMK.Name = "btnLLMK";
            this.btnLLMK.Size = new System.Drawing.Size(129, 34);
            this.btnLLMK.TabIndex = 14;
            this.btnLLMK.Text = "Lấy lại mật khẩu";
            this.btnLLMK.UseVisualStyleBackColor = true;
            this.btnLLMK.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(272, 272);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(300, 22);
            this.txtKQ.TabIndex = 11;
            // 
            // txtEmailKP
            // 
            this.txtEmailKP.Location = new System.Drawing.Point(272, 190);
            this.txtEmailKP.Name = "txtEmailKP";
            this.txtEmailKP.Size = new System.Drawing.Size(300, 22);
            this.txtEmailKP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email đăng ký";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormKhoiPhucTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLLMK);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtEmailKP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKhoiPhucTK";
            this.Text = "FormKhoiPhucTK";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLLMK;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtEmailKP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}