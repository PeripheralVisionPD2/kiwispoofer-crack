using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Windows.Forms;

namespace Spoofer
{
	// Token: 0x02000002 RID: 2
	public partial class Kiwi : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Kiwi()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000206C File Offset: 0x0000026C
		private void Form1_Load(object sender, EventArgs e)
		{
			string path = "C:\\Windows\\SystemSettings";
			string path2 = "C:\\Windows\\SystemSettings\\Assets";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/710858392737939559/717425878052634674/gdrv.sys", "C:\\Windows\\SystemSettings\\Assets\\gdrv.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/710858392737939559/717425884591685642/Kernel.sys", "C:\\Windows\\SystemSettings\\Assets\\Kernel.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/710858392737939559/717425886433116180/swind2.exe", "C:\\Windows\\SystemSettings\\Assets\\swind2.exe");
				if (!File.Exists("C:\\Windows\\tracing\\Assets\\gdrv.sysC:\\Windows\\SystemSettings\\Assets\\swind2.exeC:\\Windows\\SystemSettings\\Assets\\Kernel.sys"))
				{
					Console.Beep(500, 200);
					MessageBox.Show("Succed to install files", "Kiwi Spoofer");
					return;
				}
				Console.Beep(500, 200);
				MessageBox.Show("Failed to install files", "Kiwi Spoofer Error");
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002125 File Offset: 0x00000325
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002127 File Offset: 0x00000327
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002144 File Offset: 0x00000344
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this.mouseLocation.X, this.mouseLocation.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002188 File Offset: 0x00000388
		private void label2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Have Fun", "Kiwi Spoofer");
			Application.Exit();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000219F File Offset: 0x0000039F
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021A1 File Offset: 0x000003A1
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021A3 File Offset: 0x000003A3
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021A8 File Offset: 0x000003A8
		private void button2_Click(object sender, EventArgs e)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd");
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			Process process = Process.Start(processStartInfo);
			process.StandardInput.WriteLine("cd C:\\Windows\\SystemSettings\\Assets");
			process.StandardInput.WriteLine("swind2.exe gdrv.sys Kernel.sys");
			process.StandardInput.WriteLine("exit");
			process.StandardOutput.ReadToEnd();
			process.StandardOutput.ReadToEnd();
			if (processStartInfo != null)
			{
				Console.Beep(500, 200);
				MessageBox.Show("Spoofed", "Kiwi Spoofer");
				return;
			}
			Console.Beep(500, 200);
			MessageBox.Show("Failed to Spoof", "Error");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002270 File Offset: 0x00000470
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002272 File Offset: 0x00000472
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002274 File Offset: 0x00000474
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002276 File Offset: 0x00000476
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002278 File Offset: 0x00000478
		private void button3_Click_1(object sender, EventArgs e)
		{
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				Kiwi.HardDrive hardDrive = new Kiwi.HardDrive();
				hardDrive.SerialNo = managementObject["SerialNumber"].ToString();
				this.hardDriveDetails.Add(hardDrive);
				this.label5.Text = "Serial Key : " + hardDrive.SerialNo;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002310 File Offset: 0x00000510
		private void label5_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002312 File Offset: 0x00000512
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002314 File Offset: 0x00000514
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002316 File Offset: 0x00000516
		private void textBox2_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002318 File Offset: 0x00000518
		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000231A File Offset: 0x0000051A
		private void label5_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		public Point mouseLocation;

		// Token: 0x04000002 RID: 2
		private ArrayList hardDriveDetails = new ArrayList();

		// Token: 0x02000007 RID: 7
		private class HardDrive
		{
			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600002E RID: 46 RVA: 0x00003428 File Offset: 0x00001628
			// (set) Token: 0x0600002F RID: 47 RVA: 0x00003430 File Offset: 0x00001630
			public string Model
			{
				get
				{
					return this.model;
				}
				set
				{
					this.model = value;
				}
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000030 RID: 48 RVA: 0x00003439 File Offset: 0x00001639
			// (set) Token: 0x06000031 RID: 49 RVA: 0x00003441 File Offset: 0x00001641
			public string Type
			{
				get
				{
					return this.type;
				}
				set
				{
					this.type = value;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000032 RID: 50 RVA: 0x0000344A File Offset: 0x0000164A
			// (set) Token: 0x06000033 RID: 51 RVA: 0x00003452 File Offset: 0x00001652
			public string SerialNo
			{
				get
				{
					return this.serialNo;
				}
				set
				{
					this.serialNo = value;
				}
			}

			// Token: 0x0400001C RID: 28
			private string model;

			// Token: 0x0400001D RID: 29
			private string type;

			// Token: 0x0400001E RID: 30
			private string serialNo;
		}
	}
}
