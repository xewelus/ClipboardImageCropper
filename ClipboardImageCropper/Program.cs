using System;
using System.Threading;
using System.Windows.Forms;

namespace ClipboardImageCropper
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			Application.ThreadException += ApplicationOnThreadException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new NotifyApplicationContext());
		}

		private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs args)
		{
			MessageBox.Show(args.Exception.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
