using System;
using System.Collections.Generic;

namespace Thoughtworks.Pathshala.Domain
{
	public class CheckoutCommand: ICommand
	{
		Biblotica _biblotica;
		CommandResult _result;
		string _ISBNNumber;

		public CheckoutCommand(Biblotica biblotica, string ISBNNumber)
		{
			_biblotica = biblotica;
			_ISBNNumber = ISBNNumber;
		}

		public CommandResult Execute()
		{
			_result = new CommandResult ("Checkout");
			_result.Data = _biblotica.Checkout (_ISBNNumber);
			return _result;
		}

		public void WriteResultDataToView (IView view)
		{
			if (_result.Data != null) {
				view.Render ("Thank you! Enjoy the book");
			} 
			else {
				view.Render ("That book is not available.");
			}
		}
	}
}

