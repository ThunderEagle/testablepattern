using System;
using System.IO;
using System.Security.AccessControl;

namespace SystemWrappers
{
	/// <summary>Interface for Directory Wrapper </summary>
	public interface IDirectory
	{
		/// <summary>Creates a directory. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="security">The security.</param>
		/// <returns>.</returns>
		DirectoryInfo CreateDirectory(string path, DirectorySecurity security);

		/// <summary>Creates a directory.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		DirectoryInfo CreateDirectory(string path);

		/// <summary>Deletes this object. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="recursive">true to process recursively, false to process locally only.</param>
		void Delete(string path, bool recursive);

		/// <summary>Deletes this object.</summary>
		/// <param name="path">Full pathname of the file.</param>
		void Delete(string path);

		/// <summary>Exists the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>true if it succeeds, false if it fails.</returns>
		bool Exists(string path);

		/// <summary>Gets the access control. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="sections">The sections.</param>
		/// <returns>The access control.</returns>
		DirectorySecurity GetAccessControl(string path, AccessControlSections sections);

		/// <summary>Gets the access control.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The access control.</returns>
		DirectorySecurity GetAccessControl(string path);

		/// <summary>Gets a creation time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The creation time.</returns>
		DateTime GetCreationTime(string path);

		/// <summary>Gets a creation time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The creation time utc.</returns>
		DateTime GetCreationTimeUtc(string path);

		/// <summary>Gets the current directory. </summary>
		/// <returns>The current directory.</returns>
		string GetCurrentDirectory();

		/// <summary>Gets the directories. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="option">The option.</param>
		/// <returns>The directories.</returns>
		string[] GetDirectories(string path, string searchPattern, SearchOption option);

		/// <summary>Gets the directories.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <returns>The directories.</returns>
		string[] GetDirectories(string path, string searchPattern);

		/// <summary>Gets the directories.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The directories.</returns>
		string[] GetDirectories(string path);

		/// <summary>Gets a directory root. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The directory root.</returns>
		string GetDirectoryRoot(string path);

		/// <summary>Gets the files. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="option">The option.</param>
		/// <returns>The files.</returns>
		string[] GetFiles(string path, string searchPattern, SearchOption option);

		/// <summary>Gets the files.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <returns>The files.</returns>
		string[] GetFiles(string path, string searchPattern);

		/// <summary>Gets the files.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The files.</returns>
		string[] GetFiles(string path);

		/// <summary>Gets a file system entries. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <returns>The file system entries.</returns>
		string[] GetFileSystemEntries(string path, string searchPattern);

		/// <summary>Gets a file system entries.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The file system entries.</returns>
		string[] GetFileSystemEntries(string path);

		/// <summary>Gets the last access time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last access time.</returns>
		DateTime GetLastAccessTime(string path);

		/// <summary>Gets the last access time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last access time utc.</returns>
		DateTime GetLastAccessTimeUtc(string path);

		/// <summary>Gets the last write time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last write time.</returns>
		DateTime GetLastWriteTime(string path);

		/// <summary>Gets the last write time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last write time utc.</returns>
		DateTime GetLastWriteTimeUtc(string path);

		/// <summary>Gets the logical drives. </summary>
		/// <returns>The logical drives.</returns>
		string[] GetLogicalDrives();

		/// <summary>Gets the parent of this item. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The parent.</returns>
		DirectoryInfo GetParent(string path);

		/// <summary>Moves.</summary>
		/// <param name="sourceDirName">Pathname of the source directory.</param>
		/// <param name="destDirName">Pathname of the destination directory.</param>
		void Move(string sourceDirName, string destDirName);

		/// <summary>Sets the access control. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="security">The security.</param>
		void SetAccessControl(string path, DirectorySecurity security);

		/// <summary>Sets a creation time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		void SetCreationTime(string path, DateTime creationTime);

		/// <summary>Sets a creation time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		void SetCreationTimeUtc(string path, DateTime creationTime);

		/// <summary>Sets a current directory. </summary>
		/// <param name="path">Full pathname of the file.</param>
		void SetCurrentDirectory(string path);

		/// <summary>Sets a last access time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="lastAccessTime">Time of the last access.</param>
		void SetLastAccessTime(string path, DateTime lastAccessTime);

		/// <summary>Sets a last access time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="lastAccessTime">Time of the last access.</param>
		void SetLastAccessTimeUtc(string path, DateTime lastAccessTime);

		/// <summary>Sets a last write time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="lastWriteTime">Time of the last write.</param>
		void SetLastWriteTime(string path, DateTime lastWriteTime);

		/// <summary>Sets a last write time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="lastWriteTime">Time of the last write.</param>
		void SetLastWriteTimeUtc(string path, DateTime lastWriteTime);
	}
}