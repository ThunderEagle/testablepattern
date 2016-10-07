using System;
using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace SystemWrappers
{
	/// <summary>
	/// 	Provides methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of System.IO.FileStream objects.
	/// </summary>
	public class FileImplementation : IFile
	{
		#region IFile Members

		/// <summary>Appends all text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		/// <param name="encoding">The encoding.</param>
		public virtual void AppendAllText(string path, string contents, Encoding encoding)
		{
			File.AppendAllText(path, contents, encoding);
		}

		/// <summary>Appends all text.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		public virtual void AppendAllText(string path, string contents)
		{
			File.AppendAllText(path, contents);
		}

		/// <summary>Appends a text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		public virtual StreamWriter AppendText(string path)
		{
			return File.AppendText(path);
		}

		/// <summary>Copies this object. </summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		/// <param name="overwrite">true to overwrite, false to preserve.</param>
		public virtual void Copy(string sourceFilename, string destFilename, bool overwrite)
		{
			File.Copy(sourceFilename, destFilename, overwrite);
		}

		/// <summary>Copies this object.</summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		public virtual void Copy(string sourceFilename, string destFilename)
		{
			File.Copy(sourceFilename, destFilename);
		}

		/// <summary>Creates this object. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="bufferSize">Size of the buffer.</param>
		/// <param name="options">Options for controlling the operation.</param>
		/// <param name="security">The security.</param>
		/// <returns>.</returns>
		public virtual FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity security)
		{
			return File.Create(path, bufferSize, options, security);
		}

		/// <summary>Creates this object.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="bufferSize">Size of the buffer.</param>
		/// <param name="options">Options for controlling the operation.</param>
		/// <returns>.</returns>
		public virtual FileStream Create(string path, int bufferSize, FileOptions options)
		{
			return File.Create(path, bufferSize, options);
		}

		/// <summary>Creates this object.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="bufferSize">Size of the buffer.</param>
		/// <returns>.</returns>
		public virtual FileStream Create(string path, int bufferSize)
		{
			return File.Create(path, bufferSize);
		}

		/// <summary>Creates this object.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		public virtual FileStream Create(string path)
		{
			return File.Create(path);
		}

		/// <summary>Creates a text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		public virtual StreamWriter CreateText(string path)
		{
			return File.CreateText(path);
		}

		/// <summary>Decrypts the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		public virtual void Decrypt(string path)
		{
			File.Decrypt(path);
		}

		/// <summary>Deletes the given path. </summary>
		/// <param name="path">Full pathname of the file.</param>
		public virtual void Delete(string path)
		{
			File.Delete(path);
		}

		/// <summary>Encrypts the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		public virtual void Encrypt(string path)
		{
			File.Encrypt(path);
		}

		/// <summary>Exists the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>true if it succeeds, false if it fails.</returns>
		public virtual bool Exists(string path)
		{
			return File.Exists(path);
		}

		/// <summary>Gets the access control. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="includeSections">The include sections.</param>
		/// <returns>The access control.</returns>
		public virtual FileSecurity GetAccessControl(string path, AccessControlSections includeSections)
		{
			return File.GetAccessControl(path, includeSections);
		}

		/// <summary>Gets the access control.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The access control.</returns>
		public virtual FileSecurity GetAccessControl(string path)
		{
			return File.GetAccessControl(path);
		}

		/// <summary>Gets the attributes. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The attributes.</returns>
		public virtual FileAttributes GetAttributes(string path)
		{
			return File.GetAttributes(path);
		}

		/// <summary>Gets a creation time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The creation time.</returns>
		public virtual DateTime GetCreationTime(string path)
		{
			return File.GetCreationTime(path);
		}

		/// <summary>Gets a creation time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The creation time utc.</returns>
		public virtual DateTime GetCreationTimeUtc(string path)
		{
			return File.GetCreationTimeUtc(path);
		}

		/// <summary>Gets the last access time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last access time.</returns>
		public virtual DateTime GetLastAccessTime(string path)
		{
			return File.GetLastAccessTime(path);
		}

		/// <summary>Gets the last access time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last access time utc.</returns>
		public virtual DateTime GetLastAccessTimeUtc(string path)
		{
			return File.GetLastAccessTimeUtc(path);
		}

		/// <summary>Gets the last write time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last write time.</returns>
		public virtual DateTime GetLastWriteTime(string path)
		{
			return File.GetLastWriteTime(path);
		}

		/// <summary>Gets the last write time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last write time utc.</returns>
		public virtual DateTime GetLastWriteTimeUtc(string path)
		{
			return File.GetLastWriteTimeUtc(path);
		}

		/// <summary>Moves. </summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		public virtual void Move(string sourceFilename, string destFilename)
		{
			File.Move(sourceFilename, destFilename);
		}

		/// <summary>Opens the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="mode">The mode.</param>
		/// <param name="access">The access.</param>
		/// <param name="share">The share.</param>
		/// <returns>.</returns>
		public virtual FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
		{
			return File.Open(path, mode, access, share);
		}

		/// <summary>Opens the given file.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="mode">The mode.</param>
		/// <param name="access">The access.</param>
		/// <returns>.</returns>
		public virtual FileStream Open(string path, FileMode mode, FileAccess access)
		{
			return File.Open(path, mode, access);
		}

		/// <summary>Opens the given file.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>.</returns>
		public virtual FileStream Open(string path, FileMode mode)
		{
			return File.Open(path, mode);
		}

		/// <summary>Opens a read. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		public virtual Stream OpenRead(string path)
		{
			return File.OpenRead(path);
		}

		/// <summary>Opens a text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		public virtual StreamReader OpenText(string path)
		{
			return File.OpenText(path);
		}

		/// <summary>Opens a write. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		public virtual Stream OpenWrite(string path)
		{
			return File.OpenWrite(path);
		}

		/// <summary>Reads all bytes. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>all bytes.</returns>
		public virtual byte[] ReadAllBytes(string path)
		{
			return File.ReadAllBytes(path);
		}

		/// <summary>Reads all lines. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="encoding">The encoding.</param>
		/// <returns>all lines.</returns>
		public virtual string[] ReadAllLines(string path, Encoding encoding)
		{
			return File.ReadAllLines(path, encoding);
		}

		/// <summary>Reads all lines.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>all lines.</returns>
		public virtual string[] ReadAllLines(string path)
		{
			return File.ReadAllLines(path);
		}

		/// <summary>Reads all text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="encoding">The encoding.</param>
		/// <returns>all text.</returns>
		public virtual string ReadAllText(string path, Encoding encoding)
		{
			return File.ReadAllText(path, encoding);
		}

		/// <summary>Reads all text.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>all text.</returns>
		public virtual string ReadAllText(string path)
		{
			return File.ReadAllText(path);
		}

		/// <summary>Replaces. </summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		/// <param name="destBackupFilename">Filename of the destination backup file.</param>
		/// <param name="ignoreMetadataErrors">true to ignore metadata errors.</param>
		public virtual void Replace(string sourceFilename, string destFilename, string destBackupFilename, bool ignoreMetadataErrors)
		{
			File.Replace(sourceFilename, destFilename, destBackupFilename, ignoreMetadataErrors);
		}

		/// <summary>Replaces.</summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		/// <param name="destBackupFilename">Filename of the destination backup file.</param>
		public virtual void Replace(string sourceFilename, string destFilename, string destBackupFilename)
		{
			File.Replace(sourceFilename, destFilename, destBackupFilename);
		}

		/// <summary>Sets the access control. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="security">The security.</param>
		public virtual void SetAccessControl(string path, FileSecurity security)
		{
			File.SetAccessControl(path, security);
		}

		/// <summary>Sets the attributes. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="attributes">The attributes.</param>
		public virtual void SetAttributes(string path, FileAttributes attributes)
		{
			File.SetAttributes(path, attributes);
		}

		/// <summary>Sets a creation time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		public virtual void SetCreationTime(string path, DateTime creationTime)
		{
			File.SetCreationTime(path, creationTime);
		}

		/// <summary>Sets a creation time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		public virtual void SetCreationTimeUtc(string path, DateTime creationTime)
		{
			File.SetCreationTimeUtc(path, creationTime);
		}

		/// <summary>Sets a last access time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		public virtual void SetLastAccessTime(string path, DateTime creationTime)
		{
			File.SetLastAccessTime(path, creationTime);
		}

		/// <summary>Sets a last access time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		public virtual void SetLastAccessTimeUtc(string path, DateTime creationTime)
		{
			File.SetLastAccessTimeUtc(path, creationTime);
		}

		/// <summary>Sets a last write time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		public virtual void SetLastWriteTime(string path, DateTime creationTime)
		{
			File.SetLastWriteTime(path, creationTime);
		}

		/// <summary>Sets a last write time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		public virtual void SetLastWriteTimeUtc(string path, DateTime creationTime)
		{
			File.SetLastWriteTimeUtc(path, creationTime);
		}

		/// <summary>Writes all bytes. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="bytes">The bytes.</param>
		public virtual void WriteAllBytes(string path, byte[] bytes)
		{
			File.WriteAllBytes(path, bytes);
		}

		/// <summary>Writes all lines. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		/// <param name="encoding">The encoding.</param>
		public virtual void WriteAllLines(string path, string[] contents, Encoding encoding)
		{
			File.WriteAllLines(path, contents, encoding);
		}

		/// <summary>Writes all lines.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		public virtual void WriteAllLines(string path, string[] contents)
		{
			File.WriteAllLines(path, contents);
		}

		/// <summary>Writes all text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		/// <param name="encoding">The encoding.</param>
		public virtual void WriteAllText(string path, string contents, Encoding encoding)
		{
			File.WriteAllText(path, contents, encoding);
		}

		/// <summary>Writes all text.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		public virtual void WriteAllText(string path, string contents)
		{
			File.WriteAllText(path, contents);
		}

		#endregion
	}
}