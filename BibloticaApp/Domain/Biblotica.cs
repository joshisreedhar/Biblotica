using System;
using System.Collections.Generic;

namespace Thoughtworks.Pathshala.Domain
{
	public delegate void MessageEventHandler(object sender, MessageEventArgs e);

	public class Biblotica
	{
		private List<Book> _books;
		public event MessageEventHandler Init;
	
		public void Start()
		{
			_books = new List<Book> ();
			_books.Add(new Book ("Object Thinking"));
			_books.Add(new Book ("Cakes, Puddings + Category Theory"));
			if (Init != null) {
				Init(this,new MessageEventArgs(new Message("Welcome")));
			}
		}

		public List<Book> GetBookList ()
		{
			return _books;
		}
	}
}

