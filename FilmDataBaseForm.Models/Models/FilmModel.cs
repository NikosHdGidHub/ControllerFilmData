using FilmDataBaseForm.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDataBaseForm.Models
{
	public class FilmModel
	{
		private List<IFilm> _films;

		public int Count => _films.Count;
		public IFilm CurrentFilm { get; private set; }
		public FilmModel(Func<object> getFilms)
		{
			//Load
			LoadFilms(getFilms);			
		}

		private void LoadFilms(Func<object> getFilms)
		{
			var obj = getFilms();
			if (obj is List<IFilm> films)
				_films = films;
			else
				_films = new List<IFilm>();

			SetDefaultCurrentFilm();

		}
		private void SetDefaultCurrentFilm()
		{
			if (Count < 1)
				AddFilm();
			else
				SetCurrentFulm(0);
		}
		private void SetCurrentFulm(int index)
		{
			if (index < 0 || index >= Count)
				throw new IndexOutOfRangeException("index = " + index);

			CurrentFilm = _films.ElementAt(index);
		}
		
		public void SaveFilms(Action<object> setFilm)
		{
			setFilm(_films);
		}
		public void AddFilm()
		{
			IFilm film = new Film { Name = "Новый фильм " + (Count+1)};
			_films.Add(film);
			SetCurrentFulm(Count - 1);
		}
	}
}
