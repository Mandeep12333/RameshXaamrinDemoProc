using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyTestApp.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync("//login");
            //App.Current.MainPage = new LoginPage();
            await Navigation.PopAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // await Shell.Current.GoToAsync("//login");
            //App.Current.MainPage = new LoginPage();
            await Navigation.PopAsync();

        }
    }
}
