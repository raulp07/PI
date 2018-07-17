using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class GESTION_CAPACITACION_DA
    {
        private static GESTION_CAPACITACION_DA accion;
        private GESTION_CAPACITACION_DA() { }
        public static GESTION_CAPACITACION_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new GESTION_CAPACITACION_DA();
                }
                return accion;
            }
        }

        public List<GESTION_CAPACITACION_EL> GetAllGESTION_CAPACITACION(GESTION_CAPACITACION_EL GC)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_GESTION_CAPACITACION", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdGestionCapacitacion", SqlDbType.Int).Value = GC.iIdGestionCapacitacion;


                    List<GESTION_CAPACITACION_EL> list = new List<GESTION_CAPACITACION_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            GESTION_CAPACITACION_EL obj = new GESTION_CAPACITACION_EL();

                            if (dataReader["iIdGestionCapacitacion"] != DBNull.Value) { obj.iIdGestionCapacitacion = (int)dataReader["iIdGestionCapacitacion"]; }
                            if (dataReader["iIdCapacitacion"] != DBNull.Value) { obj.iIdCapacitacion = (int)dataReader["iIdCapacitacion"]; }
                            if (dataReader["iIdRepresentante"] != DBNull.Value) { obj.iIdRepresentante = (int)dataReader["iIdRepresentante"]; }
                            if (dataReader["dFechaRealizacionCapacitacion"] != DBNull.Value) { obj.dFechaRealizacionCapacitacion = (DateTime)dataReader["dFechaRealizacionCapacitacion"]; }
                            if (dataReader["tHoraInicio"] != DBNull.Value) { obj.tHoraInicio = (DateTime)dataReader["tHoraInicio"]; }
                            if (dataReader["tHoraFin"] != DBNull.Value) { obj.tHoraFin = (DateTime)dataReader["tHoraFin"]; }
                            if (dataReader["iTiempoTest"] != DBNull.Value) { obj.iTiempoTest = (int)dataReader["iTiempoTest"]; }
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

        public int InsertGESTION_CAPACITACION(GESTION_CAPACITACION_EL GC)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertGESTION_CAPACITACION", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdCapacitacion", SqlDbType.Int).Value = GC.iIdCapacitacion;
                    com.Parameters.Add("@iIdRepresentante", SqlDbType.Int).Value = GC.iIdRepresentante;
                    com.Parameters.Add("@dFechaRealizacionCapacitacion", SqlDbType.Date).Value = GC.dFechaRealizacionCapacitacion;
                    com.Parameters.Add("@tHoraInicio", SqlDbType.Time).Value = "05:30";//GC.tHoraInicio.ToSho;
                    com.Parameters.Add("@tHoraFin", SqlDbType.Time).Value = "05:30"; //GC.tHoraFin.ToShortTimeString();
                    com.Parameters.Add("@iTiempoTest", SqlDbType.Int).Value = GC.iTiempoTest;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = GC.iUsuarioCrea;

                    return com.ExecuteNonQuery();
                }
            }
        }

        public int UpdateGESTION_CAPACITACION(GESTION_CAPACITACION_EL GC)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdateGESTION_CAPACITACION", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdGestionCapacitacion", SqlDbType.Int).Value = GC.iIdGestionCapacitacion;
                    com.Parameters.Add("@iIdCapacitacion", SqlDbType.Int).Value = GC.iIdCapacitacion;
                    com.Parameters.Add("@iIdRepresentante", SqlDbType.Int).Value = GC.iIdRepresentante;
                    com.Parameters.Add("@dFechaRealizacionCapacitacion", SqlDbType.Date).Value = GC.dFechaRealizacionCapacitacion;
                    com.Parameters.Add("@tHoraInicio", SqlDbType.Time).Value = GC.tHoraInicio.ToShortTimeString();
                    com.Parameters.Add("@tHoraFin", SqlDbType.Time).Value = GC.tHoraFin.ToShortTimeString();
                    com.Parameters.Add("@iTiempoTest", SqlDbType.Int).Value = GC.iTiempoTest;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = GC.iUsuarioCrea;

                    return com.ExecuteNonQuery();
                }
            }
        }

    }
}