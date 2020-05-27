using System;
using System.Collections.Generic;
using MyTestApp.Models;
using System.IO;
using Xamarin.Forms;


namespace MyTestApp
{
    [QueryProperty("Name", "name")]
    public partial class NoteEntryPage : ContentPage
    {

        public string Name
        {
            set
            {
                Console.WriteLine(Uri.UnescapeDataString(value));
                //entryEntry.Text = Uri.UnescapeDataString(value);
            }
        }


        public NoteEntryPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            

        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            //var note = (Notes)BindingContext;
            //note.Date = DateTime.UtcNow;
            //await App.Database.SaveNoteAsync(note);
            Application.Current.MainPage = new AppShell();
            
            await Shell.Current.GoToAsync("Notes");
            //await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Notes)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Shell.Current.GoToAsync("..");
            //await Navigation.PopAsync();
        }
    }
}
