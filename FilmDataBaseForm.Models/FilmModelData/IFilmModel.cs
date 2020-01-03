using System;

namespace FilmDataBaseForm.Models
{
	public delegate void WarningMessageProp(object sender, string message, string nameProperty);
	public interface IFilmModel
	{
		ICurrentFilm this[int index] { get; }
		bool IsNameValid(string nameFilm);
		int Count { get; }
		int Index { get; }
		void AddFilm();
		ICurrentFilm GetFilm();
		void SaveFilms(Action<object> setFilm);

		event WarningMessageProp WarningMessageProp;
	}
}