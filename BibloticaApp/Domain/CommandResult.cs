using System;

namespace Thoughtworks.Pathshala.Domain
{
	public class CommandResult
	{
		object _data; 
		public CommandResult(object data)
		{
			_data = data;
		}

		public object Data { get{ return _data; } set{ _data = value; } }
	}
}

