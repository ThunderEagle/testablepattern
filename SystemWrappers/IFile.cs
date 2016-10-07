using System;
using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace SystemWrappers
{
	/// <summary>
	/// 	Provides methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of System.IO.FileStream objects.
	/// </summary>
	public interface IFile
	{
		/// <summary>Appends all text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		/// <param name="encoding">The encoding.</param>
		void AppendAllText(string path, string contents, Encoding encoding);

		/// <summary>Appends all text.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		void AppendAllText(string path, string contents);

		StreamWriter AppendText(string path);

		/// <summary>Copies this object. </summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		/// <param name="overwrite">true to overwrite, false to preserve.</param>
		void Copy(string sourceFilename, string destFilename, bool overwrite);

		/// <summary>Copies this object.</summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		void Copy(string sourceFilename, string destFilename);

		/// <summary>Creates this object. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="bufferSize">Size of the buffer.</param>
		/// <param name="options">Options for controlling the operation.</param>
		/// <param name="security">The security.</param>
		/// <returns>.</returns>
		FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity security);

		/// <summary>Creates this object.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="bufferSize">Size of the buffer.</param>
		/// <param name="options">Options for controlling the operation.</param>
		/// <returns>.</returns>
		FileStream Create(string path, int bufferSize, FileOptions options);

		/// <summary>Creates this object.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="bufferSize">Size of the buffer.</param>
		/// <returns>.</returns>
		FileStream Create(string path, int bufferSize);

		/// <summary>Creates this object.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		FileStream Create(string path);

		/// <summary>Creates a text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		StreamWriter CreateText(string path);

		/// <summary>Decrypts the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		void Decrypt(string path);

		/// <summary>Deletes the given path. </summary>
		/// <param name="path">Full pathname of the file.</param>
		void Delete(string path);

		/// <summary>Encrypts the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		void Encrypt(string path);

		/// <summary>Exists the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>true if it succeeds, false if it fails.</returns>
		bool Exists(string path);

		/// <summary>Gets the access control. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="includeSections">The include sections.</param>
		/// <returns>The access control.</returns>
		FileSecurity GetAccessControl(string path, AccessControlSections includeSections);

		/// <summary>Gets the access control.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The access control.</returns>
		FileSecurity GetAccessControl(string path);

		/// <summary>Gets the attributes. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The attributes.</returns>
		FileAttributes GetAttributes(string path);

		/// <summary>Gets a creation time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The creation time.</returns>
		DateTime GetCreationTime(string path);

		/// <summary>Gets a creation time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The creation time utc.</returns>
		DateTime GetCreationTimeUtc(string path);

		/// <summary>Gets the last access time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>The last access time.</returns>
		DateTime GetLastAccessTime(string path);

		/// <summary>Gets the last access time utc.</summary>
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

		/// <summary>Moves. </summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		void Move(string sourceFilename, string destFilename);

		/// <summary>Opens the given file. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="mode">The mode.</param>
		/// <param name="access">The access.</param>
		/// <param name="share">The share.</param>
		/// <returns>.</returns>
		FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);

		/// <summary>Opens the given file.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="mode">The mode.</param>
		/// <param name="access">The access.</param>
		/// <returns>.</returns>
		FileStream Open(string path, FileMode mode, FileAccess access);

		/// <summary>Opens the given file.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="mode">The mode.</param>
		/// <returns>.</returns>
		FileStream Open(string path, FileMode mode);

		/// <summary>Opens a read. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		Stream OpenRead(string path);

		/// <summary>Opens a text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		StreamReader OpenText(string path);

		/// <summary>Opens a write. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>.</returns>
		Stream OpenWrite(string path);

		/// <summary>Reads all bytes. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>all bytes.</returns>
		byte[] ReadAllBytes(string path);

		/// <summary>Reads all lines. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="encoding">The encoding.</param>
		/// <returns>all lines.</returns>
		string[] ReadAllLines(string path, Encoding encoding);

		/// <summary>Reads all lines.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>all lines.</returns>
		string[] ReadAllLines(string path);

		/// <summary>Reads all text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="encoding">The encoding.</param>
		/// <returns>all text.</returns>
		string ReadAllText(string path, Encoding encoding);

		/// <summary>Reads all text.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <returns>all text.</returns>
		string ReadAllText(string path);

		/// <summary>Replaces. </summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		/// <param name="destBackupFilename">Filename of the destination backup file.</param>
		/// <param name="ignoreMetadataErrors">true to ignore metadata errors.</param>
		void Replace(string sourceFilename, string destFilename, string destBackupFilename, bool ignoreMetadataErrors);

		/// <summary>Replaces.</summary>
		/// <param name="sourceFilename">Filename of the source file.</param>
		/// <param name="destFilename">Filename of the destination file.</param>
		/// <param name="destBackupFilename">Filename of the destination backup file.</param>
		void Replace(string sourceFilename, string destFilename, string destBackupFilename);

		/// <summary>Sets the access control. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="security">The security.</param>
		void SetAccessControl(string path, FileSecurity security);

		/// <summary>Sets the attributes. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="attributes">The attributes.</param>
		void SetAttributes(string path, FileAttributes attributes);

		/// <summary>Sets a creation time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		void SetCreationTime(string path, DateTime creationTime);

		/// <summary>Sets a creation time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		void SetCreationTimeUtc(string path, DateTime creationTime);

		/// <summary>Sets a last access time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		void SetLastAccessTime(string path, DateTime creationTime);

		/// <summary>Sets a last access time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		void SetLastAccessTimeUtc(string path, DateTime creationTime);

		/// <summary>Sets a last write time. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		void SetLastWriteTime(string path, DateTime creationTime);

		/// <summary>Sets a last write time utc. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="creationTime">Time of the creation.</param>
		void SetLastWriteTimeUtc(string path, DateTime creationTime);

		/// <summary>Writes all bytes. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="bytes">The bytes.</param>
		void WriteAllBytes(string path, byte[] bytes);

		/// <summary>Writes all lines. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		/// <param name="encoding">The encoding.</param>
		void WriteAllLines(string path, string[] contents, Encoding encoding);

		/// <summary>Writes all lines.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		void WriteAllLines(string path, string[] contents);

		/// <summary>Writes all text. </summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		/// <param name="encoding">The encoding.</param>
		void WriteAllText(string path, string contents, Encoding encoding);

		/// <summary>Writes all text.</summary>
		/// <param name="path">Full pathname of the file.</param>
		/// <param name="contents">The contents.</param>
		void WriteAllText(string path, string contents);
	}
}