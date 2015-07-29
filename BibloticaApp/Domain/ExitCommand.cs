﻿using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class ExitCommand:ICommand
	{
		CommandResult _result;
		public CommandResult Execute()
		{
			_result = new CommandResult ("Exit");
			return _result;
		}

		public void WriteResultDataToView (IView view)
		{
			view.Render (_result.Data as string);
		}
	}
}

