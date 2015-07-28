using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture]
	public class InputParserTest
	{
		[Test]
		public void InputParser_Should_Parse_Input_To_Generate_Commad ()
		{
			InputParser parser = new InputParser (new Biblotica());
			ICommand command = parser.Parse ("List");

			Assert.IsInstanceOf<ListCommand> (command);
		}
	}
}

