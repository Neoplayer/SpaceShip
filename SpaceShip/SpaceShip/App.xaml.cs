using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpaceShip.Services;
using SpaceShip.Views;

namespace SpaceShip
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<SimpleSpaceShip>();
            MainPage = new AppShell();
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
