using System;
using System.Windows.Forms;
using TestablePattern.Controller;
using WeakEvent;

namespace TestablePattern.Views
{
	public partial class Foo:Form
	{
		public Foo(FooViewModel viewModel)
		{
			InitializeComponent();
			bsFoo.DataSource = viewModel;
			bsFoo.ResetBindings(false);
			//bind click events into the viewmodel
			WeakStandardEvent<EventArgs>.AddHandler(btnChange, "Click", viewModel.ChangeText);
			WeakStandardEvent<EventArgs>.AddHandler(btnShowMessage, "Click", viewModel.DisplayMessage);
			WeakStandardEvent<EventArgs>.AddHandler(btnLoadList, "Click", viewModel.LoadList);
			WeakStandardEvent<EventArgs>.AddHandler(btnAddToList, "Click", viewModel.AddToList);
			WeakStandardEvent<EventArgs>.AddHandler(btnModifyItem, "Click", viewModel.ModifyItem);
			WeakStandardEvent<EventArgs>.AddHandler(btnSave, "Click", viewModel.SaveFile);

		}
	}
}