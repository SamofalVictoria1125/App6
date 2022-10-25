using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    public partial class App : Application
    {
        private static Database database;
        private static DatabaseShelters databaseShelters;

        public static Database Database
        {
            get
            {
                if (database == null)
                    database = new Database();
                return database;
            }
        }

        public static DatabaseShelters DatabaseShelters
        {
            get
            {
                if (databaseShelters == null)
                    databaseShelters = new DatabaseShelters();
                return databaseShelters;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
