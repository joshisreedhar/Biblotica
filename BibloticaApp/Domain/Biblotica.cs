using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoughtworks.Pathshala.Domain
{
	public class Biblotica
	{
		private List<Book> _availableBooks;
		private List<Book> _issuedBooks;
		public Biblotica(List<Book> books)
		{
			_availableBooks = books ;
		}

		public List<Book> GetBookList ()
		{
			return _availableBooks;
		}

		public void Checkout(string ISBNNumber)
		{
			_availableBooks.Remove(_availableBooks.Where(b=>b.Id == ISBNNumber).SingleOrDefault());
		}
	}
}

