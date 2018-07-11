using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class EVALUACIONPROVEEDORPREGUNTA_DA
    {
        private static EVALUACIONPROVEEDORPREGUNTA_DA accion;
        private EVALUACIONPROVEEDORPREGUNTA_DA() { }
        public static EVALUACIONPROVEEDORPREGUNTA_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new EVALUACIONPROVEEDORPREGUNTA_DA();
                }
                return accion;
            }
        }

        public List<EVALUACIONPROVEEDORPREGUNTA_EL> GetAllEVALUACIONPROVEEDORPREGUNTA(EVALUACIONPROVEEDORPREGUNTA_EL EPP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_EVALUACIONPROVEEDORPREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdEvaluacionProveedorPregunta", SqlDbType.Int).Value = EPP.iIdEvaluacionProveedorPregunta;

                    List<EVALUACIONPROVEEDORPREGUNTA_EL> list = new List<EVALUACIONPROVEEDORPREGUNTA_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            EVALUACIONPROVEEDORPREGUNTA_EL obj = new EVALUACIONPROVEEDORPREGUNTA_EL();

                            if (dataReader["iIdEvaluacionProveedorPregunta"] != DBNull.Value) { obj.iIdEvaluacionProveedorPregunta = (int)dataReader["iIdEvaluacionProveedorPregunta"]; }
                            if (dataReader["iIdEvaluacionProveedor"] != DBNull.Value) { obj.iIdEvaluacionProveedor = (int)dataReader["iIdEvaluacionProveedor"]; }
                            if (dataReader["iIdMateriaPrima"] != DBNull.Value) { obj.iIdMateriaPrima = (int)dataReader["iIdMateriaPrima"]; }
                            if (dataReader["vObservacion"] != DBNull.Value) { obj.vObservacion = (string)dataReader["vObservacion"]; }
                            if (dataReader["dFecha"] != DBNull.Value) { obj.dFecha = (DateTime)dataReader["dFecha"]; }
                            if (dataReader["iPuntajeTotal"] != DBNull.Value) { obj.iPuntajeTotal = (int)dataReader["iPuntajeTotal"]; }
                            if (dataReader["iPorcentajeCumplimiento"] != DBNull.Value) { obj.iPorcentajeCumplimiento = (int)dataReader["iPorcentajeCumplimiento"]; }
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
        public int InsertEVALUACIONPROVEEDORPREGUNTA(EVALUACIONPROVEEDORPREGUNTA_EL EPP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertEVALUACIONPROVEEDORPREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdEvaluacionProveedor", SqlDbType.Int).Value = EPP.iIdEvaluacionProveedor;
                    com.Parameters.Add("@iIdMateriaPrima", SqlDbType.Int).Value = EPP.iIdMateriaPrima;
                    com.Parameters.Add("@vObservacion", SqlDbType.VarChar).Value = EPP.vObservacion;
                    com.Parameters.Add("@dFecha", SqlDbType.Date).Value = EPP.dFecha;
                    com.Parameters.Add("@iPuntajeTotal", SqlDbType.Int).Value = EPP.iPuntajeTotal;
                    com.Parameters.Add("@iPorcentajeCumplimiento", SqlDbType.Int).Value = EPP.iPorcentajeCumplimiento;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = EPP.iUsuarioCrea;

                    return com.ExecuteNonQuery();
                }
            }
        }

        public int UpdateEVALUACIONPROVEEDORPREGUNTA(EVALUACIONPROVEEDORPREGUNTA_EL EPP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdateEVALUACIONPROVEEDORPREGUNTA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdEvaluacionProveedorPregunta", SqlDbType.Int).Value = EPP.iIdEvaluacionProveedorPregunta;
                    com.Parameters.Add("@iIdEvaluacionProveedor", SqlDbType.Int).Value = EPP.iIdEvaluacionProveedor;
                    com.Parameters.Add("@iIdMateriaPrima", SqlDbType.Int).Value = EPP.iIdMateriaPrima;
                    com.Parameters.Add("@vObservacion", SqlDbType.VarChar).Value = EPP.vObservacion;
                    com.Parameters.Add("@dFecha", SqlDbType.Date).Value = EPP.dFecha;
                    com.Parameters.Add("@iPuntajeTotal", SqlDbType.Int).Value = EPP.iPuntajeTotal;
                    com.Parameters.Add("@iPorcentajeCumplimiento", SqlDbType.Int).Value = EPP.iPorcentajeCumplimiento;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = EPP.iUsuarioMod;

                    return com.ExecuteNonQuery();
                }
            }
        }
    }
}