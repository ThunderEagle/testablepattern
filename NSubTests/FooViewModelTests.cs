using System;
using System.IO;
using System.Windows;
using SystemWrappers;
using CommonDialogs;
using NSubstitute;
using NUnit.Framework;
using TestablePattern.Controller;

namespace NSubTests
{
	[TestFixture]
	class FooViewModelTests
	{
		private IFile _file;
		private ISaveFileService _saveFileService;
		private IMessageBoxService _messageBoxService;

		[SetUp]
		public void Setup()
		{
			_file = Substitute.For<IFile>();
			_saveFileService = Substitute.For<ISaveFileService>();
			_messageBoxService = Substitute.For<IMessageBoxService>();
		}

		private FooViewModel GetViewModel()
		{
			return new FooViewModel(_messageBoxService, _saveFileService, _file);
		}

		[Test]
		public void C_VerifyAddition()
		{
			var vm = GetViewModel();

			var expected = "5";
			vm.A = "2";
			vm.B = "3";
			var actual = vm.C;
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ShowMessage_ShowInformationCalled()
		{
			_messageBoxService.ShowInformation(Arg.Any<string>());

			var vm = GetViewModel();
			vm.DisplayMessage(this, new EventArgs());
			_messageBoxService.ReceivedWithAnyArgs().ShowInformation("");
		}

		[Test]
		public void LoadList_ItemsNotEmpty()
		{
			var vm = GetViewModel();

			vm.LoadList(this, new EventArgs());

			var actual = vm.Items;

			CollectionAssert.IsNotEmpty(actual);
		}

		[Test]
		public void SaveFile_FileSelected_StreamOpenedAndDisposed()
		{
			var filename = @"C:\temp\afile.txt";

			//_saveFileService.SetupSet(s => s.OverwritePrompt = false);
			//_saveFileService.SetupSet(s => s.Filter = "Text Files|*.txt|All files|*.*");
			//_saveFileService.Setup(s => s.ShowDialog(It.IsAny<Window>())).Returns(true);
			//_saveFileService.Setup(s => s.FileName).Returns(filename);

			_saveFileService.ShowDialog(Arg.Any<Window>()).Returns(true);
			_saveFileService.FileName.Returns(filename);

			var stream = new MemoryStream();
			//_file.Setup(f => f.AppendText(filename)).Returns(new StreamWriter(stream));
			_file.AppendText(filename).Returns(new StreamWriter(stream));

			var vm = GetViewModel();

			vm.SaveFile(this, new EventArgs());

			_saveFileService.ReceivedWithAnyArgs().ShowDialog();
			var temp = _saveFileService.Received().FileName;

			Assert.Throws<ObjectDisposedException>(() =>
			{
				var length = stream.Length;
			});
		}

		[Test]
		public void SaveFile_FileSelected_FileNotOpened()
		{
			var filename = @"C:\temp\afile.txt";

			//_saveFileService.SetupSet(s => s.OverwritePrompt = false);
			//_saveFileService.SetupSet(s => s.Filter = "Text Files|*.txt|All files|*.*");
			//_saveFileService.Setup(s => s.ShowDialog(It.IsAny<Window>())).Returns(false);
			_saveFileService.ShowDialog().Returns(false);

			var vm = GetViewModel();

			vm.SaveFile(this, new EventArgs());

			//_mockRepository.VerifyAll();
			_saveFileService.Received().ShowDialog();
			//_file.Verify(f => f.AppendText(filename), Times.Never);
			_file.DidNotReceive().AppendText(filename);
		}
	}
}