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

        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute("registration", typeof(NotesPage));
            RegisterRoutes();
            BindingContext = this;
        }

        void RegisterRoutes()
        {
            routes.Add("Notes", typeof(NotesPage));
            routes.Add("NotesEntry", typeof(NoteEntryPage));
            routes.Add("catView", typeof(CatView));

            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}
