using System;
using System.Threading;

namespace SystemWrappers
{
	/// <summary>
	/// Implementation of IEventWaiter
	/// </summary>
	public class EventWaiter : IEventWaiter
	{
		/// <summary>
		/// Wait for any event to be signaled, or a timeout occurs.
		/// </summary>
		/// <param name="waitHandles">Array of wait handles to wait on.</param>
		/// <param name="timeout">Timeout for wait, in case no event is signaled.</param>
		/// <returns>
		/// The index of the wait handle which was signaled. -1 is returned if a timeout
		/// occured.
		/// </returns>
		public int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout)
		{
			return WaitHandle.WaitAny(waitHandles, timeout);
		}

		/// <summary>
		/// Wait for any event to be signaled, or a timeout (in milliseconds) occurs.
		/// </summary>
		/// <param name="waitHandles">Array of wait handles to wait on.</param>
		/// <param name="timeoutInMs">Timeout, in milliseconds, in case no event is signaled.</param>
		/// <returns>
		/// The index of the wait handle which was signaled. -1 is returned if a timeout
		/// occured.
		/// </returns>
		public int WaitAny(WaitHandle[] waitHandles, int timeoutInMs)
		{
			return WaitHandle.WaitAny(waitHandles, timeoutInMs);
		}

		/// <summary>
		/// Wait for any event to be signaled.
		/// </summary>
		/// <param name="waitHandles">Array of wait handles to wait on.</param>
		/// <returns>
		/// The index of the wait handle which was signaled.
		/// </returns>
		public int WaitAny(WaitHandle[] waitHandles)
		{
			return WaitHandle.WaitAny(waitHandles);
		}
	}
}