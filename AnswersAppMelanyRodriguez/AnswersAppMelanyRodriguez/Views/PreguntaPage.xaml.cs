using AnswersAppMelanyRodriguez.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnswersAppMelanyRodriguez.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreguntaPage : ContentPage
    {
        PreguntaViewModel viewModel;
        public PreguntaPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new PreguntaViewModel();
        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            bool R = await viewModel.AddAskAsync(TxtDate.Text.Trim(), TxtAsk.Text.Trim(), TxtImageURL.Text.Trim(), TxtAskDetail.Text.Trim());
            if (R)
            {
                await DisplayAlert(":)", " Ask Compleate!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert(":(", "Somenthig went wrong... ", "OK");
            }

           
        }

        private async void BtnCancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}