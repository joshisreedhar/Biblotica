using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class InputParser
	{
		Biblotica _biblotica;
		public InputParser(Biblotica biblotica)
		{
			_biblotica = biblotica;
		}
		public ICommand Parse(string commandText)
		{
			switch (commandText) {
			case "start":
				return new InitCommand ();
			case "list":
				return new ListCommand (_biblotica);
			case "exit":
				return new ExitCommand ();
			default:
				return new NullCommand ();
			}
		}
	}
}

