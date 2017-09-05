using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESAEAPP.Views;
using Xamarin.Forms;
using ESAEAPP.API;

namespace ESAEAPP
{
    public partial class App : Application
    {
        internal static MainPage esaeapp;

        public App()
        {
            InitializeComponent();

            MainPage = new ESAEAPP.Views.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
