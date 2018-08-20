using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace People
{
	public partial class MainPage : ContentPage
	{
        public string Text
        {
            get { return pathLabel.Text; }
            set { pathLabel.Text = value; }
        }
		public MainPage()
		{
			InitializeComponent();
            
		}
	}
}
