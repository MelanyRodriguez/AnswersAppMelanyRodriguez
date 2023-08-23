using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AnswersAppMelanyRodriguez.Models
{
    public class User
    {
        public RestRequest Request { get; set; }
      public int UserID { get; set; }
     public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public int StrikeCount { get; set; }
        public string BackUpEmail { get; set; }
        public string JobDescription { get; set; }
        public int UserStatusID { get; set; }
        public int CountryID { get; set; }
        public int UserRoleID { get; set; }

        public async Task<ObservableCollection<User>> GetUserListByUserID()
        {
            try
            {



                string RouteSufix = string.Format("Users/GetUserListByUser?id={0}", this.UserID);
                //armamos la ruta completa al endpoint en el api



                string URL = Services.APIConection.ProductionPrefijxURL + RouteSufix;



                RestClient client = new RestClient(URL);



                Request = new RestRequest(URL, Method.Get);



                //agregamos el mecanismo de seguridad, en este caso api key 
                Request.AddHeader(Services.APIConection.ApiKeyName, Services.APIConection.ApiKeyValue);



                Request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType); ;
                //ejecutamos la llamada al api
                RestResponse response = await client.ExecuteAsync(Request);



                //saber si las cosas salieron bien
                HttpStatusCode statusCode = response.StatusCode;



                if (statusCode == HttpStatusCode.OK)
                {





                    var list = JsonConvert.DeserializeObject<ObservableCollection<User>>(response.Content);





                    return list;
                }
                else
                {
                    return null;
                }



            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }



        }

        public async Task<ObservableCollection<User>> GetAskListByID()
        {
            try
            {
                string RouteSufix = string.Format("Asks/GetAskListByID?id={0}");

                //armamos la ruta completa al endpoint en el API

                string URL = Services.APIConection.ProductionPrefijxURL + RouteSufix;
                

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);

                //agregamos mecanismo de seguridad, en este caso API key
                Request.AddHeader(Services.APIConection.ApiKeyName, Services.APIConection.ApiKeyValue);
                Request.AddHeader(GlobalObjects.ContentType, GlobalObjects.MimeType);

                //ejecutar la llamada al API 
                RestResponse response = await client.ExecuteAsync(Request);

                //saber si las cosas salieron bien
                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    // en el API diseñamos el end point de forma que retorne un list <UserDTO>
                    //pero esta funcion retorna solo un objeto del UserDTO por lo tanto debemos
                    //seleccionar de lsa lista el item con index 0

                    var list = JsonConvert.DeserializeObject<ObservableCollection<User>>(response.Content);

                    return list;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }

        }



    }
}
