using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemWrappers;
using CommonDialogs;
using Ninject.Modules;
using TestablePattern.Controller;

namespace TestablePattern
{
	class DIModule:NinjectModule
	{
		public override void Load()
		{
			Kernel.Bind<FooViewModel>().ToSelf();
			Kernel.Bind<IMessageBoxService>().To<MessageBoxService>();
			Kernel.Bind<ISaveFileService>().To<SaveFileService>();
			Kernel.Bind<IFile>().To<FileImplementation>();
		}
	}
}
