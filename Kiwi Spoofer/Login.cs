using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace Spoofer
{
	// Token: 0x02000003 RID: 3
	public partial class Login : Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002B07 File Offset: 0x00000D07
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002B15 File Offset: 0x00000D15
		private void Login_Load(object sender, EventArgs e)
		{
			this.textBox1.Text = "CRACKED";
			this.textBox1.ReadOnly = true;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B49 File Offset: 0x00000D49
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002B50 File Offset: 0x00000D50
		private void HWID_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002B54 File Offset: 0x00000D54
		private void Login_button_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Welcome", "Kiwi Spoofer");
			Form form = new Kiwi();
			base.Hide();
			form.ShowDialog();
			return;
			
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002BBE File Offset: 0x00000DBE
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002BC0 File Offset: 0x00000DC0
		private void Login_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002BDC File Offset: 0x00000DDC
		private void Login_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this.mouseLocation.X, this.mouseLocation.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002C20 File Offset: 0x00000E20
		private void Login_MouseUp(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002C22 File Offset: 0x00000E22
		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/RgjCe6a");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002C2F File Offset: 0x00000E2F
		private void Key_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002C31 File Offset: 0x00000E31
		private void button2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.textBox1.Text);
			this.button2.Enabled = false;
			this.button2.Text = "Copied";
		}

		// Token: 0x0400000D RID: 13
		private string HWIDs;

		// Token: 0x0400000E RID: 14
		public Point mouseLocation;

		// Token: 0x04000011 RID: 17
		private TextBox HWID;
	}
}
