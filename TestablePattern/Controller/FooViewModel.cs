using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using CommonDialogs;
using TestablePattern.Models;
using SystemWrappers;

namespace TestablePattern.Controller
{
	public class FooViewModel:NotifyObject.NotifyObject
	{
		private readonly IMessageBoxService _messageBox;
		private readonly ISaveFileService _saveFileService;
		private readonly IFile _file;
		

		public FooViewModel(IMessageBoxService messageBoxService, ISaveFileService saveFileService, IFile file)
		{
			_saveFileService = saveFileService;
			_messageBox = messageBoxService;
			_file = file;
		}


		public string A
		{
			get { return GetPropertyValue(() => A, (0).ToString); }
			set { SetPropertyValue(() => A, value); }
		}

		public string B
		{
			get { return GetPropertyValue(() => B, (0).ToString); }
			set { SetPropertyValue(() => B, value); }
		}

		[DependsUpon("A")]
		[DependsUpon("B")]
		public string C
		{
			get
			{
				var a = int.Parse(A);
				var b = int.Parse(B);
				return (a + b).ToString();
			}
		}

		public string LabelText
		{
			get { return GetPropertyValue(() => LabelText, () => "Just a Label"); }
		}

		public bool IsEditable
		{
			get { return GetPropertyValue(() => IsEditable); }
			set { SetPropertyValue(() => IsEditable, value); }
		}

		public string EnteredText
		{
			get { return GetPropertyValue(() => EnteredText, () => "Initial Text"); }
			set
			{
				SetPropertyValue(() => EnteredText, value);
				LinkedText = value;
			}
		}

		public string LinkedText
		{
			get { return GetPropertyValue(() => LinkedText, () => "start"); }
			set { SetPropertyValue(() => LinkedText, value); }
		}

		public BindingList<FooBar> Items
		{
			get { return GetPropertyValue(() => Items, () => new BindingList<FooBar>()); }
			set { SetPropertyValue(() => Items, value); }
		}

		public bool AllowLoad
		{
			get { return GetPropertyValue(() => AllowLoad); }
			set { SetPropertyValue(() => AllowLoad, value); }
		}

		public void ChangeText(object sender, EventArgs e)
		{
			LinkedText = "changed from button";
		}

		public void DisplayMessage(object sender, EventArgs e)
		{
			_messageBox.ShowInformation("A Message from the view model");
		}

		public void LoadList(object sender, EventArgs e)
		{
			var list = new BindingList<FooBar>();
			for(int i = 0; i < 5; i++)
			{
				list.Add(GenerateFooBar());
			}
			Items = list;
		}

		public void AddToList(object sender, EventArgs e)
		{
			Items.Add(GenerateFooBar());
		}

		public void ModifyItem(object sender, EventArgs e)
		{
			if(Items != null && Items.Any())
			{
				Items[0].Name = "We changed the NAME";
			}
		}


		public void SaveFile(object sender, EventArgs e)
		{
			_saveFileService.OverwritePrompt = false;
			_saveFileService.Filter = "Text Files|*.txt|All files|*.*";
			bool? selected = _saveFileService.ShowDialog();
			if(selected.HasValue && selected.Value)
			{
				using(var file = _file.AppendText(_saveFileService.FileName))
				{
					file.WriteLine("Adding a line to the file {0}", _rnd.Next());
					file.Flush();
				}

			}
		}

		private int _nameValue = 1;
		private Random _rnd = new Random(DateTime.Now.Second);

		private FooBar GenerateFooBar()
		{
			return new FooBar
			{
				Amount = _rnd.NextDouble() * 1000,
				Date = DateTime.Now.AddMinutes(_rnd.Next(0, 250000)),
				Authorized = (_rnd.Next(1, 10) % 2 == 0),
				Name = string.Format("Name {0}", _nameValue++)
			};
		}
	}
}