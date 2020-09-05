using System;
using System.Collections.Generic;
using SpaceShip.ViewModels;
using SpaceShip.Views;
using Xamarin.Forms;

namespace SpaceShip
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
