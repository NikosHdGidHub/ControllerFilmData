using System.Collections.Generic;

namespace FilmDataBaseForm.Models.Entities
{
	public interface IFilm
	{
		/// <summary>
		/// Название фильма
		/// </summary>
		string Name { get; set; }
		/// <summary>
		/// Ссылка на скачивание
		/// </summary>
		string Url { get; set; }
		/// <summary>
		/// Комментарий
		/// </summary>
		string Comment { get; set; }
		/// <summary>
		/// Если много частей (серий), то хранит ссылки эти на серии.
		/// </summary>
		List<string> ViewedPartsUrl { get; set; }
		/// <summary>
		/// Оценка фильма
		/// </summary>
		Rate Rate { get; set; }
		/// <summary>
		/// Ссылка к картинке
		/// </summary>
		string ImageUrl { get; set; }
		/// <summary>
		/// Статус просмотра фильма
		/// </summary>
		ViewedStatus ViewedStatus { get; set; }
	}
}