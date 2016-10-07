using System;
using System.Linq;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace CommonDialogs
{
	/// <summary>
	/// 	This class implements the IOpenFileService for WPF purposes.
	/// </summary>
	public class OpenFileService : IOpenFileService
	{
		#region Data
		//System.Windows.Forms.OpenFileDialog
		/// <summary>
		/// 	Embedded OpenFileDialog to pass back correctly selected
		/// 	values to ViewModel
		/// </summary>
		private readonly CommonOpenFileDialog _openFileDialog = new CommonOpenFileDialog();

		#endregion

		#region IOpenFileService Members

		/// <summary>
		/// 	This method should show a window that allows a file to be selected.
		/// </summary>
		/// <param name = "owner">The owner window of the dialog.</param>
		/// <returns>A bool from the ShowDialog call.</returns>
		public bool? ShowDialog(Window owner = null)
		{
			return owner == null ? CommonFileDialogResult.Ok == _openFileDialog.ShowDialog() : CommonFileDialogResult.Ok == _openFileDialog.ShowDialog(owner);
		}

		/// <summary>
		/// Shows the dialog.
		/// </summary>
		/// <param name="handle">The handle.</param>
		/// <returns></returns>
		/// <remarks></remarks>
		public bool? ShowDialog(IntPtr handle)
		{
			return CommonFileDialogResult.Ok == _openFileDialog.ShowDialog(handle);
		}

		/// <summary>
		/// Gets or sets a value indicating whether this instance is folder picker.
		/// </summary>
		/// <value><c>true</c> if this instance is folder picker; otherwise, <c>false</c>.</value>
		/// <remarks></remarks>
		public bool IsFolderPicker
		{
			get { return _openFileDialog.IsFolderPicker; }
			set { _openFileDialog.IsFolderPicker = value; }
		}

		/// <summary>
		/// 	Gets or sets a value indicating whether the multiselect.
		/// </summary>
		/// <value>true if multiselect, false if not.</value>
		public bool Multiselect
		{
			get { return _openFileDialog.Multiselect; }
			set { _openFileDialog.Multiselect = value; }
		}

		/// <summary>
		/// 	Gets a list of names of the files.
		/// </summary>
		/// <value>A list of names of the files.</value>
		public string[] FileNames
		{
			get { return _openFileDialog.FileNames.ToArray(); }
		}

		/// <summary>
		/// 	Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string Title
		{
			get { return _openFileDialog.Title; }
			set { _openFileDialog.Title = value; }
		}

		/// <summary>
		/// 	FileName : Simply use embedded OpenFileDialog.FileName But DO NOT allow a Set as it will ONLY
		/// 	come from user picking a file.
		/// </summary>
		/// <value>The name of the file.</value>
		public string FileName
		{
			get { return _openFileDialog.FileName; }
		}

		/// <summary>
		/// 	Filter : Simply use embedded OpenFileDialog.Filter.
		/// </summary>
		/// <value>The filter.</value>
		public string Filter
		{
			get { return _filter; }
			set
			{
				_filter = value;
				//parse it and set the collection
				string[] filterParts = _filter.Split('|');
				if (filterParts.Length % 2 != 0)
				{
					throw new InvalidOperationException("Filter string must contain Description|extensions in pairs");
				}
				for (int i = 0; i < filterParts.Length; i += 2)
				{
					_openFileDialog.Filters.Add(new CommonFileDialogFilter(filterParts[i], filterParts[i + 1]));
				}
			}
		}

		private string _filter;

		/// <summary>
		/// 	Gets or sets zero-based index of the filter.
		/// </summary>
		/// <value>The filter index.</value>
		[Obsolete]
		public int FilterIndex
		{
			get { return _filterIndex; }
			set { _filterIndex = value; }
		}

		private int _filterIndex;

		/// <summary>
		/// 	Filter : Simply use embedded OpenFileDialog.InitialDirectory.
		/// </summary>
		/// <value>The pathname of the initial directory.</value>
		public string InitialDirectory
		{
			get { return _openFileDialog.InitialDirectory; }
			set { _openFileDialog.InitialDirectory = value; }
		}

		#endregion
	}
}