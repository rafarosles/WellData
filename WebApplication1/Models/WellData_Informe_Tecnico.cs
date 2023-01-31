using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class WellData_Informe_Tecnico
    {
        public int Id { get; set; }
        public string Bloque { get; set; }
        public string Ubicacion { get; set; }
        public string Informe { get; set; }
        public string Num_Caja { get; set; }
        public string Status { get; set; }
        public string Tipo_Info { get; set; }
        public string Id_Tipo_Expediente { get; set; }
        public string Id_Informe { get; set; }
        public string Tipo_Informe { get; set; }
        public string Area { get; set; }
        public string Prospecto { get; set; }
        public string Id_Informe_Brigada { get; set; }
        public string Contenido { get; set; }
        public string Anio { get; set; }
        public string Antigua_Informe { get; set; }
        public string Reciente_Informe { get; set; }
        public string Estados_AreaEstudio { get; set; }
        public string Tipo_Expediente { get; set; }
        public string Tipo_Pack { get; set; }
        public string Valor_Documental { get; set; }
        public string Estado_Fisico { get; set; }
        public string Medio_Fisico { get; set; }
        public string Num_Hojas { get; set; }
        public string Num_Fojas { get; set; }
        public string Anexos { get; set; }
        public string Observaciones { get; set; }
        public string Nombre_Archivo_Digital { get; set; }
        public string Tipo_Metadata { get; set; }




        public string Id_Tipo_Informe { get; set; }
        public string Id_Area { get; set; }
        public string Id_Prospecto { get; set; }
        public string Id_Contenido { get; set; }
        public string Id_Anio { get; set; }
        public string Id_Estados_AreaEstudios { get; set; }

    }

    public class ResultadoInformeTecnico
    {
        public bool Error { get; set; }
        public string MensajeError { get; set; }
        public List<WellData_Informe_Tecnico> Resultado { get; set; }

    }
}