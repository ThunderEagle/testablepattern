using System.Windows.Forms;

namespace CommonDialogs
{
	public class OpenFileDialogService
	{
		private OpenFileDialog _openFileDialog = new OpenFileDialog();

		public class OpenFileDialogOptions
		{
			public bool CheckFileExists { get; set; }
			public bool CheckPathExists { get; set; }
			public string DefaultExt { get; set; }
			public bool DereferenceLinks { get; set; }
			public string Filter { get; set; }
			public bool Multiselect { get; set; }
			public bool RestoreDirectory { get; set; }
			public bool ShowHelp { get; set; }
			public bool ShowReadOnly { get; set; }
			public bool ReadOnlyChecked { get; set; }
			public string Title { get; set; }
			public bool ValidateNames { get; set; }
		}

		public DialogResult ShowDialog(OpenFileDialogOptions options, IWin32Window owner = null)
		{
			_openFileDialog.CheckFileExists = options.CheckFileExists;
			_openFileDialog.CheckPathExists = options.CheckPathExists;
			_openFileDialog.DefaultExt = options.DefaultExt;
			_openFileDialog.DereferenceLinks = options.DereferenceLinks;
			_openFileDialog.Filter = options.Filter;
			_openFileDialog.Multiselect = options.Multiselect;
			_openFileDialog.RestoreDirectory = options.RestoreDirectory;
			_openFileDialog.ShowHelp = options.ShowHelp;
			_openFileDialog.ShowReadOnly = options.ShowReadOnly;
			_openFileDialog.ReadOnlyChecked = options.ReadOnlyChecked;
			_openFileDialog.Title = options.Title;
			_openFileDialog.ValidateNames = options.ValidateNames;

			return owner == null ? _openFileDialog.ShowDialog() : _openFileDialog.ShowDialog(owner);
		}
	}
}