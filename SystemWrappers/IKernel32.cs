namespace SystemWrappers
{
	/// <summary>
	///   Kernel32 Wrapper
	/// </summary>
	public interface IKernel32
	{
		/// <summary>
		///   Gets the disk free space.
		/// </summary>
		/// <param name="lpDirectoryName">Name of the directory.</param>
		/// <param name="lpFreeBytesAvailable">The free bytes available.</param>
		/// <param name="lpTotalNumberOfBytes">The total number of bytes.</param>
		/// <param name="lpTotalNumberOfFreeBytes">The total number of free bytes.</param>
		/// <returns></returns>
		/// <remarks></remarks>
		bool GetDiskFreeSpace(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);
	}
}