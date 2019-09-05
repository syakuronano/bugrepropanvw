using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoverflowIssue.PageTemplate
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstTemplate : ContentView
	{
		public FirstTemplate ()
		{
			InitializeComponent ();
		}
	}
}