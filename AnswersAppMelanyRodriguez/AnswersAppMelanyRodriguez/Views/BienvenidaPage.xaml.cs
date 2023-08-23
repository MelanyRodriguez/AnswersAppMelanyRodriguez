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
    public partial class BienvenidaPage : ContentPage
    {
        public BienvenidaPage()
        {
            InitializeComponent();
        }

        private async void BtnVerTodasPreguntas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserAskList());
        }

        private async void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BienvenidaPage());
        }

        private async void BtnAddAsk_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PreguntaPage());
        }

        private async void BtnAskList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserAskList());
        }
    }
}