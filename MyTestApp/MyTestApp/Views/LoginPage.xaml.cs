using System;
using System.Collections.Generic;
using MyTestApp.Views;

using Xamarin.Forms;

namespace MyTestApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected async void OnClicked(object source, EventArgs args)
        {
            //await Shell.Current.GoToAsync("//main");
            Application.Current.MainPage = new AppShell();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync("registration");
            await Navigation.PushAsync(new SignUpPage());
            //App.Current.MainPage = new SignUpPage();
        }
    }
}
