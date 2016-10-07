using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SystemWrappers;
using CommonDialogs;
using Moq;
using NUnit.Framework;
using TestablePattern.Controller;

namespace UnitTests
{
	[TestFixture]
	class FooViewModelTests
	{

		private MockRepository _mockRepository;
		private Mock<IFile> _file;
		private Mock<ISaveFileService> _saveFileService;
		private Mock<IMessageBoxService> _messageBoxService;

		[SetUp]
		public void Setup()
		{
			_mockRepository = new MockRepository(MockBehavior.Strict);
			_file = _mockRepository.Create<IFile>();
			_saveFileService = _mockRepository.Create<ISaveFileService>();
			_messageBoxService = _mockRepository.Create<IMessageBoxService>();
		}

		private FooViewModel GetViewModel()
		{
			return new FooViewModel(_messageBoxService.Object, _saveFileService.Object, _file.Object);
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
			_messageBoxService.Setup(m => m.ShowInformation(It.IsAny<string>()));
			var vm = GetViewModel();
			vm.DisplayMessage(this, new EventArgs());
			_mockRepository.VerifyAll();
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

			_saveFileService.SetupSet(s => s.OverwritePrompt = false);
			_saveFileService.SetupSet(s => s.Filter = "Text Files|*.txt|All files|*.*");
			_saveFileService.Setup(s => s.ShowDialog(It.IsAny<Window>())).Returns(true);
			_saveFileService.Setup(s => s.FileName).Returns(filename);

			var stream = new MemoryStream();
			_file.Setup(f => f.AppendText(filename)).Returns(new StreamWriter(stream));

			var vm = GetViewModel();

			vm.SaveFile(this, new EventArgs());
			_mockRepository.VerifyAll();
			Assert.Throws<ObjectDisposedException>(() =>
			{
				var length = stream.Length;
			});

		}

		[Test]
		public void SaveFile_FileSelected_FileNotOpened()
		{
			var filename = @"C:\temp\afile.txt";

			_saveFileService.SetupSet(s => s.OverwritePrompt = false);
			_saveFileService.SetupSet(s => s.Filter = "Text Files|*.txt|All files|*.*");
			_saveFileService.Setup(s => s.ShowDialog(It.IsAny<Window>())).Returns(false);

			var vm = GetViewModel();

			vm.SaveFile(this, new EventArgs());

			_mockRepository.VerifyAll();
			_file.Verify(f => f.AppendText(filename), Times.Never);
		}


	}
}
