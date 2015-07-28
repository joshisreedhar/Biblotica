﻿using System;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala
{
	public class Application
	{
		public Application ()
		{
			Biblotica app = new Biblotica ();
			app.Init += new MessageEventHandler (WriteEventToConsole);
			app.Start ();
			foreach (Book book in app.GetBookList()) {
				Console.WriteLine (book.ToString ());
			}

		}

		private void WriteEventToConsole(object sender, MessageEventArgs e)
		{
			Console.WriteLine (e.Message.Text);
		}

	}
}

