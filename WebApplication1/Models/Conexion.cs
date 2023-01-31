using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Conexion
    {
        //public List<Comun> ObtenerComboApartado()
        //{            
        //    //set the connection string
        //    string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; Trusted_Connection = True;";
        //    try
        //    {
        //        //sql connection object
        //        using (SqlConnection conn = new SqlConnection(connString))
        //        {
        //            //set stored procedure name
        //            string spName = @"dbo.[WELLDATA_OBT_APARTADO]";
        //            //define the SqlCommand object
        //            SqlCommand cmd = new SqlCommand(spName, conn);
        //            //Set SqlParameter - the employee id parameter value will be set from the command line
        //            //SqlParameter param1 = new SqlParameter();
        //            //param1.ParameterName = "@employeeID";
        //            //param1.SqlDbType = SqlDbType.Int;
        //            //param1.Value = int.Parse(args[0].ToString());
        //            ////add the parameter to the SqlCommand object
        //            //cmd.Parameters.Add(param1);
        //            //open connection
        //            conn.Open();
                    
        //            List<Comun> listComun = new List<Comun>();
        //            //set the SqlCommand type to stored procedure and execute
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            //check if there are records
        //            if (dr.HasRows)
        //            {
        //                while (dr.Read())
        //                {
        //                    Comun objComun = new Comun();
        //                    objComun.Id = dr.GetInt32(0);
        //                    objComun.Descripcion = dr.GetString(1);
        //                    listComun.Add(objComun);
        //                }                 
        //            }
        //            //close data reader
        //            dr.Close();
        //            //close connection
        //            conn.Close();
        //            return listComun;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ResultadoComun objResultado = new ResultadoComun();
        //        List<ResultadoComun> listResultado = new List<ResultadoComun>();
        //        objResultado.MensajeError = ex.Message;
        //        objResultado.Error = true;
        //        listResultado.Add(objResultado);
        //        return listResultado;
        //    }
        //}
        //public List<WellData_Campo> ObtenerComboCampo()
        //{            
        //    //set the connection string
        //    string connString = @"Server =.\SQLEXPRESS; Database = Well_Data; Trusted_Connection = True;";
        //    try
        //    {
        //        //sql connection object
        //        using (SqlConnection conn = new SqlConnection(connString))
        //        {
        //            //set stored procedure name
        //            string spName = @"dbo.[WELLDATA_OBT_CAMPO]";
        //            //define the SqlCommand object
        //            SqlCommand cmd = new SqlCommand(spName, conn);
        //            //Set SqlParameter - the employee id parameter value will be set from the command line
        //            //SqlParameter param1 = new SqlParameter();
        //            //param1.ParameterName = "@employeeID";
        //            //param1.SqlDbType = SqlDbType.Int;
        //            //param1.Value = int.Parse(args[0].ToString());
        //            ////add the parameter to the SqlCommand object
        //            //cmd.Parameters.Add(param1);
        //            //open connection
        //            conn.Open();

                    
        //            List<WellData_Campo> listCampo = new List<WellData_Campo>();

        //            //set the SqlCommand type to stored procedure and execute
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            //check if there are records
        //            if (dr.HasRows)
        //            {
        //                while (dr.Read())
        //                {
        //                    WellData_Campo objCampo = new WellData_Campo();
        //                    objCampo.Id = dr.GetInt32(0);
        //                    objCampo.Campo = dr.GetString(1);
        //                    listCampo.Add(objCampo);
        //                }
        //            }
        //            //close data reader
        //            dr.Close();
        //            //close connection
        //            conn.Close();
        //            return listCampo;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        List<WellData_Campo> listCampo = new List<WellData_Campo>();
        //        WellData_Campo objCampo = new WellData_Campo();
        //        objCampo.Mensaje_Error = ex.Message;
        //        objCampo.Error = true;
        //        listCampo.Add(objCampo);
        //        return listCampo;
        //    }
        //}
    }    
}