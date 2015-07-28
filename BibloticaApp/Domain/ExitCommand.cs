using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class ExitCommand:ICommand
	{
		private Biblotica _biblotica;
		public ExitCommand (Biblotica biblotica)
		{
			_biblotica = biblotica;
		}

		public void Execute()
		{
			_biblotica.Quit ();
		}
	}
}

