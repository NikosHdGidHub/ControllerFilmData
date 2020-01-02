
namespace Views.MainView
{
	internal interface IMainView : FilmDataBaseForm.IFormBase
	{

	}
}
namespace FilmDataBaseForm
{
	public partial class MainForm : Views.MainView.IMainView
	{
		void IFormBase.CloseF()
		{
			throw new System.NotImplementedException();
		}

		void IFormBase.HideF()
		{
			throw new System.NotImplementedException();
		}

		void IFormBase.ShowDialogF()
		{
			throw new System.NotImplementedException();
		}

		void IFormBase.ShowF()
		{
			throw new System.NotImplementedException();
		}
	}
}
