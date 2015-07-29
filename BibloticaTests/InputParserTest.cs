using NUnit.Framework;
using System;
using System.Collections.Generic;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture]
	public class InputParserTest
	{
		Biblotica _biblotica;
		[TestFixtureSetUp]
		public void Setup()
		{
			_biblotica = new Biblotica (new List<Book>());
		}
		[Test]
		public void InputParser_Should_Parse_Input_To_Generate_Commad ()
		{
			InputParser parser = new InputParser (_biblotica);
			ICommand command = parser.Parse ("list");

			Assert.IsInstanceOf<ListCommand> (command);
		}

		[Test]
		public void InputParser_Should_Parse_Input_To_Generate_exit_Commad ()
		{
			InputParser parser = new InputParser (_biblotica);
			ICommand command = parser.Parse ("exit");

			Assert.IsInstanceOf<ExitCommand> (command);
		}

	}
}

