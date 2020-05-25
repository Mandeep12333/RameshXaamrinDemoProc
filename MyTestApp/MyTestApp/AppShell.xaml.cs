using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using MyTestApp.Views;

using Xamarin.Forms;

namespace MyTestApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        Dictionary<string, Type> routes = new Dictionary<string, Type>();

        Random rand = new Random();
        public Dictionary<string, Type> Routes { get { return routes; } }

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        //public ICommand RandomPageCommand => new Command(async () => await NavigateToRandomPageAsync());


        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute("registration", typeof(NotesPage));
            RegisterRoutes();
        }

        void RegisterRoutes()
        {
            routes.Add("Notes", typeof(NotesPage));
            routes.Add("NotesEntry", typeof(NoteEntryPage));
            //routes.Add("registration", typeof(SignUpPage));


            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        //async Task NavigateToRandomPageAsyn c()
        //{
        //    string destinationRoute = routes.ElementAt(rand.Next(0, routes.Count)).Key;
        //    string animalName = null;

        //    switch (destinationRoute)
        //    {
        //        case "monkeydetails":
        //            animalName = MonkeyData.Monkeys.ElementAt(rand.Next(0, MonkeyData.Monkeys.Count)).Name;
        //            break;
        //        case "beardetails":
        //            animalName = BearData.Bears.ElementAt(rand.Next(0, BearData.Bears.Count)).Name;
        //            break;
        //        case "catdetails":
        //            animalName = CatData.Cats.ElementAt(rand.Next(0, CatData.Cats.Count)).Name;
        //            break;
        //        case "dogdetails":
        //            animalName = DogData.Dogs.ElementAt(rand.Next(0, DogData.Dogs.Count)).Name;
        //            break;
        //        case "elephantdetails":
        //            animalName = ElephantData.Elephants.ElementAt(rand.Next(0, ElephantData.Elephants.Count)).Name;
        //            break;
        //    }

        //    ShellNavigationState state = Shell.Current.CurrentState;
        //    await Shell.Current.GoToAsync($"{state.Location}/{destinationRoute}?name={animalName}");
        //    Shell.Current.FlyoutIsPresented = false;
        //}
    }
}
