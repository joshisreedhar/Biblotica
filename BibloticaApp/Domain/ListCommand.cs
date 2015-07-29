using System;
using System.Collections.Generic;

namespace Thoughtworks.Pathshala.Domain
{
	public class ListCommand: ICommand
	{
		Biblotica _biblotica;
		CommandResult _result;

		public ListCommand(Biblotica biblotica)
		{
			_biblotica = biblotica;
		}

		public CommandResult Execute()
		{
			_result = new CommandResult ("List");
			_result.Data = _biblotica.GetBookList ();
			return _result;
		}

		public void WriteResultDataToView (IView view)
		{
			foreach (Book b in _result.Data as List<Book>) {
				view.Render (b.ToString ());
			}
		}
	}
}

