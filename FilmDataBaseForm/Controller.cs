using Precedents.MainPresenter;
using System;
using System.Windows.Forms;
using Views.MainView;
//using Models;

#region Интерфейсы прецедентов
namespace Precedents.MainPresenter
{
	internal interface IMainPresenter
	{
		//Отсюда я могу создавать экземпляры зависимых форм
		//.....
		void RunOptionForm();
	}
}


#endregion

namespace FilmDataBaseForm
{

	internal interface IMainStartForm
	{
		void RunMainForm(Form maintForm);
	}


	internal class Controller : IMainStartForm, IMainPresenter
	{
		#region Общие ссылочные типы данных (Модели,...)
		//Здесь описываются общие модели, ссылочные типы данных!
		//которые будут доступны методам класса Controller
		//Будьте внимательны при использовании их в Асинхронном или много-поточном выполнении!!!

		//private readonly ISomeModel sm = new SomeModel();

		// -------------------------------------------------------------
		#endregion

		#region Реализация глобальных событий
		//Для добавления глобальных событий используйте интерфейс (IGeneric, и тп.)
		//Который наследуйте интерфейсами прецедентов
		#endregion

		void IMainStartForm.RunMainForm(Form maintForm)
		{
			//Создание дополнительных форм и моделей
			//.....
			new MainPrecedent((IMainView)maintForm);
			Application.Run(maintForm);
		}

		void IMainPresenter.RunOptionForm()
		{
			//Создание дополнительных форм и моделей
			//.....
			//new SomePrecedent(sm,data);
			//Form.ShowDialog();
			//Form.Disponce()
			throw new NotImplementedException();
		}
	}
}
