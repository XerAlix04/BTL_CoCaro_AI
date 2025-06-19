namespace BTL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnRedo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnCom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBanco = new System.Windows.Forms.Panel();
            this.btnPvP = new System.Windows.Forms.Button();
            this.btnAlphaBeta = new System.Windows.Forms.Button();
            this.timerTurn = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRedo.Location = new System.Drawing.Point(32, 489);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(199, 51);
            this.btnRedo.TabIndex = 4;
            this.btnRedo.Text = "Redo";
            this.btnRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(32, 623);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUndo.Location = new System.Drawing.Point(32, 425);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(199, 51);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnCom
            // 
            this.btnCom.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCom.Location = new System.Drawing.Point(32, 296);
            this.btnCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(199, 51);
            this.btnCom.TabIndex = 1;
            this.btnCom.Text = "Chế độ dễ";
            this.btnCom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL.Properties.Resources.Caro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBanco
            // 
            this.pnlBanco.BackColor = System.Drawing.Color.Lime;
            this.pnlBanco.Location = new System.Drawing.Point(318, 66);
            this.pnlBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBanco.Name = "pnlBanco";
            this.pnlBanco.Size = new System.Drawing.Size(669, 618);
            this.pnlBanco.TabIndex = 5;
            this.pnlBanco.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBanco_Paint);
            this.pnlBanco.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBanco_MouseClick);
            // 
            // btnPvP
            // 
            this.btnPvP.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPvP.Location = new System.Drawing.Point(32, 556);
            this.btnPvP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPvP.Name = "btnPvP";
            this.btnPvP.Size = new System.Drawing.Size(199, 51);
            this.btnPvP.TabIndex = 6;
            this.btnPvP.Text = "P vs P";
            this.btnPvP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPvP.UseVisualStyleBackColor = true;
            this.btnPvP.Click += new System.EventHandler(this.btnPvP_Click);
            // 
            // btnAlphaBeta
            // 
            this.btnAlphaBeta.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAlphaBeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlphaBeta.Location = new System.Drawing.Point(32, 360);
            this.btnAlphaBeta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlphaBeta.Name = "btnAlphaBeta";
            this.btnAlphaBeta.Size = new System.Drawing.Size(199, 51);
            this.btnAlphaBeta.TabIndex = 7;
            this.btnAlphaBeta.Text = "Chế độ khó";
            this.btnAlphaBeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlphaBeta.UseVisualStyleBackColor = true;
            this.btnAlphaBeta.Click += new System.EventHandler(this.btnAlphaBeta_Click);
            // 
            // timerTurn
            // 
            this.timerTurn.Interval = 1000;
            this.timerTurn.Tick += new System.EventHandler(this.timerTurn_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(919, 7);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 49);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 702);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnAlphaBeta);
            this.Controls.Add(this.btnPvP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.pnlBanco);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cờ caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Panel pnlBanco;
        private System.Windows.Forms.Button btnPvP;
        private System.Windows.Forms.Button btnAlphaBeta;
        private System.Windows.Forms.Timer timerTurn;
        private System.Windows.Forms.Label lblTime;
    }
}

