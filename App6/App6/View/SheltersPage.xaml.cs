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
    public partial class SheltersPage : ContentPage
    {
        public SheltersPage()
        {
            InitializeComponent();
            GetSheltersToCollection();

        }
        private async void GetSheltersToCollection()
        {
            collectionView.ItemsSource = await App.DatabaseShelters.GetShelters();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        /*private async void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (collectionView.SelectedItem != null)
            {
                await Navigation.PushAsync(new CatDetailPage((Cat)collectionView.SelectedItem));
            }
        }*/

        protected override async void OnAppearing()
        {
            collectionView.ItemsSource = new List<Shelters>();
            collectionView.ItemsSource = await App.DatabaseShelters.GetShelters();
            collectionView.SelectedItem = null;
            base.OnAppearing();
        }
    }
}