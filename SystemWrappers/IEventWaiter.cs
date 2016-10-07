using System;
using System.Threading;

namespace SystemWrappers
{
	/// <summary>
	/// Interface defining methods for waiting on events.  This is used by
	/// CommState.BaseCommunicationState objects that must wait on events.
	/// </summary>
	/// <remarks>
	/// This interface does <u>not</u> define any methods which simply sleep.  The
	/// CommState.BaseCommunicationState object derivatives should never sleep for any period of time.  At
	/// a minimum, they should always wait on an event which is signalled when a
	/// shutdown is performed.
	/// </remarks>
	public interface IEventWaiter
	{
		/// <summary>
		/// Wait for any event to be signalled, or a timeout (timespan) occurs.
		/// </summary>
		/// <param name="waitHandles">Array of wait handles to wait on.</param>
		/// <param name="timeout">Timeout for wait, in case no event is signalled.</param>
		/// <returns>
		/// The index of the wait handle which was signalled. -1 is returned if a timeout
		/// occured.
		/// </returns>
		int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout);

		/// <summary>
		/// Wait for any event to be signalled, or a timeout (in milliseconds) occurs.
		/// </summary>
		/// <param name="waitHandles">Array of wait handles to wait on.</param>
		/// <param name="timeoutInMs">Timeout, in milliseconds, in case no event is signalled.</param>
		/// <returns>
		/// The index of the wait handle which was signalled. -1 is returned if a timeout
		/// occured.
		/// </returns>
		int WaitAny(WaitHandle[] waitHandles, int timeoutInMs);

		/// <summary>
		/// Wait for any event to be signalled.
		/// </summary>
		/// <param name="waitHandles">Array of wait handles to wait on.</param>
		/// <returns>
		/// The index of the wait handle which was signalled.
		/// </returns>
		int WaitAny(WaitHandle[] waitHandles);
	}
}