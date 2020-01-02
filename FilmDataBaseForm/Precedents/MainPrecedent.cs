using Views.MainView;


namespace Precedents.MainPresenter
{
	internal class MainPrecedent
	{
		private readonly IMainView _mainView;
		private readonly IMainPresenter _controller = new FilmDataBaseForm.Controller();

		public MainPrecedent(IMainView mainView)
		{
			_mainView = mainView;
		}
	}
}
