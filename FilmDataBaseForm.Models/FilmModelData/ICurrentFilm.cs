using System.Collections.Generic;

namespace FilmDataBaseForm.Models
{
	public interface ICurrentFilm
	{
		/// <summary>
		/// Комментарий к фильму.
		/// </summary>
		string Comment { get; set; }
		/// <summary>
		/// Ссылка на изображение.
		/// </summary>
		string ImageUrl { get; set; }
		/// <summary>
		/// Название фильма
		/// </summary>
		string Name { get; set; }
		/// <summary>
		/// Рейтинг фильма
		/// </summary>
		string Rate { get; set; }
		/// <summary>
		/// Ссылка на скачивание фильма или на просмотр онлайн.
		/// </summary>
		string Url { get; set; }
		/// <summary>
		/// Дополнительная информация по сериям фильма (если есть серии).
		/// </summary>
		List<string> ViewedPartsUrl { get; }
		/// <summary>
		/// Статус просмотренности фильма
		/// </summary>
		string ViewedStatus { get; set; }

		/// <summary>
		/// Возвращает сокращенное имя фильма ( длина задается в ресурсах)
		/// </summary>
		/// <returns>Название фильма.</returns>
		string GetShortNameFilm();
		/// <summary>
		/// Возвращает сокращенное имя фильма.
		/// </summary>
		/// <param name="len">Длина имени</param>
		/// <returns>Название фильма.</returns>
		string GetShortNameFilm(int len);
		/// <summary>
		/// Возвращает индекс рейтинга фильма.
		/// </summary>
		/// <returns>Индекс</returns>
		int GetRateIndex();
		/// <summary>
		/// Возвращает индекс статуса фильма.
		/// </summary>
		/// <returns>Статус.</returns>
		int GetStatusIndex();
	}
}