using System;
using System.Collections.Generic;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala
{
	public class Application
	{
		public Application ()
		{
			Biblotica app = new Biblotica ();
			app.Init += new MessageEventHandler (WriteEventMessageToConsole);
			app.Read += new MessageEventHandler (WriteBookDataToConsole);
			List<Book> books = new List<Book> (); 
			books.Add(new Book ("Object Thinking","Dr.David West",1990));
			books.Add(new Book ("Cakes, Puddings + Category Theory","a",2015));
			app.Start (books);
			while(true)
			{
				
				Console.WriteLine ("Input:");
				new ListCommand (app).Execute();
				string input = Console.ReadLine ();


			}

		}

		private void WriteEventMessageToConsole(object sender, MessageEventArgs e)
		{
			Console.WriteLine (e.Message.Text);
		}

		private void WriteBookDataToConsole(object sender, MessageEventArgs e)
		{
			List<Book> books = e.Message.Data as List<Book>;
			foreach (Book book in books) {
				Console.WriteLine (book.ToString ());
			}
		}

	}
}

