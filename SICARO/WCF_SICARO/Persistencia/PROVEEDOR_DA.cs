using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class PROVEEDOR_DA
    {

        private static PROVEEDOR_DA accion;
        private PROVEEDOR_DA() { }
        public static PROVEEDOR_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new PROVEEDOR_DA();
                }
                return accion;
            }
        }

        public List<PROVEEDOR_EL> GetAllPROVEEDOR(PROVEEDOR_EL P)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_PROVEEDOR", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdProveedor", SqlDbType.Int).Value = P.iIdProveedor;
                    com.Parameters.Add("@iIdMateriaPrima", SqlDbType.Int).Value = P.iUbigeo;

                    List<PROVEEDOR_EL> list = new List<PROVEEDOR_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            PROVEEDOR_EL obj = new PROVEEDOR_EL();

                            if (dataReader["iIdProveedor"] != DBNull.Value) { obj.iIdProveedor = (int)dataReader["iIdProveedor"]; }
                            if (dataReader["vNombreProveedor"] != DBNull.Value) { obj.vNombreProveedor = (string)dataReader["vNombreProveedor"]; }
                            if (dataReader["vRUC"] != DBNull.Value) { obj.vRUC = (string)dataReader["vRUC"]; }
                            if (dataReader["vTelefono"] != DBNull.Value) { obj.vTelefono = (string)dataReader["vTelefono"]; }
                            if (dataReader["vNroLicenciaMunicipal"] != DBNull.Value) { obj.vNroLicenciaMunicipal = (string)dataReader["vNroLicenciaMunicipal"]; }
                            if (dataReader["vNroInspeccionSanitaria"] != DBNull.Value) { obj.vNroInspeccionSanitaria = (string)dataReader["vNroInspeccionSanitaria"]; }
                            if (dataReader["iEstadoEmpresa"] != DBNull.Value) { obj.iEstadoEmpresa = (int)dataReader["iEstadoEmpresa"]; }
                            if (dataReader["iTipoEmpresa"] != DBNull.Value) { obj.iTipoEmpresa = (int)dataReader["iTipoEmpresa"]; }
                            if (dataReader["iUbigeo"] != DBNull.Value) { obj.iUbigeo = (int)dataReader["iUbigeo"]; }
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

    }
}