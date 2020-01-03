﻿using System;
using System.Collections.Generic;

namespace FilmDataBaseForm.Models.Entities
{
	
	
	[Serializable]
	public class Film : IFilm
	{
		private const string DEFAULT_NAME = "Новый фильм";

		private string _name;

		#region IFilm

		/// <summary>
		/// Название фильма
		/// </summary>
		public string Name
		{
			get => _name;
			set
			{
				if (value == null)
				{
					_name = DEFAULT_NAME;
				}
				else
				{
					_name = value;
				}
			}
		}
		/// <summary>
		/// Ссылка на скачивание
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Комментарий
		/// </summary>
		public string Comment { get; set; }
		/// <summary>
		/// Если много частей (серий), то хранит ссылки эти на серии.
		/// </summary>
		public List<string> ViewedPartsUrl { get; } = new List<string>();
		/// <summary>
		/// Оценка фильма
		/// </summary>
		public byte Rate { get; set; }
		/// <summary>
		/// Ссылка к картинке
		/// </summary>
		public string ImageUrl { get; set; }
		/// <summary>
		/// Статус просмотра фильма
		/// </summary>
		public byte ViewedStatus { get; set; }
		#endregion
	}
}
