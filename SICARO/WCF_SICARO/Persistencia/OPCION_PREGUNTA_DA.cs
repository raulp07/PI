using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class OPCION_PREGUNTA_DA
    {
        private static OPCION_PREGUNTA_DA accion;
        private OPCION_PREGUNTA_DA() { }
        public static OPCION_PREGUNTA_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new OPCION_PREGUNTA_DA();
                }
                return accion;
            }
        }

        public List<OPCION_PREGUNTA_EL> GetAllOPCION_PREGUNTA(OPCION_PREGUNTA_EL OP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_OPCION_PREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdOpcion", SqlDbType.Int).Value = OP.iIdOpcion;
                    List<OPCION_PREGUNTA_EL> list = new List<OPCION_PREGUNTA_EL>();
                    using (IDataReader dataReader = com.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            OPCION_PREGUNTA_EL obj = new OPCION_PREGUNTA_EL();
                            if (dataReader["iIdOpcion"] != DBNull.Value) { obj.iIdOpcion = (int)dataReader["iIdOpcion"]; }
                            if (dataReader["iIdPregunta"] != DBNull.Value) { obj.iIdPregunta = (int)dataReader["iIdPregunta"]; }
                            if (dataReader["vEnunciadoOpcion"] != DBNull.Value) { obj.vEnunciadoOpcion = (string)dataReader["vEnunciadoOpcion"]; }
                            if (dataReader["iEstadoOpcion"] != DBNull.Value) { obj.iEstadoOpcion = (int)dataReader["iEstadoOpcion"]; }
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
        public int InsertOPCION_PREGUNTA(OPCION_PREGUNTA_EL OP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertOPCION_PREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdPregunta", SqlDbType.Int).Value = OP.iIdPregunta;
                    com.Parameters.Add("@vEnunciadoOpcion", SqlDbType.VarChar).Value = OP.vEnunciadoOpcion;
                    com.Parameters.Add("@iEstadoOpcion", SqlDbType.Int).Value = OP.iEstadoOpcion;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = OP.iUsuarioCrea;

                    return com.ExecuteNonQuery() ;
                }
            }    
        }
        public int UpdateOPCION_PREGUNTA(OPCION_PREGUNTA_EL OP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertPREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdOpcion", SqlDbType.Int).Value = OP.iIdOpcion;
                    com.Parameters.Add("@iIdPregunta", SqlDbType.Int).Value = OP.iIdPregunta;
                    com.Parameters.Add("@vEnunciadoOpcion", SqlDbType.VarChar).Value = OP.vEnunciadoOpcion;
                    com.Parameters.Add("@iEstadoOpcion", SqlDbType.Int).Value = OP.iEstadoOpcion;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = OP.iUsuarioMod;

                    return com.ExecuteNonQuery();
                }
            }
        }
    }
}