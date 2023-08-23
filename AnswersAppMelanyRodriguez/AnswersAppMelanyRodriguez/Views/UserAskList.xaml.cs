using AnswersAppMelanyRodriguez.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnswersAppMelanyRodriguez.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserAskList : ContentPage
    {
        UserViewModel UserViewModel { get; set; }
        public UserAskList()
        {
            InitializeComponent();
            BindingContext = UserViewModel = new UserViewModel();
            LoadUserList();
        }

        private async void LoadUserList()
        {
            LvlList.ItemsSource = await UserViewModel.GetAskAsync(GlobalObjects.MyLocalUser.IDUsuario);
        }
    }
}