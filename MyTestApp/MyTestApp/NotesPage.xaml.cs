using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using MyTestApp.Models;

namespace MyTestApp
{
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            // Go to Vendor Screen//
            string URL = $"NotesEntry";
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync(URL);

            //await Navigation.PushAsync(new NoteEntryPage
            //{
            //    BindingContext = new Notes()
            //});
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new NoteEntryPage
                {
                    BindingContext = e.SelectedItem as Notes
                });
            }
        }
    }
}