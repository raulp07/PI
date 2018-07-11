using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class EVALUACION_PROVEEDOR_DA
    {

        private static EVALUACION_PROVEEDOR_DA accion;
        private EVALUACION_PROVEEDOR_DA() { }
        public static EVALUACION_PROVEEDOR_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new EVALUACION_PROVEEDOR_DA();
                }
                return accion;
            }
        }

        public List<EVALUACION_PROVEEDOR_EL> GetAllEVALUACION_PROVEEDOR(EVALUACION_PROVEEDOR_EL EP)
        {

            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_EVALUACION_PROVEEDOR", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdEvaluacionProveedor", SqlDbType.Int).Value = EP.iIdEvaluacionProveedor;

                    List<EVALUACION_PROVEEDOR_EL> list = new List<EVALUACION_PROVEEDOR_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            EVALUACION_PROVEEDOR_EL obj = new EVALUACION_PROVEEDOR_EL();

                            if (dataReader["iIdEvaluacionProveedor"] != DBNull.Value) { obj.iIdEvaluacionProveedor = (int)dataReader["iIdEvaluacionProveedor"]; }
                            if (dataReader["iIdProveedor"] != DBNull.Value) { obj.iIdProveedor = (int)dataReader["iIdProveedor"]; }
                            if (dataReader["iCalidadProducto"] != DBNull.Value) { obj.iCalidadProducto = (int)dataReader["iCalidadProducto"]; }
                            if (dataReader["iPrecio"] != DBNull.Value) { obj.iPrecio = (int)dataReader["iPrecio"]; }
                            if (dataReader["iCondiciones"] != DBNull.Value) { obj.iCondiciones = (int)dataReader["iCondiciones"]; }
                            if (dataReader["dFechaEvaluacion"] != DBNull.Value) { obj.dFechaEvaluacion = (DateTime)dataReader["dFechaEvaluacion"]; }
                            if (dataReader["iUsuarioCrea"] != DBNull.Value) { obj.iUsuarioCrea = (int)dataReader["iUsuarioCrea"]; }
                            if (dataReader["dFechaCrea"] != DBNull.Value) { obj.dFechaCrea = (DateTime)dataReader["dFechaCrea"]; }
                            if (dataReader["iUsuarioMod"] != DBNull.Value) { obj.iUsuarioMod = (int)dataReader["iUsuarioMod"]; }
                            if (dataReader["dFechaMod"] != DBNull.Value) { obj.dFechaMod = (DateTime)dataReader["dFechaMod"]; }

                            list.Add(obj);

                        }

                    }

                    return list;
                }
            }
        }
        public int InsertEVALUACION_PROVEEDOR(EVALUACION_PROVEEDOR_EL EP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertEVALUACION_PROVEEDOR", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdProveedor", SqlDbType.Int).Value = EP.iIdProveedor;
                    com.Parameters.Add("@iCalidadProducto", SqlDbType.Int).Value = EP.iCalidadProducto;
                    com.Parameters.Add("@iPrecio", SqlDbType.Int).Value = EP.iPrecio;
                    com.Parameters.Add("@iCondiciones", SqlDbType.Int).Value = EP.iCondiciones;
                    com.Parameters.Add("@dFechaEvaluacion", SqlDbType.Date).Value = EP.dFechaEvaluacion;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = EP.iUsuarioCrea;

                    return com.ExecuteNonQuery() ;
                }
            }
        }
        public int UpdateEVALUACION_PROVEEDOR(EVALUACION_PROVEEDOR_EL EP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdateEVALUACION_PROVEEDOR", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdEvaluacionProveedor", SqlDbType.Int).Value = EP.iIdEvaluacionProveedor;
                    com.Parameters.Add("@iIdProveedor", SqlDbType.Int).Value = EP.iIdProveedor;
                    com.Parameters.Add("@iCalidadProducto", SqlDbType.Int).Value = EP.iCalidadProducto;
                    com.Parameters.Add("@iPrecio", SqlDbType.Int).Value = EP.iPrecio;
                    com.Parameters.Add("@iCondiciones", SqlDbType.Int).Value = EP.iCondiciones;
                    com.Parameters.Add("@dFechaEvaluacion", SqlDbType.Date).Value = EP.dFechaEvaluacion;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = EP.iUsuarioMod;

                    return com.ExecuteNonQuery();
                }
            }
        }

    }

}