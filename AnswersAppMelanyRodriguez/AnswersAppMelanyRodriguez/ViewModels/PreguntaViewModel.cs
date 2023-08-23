using AnswersAppMelanyRodriguez.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnswersAppMelanyRodriguez.ViewModels
{
    public class PreguntaViewModel: BaseViewModel
    {
        public Ask MyAsk { get; set; }

        public PreguntaViewModel()
        {
            MyAsk = new Ask();
        }

        public async Task<bool> AddAskAsync(string pDate, string pAsk, string pImageURL, string pAskDetail)
        {
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyAsk = new Ask();
                MyAsk.Date = pDate;
                MyAsk.Ask1 = pAsk;
                MyAsk.ImageUrl = pImageURL;
                MyAsk.AskDetail = pAskDetail;

                bool R = await MyAsk.AddAskAsync();
                return R;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
