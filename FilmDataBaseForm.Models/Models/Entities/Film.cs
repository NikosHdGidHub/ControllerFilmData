using System.Collections.Generic;
using System;

namespace FilmDataBaseForm.Models.Entities
{
	[Serializable]
	public struct ViewedStatus
	{
		public string NameStatus { get; set; }
	}
	[Serializable]
	public struct Rate
	{
		public string NameRate { get; set; }
	}
	[Serializable]
	public class Film : IFilm
	{
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
		public List<string> ViewedPartsUrl { get; set; }
		/// <summary>
		/// Оценка фильма
		/// </summary>
		public Rate Rate { get; set; }
		/// <summary>
		/// Ссылка к картинке
		/// </summary>
		public string ImageUrl { get; set; }
		/// <summary>
		/// Статус просмотра фильма
		/// </summary>
		public ViewedStatus ViewedStatus { get; set; }
	}
}
