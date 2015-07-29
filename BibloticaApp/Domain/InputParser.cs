using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class InputParser
	{
		Biblotica _biblotica;

		public InputParser (Biblotica biblotica)
		{
			_biblotica = biblotica;
		}

		public ICommand Parse (string commandText)
		{
			if (commandText == "start") {
				return new InitCommand ();
			} else if (commandText == "list") {
				return new ListCommand (_biblotica);
			} else if (commandText == "exit") {
				return new ExitCommand ();
			} else if (commandText.StartsWith ("checkout")) {
				string isbnNumber = commandText.Remove (7);
				return new CheckoutCommand (_biblotica, isbnNumber);
			} else {
				return new NullCommand ();
			}
		}
	}
}

