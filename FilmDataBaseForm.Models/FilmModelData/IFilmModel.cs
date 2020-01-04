using System;

namespace FilmDataBaseForm.Models
{
	public delegate void WarningMessageProp(object sender, string message, string nameProperty);
	public interface IFilmModel
	{
		ICurrentFilm this[int index] { get; }
		FormatFilmList[] GetFilmList();
		bool IsValidName(string nameFilm);
		bool IsValidRate(string strRate, out bool? resultIsIndexInList);
		bool IsValidStaus(string strStatusIndex, out byte result);
		int Count { get; }
		int Index { get; }
		void AddFilm();
		ICurrentFilm GetFilm();
		void SaveFilms(Action<object> setFilm);

		event WarningMessageProp WarningMessageProp;
	}
}