namespace Spoofer
{
	// Token: 0x02000003 RID: 3
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002C5F File Offset: 0x00000E5F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002C80 File Offset: 0x00000E80
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Spoofer.Login));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.Login_button = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.Title_Login = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(361, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(64, 67);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(8, 80);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(44, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "HWID";
			this.Login_button.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Login_button.Location = new global::System.Drawing.Point(169, 151);
			this.Login_button.Name = "Login_button";
			this.Login_button.Size = new global::System.Drawing.Size(89, 30);
			this.Login_button.TabIndex = 6;
			this.Login_button.Text = "Login";
			this.Login_button.UseVisualStyleBackColor = true;
			this.Login_button.Click += new global::System.EventHandler(this.Login_button_Click);
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(58, 151);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(89, 30);
			this.button1.TabIndex = 7;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.Title_Login.AutoSize = true;
			this.Title_Login.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Title_Login.ForeColor = global::System.Drawing.Color.White;
			this.Title_Login.Location = new global::System.Drawing.Point(12, 18);
			this.Title_Login.Name = "Title_Login";
			this.Title_Login.Size = new global::System.Drawing.Size(110, 25);
			this.Title_Login.TabIndex = 8;
			this.Title_Login.Text = "Kiwi Login";
			this.textBox1.BackColor = global::System.Drawing.Color.DarkGreen;
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(58, 79);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(200, 20);
			this.textBox1.TabIndex = 9;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.Color.White;
			this.button4.Location = new global::System.Drawing.Point(327, 80);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(98, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "Discord";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(327, 127);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(98, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Copy HWID";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.DarkGreen;
			base.ClientSize = new global::System.Drawing.Size(428, 195);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.Title_Login);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.Login_button);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			base.Load += new global::System.EventHandler(this.Login_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000F RID: 15
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button Login_button;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label Title_Login;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button2;
	}
}
