﻿using FilmDataBaseForm.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmDataBaseForm.Models
{
	public class FilmModel : ICurrentFilm, IFilmModel
	{
		public static IFilmModel GetModel(Func<object> getFilms)
		{
			return new FilmModel(getFilms);
		}


		/// <summary>
		/// Список фильмов
		/// </summary>
		private List<IFilm> _films;
		/// <summary>
		/// Является ссылкой активного фильма (изменяя это свойство оно меняется в списке!)
		/// </summary>
		private IFilm _currentFilm;

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

			_currentFilm = _films.ElementAt(index);
			Index = index;
		}

		private FilmModel(Func<object> getFilms)
		{
			//Load
			LoadFilms(getFilms);
		}
		public ICurrentFilm this[int index]
		{
			get
			{
				SetCurrentFulm(index);
				return this;
			}
		}


		public int Count => _films.Count;
		public int Index { get; private set; }

		public void SaveFilms(Action<object> setFilm)
		{
			setFilm(_films);
		}
		public void AddFilm()
		{
			IFilm film = new Film { Name = "Новый фильм " + (Count + 1) };
			_films.Add(film);
			SetCurrentFulm(Count - 1);
		}
		public ICurrentFilm GetFilm()
		{
			return this;
		}


		//TODO: Проверить входящие данные
		#region ICurrentFilm
		string ICurrentFilm.Name { get => _currentFilm.Name; set => _currentFilm.Name = value; }
		string ICurrentFilm.Url { get => _currentFilm.Url; set => _currentFilm.Url = value; }
		string ICurrentFilm.Comment { get => _currentFilm.Comment; set => _currentFilm.Comment = value; }
		List<string> ICurrentFilm.ViewedPartsUrl => _currentFilm.ViewedPartsUrl;
		//TODO: Реализовать обработчик Rate
		string ICurrentFilm.Rate
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		//TODO: Реализовать обработчик статуса
		}
		string ICurrentFilm.ImageUrl { get => _currentFilm.ImageUrl; set => _currentFilm.ImageUrl = value; }
		//TODO: Реализовать обработчик статуса
		string ICurrentFilm.ViewedStatus
		{
			
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}
		#endregion
	}
}
