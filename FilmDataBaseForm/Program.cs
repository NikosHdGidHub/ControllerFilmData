using System;
using System.Windows.Forms;

namespace FilmDataBaseForm
{
	internal static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			IMainStartForm mainStartForm = new Controller();

			mainStartForm.RunMainForm(new MainForm());
		}
	}
}
