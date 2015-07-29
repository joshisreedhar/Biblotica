using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture]
	public class CommandTest
	{
		[Test]
		public void List_Command_Should_List_The_Books_In_Library ()
		{
			Biblotica biblotica = new Biblotica (new List<Book>(){new Book("A","a",1990)});
			ListCommand command = new ListCommand (biblotica);
			CommandResult result = command.Execute ();
			List<Book> books = result.Data as List<Book>;
			Assert.AreEqual (1,books.Count);
			Assert.AreEqual ("[Book: Name=A, Author=a, Year=1990]", books.First().ToString());
		}

		[Test]
		public void ExitCommand_Should_Notify_Exit ()
		{
			ExitCommand command = new ExitCommand ();
			CommandResult result = command.Execute ();
			Assert.AreEqual ("Exit", result.Data);
		}

		[Test]
		public void InitCommand_Should_Notify_Initialization_With_Welcome_Message ()
		{
			InitCommand command = new InitCommand ();
			CommandResult result = command.Execute ();
			Assert.AreEqual ("Welcome", result.Data);
		}

		[Test]
		public void InvalidCommand_Should_Notify_Initialization_With_Welcome_Message ()
		{
			NullCommand command = new NullCommand ();
			CommandResult result = command.Execute ();
			Assert.AreEqual ("Provide a valid Input!!", result.Data);
		}
	}
}

