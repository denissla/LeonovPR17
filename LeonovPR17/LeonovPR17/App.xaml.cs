using LeonovPR17.Services;
using LeonovPR17.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeonovPR17
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
