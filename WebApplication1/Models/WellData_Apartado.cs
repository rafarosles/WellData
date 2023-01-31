using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class WellData_Apartado
    {
        public int Id { get; set; }
        public string Apartado { get; set; }
        public string Mensaje_Error { get; set; }
        public bool Error { get; set; }
    }

    public class ResultadoApartado
    {
        public bool Error { get; set; }
        public string MensajeError { get; set; }
        public List<WellData_Apartado> Resultado { get; set; }

    }
}