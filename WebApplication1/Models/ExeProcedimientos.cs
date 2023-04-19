using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ExeProcedimientos
    {
        public static List<Comun> ObtenerCombos( string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = Parametros[0];
                //param1.SqlDbType = SqlDbType.Int;
                //param1.Value = Valores[0];
                //add the parameter to the SqlCommand object
                //cmd.Parameters.Add(param1);
                //open connection           
                conn.Open();

                List<Comun> listComun = new List<Comun>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Comun objComun = new Comun();
                        objComun.Id = dr.GetInt32(0);
                        objComun.Descripcion = dr.GetString(1);
                        listComun.Add(objComun);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return listComun;
            }
        }

        public static List<Comun> ObtenerCombosParam(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = Parametros[0];
                //param1.SqlDbType = SqlDbType.Int;
                //param1.Value = Valores[0];
                //add the parameter to the SqlCommand object
                //cmd.Parameters.Add(param1);
                //open connection
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];

                }
                conn.Open();

                List<Comun> listComun = new List<Comun>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Comun objComun = new Comun();
                        objComun.Id = dr.GetInt32(0);
                        objComun.Descripcion = dr.GetString(1);
                        listComun.Add(objComun);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return listComun;
            }
        }
        public static List<Cat_Bloques> ObtenerGridTx(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = Parametros[0];
                //param1.SqlDbType = SqlDbType.Int;
                //param1.Value = Valores[0];
                //add the parameter to the SqlCommand object
                //cmd.Parameters.Add(param1);
                //open connection
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];

                }
                conn.Open();
                cmd.CommandTimeout = 60;

                List<Cat_Bloques> listComun = new List<Cat_Bloques>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();                
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cat_Bloques objDataTx = new Cat_Bloques();
                        
                        objDataTx.id                    = dr.GetInt32(0);
                        objDataTx.nombre_archivo_dig    = dr.GetString(1);
                        objDataTx.id_cadido             = dr.GetString(2);
                        objDataTx.cadido                = dr.GetString(3);
                        objDataTx.id_uwi                = dr.GetString(4);
                        objDataTx.uwi                   = dr.GetString(5);
                        objDataTx.tipo_info             = dr.GetString(6);
                        objDataTx.id_class_pozo         = dr.GetString(7);
                        objDataTx.class_pozo            = dr.GetString(8);
                        objDataTx.status_pozo           = dr.GetString(9);
                        objDataTx.id_campo              = dr.GetString(10);
                        objDataTx.campo                 = dr.GetString(11);
                        objDataTx.id_nombre_pozo        = dr.GetString(12);
                        objDataTx.nombre_pozo           = dr.GetString(13);
                        objDataTx.id_mnemonico          = dr.GetString(14);
                        objDataTx.mnemonico             = dr.GetString(15);
                        objDataTx.id_apartado           = dr.GetString(16);
                        objDataTx.apartado              = dr.GetString(17);
                        objDataTx.estado                = dr.GetString(18);
                        objDataTx.descripcion_mne       = dr.GetString(19);
                        listComun.Add(objDataTx);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return listComun;
            }
        }

        public static List<WellData_Informe_Tecnico> ObtenerGridInformesTecnicos(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = Parametros[0];
                //param1.SqlDbType = SqlDbType.Int;
                //param1.Value = Valores[0];
                //add the parameter to the SqlCommand object
                //cmd.Parameters.Add(param1);
                //open connection
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];

                }
                conn.Open();
                cmd.CommandTimeout = 60;

                List<WellData_Informe_Tecnico> listComun = new List<WellData_Informe_Tecnico>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        WellData_Informe_Tecnico objInformeTecnico = new WellData_Informe_Tecnico();

                        objInformeTecnico.Id                    = dr.GetInt32(0);
                        objInformeTecnico.Bloque                = dr.GetString(1);
                        objInformeTecnico.Ubicacion             = dr.GetString(2);
                        objInformeTecnico.Num_Caja              = dr.GetString(3);
                        objInformeTecnico.Status                = dr.GetString(4);
                        objInformeTecnico.Tipo_Info             = dr.GetString(5);
                        objInformeTecnico.Id_Tipo_Expediente    = dr.GetString(6);
                        objInformeTecnico.Id_Informe            = dr.GetString(7);
                        objInformeTecnico.Informe               = dr.GetString(8);
                        objInformeTecnico.Id_Tipo_Informe        = dr.GetString(9);
                        objInformeTecnico.Tipo_Informe          = dr.GetString(10);
                        objInformeTecnico.Id_Area               = dr.GetString(11);
                        objInformeTecnico.Area                  = dr.GetString(12);
                        objInformeTecnico.Id_Prospecto          = dr.GetString(13);
                        objInformeTecnico.Prospecto             = dr.GetString(14);
                        objInformeTecnico.Id_Informe_Brigada    = dr.GetString(15);
                        objInformeTecnico.Id_Contenido          = dr.GetString(16);
                        objInformeTecnico.Contenido             = dr.GetString(17);
                        objInformeTecnico.Id_Anio               = dr.GetString(18);
                        objInformeTecnico.Anio                  = dr.GetString(19);
                        objInformeTecnico.Antigua_Informe       = dr.GetString(20);
                        objInformeTecnico.Reciente_Informe      = dr.GetString(21);
                        objInformeTecnico.Id_Estados_AreaEstudios = dr.GetString(22);
                        objInformeTecnico.Estados_AreaEstudio   = dr.GetString(23);
                        objInformeTecnico.Id_Tipo_Expediente    = dr.GetString(24);
                        objInformeTecnico.Tipo_Expediente       = dr.GetString(25);
                        objInformeTecnico.Tipo_Pack             = dr.GetString(26);
                        objInformeTecnico.Valor_Documental      = dr.GetString(27);
                        objInformeTecnico.Estado_Fisico         = dr.GetString(28);
                        objInformeTecnico.Medio_Fisico          = dr.GetString(29);
                        objInformeTecnico.Num_Hojas             = dr.GetString(30);
                        objInformeTecnico.Num_Fojas             = dr.GetString(31);
                        objInformeTecnico.Anexos                = dr.GetString(32);
                        objInformeTecnico.Observaciones         = dr.GetString(33);
                        objInformeTecnico.Nombre_Archivo_Digital = dr.GetString(34);
                        listComun.Add(objInformeTecnico);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return listComun;
            }
        }

        public static List<WellData_Afectaciones> ObtenerGridAfectaciones(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = Parametros[0];
                //param1.SqlDbType = SqlDbType.Int;
                //param1.Value = Valores[0];
                //add the parameter to the SqlCommand object
                //cmd.Parameters.Add(param1);
                //open connection
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];

                }
                conn.Open();
                cmd.CommandTimeout = 60;

                List<WellData_Afectaciones> listComun = new List<WellData_Afectaciones>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        WellData_Afectaciones objAfectaciones = new WellData_Afectaciones();

                        objAfectaciones.Id                                  = dr.GetInt32(0);
                        objAfectaciones.Id_Compania                         = dr.GetInt32(1);
                        objAfectaciones.Compania                            = dr.GetString(2);
                        objAfectaciones.Id_Proyecto                         = dr.GetInt32(3);
                        objAfectaciones.Proyecto                            = dr.GetString(4);
                        objAfectaciones.Num_Caja_Provicional                = dr.GetString(5);
                        objAfectaciones.Num_Estimacion                      = dr.GetString(6);
                        objAfectaciones.Num_Tomo                            = dr.GetString(7);
                        objAfectaciones.Num_Dictamen                        = dr.GetString(8);
                        objAfectaciones.Anio                                = dr.GetString(9);
                        objAfectaciones.Nombre_Afectado                     = dr.GetString(10);
                        objAfectaciones.Finiquito                           = dr.GetString(11);
                        objAfectaciones.No_Permiso                          = dr.GetString(12);
                        objAfectaciones.Fecha_Solicitud_Ficha_Pago          = dr.GetString(13);
                        objAfectaciones.Fecha_Pago                          = dr.GetString(14);
                        objAfectaciones.Predio_Parcela_Rancho               = dr.GetString(15);
                        objAfectaciones.Id_Municipio                        = dr.GetInt32(16);
                        objAfectaciones.Municipio                           = dr.GetString(17);
                        objAfectaciones.Id_Estado                           = dr.GetInt32(18);
                        objAfectaciones.Estado                              = dr.GetString(19);
                        objAfectaciones.Id_Regimen                          = dr.GetInt32(20);
                        objAfectaciones.Regimen                             = dr.GetString(21);
                        objAfectaciones.Importe                             = dr.GetString(22);
                        objAfectaciones.Afectacion                          = dr.GetString(23);
                        objAfectaciones.Finiquito_x_Afectacion              = dr.GetString(24);
                        objAfectaciones.Reporte_Danio                       = dr.GetString(25);
                        objAfectaciones.Croquis_Plano_Estudio               = dr.GetString(26);
                        objAfectaciones.Evidencia_Fotografica_Afectacion    = dr.GetString(27);
                        objAfectaciones.Oficio_Deslinde                     = dr.GetString(28);
                        objAfectaciones.Acuerdo_Permiso                     = dr.GetString(29);
                        objAfectaciones.Ine                                 = dr.GetString(30);
                        objAfectaciones.Copia_Ficha_Pago                    = dr.GetString(31);
                        objAfectaciones.Observaciones                       = dr.GetString(32);
                        listComun.Add(objAfectaciones);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return listComun;
            }
        }

        public static List<WellData_Afectaciones> ObtenerGridAfectacionesPep(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = Parametros[0];
                //param1.SqlDbType = SqlDbType.Int;
                //param1.Value = Valores[0];
                //add the parameter to the SqlCommand object
                //cmd.Parameters.Add(param1);
                //open connection
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];

                }
                conn.Open();
                cmd.CommandTimeout = 60;

                List<WellData_Afectaciones> listComun = new List<WellData_Afectaciones>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        WellData_Afectaciones objAfectaciones = new WellData_Afectaciones();

                        objAfectaciones.Id = dr.GetInt32(0);
                        objAfectaciones.Id_Compania = dr.GetInt32(1);
                        objAfectaciones.Compania = dr.GetString(2);
                        objAfectaciones.Id_Proyecto = dr.GetInt32(3);
                        objAfectaciones.Proyecto = dr.GetString(4);
                        objAfectaciones.Clave_Levantamiento_Sismologico = dr.GetDouble(5);
                        objAfectaciones.Num_Caja = dr.GetString(6);
                        objAfectaciones.Num_Siarp = dr.GetString(7);
                        objAfectaciones.Anio = dr.GetString(8);
                        objAfectaciones.Nombre_Afectado = dr.GetString(9);
                        objAfectaciones.Folio = dr.GetString(10);
                        objAfectaciones.Fecha_Solicitud_Ficha_Pago = dr.GetString(11);
                        objAfectaciones.Fecha_Pago = dr.GetString(12);
                        objAfectaciones.Comunidad = dr.GetString(13);
                        objAfectaciones.Id_Municipio = dr.GetInt32(14);
                        objAfectaciones.Municipio = dr.GetString(15);
                        objAfectaciones.Id_Estado = dr.GetInt32(16);
                        objAfectaciones.Estado = dr.GetString(17);
                        objAfectaciones.Id_Regimen = dr.GetInt32(18);
                        objAfectaciones.Regimen = dr.GetString(19);
                        objAfectaciones.Importe = dr.GetString(20);
                        objAfectaciones.Afectacion = dr.GetString(21);
                        objAfectaciones.Recibo_Siarp_Firmas= dr.GetString(22);
                        objAfectaciones.Copia_Finiquito_Afectaciones= dr.GetString(23);
                        objAfectaciones.Copia_Ficha_Pago= dr.GetString(24);
                        objAfectaciones.Ine = dr.GetString(25);
                        objAfectaciones.Reporte_Danios = dr.GetString(26);
                        objAfectaciones.Formato_Permiso_Servidumbre = dr.GetString(27);
                        objAfectaciones.Documento_Acredita_Propiedad = dr.GetString(28);
                        objAfectaciones.Croquis_Afectaciones = dr.GetString(29);
                        objAfectaciones.Copia_Ubicacion_Plano_Estudio = dr.GetString(30);
                        objAfectaciones.Copia_Oficio_Direccionamiento_Presupuestal = dr.GetString(31);
                        objAfectaciones.Observaciones = dr.GetString(32);
                        listComun.Add(objAfectaciones);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return listComun;
            }
        }
        public static List<WellData_Tx> ObtenerDetalleUwi(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];
                    /*SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = Parametros[i];
                    param1.SqlDbType = SqlDbType.VarChar;
                    param1.Value = Valores[i];
                    //add the parameter to the SqlCommand object
                    */

                }
                //open connection
                conn.Open();

                List<WellData_Tx> list = new List<WellData_Tx>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                while (dr.Read())
                {
                    WellData_Tx objWellData = new WellData_Tx();
                    objWellData.inai = dr.GetString(0);
                    objWellData.fecha_ini_perf = Convert.ToString(dr.GetDateTime(1));
                    objWellData.uwi = dr.GetString(2);
                    objWellData.nombre_archivo_dig = dr.GetString(2);
                    list.Add(objWellData);
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return list;
            }
        }
        public static WellData_Usuario IniciarSesion(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];

                }
                //open connection
                conn.Open();

                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                WellData_Usuario objUsuario = new WellData_Usuario();
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        objUsuario.Nombre = dr.GetString(0);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return objUsuario;
            }
        }
        public static List<WellData_Tx> ObtenerDetalleMetadata(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];
                    /*SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = Parametros[i];
                    param1.SqlDbType = SqlDbType.VarChar;
                    param1.Value = Valores[i];
                    //add the parameter to the SqlCommand object
                    */

                }
                //open connection
                conn.Open();

                List<WellData_Tx> list = new List<WellData_Tx>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                while (dr.Read())
                {
                    WellData_Tx objWellData = new WellData_Tx();
                    objWellData.inai = dr.GetString(0);
                    objWellData.uwi = dr.GetString(1);
                    objWellData.nombre_archivo_dig = dr.GetString(2);
                    objWellData.no_caja = dr.GetString(3);
                    objWellData.tipo_info = dr.GetString(4);
                    objWellData.class_pozo = dr.GetString(5);
                    objWellData.status_pozo = dr.GetString(6);
                    objWellData.campo = dr.GetString(7);
                    objWellData.nombre_pozo = dr.GetString(8);
                    objWellData.mnemonico = dr.GetString(9);
                    objWellData.apartado = dr.GetString(10);
                    objWellData.total_hojas = Convert.ToInt32(11);
                    objWellData.no_total_paginas =Convert.ToInt32(12);
                    objWellData.observaciones = dr.GetString(13);
                    objWellData.estado = dr.GetString(14);
                    list.Add(objWellData);
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return list;
            }
        }
        public static List<Cat_Bloques> ObtenerGridBloqueSur(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = Parametros[0];
                //param1.SqlDbType = SqlDbType.Int;
                //param1.Value = Valores[0];
                //add the parameter to the SqlCommand object
                //cmd.Parameters.Add(param1);
                //open connection
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];

                }
                conn.Open();
                cmd.CommandTimeout = 60;

                List<Cat_Bloques> listComun = new List<Cat_Bloques>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cat_Bloques objDataTx = new Cat_Bloques();

                        objDataTx.id = dr.GetInt32(0);
                        objDataTx.nombre_archivo_dig = dr.GetString(1);
                        objDataTx.id_cadido = dr.GetString(2);
                        objDataTx.cadido = dr.GetString(3);
                        objDataTx.id_uwi = dr.GetString(4);
                        objDataTx.uwi = dr.GetString(5);
                        //objDataTx.id_info = dr.GetString(6);
                        //objDataTx.tipo_info = dr.GetString(7);
                        //objDataTx.id_class_pozo = dr.GetString(8);
                        //objDataTx.class_pozo = dr.GetString(9);
                        //objDataTx.id_status_pozo = dr.GetString(10);
                        //objDataTx.status_pozo = dr.GetString(11);
                        objDataTx.id_campo = dr.GetString(6);
                        objDataTx.campo = dr.GetString(7);
                        objDataTx.id_nombre_pozo = dr.GetString(8);
                        objDataTx.nombre_pozo = dr.GetString(9);
                        objDataTx.id_mnemonico = dr.GetString(10);
                        objDataTx.mnemonico = dr.GetString(11);
                        objDataTx.id_apartado = dr.GetString(12);
                        objDataTx.apartado = dr.GetString(13);
                        objDataTx.id_estado = dr.GetString(14);
                        objDataTx.estado = dr.GetString(15);
                        objDataTx.nombre_archivo_dig = dr.GetString(16);
                        listComun.Add(objDataTx);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return listComun;
            }
        }
        public static List<Cat_Registros_Geo_Veracruz> GridCatRegistrosGeoVer(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                //SqlParameter param1 = new SqlParameter();
                //param1.ParameterName = Parametros[0];
                //param1.SqlDbType = SqlDbType.Int;
                //param1.Value = Valores[0];
                //add the parameter to the SqlCommand object
                //cmd.Parameters.Add(param1);
                //open connection
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];

                }
                conn.Open();
                cmd.CommandTimeout = 60;

                List<Cat_Registros_Geo_Veracruz> listComun = new List<Cat_Registros_Geo_Veracruz>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cat_Registros_Geo_Veracruz objDataRegistrosVer = new Cat_Registros_Geo_Veracruz();

                        objDataRegistrosVer.Id = Convert.ToInt32(0);
                        objDataRegistrosVer.Campo = dr.GetString(2);
                        objDataRegistrosVer.Id_Pozo = dr.GetString(3);
                        objDataRegistrosVer.Pozo = dr.GetString(4);
                        objDataRegistrosVer.Descripcion = dr.GetString(5);
                        objDataRegistrosVer.Escala = dr.GetString(6);
                        objDataRegistrosVer.Cima = dr.GetString(7);
                        objDataRegistrosVer.Base = dr.GetString(8);
                        objDataRegistrosVer.Fecha_Registro = dr.GetString(9);
                        objDataRegistrosVer.Compania = dr.GetString(10);
                        objDataRegistrosVer.Estado_Fisico = dr.GetString(11);
                        objDataRegistrosVer.Observaciones = dr.GetString(12);
                        objDataRegistrosVer.Codigo_Caja = dr.GetString(13);
                        objDataRegistrosVer.Ubicacion = dr.GetString(14);
                        //objDataRegistrosVer.Fecha_Inventario = dr.GetString(18);
                        listComun.Add(objDataRegistrosVer);
                    }
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return listComun;
            }
        }

        public static List<WellData_Afectaciones> ObtenerDetalleAfecationCia(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];
                    /*SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = Parametros[i];
                    param1.SqlDbType = SqlDbType.VarChar;
                    param1.Value = Valores[i];
                    //add the parameter to the SqlCommand object
                    */

                }
                //open connection
                conn.Open();

                List<WellData_Afectaciones> list = new List<WellData_Afectaciones>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                while (dr.Read())
                {
                    WellData_Afectaciones objAfectacion = new WellData_Afectaciones();
                    objAfectacion.Id_Compania                       = dr.GetInt32(0);
                    objAfectacion.Id_Proyecto                       = dr.GetInt32(1);
                    objAfectacion.Num_Caja_Provicional              = dr.GetString(2);
                    objAfectacion.Num_Estimacion                    = dr.GetString(3);
                    objAfectacion.Num_Tomo                          = dr.GetString(4);
                    objAfectacion.Num_Dictamen                      = dr.GetString(5);
                    objAfectacion.Anio                              = dr.GetString(6);
                    objAfectacion.Nombre_Afectado                   = dr.GetString(7);
                    objAfectacion.Finiquito                         = dr.GetString(8);
                    objAfectacion.No_Permiso                        = dr.GetString(9);
                    objAfectacion.Fecha_Solicitud_Ficha_Pago        = dr.GetString(10);
                    objAfectacion.Fecha_Pago                        = dr.GetString(11);
                    objAfectacion.Predio_Parcela_Rancho             = dr.GetString(12);
                    objAfectacion.Id_Municipio                      = dr.GetInt32(13);
                    objAfectacion.Id_Estado                         = dr.GetInt32(14);
                    objAfectacion.Id_Regimen                        = dr.GetInt32(15);
                    objAfectacion.Importe                           = dr.GetString(16);
                    objAfectacion.Afectacion                        = dr.GetString(17);
                    objAfectacion.Finiquito_x_Afectacion            = dr.GetString(18);
                    objAfectacion.Reporte_Danios                    = dr.GetString(19);
                    objAfectacion.Croquis_Plano_Estudio             = dr.GetString(20);
                    objAfectacion.Evidencia_Fotografica_Afectacion  = dr.GetString(21);
                    objAfectacion.Oficio_Deslinde                   = dr.GetString(22);
                    objAfectacion.Acuerdo_Permiso                   = dr.GetString(23);
                    objAfectacion.Ine                               = dr.GetString(24);
                    objAfectacion.Copia_Ficha_Pago                  = dr.GetString(25);
                    objAfectacion.Observaciones                     = dr.GetString(26);

                    list.Add(objAfectacion);
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return list;
            }
        }

        public static List<WellData_Afectaciones> ObtenerDetalleAfectacionCia(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];
                    /*SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = Parametros[i];
                    param1.SqlDbType = SqlDbType.VarChar;
                    param1.Value = Valores[i];
                    //add the parameter to the SqlCommand object
                    */

                }
                //open connection
                conn.Open();

                List<WellData_Afectaciones> list = new List<WellData_Afectaciones>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                while (dr.Read())
                {
                    WellData_Afectaciones objAfectacion = new WellData_Afectaciones();
                    objAfectacion.Compania = dr.GetString(0);
                    objAfectacion.Proyecto = dr.GetString(1);
                    objAfectacion.Num_Caja_Provicional = dr.GetString(2);
                    objAfectacion.Num_Estimacion = dr.GetString(3);
                    objAfectacion.Num_Tomo = dr.GetString(4);
                    objAfectacion.Num_Dictamen = dr.GetString(5);
                    objAfectacion.Anio = dr.GetString(6);
                    objAfectacion.Nombre_Afectado = dr.GetString(7);
                    objAfectacion.Finiquito = dr.GetString(8);
                    objAfectacion.No_Permiso = dr.GetString(9);
                    objAfectacion.Fecha_Solicitud_Ficha_Pago = dr.GetString(10);
                    objAfectacion.Fecha_Pago = dr.GetString(11);
                    objAfectacion.Predio_Parcela_Rancho = dr.GetString(12);
                    objAfectacion.Municipio = dr.GetString(13);
                    objAfectacion.Estado = dr.GetString(14);
                    objAfectacion.Regimen = dr.GetString(15);
                    objAfectacion.Importe = dr.GetString(16);
                    objAfectacion.Afectacion = dr.GetString(17);
                    objAfectacion.Finiquito_x_Afectacion = dr.GetString(18);
                    objAfectacion.Reporte_Danios = dr.GetString(19);
                    objAfectacion.Croquis_Plano_Estudio = dr.GetString(20);
                    objAfectacion.Evidencia_Fotografica_Afectacion = dr.GetString(21);
                    objAfectacion.Oficio_Deslinde = dr.GetString(22);
                    objAfectacion.Acuerdo_Permiso = dr.GetString(23);
                    objAfectacion.Ine = dr.GetString(24);
                    objAfectacion.Copia_Ficha_Pago = dr.GetString(25);
                    objAfectacion.Observaciones = dr.GetString(26);

                    list.Add(objAfectacion);
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return list;
            }
        }

        public static List<WellData_Afectaciones> ObtenerDetalleAfectacionPep(string SP, string[] Parametros, object[] Valores)
        {
            //set the connection string
            string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; user id = sa; password = 12345";
            //sql connection object
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //set stored procedure name
                string spName = SP;
                //string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, conn);
                //Set SqlParameter - the employee id parameter value will be set from the command line
                for (int i = 0; i < Parametros.Length; i++)
                {
                    cmd.Parameters.Add(Parametros[i], SqlDbType.VarChar);
                    cmd.Parameters[Parametros[i]].Value = Valores[i];
                    /*SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = Parametros[i];
                    param1.SqlDbType = SqlDbType.VarChar;
                    param1.Value = Valores[i];
                    //add the parameter to the SqlCommand object
                    */

                }
                //open connection
                conn.Open();

                List<WellData_Afectaciones> list = new List<WellData_Afectaciones>();
                //set the SqlCommand type to stored procedure and execute
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                //check if there are records
                while (dr.Read())
                {
                    WellData_Afectaciones objAfectaciones = new WellData_Afectaciones();
                    objAfectaciones.Id = dr.GetInt32(0);
                    objAfectaciones.Id_Compania = dr.GetInt32(1);
                    objAfectaciones.Compania = dr.GetString(2);
                    objAfectaciones.Id_Proyecto = dr.GetInt32(3);
                    objAfectaciones.Proyecto = dr.GetString(4);
                    objAfectaciones.Clave_Levantamiento_Sismologico = dr.GetDouble(5);
                    objAfectaciones.Num_Caja = dr.GetString(6);
                    objAfectaciones.Num_Siarp = dr.GetString(7);
                    objAfectaciones.Anio = dr.GetString(8);
                    objAfectaciones.Nombre_Afectado = dr.GetString(9);
                    objAfectaciones.Folio = dr.GetString(10);
                    objAfectaciones.Fecha_Solicitud_Ficha_Pago = dr.GetString(11);
                    objAfectaciones.Fecha_Pago = dr.GetString(12);
                    objAfectaciones.Comunidad = dr.GetString(13);
                    objAfectaciones.Id_Municipio = dr.GetInt32(14);
                    objAfectaciones.Municipio = dr.GetString(15);
                    objAfectaciones.Id_Estado = dr.GetInt32(16);
                    objAfectaciones.Estado = dr.GetString(17);
                    objAfectaciones.Id_Regimen = dr.GetInt32(18);
                    objAfectaciones.Regimen = dr.GetString(19);
                    objAfectaciones.Importe = dr.GetString(20);
                    objAfectaciones.Afectacion = dr.GetString(21);
                    objAfectaciones.Recibo_Siarp_Firmas = dr.GetString(22);
                    objAfectaciones.Copia_Finiquito_Afectaciones = dr.GetString(23);
                    objAfectaciones.Copia_Ficha_Pago = dr.GetString(24);
                    objAfectaciones.Ine = dr.GetString(25);
                    objAfectaciones.Reporte_Danios = dr.GetString(26);
                    objAfectaciones.Formato_Permiso_Servidumbre = dr.GetString(27);
                    objAfectaciones.Documento_Acredita_Propiedad = dr.GetString(28);
                    objAfectaciones.Croquis_Afectaciones = dr.GetString(29);
                    objAfectaciones.Copia_Ubicacion_Plano_Estudio = dr.GetString(30);
                    objAfectaciones.Copia_Oficio_Direccionamiento_Presupuestal = dr.GetString(31);
                    objAfectaciones.Observaciones = dr.GetString(32);

                    list.Add(objAfectaciones);
                }
                //close data reader
                dr.Close();
                //close connection
                conn.Close();
                return list;
            }
        }
    }
}