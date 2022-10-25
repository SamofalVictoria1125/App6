using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App6.View;

namespace App6
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CatDetailPage), typeof(CatDetailPage));
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
