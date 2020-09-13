using System.ComponentModel;
using Xamarin.Forms;
using ProyectoSC.ViewModels;

namespace ProyectoSC.Views
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