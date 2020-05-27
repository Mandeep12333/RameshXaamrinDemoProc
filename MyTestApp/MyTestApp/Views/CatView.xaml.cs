using System;
using System.Collections.Generic;
using MyTestApp.Models;
using System.Linq;

using Xamarin.Forms;
using MyTestApp.ViewModels;

namespace MyTestApp.Views
{
    public partial class CatView : ContentPage
    {
        public CatView()
        {
            //InitializeComponent();
            //this.BindingContext = new CatModel();

            InitializeComponent();
            this.BindingContext = new CatViewModel();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string catName = (e.CurrentSelection.FirstOrDefault() as CatModel).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"catdetails?name={catName}");
            // The full route is shown below.

        }
    }

}