using System;
using System.Collections.Generic;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala
{
	public class Application
	{
		bool _shouldContinue;
		public Application ()
		{
			Biblotica app = new Biblotica ();
			app.Init += new MessageEventHandler (WriteEventMessageToConsole);
			app.Read += new MessageEventHandler (WriteBookDataToConsole);
			app.Exit += new MessageEventHandler (HandleExitComand);
			List<Book> books = new List<Book> (); 
			books.Add(new Book ("Object Thinking","Dr.David West",1990));
			books.Add(new Book ("Cakes, Puddings + Category Theory","a",2015));
			app.Start (books);
			InputParser parser = new InputParser (app);
			_shouldContinue = true;
			while(_shouldContinue)
			{
				
				Console.WriteLine ("Input:");
				string input = Console.ReadLine ();
				try{
				ICommand command = parser.Parse (input);
				command.Execute();
				}
				catch(InvalidOperationException) {
					Console.WriteLine ("Select a valid option!");
				}
			}
			Console.Write ("Application Existing");


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

		private void HandleExitComand(object sender, MessageEventArgs e)
		{
			_shouldContinue = false;
		}

	}
}

