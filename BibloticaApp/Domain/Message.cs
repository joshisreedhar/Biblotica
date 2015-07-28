using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class Message
	{
		private string _message;
		public Message (string messageText)
		{
			_message = messageText;
		}

		public string Text
		{
			get{
				return _message;
			}
		}
	}
}

