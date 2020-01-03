using System.Collections.Generic;

namespace FilmDataBaseForm.Models
{
	//TODO: За комментировать интерфейс
	public interface ICurrentFilm
	{
		string Comment { get; set; }
		string ImageUrl { get; set; }
		string Name { get; set; }
		string Rate { get; set; }
		string Url { get; set; }
		List<string> ViewedPartsUrl { get; }
		string ViewedStatus { get; set; }

		string GetShortNameFilm();
		string GetShortNameFilm(int len);
	}
}