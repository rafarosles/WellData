using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Comun
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string P1 { get; set; }        
    }

    public class ResultadoComun
    {
        public bool Error { get; set; }
        public string MensajeError { get; set; }

        public string Ruta_Archivo { get; set; }
        public List<Comun> Resultado { get; set; }

    }
}