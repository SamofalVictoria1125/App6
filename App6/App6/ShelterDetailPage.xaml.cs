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
    public partial class ShelterDetailPage : ContentPage
    {
        public Cat Cat { get; set; }
        public Shelters Shelters { get; set; }

        public ShelterDetailPage(Shelters shelters)
        {
            InitializeComponent();
            GetCatsToCollection(shelters.Id);
        }

        private async void GetCatsToCollection(int id)
        {
            collectionView.ItemsSource = await App.Database.GetCatsByShelter(id);
        }
    }
}