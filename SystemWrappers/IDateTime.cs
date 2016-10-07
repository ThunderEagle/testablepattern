using System;

namespace SystemWrappers
{
	/// <summary>Interface for DateTime wrapper</summary>
	public interface IDateTime
	{
		/// <summary>Gets the Date/Time.</summary>
		DateTime Now { get; }

		/// <summary>Gets the UTC Date/Time.</summary>
		DateTime UtcNow { get; }
	}
}