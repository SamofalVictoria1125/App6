using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SPage : ContentPage
    {
        public Cat newCat { get; set; }

        public SPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            newCat = new Cat { Name = entryName.Text, Breed = entryBreed.Text };
            await App.Database.AddCat(newCat);
            await Navigation.PopAsync();
        }
    }
}