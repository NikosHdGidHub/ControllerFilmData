using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmDataBaseForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.StreamDataController;

namespace FilmDataBaseForm.Models.Tests
{
	[TestClass()]
	public class FilmModelTests
	{
		private IStreamDataController<string> fM = new FileController();
		private string path = "TestSer.dat";
		private object Load()
		{
			return fM.LoadBinaryFormatter();
		}
		private void Save(object obj)
		{
			fM.SaveBinaryFormatter(obj);
		}
		private IFilmModel GetFilmModel()
		{
			fM.Create(path);
			return FilmModel.GetModel(Load);
		}

		[TestMethod()]
		public void LoadIndexFilmsTest()
		{
			var filmModel = GetFilmModel();
			Assert.AreEqual(1, filmModel.Count);
			Assert.AreEqual(0, filmModel.Index);
		}
		[TestMethod()]
		public void Save_AddFilmsTest()
		{
			var filmModel = GetFilmModel();
			filmModel.AddFilm();
			filmModel.SaveFilms(Save);
			var filmModel2 = FilmModel.GetModel(Load);
			Assert.AreEqual(2, filmModel2.Count);
		}
		[TestMethod()]
		public void IndexatorFilmsTest()
		{
			var filmModel = GetFilmModel();
			var film = filmModel.GetFilm();
			film.Name = "AAAAAAAAAAA";
			Assert.AreEqual(film.Name, filmModel[0].Name);
		}

		[TestMethod()]
		public void GetSetNameFilmTest()
		{
			var testName = Guid.NewGuid().ToString();
			var testName2 = "ASDSDASDD";

			var filmModel = GetFilmModel();
			var filmModel2 = FilmModel.GetModel(Load);

			filmModel.GetFilm().Name = testName;
			filmModel2.GetFilm().Name = testName2;

			Assert.AreEqual(testName, filmModel.GetFilm().Name);
			Assert.AreEqual("...", filmModel.GetFilm().GetShortNameFilm(3));


			Assert.AreEqual(testName2, filmModel2.GetFilm().GetShortNameFilm());
			Assert.AreEqual(testName2, filmModel2.GetFilm().Name);
		}

		[TestMethod()]
		public void IsNameValidTest()
		{
			var filmModel = GetFilmModel();
			Assert.IsTrue(filmModel.IsNameValid("123"));
			Assert.IsFalse(filmModel.IsNameValid(null));
		}
	}
}