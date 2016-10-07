using System.Runtime.InteropServices;

namespace SystemWrappers
{
	/// <summary>
	///   Wrapper around DLLImport of Kernel32.dll to allow for mocking in unit testing.
	/// </summary>
	/// <remarks></remarks>
	public class Kernel32Implementation : IKernel32
	{
		/// <summary>
		/// Gets the disk free space.
		/// </summary>
		/// <param name="lpDirectoryName">Name of the directory.</param>
		/// <param name="lpFreeBytesAvailable">The free bytes available.</param>
		/// <param name="lpTotalNumberOfBytes">The total number of bytes.</param>
		/// <param name="lpTotalNumberOfFreeBytes">The total number of free bytes.</param>
		/// <returns></returns>
		/// <remarks></remarks>
		public bool GetDiskFreeSpace(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes)
		{
			return GetDiskFreeSpaceEx(lpDirectoryName, out lpFreeBytesAvailable, out lpTotalNumberOfBytes, out lpTotalNumberOfFreeBytes);
		}

		[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);
	}
}