using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class PREGUNTA_DA
    {

        private static PREGUNTA_DA accion;
        private PREGUNTA_DA() { }
        public static PREGUNTA_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new PREGUNTA_DA();
                }
                return accion;
            }
        }

        public List<PREGUNTA_EL> GetAllPREGUNTA(PREGUNTA_EL P)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_PREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdPregunta", SqlDbType.Int).Value = P.iIdPregunta;

                    List<PREGUNTA_EL> list = new List<PREGUNTA_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            PREGUNTA_EL obj = new PREGUNTA_EL();

                            if (dataReader["iIdPregunta"] != DBNull.Value) { obj.iIdPregunta = (int)dataReader["iIdPregunta"]; }
                            if (dataReader["iIdTest"] != DBNull.Value) { obj.iIdTest = (int)dataReader["iIdTest"]; }
                            if (dataReader["vEnunciadoPregunta"] != DBNull.Value) { obj.vEnunciadoPregunta = (string)dataReader["vEnunciadoPregunta"]; }
                            if (dataReader["iPuntajePregunta"] != DBNull.Value) { obj.iPuntajePregunta = (int)dataReader["iPuntajePregunta"]; }
                            if (dataReader["iTipoRespuestaPregunta"] != DBNull.Value) { obj.iTipoRespuestaPregunta = (int)dataReader["iTipoRespuestaPregunta"]; }
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
        public int InsertPREGUNTA(PREGUNTA_EL P)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertPREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdTest", SqlDbType.Int).Value = P.iIdTest;
                    com.Parameters.Add("@vEnunciadoPregunta", SqlDbType.VarChar).Value = P.vEnunciadoPregunta;
                    com.Parameters.Add("@iPuntajePregunta", SqlDbType.Int).Value = P.iPuntajePregunta;
                    com.Parameters.Add("@iTipoRespuestaPregunta", SqlDbType.Int).Value = P.iTipoRespuestaPregunta;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = P.iUsuarioCrea;

                    return com.ExecuteNonQuery() ;

                }
            }
        }
        public int UpdatePREGUNTA(PREGUNTA_EL P)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdatePREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdPregunta", SqlDbType.Int).Value = P.iIdPregunta;
                    com.Parameters.Add("@iIdTest", SqlDbType.Int).Value = P.iIdTest;
                    com.Parameters.Add("@vEnunciadoPregunta", SqlDbType.VarChar).Value = P.vEnunciadoPregunta;
                    com.Parameters.Add("@iPuntajePregunta", SqlDbType.Int).Value = P.iPuntajePregunta;
                    com.Parameters.Add("@iTipoRespuestaPregunta", SqlDbType.Int).Value = P.iTipoRespuestaPregunta;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = P.iUsuarioMod;

                    return com.ExecuteNonQuery();

                }
            }
        }

    }
}