using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture ()]
	public class BibloticaTests
	{
		[Test ()]
		public void Biblotica_Should_Send_Welcome_Message_On_Start ()
		{
			Biblotica biblotica = new Biblotica ();
			biblotica.Init += new MessageEventHandler (CheckMessage);
		
			biblotica.Start ();

		}

		private void CheckMessage(object sender, MessageEventArgs e)
		{
			Assert.AreEqual ("Welcome", e.Message.Text);
		}
	}
}