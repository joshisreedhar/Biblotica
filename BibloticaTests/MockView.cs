using System;
using Thoughtworks.Pathshala.Domain;
using NUnit.Framework;

namespace Thoughtworks.Pathshala.Tests
{
	public class MockView:IView
	{
		string _expectedMessage;
		string _actulaMessage;
		public MockView(string expectedMessage)
		{
			_expectedMessage = expectedMessage;
		}
		public void Render(string message)
		{
			_actulaMessage = message;
		}

		public void Verify()
		{
			Assert.AreEqual (_expectedMessage, _actulaMessage);
		}
	}
}

