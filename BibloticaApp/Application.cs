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
			List<Book> books = new List<Book> (); 
			books.Add(new Book ("Object Thinking","Dr.David West",1990));
			books.Add(new Book ("Cakes, Puddings + Category Theory","a",2015));
			Biblotica app = new Biblotica (books);
			InputParser parser = new InputParser (app);
			_shouldContinue = true;
			ConsoleView view = new ConsoleView ();
			InitCommand startCommand = new InitCommand ();
			startCommand.Execute ();
			startCommand.WriteResultDataToView (view);

			while(_shouldContinue)
			{
				Console.WriteLine ("Input:");
				string input = Console.ReadLine ();
				ICommand command = parser.Parse (input);
				if (command is ExitCommand) {
					_shouldContinue = false;
				}
				command.Execute();
				command.WriteResultDataToView(view);
			}
		}
	}
}

