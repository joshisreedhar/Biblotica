using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class ListCommand
	{
		Biblotica _biblotica;

		public ListCommand(Biblotica biblotica)
		{
			_biblotica = biblotica;
		}

		public void Execute()
		{
			_biblotica.GetBookList ();
		}
	}
}

