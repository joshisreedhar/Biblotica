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
			Biblotica biblotica = new Biblotica (new List<Book>(){new Book("A","a",1990,"ISBN1990")});
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

		[Test]
		public void CheckoutCommand_Should_Incdicate_Success_Message_On_Success ()
		{
			Biblotica biblotica = new Biblotica (new List<Book>(){new Book("A","a",1990,"ISBN1990")});
			CheckoutCommand command = new CheckoutCommand (biblotica,"ISBN1990");
			CommandResult result = command.Execute ();
			Book checkedoutBook = result.Data as Book;
			Assert.AreEqual ("ISBN1990", checkedoutBook.Id);
		}

		[Test]
		public void CheckoutCommand_Should_Write_Success_Message_To_View ()
		{
			Biblotica biblotica = new Biblotica (new List<Book>(){new Book("A","a",1990,"ISBN1990")});
			CheckoutCommand command = new CheckoutCommand (biblotica,"ISBN1990");
			command.Execute ();
			MockView view = new MockView ("Thank you! Enjoy the book");
			command.WriteResultDataToView (view);
			view.Verify();
		}

		[Test]
		public void CheckoutCommand_Should_Incdicate_Failure_Message_To_View ()
		{
			Biblotica biblotica = new Biblotica (new List<Book>(){new Book("A","a",1990,"ISBN1990")});
			CheckoutCommand command = new CheckoutCommand (biblotica,"ISBN19900");
			command.Execute ();
			MockView view = new MockView ("That book is not available.");
			command.WriteResultDataToView (view);
			view.Verify();
		}
	}
}

