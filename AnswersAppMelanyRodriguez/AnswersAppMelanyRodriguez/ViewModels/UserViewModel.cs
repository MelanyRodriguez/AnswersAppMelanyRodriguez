using AnswersAppMelanyRodriguez.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnswersAppMelanyRodriguez.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
       public User MyUser { get; set; }

        public UserViewModel() 
        { 
            MyUser = new User();
        }
        public async Task<ObservableCollection<User>> GetAskAsync(int pUserID)
        {
            if (IsBusy) return null;
            IsBusy = true;
            try
            {
                ObservableCollection<User> users = new ObservableCollection<User>();

                MyUser.UserID = pUserID;

               users = await MyUser.GetAskListByID();

                if (users == null)
                {
                    return users;
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
