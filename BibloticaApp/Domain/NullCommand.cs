using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class NullCommand:ICommand
	{
		CommandResult _result ;
		public CommandResult Execute()
		{
			_result = new CommandResult("Provide a valid Input!!");
			return _result;
		}


		public void WriteResultDataToView (IView view)
		{
			view.Render (_result.Data as string);
		}
	}
}

