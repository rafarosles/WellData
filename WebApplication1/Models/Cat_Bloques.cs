using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Cat_Bloques
    {

        public int id { get; set; }
        public string cadido { get; set; }
        public string id_cadido { get; set; }
        public string uwi { get; set; }
        public string id_uwi { get; set; }
        public string tipo_info { get; set; }
        public string id_info { get; set; }
        public string class_pozo { get; set; }
        public string id_class_pozo { get; set; }
        public string status_pozo { get; set; }
        public string id_status_pozo { get; set; }        
        public string campo { get; set; }
        public string id_campo { get; set; }
        public string nombre_pozo { get; set; }
        public string id_nombre_pozo { get; set; }
        public string mnemonico { get; set; }
        public string id_mnemonico { get; set; }
        public string apartado { get; set; }
        public string id_apartado { get; set; }
        public string estado { get; set; }
        public string id_estado { get; set; }        
        public string nombre_archivo_dig { get; set; }
        public string inai { get; set; }
        public string descripcion_mne { get; set; }

        public string folio_inicial { get; set; }
        public string ubicacion { get; set; }
        public string codigo_mne { get; set; }
        public string fecha_ini_perf { get; set; }
        public string no_caja { get; set; }
        public int total_hojas { get; set; }
        public int no_total_paginas { get; set; }
        public string observaciones { get; set; }

        public string Region { get; set; }

        public bool Error { get; set; }

    }

    public class Resultado_Bloques
    {
        public bool Error { get; set; }
        public string MensajeError { get; set; }
        public List<Cat_Bloques> Resultado { get; set; }

    }
}