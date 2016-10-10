using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestablePattern.Models
{
	public class FooBar:NotifyObject.NotifyObject
	{

		public string Name
		{
			get { return GetPropertyValue(() => Name); }
			set { SetPropertyValue(() => Name, value); }
		}

		public DateTime Date
		{
			get { return GetPropertyValue(() => Date); }
			set { SetPropertyValue(() => Date, value); }
		}

		public bool Authorized
		{
			get { return GetPropertyValue(() => Authorized); }
			set { SetPropertyValue(() => Authorized, value); }
		}

		public double Amount
		{
			get { return GetPropertyValue(() => Amount); }
			set { SetPropertyValue(() => Amount, value); }
		}

	}
}
