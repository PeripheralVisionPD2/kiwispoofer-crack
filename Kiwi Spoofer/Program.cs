using System;
using System.Net;
using System.Windows.Forms;

namespace Spoofer
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00003304 File Offset: 0x00001504
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
