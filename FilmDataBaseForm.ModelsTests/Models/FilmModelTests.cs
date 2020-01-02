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
		[TestMethod()]
		public void LoadFilmsTest()
		{
			fM.Create(path);
			var filmModel = new FilmModel(Load);
			Assert.AreEqual(1, filmModel.Count);
		}
		[TestMethod()]
		public void SaveAddFilmsTest()
		{
			fM.Create(path);
			var filmModel = new FilmModel(Load);
			filmModel.AddFilm();
			filmModel.SaveFilms(Save);
			var filmModel2 = new FilmModel(Load);
			Assert.AreEqual(2, filmModel.Count);
		}
		
	}
}