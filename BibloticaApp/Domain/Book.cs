using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class Book
	{
		private string _name;
		public Book (string name)
		{
			_name = name;
		}

		public string Name
		{
			get
			{
				return _name;
			}
		}

		public override string ToString ()
		{
			return string.Format ("[Book: Name={0}]", Name);
		}
	}
}

