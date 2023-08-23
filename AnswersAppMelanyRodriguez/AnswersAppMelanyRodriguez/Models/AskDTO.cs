using System;
using System.Collections.Generic;
using System.Text;

namespace AnswersAppMelanyRodriguez.Models
{
    public class AskDTO
    {
        public int IDPregunta { get; set; }
        public DateTime Fecha { get; set; }
        public string Pregunta1 { get; set; } 
        public int UsuarioID { get; set; }
        public int StatusPregunta { get; set; }
        public bool EsError{ get; set; }
        public string ImagenURL { get; set; }
        public string DetallePregunta { get; set; }

    }
}
