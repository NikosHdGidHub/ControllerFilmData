using Lib.StreamDataController;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmDataBaseForm.Models.FilmModelData;
using System;

namespace FilmDataBaseForm.Models.Tests
{
	[TestClass()]
	public class FilmModelTests
	{
		private readonly IStreamDataController<string> fM = new FileController();
		private readonly string path = "TestSer.dat";
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
			Assert.IsTrue(filmModel.IsValidName("123"));
			Assert.IsFalse(filmModel.IsValidName(null));
		}

		[TestMethod()]
		public void ValidRateTest()
		{
			var filmModel = GetFilmModel();
			bool? out1 = null;
			var res1 = filmModel.IsValidRate("0", out out1);
			Assert.IsTrue(res1 && out1 == true);
			res1 = filmModel.IsValidRate("blabla", out out1); 
			Assert.IsTrue(!res1 && out1 == null);
			res1 = filmModel.IsValidRate("88", out out1);
			Assert.IsTrue(!res1 && out1 == null); 
			res1 = filmModel.IsValidRate("Один из лучших самых фильмов...", out out1);
			Assert.IsTrue(res1 && out1 == false);
		}
		[TestMethod()]
		public void SetGetRateTest()
		{
			var filmModel = GetFilmModel();
			var strRate_6 = "Один из лучших самых фильмов...";
			var film = filmModel.GetFilm();
			film.Rate = strRate_6;

			Assert.AreEqual(strRate_6, film.Rate);
			Assert.AreEqual(6, film.GetRateIndex());

			film.Rate = "0";
			Assert.AreEqual(0, film.GetRateIndex());
		}
		[TestMethod()]
		public void SetGetStatusTest()
		{
			var filmModel = GetFilmModel();
			var strRate_0 = "Просмотрен";
			var film = filmModel.GetFilm();
			film.ViewedStatus = "0";
			Assert.IsTrue(filmModel.IsValidStaus("1", out byte someThing));
			Assert.AreEqual(1, someThing);

			Assert.AreEqual(strRate_0, film.ViewedStatus);
			Assert.AreEqual(0, film.GetStatusIndex());

			film.ViewedStatus = "2";
			Assert.AreEqual(2, film.GetStatusIndex());
		}
	}
}