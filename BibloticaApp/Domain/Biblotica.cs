using System;
using System.Collections.Generic;
using System.Linq;

namespace Thoughtworks.Pathshala.Domain
{
	public class Biblotica
	{
		private List<Book> _availableBooks;
		public Biblotica(List<Book> books)
		{
			_availableBooks = books ;
		}

		public List<Book> GetBookList ()
		{
			return _availableBooks;
		}

		public Book Checkout(string ISBNNumber)
		{
			Book bookToCheckout = _availableBooks.Where (b => b.Id == ISBNNumber).SingleOrDefault ();
			_availableBooks.Remove(bookToCheckout);
			return bookToCheckout;
		}
	}
}

