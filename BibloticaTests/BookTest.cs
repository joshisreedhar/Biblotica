using NUnit.Framework;
using System;
using Thoughtworks.Pathshala.Domain;

namespace Thoughtworks.Pathshala.Tests
{
	[TestFixture ()]
	public class BookTests
	{
		[Test ()]
		public void Book_When_Represented_As_String_Should_Display_Its_Name ()
		{
			Book book = new Book ("Test");
			Assert.AreEqual ("[Book: Name=Test]", book.ToString ());
		}
	}
}

