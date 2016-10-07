using System;

namespace SystemWrappers
{
	/// <summary>Date time implementation. </summary>
	public class DateTimeImplementation : IDateTime
	{
		/// <summary>Gets the current Date/Time.</summary>
		public virtual DateTime Now
		{
			get { return DateTime.Now; }
		}

		/// <summary>Gets the UTC Date/Time.</summary>
		public virtual DateTime UtcNow
		{
			get { return DateTime.UtcNow; }
		}
	}
}