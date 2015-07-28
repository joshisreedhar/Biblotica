using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture ()]
	public class MessageEventArgsTests
	{
		[Test ()]
		public void MessageEventArgs_When_Instatntiated_Should_Set_Its_Message ()
		{
			MessageEventArgs msg = new MessageEventArgs (new Message("hi"));
			Assert.IsNotNull (msg.Message);
		}
	}
}
