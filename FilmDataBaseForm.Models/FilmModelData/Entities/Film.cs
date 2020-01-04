using System;
using System.Collections.Generic;

namespace FilmDataBaseForm.Models.Entities
{


	[Serializable]
	public class Film : IFilm
	{
		#region IFilm

		/// <summary>
		/// Название фильма
		/// </summary>
		public string Name { get; set; }

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
