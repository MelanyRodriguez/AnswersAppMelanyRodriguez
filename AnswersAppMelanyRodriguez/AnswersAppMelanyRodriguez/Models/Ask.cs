using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AnswersAppMelanyRodriguez.Models
{
    public class Ask
    {


        public Ask() 
        { 

        }
        [Newtonsoft.Json.JsonIgnore]
        public RestRequest Request { get; set; }
        public int AskId { get; set; }
        public string Date { get; set; }
        public string Ask1 { get; set; } 
        public int UserId { get; set; }
        public int AskStatusId { get; set; }
        public bool IsStrike { get; set; }
        public string ImageUrl { get; set; }
        public string AskDetail { get; set; }

        public async Task<bool> AddAskAsync()
        {
            try
            {



                string RouteSufix = string.Format("Users");
                //armamos la ruta completa al endpoint en el api



                string URL = Services.APIConection.ProductionPrefijxURL + RouteSufix;



                RestClient client = new RestClient(URL);



                Request = new RestRequest(URL, Method.Post);



                //agregamos el mecanismo de seguridad, en este caso api key 
                Request.AddHeader(Services.APIConection.ApiKeyName, Services.APIConection.ApiKeyValue);



                //en el caso de una operacion post debemos serializar el objeto para pasarlo como
                //json al api



                string SerealizedModelObject = JsonConvert.SerializeObject(this);
                //Agregamos el objeto serializado en el cuerpo del request
                Request.AddBody(SerealizedModelObject, GlobalObjects.MimeType);





                //ejecutamos la llamada al api
                RestResponse response = await client.ExecuteAsync(Request);



                //saber si las cosas salieron bien
                HttpStatusCode statusCode = response.StatusCode;



                if (statusCode == HttpStatusCode.Created)
                {
                    return true;
                }
                else
                {
                    return false;
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
