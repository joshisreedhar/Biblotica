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
		
			biblotica.Start ();

		}

		[Test]
		public void Biblotica_When_Started_Should_Contain_Books()
		{
			Biblotica biblotica = new Biblotica ();
			biblotica.Init += new MessageEventHandler (CheckMessage);

			biblotica.Start ();
			List<Book> books =  biblotica.GetBookList ();
			Assert.IsTrue (books.Count > 0);
		}

		private void CheckMessage(object sender, MessageEventArgs e)
		{
			Assert.AreEqual ("Welcome", e.Message.Text);
		}


	}
}