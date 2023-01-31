using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Cat_Registros_Geo_Veracruz
    {
        public float Id { get; set; }
        public string Campo { get; set; }
        public string Id_Pozo { get; set; }
        public string Pozo { get; set; }
        public string Descripcion { get; set; }
        public string Escala { get; set; }
        public float Cima { get; set; }
        public float Base { get; set; }
        public string Fecha_Registro { get; set; }
        public string Compania { get; set; }
        public string Estado_Fisico { get; set; }
        public string Observaciones { get; set; }
        public string Codigo_Caja { get; set; }
        public string Ubicacion { get; set; }
        public string Fecha_Inventario { get; set; }

        public string Region { get; set; }
    }

    public class Resultado_Registros_Geo_Veracruz
    {
        public bool Error { get; set; }
        public string MensajeError { get; set; }
        public List<Cat_Registros_Geo_Veracruz> Resultado { get; set; }

    }
}