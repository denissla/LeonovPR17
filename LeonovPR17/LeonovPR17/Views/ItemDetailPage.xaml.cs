using LeonovPR17.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LeonovPR17.Views
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