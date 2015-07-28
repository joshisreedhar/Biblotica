using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;
using System.Collections.Generic;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture ()]
	public class BibloticaTests
	{
		[Test ()]
		public void Biblotica_Should_Send_Welcome_Message_On_Start ()
		{
			Biblotica biblotica = new Biblotica ();
			biblotica.Init += new MessageEventHandler (CheckMessage);
		
			biblotica.Start (new List<Book>());

		}

		[Test]
		public void Biblotica_When_Requested_For_BooksList_Should_Contain_Books()
		{
			Biblotica biblotica = new Biblotica ();
			biblotica.Init += new MessageEventHandler (CheckMessage);

			biblotica.Start (new List<Book>(){new Book("a","a",1990)});

			List<Book> books =  biblotica.GetBookList ();
			Assert.AreEqual (1, books.Count );
		}



		private void CheckMessage(object sender, MessageEventArgs e)
		{
			Assert.AreEqual ("Welcome", e.Message.Text);
		}


	}
}