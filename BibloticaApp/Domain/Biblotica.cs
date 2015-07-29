using System;
using System.Collections.Generic;

namespace Thoughtworks.Pathshala.Domain
{
	public class Biblotica
	{
		private List<Book> _books;
		public Biblotica(List<Book> books)
		{
			_books = books ;
		}

		public List<Book> GetBookList ()
		{
			return _books;
		}
	}
}

