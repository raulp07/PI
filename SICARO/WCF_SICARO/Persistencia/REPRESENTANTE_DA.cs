using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class REPRESENTANTE_DA
    {
        private static REPRESENTANTE_DA accion;
        private REPRESENTANTE_DA() { }
        public static REPRESENTANTE_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new REPRESENTANTE_DA();
                }
                return accion;
            }
        }

        public List<REPRESENTANTE_EL> GetAllREPRESENTANTE(REPRESENTANTE_EL R)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_REPRESENTANTE", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdRepresentante", SqlDbType.Int).Value = R.iIdRepresentante;

                    List<REPRESENTANTE_EL> list = new List<REPRESENTANTE_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            REPRESENTANTE_EL obj = new REPRESENTANTE_EL();

                            if (dataReader["iIdRepresentante"] != DBNull.Value) { obj.iIdRepresentante = (int)dataReader["iIdRepresentante"]; }
                            if (dataReader["iIdProveedor"] != DBNull.Value) { obj.iIdProveedor = (int)dataReader["iIdProveedor"]; }
                            if (dataReader["vNombreRepresentante"] != DBNull.Value) { obj.vNombreRepresentante = (string)dataReader["vNombreRepresentante"]; }
                            if (dataReader["vApellidoPaternoRepresentante"] != DBNull.Value) { obj.vApellidoPaternoRepresentante = (string)dataReader["vApellidoPaternoRepresentante"]; }
                            if (dataReader["vApellidoMaternoRepresentante"] != DBNull.Value) { obj.vApellidoMaternoRepresentante = (string)dataReader["vApellidoMaternoRepresentante"]; }
                            if (dataReader["cDNI"] != DBNull.Value) { obj.cDNI = (string)dataReader["cDNI"]; }
                            if (dataReader["vCelular"] != DBNull.Value) { obj.vCelular = (string)dataReader["vCelular"]; }
                            if (dataReader["iTipoRepresentante"] != DBNull.Value) { obj.iTipoRepresentante = (int)dataReader["iTipoRepresentante"]; }
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

        public int InsertREPRESENTANTE(REPRESENTANTE_EL R)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertREPRESENTANTE", con))
                {

                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdProveedor", SqlDbType.Int).Value = R.iIdProveedor;
                    com.Parameters.Add("@vNombreRepresentante", SqlDbType.VarChar).Value = R.vNombreRepresentante;
                    com.Parameters.Add("@vApellidoPaternoRepresentante", SqlDbType.VarChar).Value = R.vApellidoPaternoRepresentante;
                    com.Parameters.Add("@vApellidoMaternoRepresentante", SqlDbType.VarChar).Value = R.vApellidoMaternoRepresentante;
                    com.Parameters.Add("@cDNI", SqlDbType.VarChar).Value = R.cDNI;
                    com.Parameters.Add("@vCelular", SqlDbType.VarChar).Value = R.vCelular;
                    com.Parameters.Add("@iTipoRepresentante", SqlDbType.Int).Value = R.iTipoRepresentante;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = R.iUsuarioCrea;

                    return com.ExecuteNonQuery();
                }
            }
        }

        public int UpdateREPRESENTANTE(REPRESENTANTE_EL R)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdateREPRESENTANTE", con))
                {

                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdRepresentante", SqlDbType.Int).Value = R.iIdRepresentante;
                    com.Parameters.Add("@iIdProveedor", SqlDbType.Int).Value = R.iIdProveedor;
                    com.Parameters.Add("@vNombreRepresentante", SqlDbType.VarChar).Value = R.vNombreRepresentante;
                    com.Parameters.Add("@vApellidoPaternoRepresentante", SqlDbType.VarChar).Value = R.vApellidoPaternoRepresentante;
                    com.Parameters.Add("@vApellidoMaternoRepresentante", SqlDbType.VarChar).Value = R.vApellidoMaternoRepresentante;
                    com.Parameters.Add("@cDNI", SqlDbType.VarChar).Value = R.cDNI;
                    com.Parameters.Add("@vCelular", SqlDbType.VarChar).Value = R.vCelular;
                    com.Parameters.Add("@iTipoRepresentante", SqlDbType.Int).Value = R.iTipoRepresentante;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = R.iUsuarioMod;

                    return com.ExecuteNonQuery();
                }
            }
        }
    }
}