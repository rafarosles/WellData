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
                        objDataRegistrosVer.Cima = Convert.ToInt32(7);
                        objDataRegistrosVer.Base = Convert.ToInt32(8);
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
    }
}