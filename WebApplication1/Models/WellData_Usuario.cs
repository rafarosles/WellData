using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class WellData_Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Password_encript { get; set; }
    }

    public class ResultadoUsuario
    {
        public bool Error { get; set; }
        public string MensajeError { get; set; }
        public List<WellData_Usuario> Resultado { get; set; }
    }
}