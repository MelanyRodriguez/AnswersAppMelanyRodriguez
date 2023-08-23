using System;
using System.Collections.Generic;
using System.Text;

namespace AnswersAppMelanyRodriguez.Models
{
    public class UserDTO
    {
        public int IDUsuario { get; set; }
        public string UsuarioNombre { get; set; } 
        public string PrimerApellido { get; set; } 
        public string SegundoApellido { get; set; }
        public string NumeroTelefono { get; set; }
        public string Contrasennia { get; set; } 
        public int CuentaErrores { get; set; }
        public string RespaldoCorreo { get; set; }
        public string DescripciondeTrabajo { get; set; }
        public int StatusUsuarioID { get; set; }
        public int PaisID { get; set; }
        public int RolUsuarioID { get; set; }

    }
}
