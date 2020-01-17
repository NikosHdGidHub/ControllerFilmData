using System;

namespace FilmDataBaseForm.Models
{
	public delegate void WarningMessageProp(object sender, string message, string nameProperty);
	public interface IFilmModel
	{
		/// <summary>
		/// Возвращает ссылку на этот экземпляр через интерфейсом фильма
		/// </summary>
		/// <param name="index">Индекс выбранного фильма</param>
		/// <returns>Ссылка на себя</returns>
		ICurrentFilm this[int index] { get; }
		/// <summary>
		/// Возвращает список всех фильмов, только для чтения
		/// </summary>
		/// <returns></returns>
		FormatFilmList[] GetFilmList();
		/// <summary>
		/// Проверяет задаваемое имя фильма на корректность. Использует событие WarningMessageProp.
		/// </summary>
		/// <param name="nameFilm">Имя фильма</param>
		/// <returns></returns>
		bool IsValidName(string nameFilm);
		/// <summary>
		/// Проверяет правильность задаваемого рейтинга фильмов. Использует событие WarningMessageProp.
		/// </summary>
		/// <param name="strRate">Рейтинг. Задается либо индексом, либо строкой</param>
		/// <param name="resultIsIndexInList">Правда - если рейтинг задавался индексом</param>
		/// <returns></returns>
		bool IsValidRate(string strRate, out bool? resultIsIndexInList);
		/// <summary>
		/// Проверяет правильность задаваемого статуса фильмов. Использует событие WarningMessageProp.
		/// </summary>
		/// <param name="strStatusIndex">Индекс статуса.</param>
		/// <param name="result">Переведенный индекс в байты</param>
		/// <returns></returns>
		bool IsValidStaus(string strStatusIndex, out byte result);
		/// <summary>
		/// Количество фильмов.
		/// </summary>
		int Count { get; }
		/// <summary>
		/// Индекс текущего фильма
		/// </summary>
		int Index { get; }
		/// <summary>
		/// Создает новый фильм и выбирает его.
		/// </summary>
		void AddFilm();
		/// <summary>
		/// Возвращает выбранный фильм (ссылка!! на экземпляр самого себя)
		/// </summary>
		/// <returns></returns>
		ICurrentFilm GetFilm();
		/// <summary>
		/// Вызывает переданный метод, кладя в него список фильмов
		/// </summary>
		/// <param name="setFilm">Метод для сохранения фильмов</param>
		void SaveFilms(Action<object> setFilm);
		/// <summary>
		/// Вызывается как предупреждение об некорректном вводе.
		/// </summary>
		event WarningMessageProp WarningMessageProp;		
	}
}