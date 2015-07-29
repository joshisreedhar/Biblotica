using System;

namespace Thoughtworks.Pathshala.Domain
{
	public interface ICommand
	{
		CommandResult Execute();
		void WriteResultDataToView (IView view);
	}
}

