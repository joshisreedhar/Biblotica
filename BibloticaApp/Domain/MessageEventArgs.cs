using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class MessageEventArgs:EventArgs
	{
		private Message _message;
		public MessageEventArgs(Message message)

		{
			_message = message;
		}

		public Message Message
		{
			get{
				return _message;
			}
		}
	}
}

