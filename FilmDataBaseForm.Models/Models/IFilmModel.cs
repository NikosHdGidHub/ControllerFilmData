using System;

namespace FilmDataBaseForm.Models
{
	public interface IFilmModel
	{
		ICurrentFilm this[int index] { get; }

		int Count { get; }
		int Index { get; }

		void AddFilm();
		ICurrentFilm GetFilm();
		void SaveFilms(Action<object> setFilm);
	}
}