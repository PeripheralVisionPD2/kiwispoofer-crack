namespace Spoofer
{
	// Token: 0x02000002 RID: 2
	public partial class Kiwi : global::System.Windows.Forms.Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000231C File Offset: 0x0000051C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000233C File Offset: 0x0000053C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Spoofer.Kiwi));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(69, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(613, 71);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(581, 2);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(32, 31);
			this.label2.TabIndex = 2;
			this.label2.Text = "X";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(186, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(115, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kiwi Spoofer";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.button2.BackColor = global::System.Drawing.Color.DarkGreen;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(12, 114);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(167, 60);
			this.button2.TabIndex = 1;
			this.button2.Text = "Spoof ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.pictureBox1.BackColor = global::System.Drawing.Color.DarkGreen;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(70, 71);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(501, 320);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(181, 80);
			this.label3.TabIndex = 5;
			this.label3.Text = "Spoofer Dev:  kiwifirmin#8888\r\nMenu Dev: Ski#1363\r\n\r\n\r\n\r\n";
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(9, 285);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(0, 16);
			this.label4.TabIndex = 6;
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.button3.BackColor = global::System.Drawing.Color.DarkGreen;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(12, 205);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(167, 60);
			this.button3.TabIndex = 7;
			this.button3.Text = "Check HWID";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click_1);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(203, 114);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(44, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "HWID";
			this.label5.Click += new global::System.EventHandler(this.label5_Click_2);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.DarkGreen;
			base.ClientSize = new global::System.Drawing.Size(682, 360);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Kiwi";
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label5;
	}
}
