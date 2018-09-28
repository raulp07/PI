using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class CONTROLPRODUCCION_DA
    {

        private static CONTROLPRODUCCION_DA accion;
        private CONTROLPRODUCCION_DA() { }
        public static CONTROLPRODUCCION_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new CONTROLPRODUCCION_DA();
                }
                return accion;
            }
        }

        public List<CONTROLPRODUCCION_EL> GetCONTROLPRODUCCIONAll(CONTROLPRODUCCION_EL CP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGetCONTROLPRODUCCIONAll", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@idControlProduccion", SqlDbType.Int).Value = CP.idControlProduccion;

                    List<CONTROLPRODUCCION_EL> list = new List<CONTROLPRODUCCION_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            CONTROLPRODUCCION_EL obj = new CONTROLPRODUCCION_EL();

                            if (dataReader["idControlProduccion"] != DBNull.Value) { obj.idControlProduccion = (int)dataReader["idControlProduccion"]; }
                            if (dataReader["idProducto"] != DBNull.Value) { obj.idProducto = (int)dataReader["idProducto"]; }
                            if (dataReader["tipoPronostico"] != DBNull.Value) { obj.tipoPronostico = (string)dataReader["tipoPronostico"]; }
                            if (dataReader["fechaProduccion"] != DBNull.Value) { obj.fechaProduccion = (DateTime)dataReader["fechaProduccion"]; }
                            if (dataReader["cantidadProducida"] != DBNull.Value) { obj.cantidadProducida = (int)dataReader["cantidadProducida"]; }
                            if (dataReader["idActividadControlProduccion"] != DBNull.Value) { obj.idActividadControlProduccion = (int)dataReader["idActividadControlProduccion"]; }
                            if (dataReader["indicador"] != DBNull.Value) { obj.indicador = (string)dataReader["indicador"]; }

                            list.Add(obj);

                        }

                    }

                    return list;
                }
            }
        }

        public int InsertCONTROLPRODUCCION(CONTROLPRODUCCION_EL CP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertCONTROLPRODUCCION", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    
                    com.Parameters.Add("@idProducto", SqlDbType.Int).Value = CP.idProducto;
                    com.Parameters.Add("@tipoPronostico", SqlDbType.VarChar).Value = CP.tipoPronostico;
                    com.Parameters.Add("@cantidadProducida", SqlDbType.Int).Value = CP.cantidadProducida;
                    com.Parameters.Add("@idActividadControlProduccion", SqlDbType.Int).Value = CP.idActividadControlProduccion;
                    com.Parameters.Add("@indicador", SqlDbType.VarChar).Value = CP.indicador;

                    return com.ExecuteNonQuery();
                }
            }

        }
        public int UpdateCONTROLPRODUCCION(CONTROLPRODUCCION_EL CP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdateCONTROLPRODUCCION", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@idControlProduccion", SqlDbType.Int).Value = CP.idControlProduccion;
                    com.Parameters.Add("@idProducto", SqlDbType.Int).Value = CP.idProducto;
                    com.Parameters.Add("@tipoPronostico", SqlDbType.VarChar).Value = CP.tipoPronostico;
                    com.Parameters.Add("@fechaProduccion", SqlDbType.DateTime).Value = CP.fechaProduccion;
                    com.Parameters.Add("@cantidadProducida", SqlDbType.Int).Value = CP.cantidadProducida;
                    com.Parameters.Add("@idActividadControlProduccion", SqlDbType.Int).Value = CP.idActividadControlProduccion;
                    com.Parameters.Add("@indicador", SqlDbType.VarChar).Value = CP.indicador;

                    return com.ExecuteNonQuery();
                }
            }

        }
    }
}