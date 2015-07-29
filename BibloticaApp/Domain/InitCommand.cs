using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class InitCommand:ICommand
	{
		CommandResult _result;
		public CommandResult Execute()
		{
			_result = new CommandResult ("Welcome");
			return _result;
		}

		public void WriteResultDataToView (IView view)
		{
			view.Render (_result.Data as string);
		}
	}
}
