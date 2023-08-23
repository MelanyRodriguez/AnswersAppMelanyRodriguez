using AnswersAppMelanyRodriguez.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnswersAppMelanyRodriguez
{
    public static class GlobalObjects
    {
        public static string MimeType = "aplication/json";
        public static string ContentType = "Content-Type";

        //crear el objeto local (global) de usuario
        public static UserDTO MyLocalUser = new UserDTO();
        public static AskDTO MyLocalAsk = new AskDTO();

    }
}
