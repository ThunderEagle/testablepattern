using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using TestablePattern.Views;

namespace TestablePattern
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//configure ninject

			using(IKernel kernel = new StandardKernel(new DIModule()))
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(kernel.Get<Foo>());
			}
		}
	}
}
