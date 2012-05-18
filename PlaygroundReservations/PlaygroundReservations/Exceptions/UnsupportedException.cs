using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Exceptions
{
	public class UnsupportedException : Exception
	{
		public UnsupportedException(string message) : base(message) { }
	}
}