using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture]
	public class ExitCommandTest
	{
		[Test]
		public void ExitCommand_Should_Notify_Exit ()
		{
			Biblotica bib = new Biblotica ();
			bib.Exit  += new MessageEventHandler(AssertExistNotification);
			ExitCommand command = new ExitCommand (bib);
			command.Execute ();
		}

		private void AssertExistNotification(object sender, MessageEventArgs e)
		{
			Assert.AreEqual ("Exit", e.Message.Text);
		}
	}
}

