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
			case "List":
				return new ListCommand (_biblotica);
				break;
			default:
				throw new InvalidOperationException ();
			}
		}
	}
}

