using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class PRONOSTICO_DA
    {

        private static PRONOSTICO_DA accion;
        private PRONOSTICO_DA() { }
        public static PRONOSTICO_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new PRONOSTICO_DA();
                }
                return accion;
            }
        }

        public List<PRONOSTICO_EL> GetPRONOSTICOAll(PRONOSTICO_EL CP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGetPRONOSTICOAll", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@idPronostico", SqlDbType.Int).Value = CP.idPronostico;

                    List<PRONOSTICO_EL> list = new List<PRONOSTICO_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            PRONOSTICO_EL obj = new PRONOSTICO_EL();

                            if (dataReader["idPronostico"] != DBNull.Value) { obj.idPronostico = (int)dataReader["idPronostico"]; }
                            if (dataReader["tipoPronostico"] != DBNull.Value) { obj.tipoPronostico = (string)dataReader["tipoPronostico"]; }
                            if (dataReader["idProveedor"] != DBNull.Value) { obj.idProveedor = (int)dataReader["idProveedor"]; }
                            if (dataReader["idProducto"] != DBNull.Value) { obj.idProducto = (int)dataReader["idProducto"]; }
                            if (dataReader["idInsumo"] != DBNull.Value) { obj.idInsumo = (int)dataReader["idInsumo"]; }
                            if (dataReader["idActividadProduccion"] != DBNull.Value) { obj.idActividadProduccion = (int)dataReader["idActividadProduccion"]; }
                            if (dataReader["cantidad"] != DBNull.Value) { obj.cantidad = (int)dataReader["cantidad"]; }
                            if (dataReader["unidadDeMedida"] != DBNull.Value) { obj.unidadDeMedida = (string)dataReader["unidadDeMedida"]; }

                            list.Add(obj);

                        }

                    }

                    return list;
                }
            }
        }

        public int InsertPRONOSTICO(PRONOSTICO_EL CP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertPRONOSTICO", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@tipoPronostico", SqlDbType.VarChar).Value = CP.tipoPronostico;
                    com.Parameters.Add("@idProveedor", SqlDbType.Int).Value = CP.idProveedor;
                    com.Parameters.Add("@idProducto", SqlDbType.Int).Value = CP.idProducto;
                    com.Parameters.Add("@idInsumo", SqlDbType.Int).Value = CP.idInsumo;
                    com.Parameters.Add("@idActividadProduccion", SqlDbType.Int).Value = CP.idActividadProduccion;
                    com.Parameters.Add("@cantidad", SqlDbType.Int).Value = CP.cantidad;
                    com.Parameters.Add("@unidadDeMedida", SqlDbType.VarChar).Value = CP.unidadDeMedida;


                    return com.ExecuteNonQuery();
                }
            }

        }
        public int UpdatePRONOSTICO(PRONOSTICO_EL CP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdatePRONOSTICO", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@idPronostico", SqlDbType.Int).Value = CP.idPronostico;
                    com.Parameters.Add("@tipoPronostico", SqlDbType.VarChar).Value = CP.tipoPronostico;
                    com.Parameters.Add("@idProveedor", SqlDbType.Int).Value = CP.idProveedor;
                    com.Parameters.Add("@idProducto", SqlDbType.Int).Value = CP.idProducto;
                    com.Parameters.Add("@idInsumo", SqlDbType.Int).Value = CP.idInsumo;
                    com.Parameters.Add("@idActividadProduccion", SqlDbType.Int).Value = CP.idActividadProduccion;
                    com.Parameters.Add("@cantidad", SqlDbType.Int).Value = CP.cantidad;
                    com.Parameters.Add("@unidadDeMedida", SqlDbType.VarChar).Value = CP.unidadDeMedida;

                    return com.ExecuteNonQuery();
                }
            }

        }

    }
}