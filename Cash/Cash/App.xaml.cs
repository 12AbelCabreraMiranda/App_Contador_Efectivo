using Cash.Data;
using Cash.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cash
{
    public partial class App : Application
    {
        public static DataBaseContext Context { get; set; }
        public static MasterDetailPage MasterDet { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDataBase();
            MainPage = new MenuPage();
        }
        //Configuracion de Base de datos locales
        private void InitializeDataBase()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var dbPath = System.IO.Path.Combine(folderApp, "ToDo.db3");
            Context = new DataBaseContext(dbPath);
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
