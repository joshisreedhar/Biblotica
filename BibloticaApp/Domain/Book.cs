using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class Book
	{
		private string _name;
		private string _author;
		private int _year;
		public Book (string name, string author, int year)
		{
			_name = name;
			_author = author;
			_year = year;
		}

		public override string ToString ()
		{
			return string.Format ("[Book: Name={0}, Author={1}, Year={2}]", _name, _author, _year);
		}
	}
}

