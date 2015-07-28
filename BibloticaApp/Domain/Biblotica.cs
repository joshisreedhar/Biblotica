using System;
using System.Collections.Generic;

namespace Thoughtworks.Pathshala.Domain
{
	public delegate void MessageEventHandler(object sender, MessageEventArgs e);

	public class Biblotica
	{
		private List<Book> _books;
		public event MessageEventHandler Init;
		public event MessageEventHandler Read;
		public event MessageEventHandler Exit;


		public void Start(List<Book> books)
		{
			_books = books ;
			if (Init != null) {
				Init(this,new MessageEventArgs(new Message("Welcome")));
			}
		}

		public List<Book> GetBookList ()
		{
			if (Read != null) {
				Message message = new Message ("Read");
				message.Data = _books;
				Read (this, new MessageEventArgs (message));
					
			}
			return _books;
		}

		public void Quit()
		{
			if (Exit != null) {
				Message message = new Message ("Exit");
				Exit (this, new MessageEventArgs (message));

			}
		}
	}
}

