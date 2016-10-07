using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommonDialogs
{
	/// <summary>
	/// 	This interface defines a interface that will allow 
	/// 	a ViewModel to open a file
	/// </summary>
	public interface IOpenFileService
	{
		/// <summary>
		/// 	FileName
		/// </summary>
		string FileName { get; }

		/// <summary>
		/// 	Filter
		/// </summary>
		string Filter { get; set; }

		/// <summary>
		/// 	Filter
		/// </summary>
		string InitialDirectory { get; set; }

		/// <summary>
		/// 	This method should show a window that allows a file to be selected
		/// </summary>
		/// <param name = "owner">The owner window of the dialog</param>
		/// <returns>A bool from the ShowDialog call</returns>
		bool? ShowDialog(Window owner = null);

		/// <summary>
		/// Shows the dialog.
		/// </summary>
		/// <param name="handle">The handle.</param>
		/// <returns></returns>
		/// <remarks></remarks>
		bool? ShowDialog(IntPtr handle);

		/// <summary>
		/// 	Gets or sets the index of the filter.
		/// </summary>
		/// <value>The index of the filter.</value>
		int FilterIndex { get; set; }

		/// <summary>
		/// 	Gets or sets a value indicating whether this <see cref = "IOpenFileService" /> is multiselect.
		/// </summary>
		/// <value><c>true</c> if multiselect; otherwise, <c>false</c>.</value>
		bool Multiselect { get; set; }

		/// <summary>
		/// 	Gets the file names.
		/// </summary>
		/// <value>The file names.</value>
		string[] FileNames { get; }

		/// <summary>
		/// 	Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		string Title { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is folder picker.
		/// </summary>
		/// <value><c>true</c> if this instance is folder picker; otherwise, <c>false</c>.</value>
		/// <remarks></remarks>
		bool IsFolderPicker { get; set; }
	}
}
