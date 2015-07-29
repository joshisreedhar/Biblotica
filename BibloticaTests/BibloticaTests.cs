using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;
using System.Collections.Generic;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture ()]
	public class BibloticaTests
	{
		[Test]
		public void Biblotica_When_Requested_For_BooksList_Should_Contain_Books()
		{
			Biblotica biblotica = new Biblotica (new List<Book>(){new Book("a","a",1990,"ISBN190")});
			List<Book> books =  biblotica.GetBookList ();
			Assert.AreEqual (1, books.Count );
		}

		[Test]
		public void Biblotica_When_Checkedout_Should_Not_Be_In_Available_Books()
		{
			Biblotica biblotica = new Biblotica (new List<Book>(){new Book("a","a",1990,"ISBN190")});
			biblotica.Checkout ("ISBN190");
			List<Book> books =  biblotica.GetBookList ();
			Assert.AreEqual (0, books.Count );
		}
	}
}