using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class PERSONAL_DA
    {
        private static PERSONAL_DA accion;
        private PERSONAL_DA() { }
        public static PERSONAL_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new PERSONAL_DA();
                }
                return accion;
            }
        }

        public List<PERSONAL_EL> GetAllPERSONAL(PERSONAL_EL P)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_PERSONAL", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdPersonal", SqlDbType.Int).Value = P.iIdPersonal;
                    List<PERSONAL_EL> list = new List<PERSONAL_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            PERSONAL_EL obj = new PERSONAL_EL();

                            if (dataReader["iIdPersonal"] != DBNull.Value) { obj.iIdPersonal = (int)dataReader["iIdPersonal"]; }
                            if (dataReader["vCodPersonal"] != DBNull.Value) { obj.vCodPersonal = (string)dataReader["vCodPersonal"]; }
                            if (dataReader["vNombrePersonal"] != DBNull.Value) { obj.vNombrePersonal = (string)dataReader["vNombrePersonal"]; }
                            if (dataReader["vApellidoPaternoPersonal"] != DBNull.Value) { obj.vApellidoPaternoPersonal = (string)dataReader["vApellidoPaternoPersonal"]; }
                            if (dataReader["vApellidoMaternoPersonal"] != DBNull.Value) { obj.vApellidoMaternoPersonal = (string)dataReader["vApellidoMaternoPersonal"]; }
                            if (dataReader["cDNI"] != DBNull.Value) { obj.cDNI = (string)dataReader["cDNI"]; }
                            if (dataReader["dFechaNacimiento"] != DBNull.Value) { obj.dFechaNacimiento = (DateTime)dataReader["dFechaNacimiento"]; }
                            if (dataReader["vDomicilio"] != DBNull.Value) { obj.vDomicilio = (string)dataReader["vDomicilio"]; }
                            if (dataReader["iIdArea"] != DBNull.Value) { obj.iIdArea = (int)dataReader["iIdArea"]; }
                            if (dataReader["iUbigeo"] != DBNull.Value) { obj.iUbigeo = (int)dataReader["iUbigeo"]; }
                            if (dataReader["iTipoPersonal"] != DBNull.Value) { obj.iTipoPersonal = (int)dataReader["iTipoPersonal"]; }
                            if (dataReader["iEstadoPersonal"] != DBNull.Value) { obj.iEstadoPersonal = (int)dataReader["iEstadoPersonal"]; }
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
        public int InsertPERSONAL(PERSONAL_EL P)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertPERSONAL", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@vCodPersonal", SqlDbType.VarChar).Value = P.vCodPersonal;
                    com.Parameters.Add("@vNombrePersonal", SqlDbType.VarChar).Value = P.vNombrePersonal;
                    com.Parameters.Add("@vApellidoPaternoPersonal", SqlDbType.VarChar).Value = P.vApellidoPaternoPersonal;
                    com.Parameters.Add("@vApellidoMaternoPersonal", SqlDbType.VarChar).Value = P.vApellidoMaternoPersonal;
                    com.Parameters.Add("@cDNI", SqlDbType.VarChar).Value = P.cDNI;
                    com.Parameters.Add("@dFechaNacimiento", SqlDbType.Date).Value = P.dFechaNacimiento;
                    com.Parameters.Add("@vDomicilio", SqlDbType.VarChar).Value = P.vDomicilio;
                    com.Parameters.Add("@iIdArea", SqlDbType.Int).Value = P.iIdArea;
                    com.Parameters.Add("@iUbigeo", SqlDbType.Int).Value = P.iUbigeo;
                    com.Parameters.Add("@iTipoPersonal", SqlDbType.Int).Value = P.iTipoPersonal;
                    com.Parameters.Add("@iEstadoPersonal", SqlDbType.Int).Value = P.iEstadoPersonal;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = P.iUsuarioCrea;

                    return com.ExecuteNonQuery();
                }
            }       
        }
        public int UpdatePERSONAL(PERSONAL_EL P)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdatePERSONAL", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdPersonal", SqlDbType.Int).Value = P.iIdPersonal;
                    com.Parameters.Add("@vCodPersonal", SqlDbType.VarChar).Value = P.vCodPersonal;
                    com.Parameters.Add("@vNombrePersonal", SqlDbType.VarChar).Value = P.vNombrePersonal;
                    com.Parameters.Add("@vApellidoPaternoPersonal", SqlDbType.VarChar).Value = P.vApellidoPaternoPersonal;
                    com.Parameters.Add("@vApellidoMaternoPersonal", SqlDbType.VarChar).Value = P.vApellidoMaternoPersonal;
                    com.Parameters.Add("@cDNI", SqlDbType.VarChar).Value = P.cDNI;
                    com.Parameters.Add("@dFechaNacimiento", SqlDbType.Date).Value = P.dFechaNacimiento;
                    com.Parameters.Add("@vDomicilio", SqlDbType.VarChar).Value = P.vDomicilio;
                    com.Parameters.Add("@iIdArea", SqlDbType.Int).Value = P.iIdArea;
                    com.Parameters.Add("@iUbigeo", SqlDbType.Int).Value = P.iUbigeo;
                    com.Parameters.Add("@iTipoPersonal", SqlDbType.Int).Value = P.iTipoPersonal;
                    com.Parameters.Add("@iEstadoPersonal", SqlDbType.Int).Value = P.iEstadoPersonal;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = P.iUsuarioMod;

                    return com.ExecuteNonQuery();
                }
            }
        }

    }
}