using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class ConsoleView:IView
	{
		public void Render(string message)
		{
			Console.WriteLine (message);
		}
	}
}

