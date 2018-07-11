using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class UBIGEO_DA
    {
        private static UBIGEO_DA accion;
        private UBIGEO_DA() { }
        public static UBIGEO_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new UBIGEO_DA();
                }
                return accion;
            }
        }
        public List<UBIGEO_EL> GetAllUBIGEO(UBIGEO_EL U)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_UBIGEO", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@vCodDpto", SqlDbType.Int).Value = U.vCodDpto;
                    com.Parameters.Add("@vCodProv", SqlDbType.Int).Value = U.vCodProv;
                    com.Parameters.Add("@vCodDist", SqlDbType.Int).Value = U.vCodDist;

                    List<UBIGEO_EL> list = new List<UBIGEO_EL>();
                    using (IDataReader dataReader = com.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            UBIGEO_EL obj = new UBIGEO_EL();
                            if (dataReader["vCodDpto"] != DBNull.Value) { obj.vCodDpto = (string)dataReader["vCodDpto"]; }
                            if (dataReader["vCodProv"] != DBNull.Value) { obj.vCodProv = (string)dataReader["vCodProv"]; }
                            if (dataReader["vCodDist"] != DBNull.Value) { obj.vCodDist = (string)dataReader["vCodDist"]; }
                            if (dataReader["vNombre"] != DBNull.Value) { obj.vNombre = (string)dataReader["vNombre"]; }
                            list.Add(obj);
                        }
                    }
                    return list;
                }
            }
        }
    }
}