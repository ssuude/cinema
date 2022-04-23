using SinemaCepte.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SinemaCepte.Views
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