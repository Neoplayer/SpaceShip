using System.ComponentModel;
using Xamarin.Forms;
using SpaceShip.ViewModels;

namespace SpaceShip.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}