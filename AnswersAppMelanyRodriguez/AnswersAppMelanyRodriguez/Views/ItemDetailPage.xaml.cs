using AnswersAppMelanyRodriguez.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AnswersAppMelanyRodriguez.Views
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