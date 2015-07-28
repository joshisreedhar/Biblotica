using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture]
	public class ListCommandTest
	{
		[Test]
		public void List_Command_Should_List_The_Books_In_Library ()
		{
			Biblotica biblotica = new Biblotica ();
			biblotica.Read += new MessageEventHandler (AssertListIsRead);
			biblotica.Start (new List<Book>(){new Book("A","a",1990)});
			ListCommand command = new ListCommand (biblotica);
			command.Execute ();
		}

		private void AssertListIsRead(object sender, MessageEventArgs e)
		{
			List<Book> books = e.Message.Data as List<Book>;
			Assert.AreEqual (1,books.Count);
			Assert.AreEqual ("[Book: Name=A, Author=a, Year=1990]", books.First().ToString());
		}
	}
}

