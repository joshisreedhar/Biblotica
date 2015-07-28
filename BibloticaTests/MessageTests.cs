using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture ()]
	public class MessageTests
	{
		[Test ()]
		public void Message_When_Instatntiated_Should_Set_Its_Text ()
		{
			Message msg = new Message ("hi");
			Assert.AreEqual ("hi", msg.Text);
		}
	}
}
