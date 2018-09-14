using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class CAPACITACION_DA
    {
        private static CAPACITACION_DA accion;
        private CAPACITACION_DA() { }
        public static CAPACITACION_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new CAPACITACION_DA();
                }
                return accion;
            }
        }

        public List<CAPACITACION_EL> GetAllCAPACITACION1()
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_CAPACITACION", con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    List<CAPACITACION_EL> list = new List<CAPACITACION_EL>();
                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            CAPACITACION_EL obj = new CAPACITACION_EL();

                            if (dataReader["iIdCapacitacion"] != DBNull.Value) { obj.iIdCapacitacion = (int)dataReader["iIdCapacitacion"]; }
                            if (dataReader["vCodCapacitacion"] != DBNull.Value) { obj.vCodCapacitacion = (string)dataReader["vCodCapacitacion"]; }
                            if (dataReader["vTemaCapacitacion"] != DBNull.Value) { obj.vTemaCapacitacion = (string)dataReader["vTemaCapacitacion"]; }
                            if (dataReader["dFechaPropuestaCapacitacion"] != DBNull.Value) { obj.dFechaPropuestaCapacitacion = (DateTime)dataReader["dFechaPropuestaCapacitacion"]; }
                            if (dataReader["iEstadoCapactiacion"] != DBNull.Value) { obj.iEstadoCapactiacion = (int)dataReader["iEstadoCapactiacion"]; }
                            if (dataReader["iEstadoComunicacionCapacitacion"] != DBNull.Value) { obj.iEstadoComunicacionCapacitacion = (int)dataReader["iEstadoComunicacionCapacitacion"]; }
                            if (dataReader["iUsuarioCrea"] != DBNull.Value) { obj.iUsuarioCrea = (int)dataReader["iUsuarioCrea"]; }
                            if (dataReader["dFechaCrea"] != DBNull.Value) { obj.dFechaCrea = (DateTime)dataReader["dFechaCrea"]; }
                            if (dataReader["iUsuarioMod"] != DBNull.Value) { obj.iUsuarioMod = (int)dataReader["iUsuarioMod"]; }
                            if (dataReader["dFechaMod"] != DBNull.Value) { obj.dFechaMod = (DateTime)dataReader["dFechaMod"]; }
                            if (dataReader["Latitud"] != DBNull.Value) { obj.dLatitud = (decimal)dataReader["Latitud"]; }
                            if (dataReader["Longitud"] != DBNull.Value) { obj.dLongitud = (decimal)dataReader["Longitud"]; }
                            list.Add(obj);

                        }

                    }
                    return list;
                }

            }
        }

        public List<CAPACITACION_EL> GetAllCAPACITACION(CAPACITACION_EL C)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_CAPACITACION", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdCapacitacion", SqlDbType.Int).Value = C.iIdCapacitacion;

                    List<CAPACITACION_EL> list = new List<CAPACITACION_EL>();
                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            CAPACITACION_EL obj = new CAPACITACION_EL();

                            if (dataReader["iIdCapacitacion"] != DBNull.Value) { obj.iIdCapacitacion = (int)dataReader["iIdCapacitacion"]; }
                            if (dataReader["vCodCapacitacion"] != DBNull.Value) { obj.vCodCapacitacion = (string)dataReader["vCodCapacitacion"]; }
                            if (dataReader["vTemaCapacitacion"] != DBNull.Value) { obj.vTemaCapacitacion = (string)dataReader["vTemaCapacitacion"]; }
                            if (dataReader["dFechaPropuestaCapacitacion"] != DBNull.Value) { obj.dFechaPropuestaCapacitacion = (DateTime)dataReader["dFechaPropuestaCapacitacion"]; }
                            if (dataReader["iEstadoCapactiacion"] != DBNull.Value) { obj.iEstadoCapactiacion = (int)dataReader["iEstadoCapactiacion"]; }
                            if (dataReader["iEstadoComunicacionCapacitacion"] != DBNull.Value) { obj.iEstadoComunicacionCapacitacion = (int)dataReader["iEstadoComunicacionCapacitacion"]; }
                            if (dataReader["iUsuarioCrea"] != DBNull.Value) { obj.iUsuarioCrea = (int)dataReader["iUsuarioCrea"]; }
                            if (dataReader["dFechaCrea"] != DBNull.Value) { obj.dFechaCrea = (DateTime)dataReader["dFechaCrea"]; }
                            if (dataReader["iUsuarioMod"] != DBNull.Value) { obj.iUsuarioMod = (int)dataReader["iUsuarioMod"]; }
                            if (dataReader["dFechaMod"] != DBNull.Value) { obj.dFechaMod = (DateTime)dataReader["dFechaMod"]; }
                            if (dataReader["Latitud"] != DBNull.Value) { obj.dLatitud = (decimal)dataReader["Latitud"]; }
                            if (dataReader["Longitud"] != DBNull.Value) { obj.dLongitud = (decimal)dataReader["Longitud"]; }
                            list.Add(obj);

                        }

                    }
                    return list;
                }
                    
            }
        }
    }
}