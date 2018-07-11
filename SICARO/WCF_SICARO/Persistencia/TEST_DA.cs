using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class TEST_DA
    {

        private static TEST_DA accion;
        private TEST_DA() { }
        public static TEST_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new TEST_DA();
                }
                return accion;
            }
        }

        public List<TEST_EL> GetAllTEST(TEST_EL T)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_TEST", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdTest", SqlDbType.Int).Value = T.iIdTest;

                    List<TEST_EL> list = new List<TEST_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            TEST_EL obj = new TEST_EL();

                            if (dataReader["iIdTest"] != DBNull.Value) { obj.iIdTest = (int)dataReader["iIdTest"]; }
                            if (dataReader["iIdGestorCapacitacion"] != DBNull.Value) { obj.iIdGestorCapacitacion = (int)dataReader["iIdGestorCapacitacion"]; }
                            if (dataReader["vDescricionTest"] != DBNull.Value) { obj.vDescricionTest = (string)dataReader["vDescricionTest"]; }
                            if (dataReader["dFechaTest"] != DBNull.Value) { obj.dFechaTest = (DateTime)dataReader["dFechaTest"]; }
                            if (dataReader["iEstadoTest"] != DBNull.Value) { obj.iEstadoTest = (int)dataReader["iEstadoTest"]; }
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

        public int InsertTEST(TEST_EL T)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertTEST", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdGestorCapacitacion", SqlDbType.Int).Value = T.iIdGestorCapacitacion;
                    com.Parameters.Add("@vDescricionTest", SqlDbType.VarChar).Value = T.vDescricionTest;
                    com.Parameters.Add("@dFechaTest", SqlDbType.Date).Value = T.dFechaTest;
                    com.Parameters.Add("@iEstadoTest", SqlDbType.Int).Value = T.iEstadoTest;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = T.iUsuarioCrea;

                    return com.ExecuteNonQuery();

                }
            }
        }
        public int UpdateTEST(TEST_EL T)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdateTEST", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdTest", SqlDbType.Int).Value = T.iIdTest;
                    com.Parameters.Add("@iIdGestorCapacitacion", SqlDbType.Int).Value = T.iIdGestorCapacitacion;
                    com.Parameters.Add("@vDescricionTest", SqlDbType.VarChar).Value = T.vDescricionTest;
                    com.Parameters.Add("@dFechaTest", SqlDbType.Date).Value = T.dFechaTest;
                    com.Parameters.Add("@iEstadoTest", SqlDbType.Int).Value = T.iEstadoTest;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = T.iUsuarioMod;

                    return com.ExecuteNonQuery();

                }
            }
        }
    }
}