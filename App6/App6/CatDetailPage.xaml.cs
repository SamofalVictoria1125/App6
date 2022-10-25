using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatDetailPage : ContentPage
    {
        public Cat Cat { get; set; }
        public Shelters Shelters { get; set; }

        public CatDetailPage(Cat cat)
        {
            InitializeComponent();
            entryName.Text = cat.Name;
            entryBreed.Text = cat.Breed;
            /*if (entryShelter.Text == shelters.Adress)
                cat.ShelterId = shelters.Id; 
            Cat = cat;
            Shelters = shelters;*/
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Cat.Name = entryName.Text;
            Cat.Breed = entryBreed.Text;
            await App.Database.EditCat(Cat);
            await Navigation.PopAsync();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await App.Database.DeleteCat(Cat);
            await Navigation.PopAsync();
        }
    }
}