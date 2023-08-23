using AnswersAppMelanyRodriguez.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AnswersAppMelanyRodriguez.ViewModels
{

    public class BienvenidaPageViewModel : BaseViewModel
    {
        public User MyUser { get; set; }
        public BienvenidaPageViewModel()
        {
            MyUser = new User();
        }
        public async Task<ObservableCollection<User>> GetUsersAsync(int pUserID)
        {
            if (IsBusy) return null;
            IsBusy = true;
            try
            {
                ObservableCollection<User> users = new ObservableCollection<User>();
                MyUser.UserID = pUserID;
                users = await MyUser.GetUserListByUserID();
                if (users == null)



                {
                    return null;



                }
                return users;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
