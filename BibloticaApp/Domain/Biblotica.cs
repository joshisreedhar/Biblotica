using System;

namespace Thoughtworks.Pathshala.Domain
{
	public delegate void MessageEventHandler(object sender, MessageEventArgs e);

	public class Biblotica
	{
		public event MessageEventHandler Init;
	
		public void Start()
		{
			if (Init != null) {
				Init(this,new MessageEventArgs(new Message("Welcome")));
			}
		}
	}
}

