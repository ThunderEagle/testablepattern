using System;
using System.IO;
using System.Security.AccessControl;

namespace SystemWrappers
{
	/// <summary>Directory implementation. </summary>
	public class DirectoryImplementation : IDirectory
	{
		/// <summary>Creates a directory. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="security">The security.</param>
		/// <returns>.</returns>
		public virtual DirectoryInfo CreateDirectory(string path, DirectorySecurity security)
		{
			return Directory.CreateDirectory(path, security);
		}

		/// <summary>Creates a directory.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		public virtual DirectoryInfo CreateDirectory(string path)
		{
			return Directory.CreateDirectory(path);
		}

		/// <summary>Deletes this object. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="recursive">true to process recursively, false to process locally only.</param>
		public virtual void Delete(string path, bool recursive)
		{
			Directory.Delete(path, recursive);
		}

		/// <summary>Deletes this object.</summary>
		/// <param name="path">Full pathname of the file.</param>
		public virtual void Delete(string path)
		{
			Directory.Delete(path);
		}

		/// <summary>Exists the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>true if it succeeds, false if it fails.</returns>
		public virtual bool Exists(string path)
		{
			return Directory.Exists(path);
		}

		/// <summary>Gets the access control. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="sections">The sections.</param>
		/// <returns>The access control.</returns>
		public virtual DirectorySecurity GetAccessControl(string path, AccessControlSections sections)
		{
			return Directory.GetAccessControl(path, sections);
		}

		/// <summary>Gets the access control.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The access control.</returns>
		public virtual DirectorySecurity GetAccessControl(string path)
		{
			return Directory.GetAccessControl(path);
		}

		/// <summary>Gets a creation time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The creation time.</returns>
		public virtual DateTime GetCreationTime(string path)
		{
			return Directory.GetCreationTime(path);
		}

		/// <summary>Gets a creation time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The creation time utc.</returns>
		public virtual DateTime GetCreationTimeUtc(string path)
		{
			return Directory.GetCreationTimeUtc(path);
		}

		/// <summary>Gets the current directory. </summary>
		/// <returns>The current directory.</returns>
		public virtual string GetCurrentDirectory()
		{
			return Directory.GetCurrentDirectory();
		}

		/// <summary>Gets the directories. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="option">The option.</param>
		/// <returns>The directories.</returns>
		public virtual string[] GetDirectories(string path, string searchPattern, SearchOption option)
		{
			return Directory.GetDirectories(path, searchPattern, option);
		}

		/// <summary>Gets the directories.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <returns>The directories.</returns>
		public virtual string[] GetDirectories(string path, string searchPattern)
		{
			return Directory.GetDirectories(path, searchPattern);
		}

		/// <summary>Gets the directories.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The directories.</returns>
		public virtual string[] GetDirectories(string path)
		{
			return Directory.GetDirectories(path);
		}

		/// <summary>Gets a directory root. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The directory root.</returns>
		public virtual string GetDirectoryRoot(string path)
		{
			return Directory.GetDirectoryRoot(path);
		}

		/// <summary>Gets the files. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <param name="option">The option.</param>
		/// <returns>The files.</returns>
		public virtual string[] GetFiles(string path, string searchPattern, SearchOption option)
		{
			return Directory.GetFiles(path, searchPattern, option);
		}

		/// <summary>Gets the files.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <returns>The files.</returns>
		public virtual string[] GetFiles(string path, string searchPattern)
		{
			return Directory.GetFiles(path, searchPattern);
		}

		/// <summary>Gets the files.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The files.</returns>
		public virtual string[] GetFiles(string path)
		{
			return Directory.GetFiles(path);
		}

		/// <summary>Gets a file system entries. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="searchPattern">The search pattern.</param>
		/// <returns>The file system entries.</returns>
		public virtual string[] GetFileSystemEntries(string path, string searchPattern)
		{
			return Directory.GetFileSystemEntries(path, searchPattern);
		}

		/// <summary>Gets a file system entries.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The file system entries.</returns>
		public virtual string[] GetFileSystemEntries(string path)
		{
			return Directory.GetFileSystemEntries(path);
		}

		/// <summary>Gets the last access time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last access time.</returns>
		public virtual DateTime GetLastAccessTime(string path)
		{
			return Directory.GetLastAccessTime(path);
		}

		/// <summary>Gets the last access time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last access time utc.</returns>
		public virtual DateTime GetLastAccessTimeUtc(string path)
		{
			return Directory.GetLastAccessTimeUtc(path);
		}

		/// <summary>Gets the last write time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last write time.</returns>
		public virtual DateTime GetLastWriteTime(string path)
		{
			return Directory.GetLastWriteTime(path);
		}

		/// <summary>Gets the last write time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last write time utc.</returns>
		public virtual DateTime GetLastWriteTimeUtc(string path)
		{
			return Directory.GetLastWriteTimeUtc(path);
		}

		/// <summary>Gets the logical drives. </summary>
		/// <returns>The logical drives.</returns>
		public virtual string[] GetLogicalDrives()
		{
			return Directory.GetLogicalDrives();
		}

		/// <summary>Gets the parent of this item. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The parent.</returns>
		public virtual DirectoryInfo GetParent(string path)
		{
			return Directory.GetParent(path);
		}

		/// <summary>Moves. </summary>
		/// <param name="sourceDirName">Pathname of the source directory.</param>
		/// <param name="destDirName">Pathname of the destination directory.</param>
		public virtual void Move(string sourceDirName, string destDirName)
		{
			Directory.Move(sourceDirName, destDirName);
		}

		/// <summary>Sets the access control. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="security">The security.</param>
		public virtual void SetAccessControl(string path, DirectorySecurity security)
		{
			Directory.SetAccessControl(path, security);
		}

		/// <summary>Sets a creation time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		public virtual void SetCreationTime(string path, DateTime creationTime)
		{
			Directory.SetCreationTime(path, creationTime);
		}

		/// <summary>Sets a creation time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		public virtual void SetCreationTimeUtc(string path, DateTime creationTime)
		{
			Directory.SetCreationTimeUtc(path, creationTime);
		}

		/// <summary>Sets a current directory. </summary>
		/// <param name="path">Full pathname of the file.</param>
		public virtual void SetCurrentDirectory(string path)
		{
			Directory.SetCurrentDirectory(path);
		}

		/// <summary>Sets a last access time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="lastAccessTime">Time of the last access.</param>
		public virtual void SetLastAccessTime(string path, DateTime lastAccessTime)
		{
			Directory.SetLastAccessTime(path, lastAccessTime);
		}

		/// <summary>Sets a last access time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="lastAccessTime">Time of the last access.</param>
		public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTime)
		{
			Directory.SetLastAccessTimeUtc(path, lastAccessTime);
		}

		/// <summary>Sets a last write time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="lastWriteTime">Time of the last write.</param>
		public virtual void SetLastWriteTime(string path, DateTime lastWriteTime)
		{
			Directory.SetLastWriteTime(path, lastWriteTime);
		}

		/// <summary>Sets a last write time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="lastWriteTime">Time of the last write.</param>
		public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTime)
		{
			Directory.SetLastWriteTimeUtc(path, lastWriteTime);
		}
	}
}