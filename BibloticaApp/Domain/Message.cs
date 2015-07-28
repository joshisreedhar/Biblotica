using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class Message
	{
		private string _message;
		private object _data;

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

		public object Data
		{
			get{
				return _data;
			}
			set{
				_data = value;
			}
		}
	}
}

