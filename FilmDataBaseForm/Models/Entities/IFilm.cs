using System.Collections.Generic;

namespace FilmDataBaseForm.Models.Entities
{
	internal interface IFilm
	{
		/// <summary>
		/// 
		/// </summary>
		string Comment { get; set; }
		string ImageUrl { get; set; }
		string Name { get; set; }
		Rate Rate { get; set; }
		string Url { get; set; }
		List<string> ViewedPartsUrl { get; set; }
		ViewedStatus ViewedStatus { get; set; }
	}
}