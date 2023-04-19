using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class WellData_Afectaciones
    {
        public int Id { get; set; }
        public int Id_Compania { get; set; }
        public string Compania { get; set; }
        public int Id_Proyecto { get; set; }
        public string Proyecto { get; set; }
        public string Num_Caja_Provicional { get; set; }
        public string Num_Estimacion { get; set; }
        public string Num_Tomo { get; set; }
        public string Num_Dictamen { get; set; }
        public string Anio { get; set; }
        public string Nombre_Afectado { get; set; }
        public string Finiquito { get; set; }
        public string No_Permiso { get; set; }
        public string Fecha_Solicitud_Ficha_Pago { get; set; }
        public string Fecha_Pago { get; set; }
        public string Predio_Parcela_Rancho { get; set; }
        public int Id_Municipio { get; set; }
        public string Municipio { get; set; }
        public int Id_Estado { get; set; }
        public string Estado { get; set; }
        public int Id_Regimen { get; set; }
        public string Regimen { get; set; }
        public string Importe { get; set; }
        public string Afectacion { get; set; }
        public string Finiquito_x_Afectacion { get; set; }
        public string Reporte_Danio { get; set; }
        public string Croquis_Plano_Estudio { get; set; }
        public string Evidencia_Fotografica_Afectacion { get; set; }
        public string Oficio_Deslinde { get; set; }
        public string Acuerdo_Permiso { get; set; }
        public string Ine { get; set; }
        public string Copia_Ficha_Pago { get; set; }
        public string Observaciones { get; set; }
        public double Clave_Levantamiento_Sismologico { get; set; }
        public string Num_Caja { get; set; }
        public string Num_Siarp { get; set; }
        public string Folio { get; set; }
        public string Comunidad { get; set; }
        public string Recibo_Siarp_Firmas { get; set; }
        public string Copia_Finiquito_Afectaciones { get; set; }
        public string Reporte_Danios { get; set; }
        public string Formato_Permiso_Servidumbre { get; set; }
        public string Documento_Acredita_Propiedad { get; set; }
        public string Croquis_Afectaciones { get; set; }
        public string Copia_Ubicacion_Plano_Estudio { get; set; }
        public string Copia_Oficio_Direccionamiento_Presupuestal { get; set; }




    }

    public class ResultadoAfectaciones
    {
        public bool Error { get; set; }
        public string MensajeError { get; set; }
        public List<WellData_Afectaciones> Resultado { get; set; }

    }
}