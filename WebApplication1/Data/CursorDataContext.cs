using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class CursorDataContext
    {
        public static List<Comun> ComboTipoInfo()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_TIPO_INFO_VERACRUZ", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboApartado(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_EXPEDIENTES_APARTADOS", Parametros, Valores);
            return Lista;
        }

        public static List<Comun> ComboCadido(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_EXPEDIENTES_CADIDOS", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboCampo(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_EXPEDIENTES_CAMPOS", Parametros, Valores);
            return Lista;
        }

        public static List<Comun> ComboClassPozo(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_EXPEDIENTES_CLASIFICACIONES_POZOS", Parametros, Valores);
            return Lista;
        }

        public static List<Comun> ComboMnemonico(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_EXPEDIENTES_CODIGOS_MNE", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboNombrePozo(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_EXPEDIENTES_NOMBRES_POZOS", Parametros, Valores);
            return Lista;
        }

        public static List<Comun> ComboUwi(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_EXPEDIENTES_UWIS", Parametros, Valores);
            return Lista;
        }

        public static List<Comun> ComboEstado(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_ESTADO_DOCTO_VERACRUZ", Parametros, Valores);
            return Lista;
        }
        
        public static List<Comun> ComboStatusPozo(string region_seleccionada)
        {
            string[] Parametros = { "@id_region" };
            object[] Valores = { region_seleccionada };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_STATUS_POZO_VERACRUZ", Parametros, Valores);
            return Lista;
        }
        
        public static List<Cat_Bloques> GridCatTx(Cat_Bloques objVeracruz)
        {
            string[] Parametros = { "@id_region", "@cadido", "@uwi", "@class_pozo", "@campo", "@nombre_pozo", "@mne", "@apartado" };
            object[] Valores = { objVeracruz.Region, objVeracruz.inai, objVeracruz.uwi, objVeracruz.class_pozo, objVeracruz.campo, objVeracruz.nombre_pozo, objVeracruz.id_mnemonico, objVeracruz .apartado };
            //string[] Parametros = { };
            //object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerGridTx("dbo.NEURALOG_OBT_CAT_EXPEDIENTES", Parametros, Valores);
            return Lista;
        }

        public static WellData_Usuario IniciarSesion(WellData_Usuario objUsuario)
        {
            string[] Parametros = { "@username", "@password" };
            object[] Valores = {objUsuario.Usuario, objUsuario.Password };
            objUsuario = ExeProcedimientos.IniciarSesion("dbo.NEURALOG_OBT_USUARIO", Parametros, Valores);
            return objUsuario;
        }

        

        public static List<WellData_Tx> ObtenerDetalleMetadata(WellData_Tx objTx)
        {
            string[] Parametros = { "id"};
            object[] Valores = { objTx.id };
            var Lista =  ExeProcedimientos.ObtenerDetalleMetadata("dbo.NEURALOG_OBT_CAT_EXPEDIENTE_DETALLE", Parametros, Valores);
            return Lista;
        }

        /*----------------INFO BLOQUE SUR---------------*/
        public static List<Comun> ComboApartadoBloqueSur()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_APARTADO_BLOQUE_SUR", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboCadidoBloqueSur()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_CADIDO_BLOQUE_SUR", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboCampoBloqueSur()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_CAMPO_BLOQUE_SUR", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboEstadoDoctoBloqueSur()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_ESTADO_DOCTO_BLOQUE_SUR", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboMneBloqueSur()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_MNEMONICO_BLOQUE_SUR", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboNombrePozoBloqueSur()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_NOMBRE_POZO_BLOQUE_SUR", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboUwiBloqueSur()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_UWI_BLOQUE_SUR", Parametros, Valores);
            return Lista;
        }
        public static List<Cat_Bloques> ObtenerGridBloqueSur(Cat_Bloques objVeracruz)
        {
            string[] Parametros = { "@cadido", "@tipo_info", "@uwi", "@class_pozo", "@status_pozo", "@campo", "@nombre_pozo", "@mne", "@apartado", "@edo_fisico" };
            object[] Valores = { objVeracruz.inai, objVeracruz.tipo_info, objVeracruz.uwi, objVeracruz.class_pozo, objVeracruz.status_pozo, objVeracruz.campo, objVeracruz.nombre_pozo, objVeracruz.id_mnemonico, objVeracruz.apartado, objVeracruz.estado };
            //string[] Parametros = { };
            //object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerGridBloqueSur("dbo.NEURALOG_OBT_CAT_BLOQUE_SUR", Parametros, Valores);
            return Lista;
        }


        /*-----------------INFORMES TECNICOS-------------*/
        
        public static List<Comun> ComboEdoInfoTecnVer()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_CAT_INF_TEC_VER_EDO_AREA", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboInfInfoTecnVer()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_CAT_INF_TEC_VER_INF", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboInformeInfoTecnVer()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_CAT_INF_TEC_VER_INFORME", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboPropsInfoTecnVer()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_CAT_INF_TEC_VER_PROSP", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboTipoExpInfoTecnVer()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombos("dbo.NEURALOG_OBT_CAT_INF_TEC_VER_TIPO_EXP", Parametros, Valores);
            return Lista;
        }
        public static List<Cat_Registros_Geo_Veracruz> GridCatRegistrosGeoVer(Cat_Registros_Geo_Veracruz objRegistrosGeo)
        {
            string[] Parametros = {"@id_region" , "@nombre_pozo" , "@campo" };
            object[] Valores = {objRegistrosGeo.Region,  objRegistrosGeo.Pozo , objRegistrosGeo.Campo};
            //string[] Parametros = { };
            //object[] Valores = { };
            var Lista = ExeProcedimientos.GridCatRegistrosGeoVer("dbo.NEURALOG_OBT_CAT_REGISTROS_GEOFISICOS", Parametros, Valores);
            return Lista;
        }


        /*-----------------INFORMES TECNICOS -------------*/

        public static List<Comun> ComboIdInformeInfTec(string tipo_metadata)
        {
            string[] Parametros = { "@tipo_metadata" };
            object[] Valores = { tipo_metadata };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_INFORME_TECNICO_ID_INFORME", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboTipoInformeInfTec(string tipo_metadata)
        {
            string[] Parametros = { "@tipo_metadata" };
            object[] Valores = { tipo_metadata };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_INFORME_TECNICO_TIPO_INFORME", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboAreaInfTec(string tipo_metadata)
        {
            string[] Parametros = { "@tipo_metadata" };
            object[] Valores = { tipo_metadata };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_INFORME_TECNICO_AREA", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboProspectoInfTec(string tipo_metadata)
        {
            string[] Parametros = { "@tipo_metadata" };
            object[] Valores = { tipo_metadata };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_INFORME_TECNICO_PROSPECTOS", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboContenidoInfTec(string tipo_metadata)
        {
            string[] Parametros = { "@tipo_metadata" };
            object[] Valores = { tipo_metadata };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_INFORME_TECNICO_CONTENIDOS", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboEdosAreaEstudioInfTec(string tipo_metadata)
        {
            string[] Parametros = { "@tipo_metadata" };
            object[] Valores = { tipo_metadata };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_INFORME_TECNICO_ESTADOS_AREA_ESTUDIOS", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboTipoExpedienteInfTec(string tipo_metadata)
        {
            string[] Parametros = { "@tipo_metadata" };
            object[] Valores = { tipo_metadata };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_INFORME_TECNICO_TIPO_EXPEDIENTES", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboAniosInfTec(string tipo_metadata)
        {
            string[] Parametros = { "@tipo_metadata" };
            object[] Valores = { tipo_metadata };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_OBT_CAT_INFORME_TECNICO_ANIOS", Parametros, Valores);
            return Lista;
        }

        public static List<WellData_Informe_Tecnico> GridInfomresTecnicos(WellData_Informe_Tecnico objInformeTecnico)
        {
            string[] Parametros = { "@tipo_metadata", "@id_informe", "@tipo_informe", "@area", "@prospecto", "@contenido", "@anio", "@estados_area_estudio", "@tipo_expediente" };
            object[] Valores = { objInformeTecnico.Tipo_Metadata, objInformeTecnico.Id_Informe, objInformeTecnico.Tipo_Informe, objInformeTecnico.Area, objInformeTecnico.Prospecto, objInformeTecnico.Contenido, objInformeTecnico.Anio, objInformeTecnico.Estados_AreaEstudio, objInformeTecnico.Tipo_Expediente };
            //string[] Parametros = { };
            //object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerGridInformesTecnicos("dbo.NEURALOG_OBT_CAT_INFORMES_TECNICOS", Parametros, Valores);
            return Lista;
        }

        public static List<WellData_Afectaciones> GridAfectacionesCia(WellData_Afectaciones objAfectaciones)
        {
            string[] Parametros = { "@id_compania", "@id_proyecto", "@id_municipio", "@id_estado", "@id_regimen" };
            object[] Valores = { objAfectaciones.Compania, objAfectaciones.Proyecto, objAfectaciones.Municipio, objAfectaciones.Estado, objAfectaciones.Regimen};
            //string[] Parametros = { };
            //object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerGridAfectaciones("dbo.NEURALOG_OBT_CAT_CIA_AFECTACIONES", Parametros, Valores);
            return Lista;
        }

        public static List<WellData_Afectaciones> GridAfectacionesPep(WellData_Afectaciones objAfectaciones)
        {
            string[] Parametros = { "@id_compania", "@id_proyecto", "@id_municipio", "@id_estado", "@id_regimen" };
            object[] Valores = { objAfectaciones.Compania, objAfectaciones.Proyecto, objAfectaciones.Municipio, objAfectaciones.Estado, objAfectaciones.Regimen };
            //string[] Parametros = { };
            //object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerGridAfectacionesPep("dbo.NEURALOG_OBT_CAT_PEP_AFECTACIONES", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboCompaniaCia()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_CIA_OBT_COMPANIA", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboEstadoCia()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_CIA_OBT_ESTADO", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboMunicipioCia(int estado)
        {
            string[] Parametros = { "@id_estado" };
            object[] Valores = { estado };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_CIA_OBT_MUNICIPIO", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboProyectoCia()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_CIA_OBT_PROYECTO", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboRegimenCia()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_CIA_OBT_REGIMEN", Parametros, Valores);
            return Lista;
        }

        public static List<Comun> ComboAfectadoCia()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_CIA_OBT_NOMBRE_AFECTADO", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboCompaniaPep()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_PEP_OBT_COMPANIA", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboEstadoPep()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_PEP_OBT_ESTADO", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboMunicipioPep(int estado)
        {
            string[] Parametros = { "@id_estado" };
            object[] Valores = { estado };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_PEP_OBT_MUNICIPIO", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboProyectoPep()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_PEP_OBT_PROYECTO", Parametros, Valores);
            return Lista;
        }
        public static List<Comun> ComboRegimenPep()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_PEP_OBT_REGIMEN", Parametros, Valores);
            return Lista;
        }

        public static List<Comun> ComboAfectadoPep()
        {
            string[] Parametros = { };
            object[] Valores = { };
            var Lista = ExeProcedimientos.ObtenerCombosParam("dbo.NEURALOG_PEP_OBT_NOMBRE_AFECTADO", Parametros, Valores);
            return Lista;
        }
        public static List<WellData_Afectaciones> ObtenerAfectacionCia(WellData_Afectaciones objAfectacion)
        {
            string[] Parametros = { "@id" };
            object[] Valores = { objAfectacion.Id };
            var Lista = ExeProcedimientos.ObtenerDetalleAfectacionCia("dbo.NEURALOG_OBT_AFECTACION_CIA_DETALLE", Parametros, Valores);
            return Lista;
        }
        public static List<WellData_Afectaciones> ObtenerAfectacionPep(WellData_Afectaciones objAfectacion)
        {
            string[] Parametros = { "@id" };
            object[] Valores = { objAfectacion.Id };
            var Lista = ExeProcedimientos.ObtenerDetalleAfectacionPep("dbo.NEURALOG_OBT_AFECTACION_PEP_DETALLE", Parametros, Valores);
            return Lista;
        }
    }
}