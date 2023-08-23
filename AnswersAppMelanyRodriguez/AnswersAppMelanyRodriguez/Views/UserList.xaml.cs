using AnswersAppMelanyRodriguez.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnswersAppMelanyRodriguez.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserList : ContentPage
    {
        BienvenidaPageViewModel BienvenidaPageViewModel;
        public UserList()
        {
            InitializeComponent();
            BindingContext = BienvenidaPageViewModel = new BienvenidaPageViewModel();
            LoadUserList();
        }
        private async void LoadUserList()
        {
            LvList.ItemsSource = await BienvenidaPageViewModel.GetUsersAsync(GlobalObjects.MyLocalUser.IDUsuario);
        }

    }
}