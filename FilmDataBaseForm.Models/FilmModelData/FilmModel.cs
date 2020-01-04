using FilmDataBaseForm.Models.Entities;
using FilmDataBaseForm.Models.FilmModelData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmDataBaseForm.Models
{
	public struct FormatFilmList
	{
		public FormatFilmList(int iD, string nameFilm, int rateFilm, bool multiSerial)
		{
			ID = iD;
			NameFilm = nameFilm ?? throw new ArgumentNullException(nameof(nameFilm));
			RateFilm = rateFilm;
			MultiSerial = multiSerial;
		}

		public int ID { get; }
		public string NameFilm { get; }
		public int RateFilm { get; }
		public bool MultiSerial { get; }
	}

	public class FilmModel : ICurrentFilm, IFilmModel
	{
		private readonly string[] RATE_LIST_DATA = new[]
		{
			Messages.Rate0,
			Messages.Rate1,
			Messages.Rate2,
			Messages.Rate3,
			Messages.Rate4,
			Messages.Rate5,
			Messages.Rate6,
		};
		private readonly string[] STATUS_LIST_DATA = new[]
		 {
			Messages.StatusFilm0,
			Messages.StatusFilm1,
			Messages.StatusFilm2
		};



		/// <summary>
		/// Возвращает экземпляр класса FilmModel через интерфейс IFilmModel.
		/// </summary>
		/// <param name="getFilms">Метод который должен возвращать список фильмов.</param>
		/// <returns>FilmModel.</returns>
		public static IFilmModel GetModel(Func<object> getFilms)
		{
			return new FilmModel(getFilms);
		}
		private FilmModel(Func<object> getFilms)
		{
			//Load
			LoadFilms(getFilms);
		}
		/// <summary>
		/// Список фильмов
		/// </summary>
		private List<IFilm> _films;
		/// <summary>
		/// Является ссылкой активного фильма (изменяя это свойство оно меняется в списке!)
		/// </summary>
		private IFilm _currentFilm;

		#region prrivateFinctions

		/// <summary>
		/// Загружает фильм исполняя переданный метод.
		/// </summary>
		/// <param name="getFilms">Метод который должен возвращать список фильмов.</param>
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
		private void SetRate(string strRate)
		{
			if (!IsValidRate(strRate, out bool? isIndex)) throw new FormatException();

			if (isIndex == true) _currentFilm.Rate = byte.Parse(strRate);
			else
			{
				_currentFilm.Rate = Convert.ToByte(Array.IndexOf(RATE_LIST_DATA, strRate));
			}
		}
		private void SetStatus(string strStatusIndex)
		{
			if (!IsValidStaus(strStatusIndex, out byte result))
			{
				throw new FormatException();
			}
			_currentFilm.ViewedStatus = result;
		}

		#endregion

		//TODO: Реализовать отдачу списка фильмов возможно в виде структуры с ID для возможности сортировки
		#region IFilmModel
		public FormatFilmList[] GetFilmList()
		{
			var len = _films.Count;
			var filmList = new FormatFilmList[len];
			for (int i = 0; i < len; i++)
			{
				var film = _films[i];
				var FormatFilm = new FormatFilmList(i, film.Name, film.Rate, (film.ViewedPartsUrl.Count > 0) ? true : false);
				filmList[i] = FormatFilm;
			}
			return filmList;
		}

		public bool IsValidName(string nameFilm)
		{
			if (string.IsNullOrWhiteSpace(nameFilm))
			{
				WarningMessageProp?.Invoke(this, Messages.NameFilmIsNull, nameof(nameFilm));
				return false;
			}
			if (nameFilm.Length > Convert.ToInt32(Constants.MaxSetLengthNameFilm))
			{
				WarningMessageProp?.Invoke(this, Messages.NameFilmIsLong, nameof(nameFilm));
				return false;
			}
			return true;
		}
		public bool IsValidRate(string strRate, out bool? resultIsIndexInList)
		{
			resultIsIndexInList = null;
			if (RATE_LIST_DATA.SingleOrDefault(item => item == strRate) != default)
			{
				resultIsIndexInList = false;
				return true;
			}
			if (byte.TryParse(strRate, out byte result))
			{
				if (result >= 0 && result < RATE_LIST_DATA.Length)
				{
					resultIsIndexInList = true;
					return true;
				}
			}
			WarningMessageProp?.Invoke(this, Messages.RateFilmIsNotCorrect, nameof(strRate));
			return false;
		}
		public bool IsValidStaus(string strStatusIndex, out byte result)
		{
			if (byte.TryParse(strStatusIndex, out result))
			{
				if (result >= 0 && result < STATUS_LIST_DATA.Length)
				{
					return true;
				}
			}
			WarningMessageProp?.Invoke(this, Messages.StatusFilmIsNotCorrect, null);
			return false;
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
			IFilm film = new Film { Name = FilmModelData.Constants.DefaultNameFilm + " " + (Count + 1) };
			_films.Add(film);
			SetCurrentFulm(Count - 1);
		}
		public ICurrentFilm GetFilm()
		{
			return this;
		}
		public event WarningMessageProp WarningMessageProp;

		#endregion

		#region ICurrentFilm
		string ICurrentFilm.GetShortNameFilm()
		{
			var len = int.Parse(FilmModelData.Constants.MaxGetLengthNameFilm);
			return GetFilm().GetShortNameFilm(len);
		}
		string ICurrentFilm.GetShortNameFilm(int len)//root
		{
			string result = _currentFilm.Name;
			if (_currentFilm.Name.Length > len)
			{
				result = _currentFilm.Name.Substring(0, len - 3) + "...";
			}
			return result;
		}
		int ICurrentFilm.GetRateIndex()
		{
			return _currentFilm.Rate;
		}
		int ICurrentFilm.GetStatusIndex()
		{
			return _currentFilm.ViewedStatus;
		}



		string ICurrentFilm.Name
		{
			get => _currentFilm.Name;
			set
			{
				if (IsValidName(value))
				{
					_currentFilm.Name = value;
				}
				else throw new FormatException();
			}
		}
		string ICurrentFilm.Url { get => _currentFilm.Url; set => _currentFilm.Url = value; }
		string ICurrentFilm.Comment { get => _currentFilm.Comment; set => _currentFilm.Comment = value; }
		List<string> ICurrentFilm.ViewedPartsUrl => _currentFilm.ViewedPartsUrl;
		string ICurrentFilm.Rate
		{
			get => RATE_LIST_DATA[_currentFilm.Rate];
			set => SetRate(value);
		}
		string ICurrentFilm.ImageUrl { get => _currentFilm.ImageUrl; set => _currentFilm.ImageUrl = value; }
		string ICurrentFilm.ViewedStatus
		{

			get => STATUS_LIST_DATA[_currentFilm.ViewedStatus];
			set => SetStatus(value);
		}
		#endregion
	}
}
