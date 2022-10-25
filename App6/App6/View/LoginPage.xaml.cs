using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App6.View;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Login.Text != "chupapa" && Password.Text != "munyanya")
            {
                await DisplayAlert("Ошибка", "Неправильно набран логин или пароль", "Ок");
            }
            if (Login.Text == "chupapa" && Password.Text == "munyanya")
            await Shell.Current.GoToAsync("//First Page");
        }

    }     
}