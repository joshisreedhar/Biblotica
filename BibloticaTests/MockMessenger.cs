using System;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala.Tests
{
	public class MockMessenger:IMessenger
	{
		public event MessageEventHandler Init;

		 
	}
}

