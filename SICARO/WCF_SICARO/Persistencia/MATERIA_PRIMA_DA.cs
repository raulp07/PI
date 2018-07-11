using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_SICARO.Dominio;

namespace WCF_SICARO.Persistencia
{
    public class MATERIA_PRIMA_DA
    {
        private static MATERIA_PRIMA_DA accion;
        private MATERIA_PRIMA_DA() { }
        public static MATERIA_PRIMA_DA Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new MATERIA_PRIMA_DA();
                }
                return accion;
            }
        }
        public List<MATERIA_PRIMA_EL> GetAllMATERIA_PRIMA(MATERIA_PRIMA_EL MP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spGet_MATERIA_PRIMA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.Add("@iIdMateriaPrima", SqlDbType.Int).Value = MP.iIdMateriaPrima;

                    List<MATERIA_PRIMA_EL> list = new List<MATERIA_PRIMA_EL>();

                    using (IDataReader dataReader = com.ExecuteReader())
                    {

                        while (dataReader.Read())
                        {

                            MATERIA_PRIMA_EL obj = new MATERIA_PRIMA_EL();

                            if (dataReader["iIdMateriaPrima"] != DBNull.Value) { obj.iIdMateriaPrima = (int)dataReader["iIdMateriaPrima"]; }
                            if (dataReader["vCodMateriaPrima"] != DBNull.Value) { obj.vCodMateriaPrima = (string)dataReader["vCodMateriaPrima"]; }
                            if (dataReader["vNombreMateriaPrima"] != DBNull.Value) { obj.vNombreMateriaPrima = (string)dataReader["vNombreMateriaPrima"]; }
                            if (dataReader["vDescripcionMateriaPrima"] != DBNull.Value) { obj.vDescripcionMateriaPrima = (string)dataReader["vDescripcionMateriaPrima"]; }
                            if (dataReader["iOlorCS"] != DBNull.Value) { obj.iOlorCS = (int)dataReader["iOlorCS"]; }
                            if (dataReader["iColorCS"] != DBNull.Value) { obj.iColorCS = (int)dataReader["iColorCS"]; }
                            if (dataReader["iSaborCS"] != DBNull.Value) { obj.iSaborCS = (int)dataReader["iSaborCS"]; }
                            if (dataReader["iTexturaCS"] != DBNull.Value) { obj.iTexturaCS = (int)dataReader["iTexturaCS"]; }
                            if (dataReader["iBrixRF"] != DBNull.Value) { obj.iBrixRF = (int)dataReader["iBrixRF"]; }
                            if (dataReader["iPHRF"] != DBNull.Value) { obj.iPHRF = (int)dataReader["iPHRF"]; }
                            if (dataReader["iAcidesRF"] != DBNull.Value) { obj.iAcidesRF = (int)dataReader["iAcidesRF"]; }
                            if (dataReader["vRequisitosMicrobiolicos"] != DBNull.Value) { obj.vRequisitosMicrobiolicos = (string)dataReader["vRequisitosMicrobiolicos"]; }
                            if (dataReader["vRequisitoRotulado"] != DBNull.Value) { obj.vRequisitoRotulado = (string)dataReader["vRequisitoRotulado"]; }
                            if (dataReader["vRequisitosEmpaquetado"] != DBNull.Value) { obj.vRequisitosEmpaquetado = (string)dataReader["vRequisitosEmpaquetado"]; }
                            if (dataReader["vRequisitosPresentacion"] != DBNull.Value) { obj.vRequisitosPresentacion = (string)dataReader["vRequisitosPresentacion"]; }
                            if (dataReader["vCondicionFisicaEntrega"] != DBNull.Value) { obj.vCondicionFisicaEntrega = (string)dataReader["vCondicionFisicaEntrega"]; }
                            if (dataReader["vCondicionFisicaAlmacenamiento"] != DBNull.Value) { obj.vCondicionFisicaAlmacenamiento = (string)dataReader["vCondicionFisicaAlmacenamiento"]; }
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
        public int InsertMATERIA_PRIMA(MATERIA_PRIMA_EL MP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spInsertMATERIA_PRIMA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    
                    com.Parameters.Add("@vCodMateriaPrima", SqlDbType.VarChar).Value = MP.vCodMateriaPrima;
                    com.Parameters.Add("@vNombreMateriaPrima", SqlDbType.VarChar).Value = MP.vNombreMateriaPrima;
                    com.Parameters.Add("@vDescripcionMateriaPrima", SqlDbType.VarChar).Value = MP.vDescripcionMateriaPrima;
                    com.Parameters.Add("@iOlorCS", SqlDbType.Int).Value = MP.iOlorCS;
                    com.Parameters.Add("@iColorCS", SqlDbType.Int).Value = MP.iColorCS;
                    com.Parameters.Add("@iSaborCS", SqlDbType.Int).Value = MP.iSaborCS;
                    com.Parameters.Add("@iTexturaCS", SqlDbType.Int).Value = MP.iTexturaCS;
                    com.Parameters.Add("@iBrixRF", SqlDbType.Int).Value = MP.iBrixRF;
                    com.Parameters.Add("@iPHRF", SqlDbType.Int).Value = MP.iPHRF;
                    com.Parameters.Add("@iAcidesRF", SqlDbType.Int).Value = MP.iAcidesRF;
                    com.Parameters.Add("@vRequisitosMicrobiolicos", SqlDbType.VarChar).Value = MP.vRequisitosMicrobiolicos;
                    com.Parameters.Add("@vRequisitoRotulado", SqlDbType.VarChar).Value = MP.vRequisitoRotulado;
                    com.Parameters.Add("@vRequisitosEmpaquetado", SqlDbType.VarChar).Value = MP.vRequisitosEmpaquetado;
                    com.Parameters.Add("@vRequisitosPresentacion", SqlDbType.VarChar).Value = MP.vRequisitosPresentacion;
                    com.Parameters.Add("@vCondicionFisicaEntrega", SqlDbType.VarChar).Value = MP.vCondicionFisicaEntrega;
                    com.Parameters.Add("@vCondicionFisicaAlmacenamiento", SqlDbType.VarChar).Value = MP.vCondicionFisicaAlmacenamiento;
                    com.Parameters.Add("@iUsuarioCrea", SqlDbType.Int).Value = MP.iUsuarioCrea;

                    return com.ExecuteNonQuery();
                }
            }
        }
        public int UpdateMATERIA_PRIMA(MATERIA_PRIMA_EL MP)
        {
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("spUpdateMATERIA_PRIMA", con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add("@iIdMateriaPrima", SqlDbType.Int).Value = MP.iIdMateriaPrima;
                    com.Parameters.Add("@vCodMateriaPrima", SqlDbType.VarChar).Value = MP.vCodMateriaPrima;
                    com.Parameters.Add("@vNombreMateriaPrima", SqlDbType.VarChar).Value = MP.vNombreMateriaPrima;
                    com.Parameters.Add("@vDescripcionMateriaPrima", SqlDbType.VarChar).Value = MP.vDescripcionMateriaPrima;
                    com.Parameters.Add("@iOlorCS", SqlDbType.Int).Value = MP.iOlorCS;
                    com.Parameters.Add("@iColorCS", SqlDbType.Int).Value = MP.iColorCS;
                    com.Parameters.Add("@iSaborCS", SqlDbType.Int).Value = MP.iSaborCS;
                    com.Parameters.Add("@iTexturaCS", SqlDbType.Int).Value = MP.iTexturaCS;
                    com.Parameters.Add("@iBrixRF", SqlDbType.Int).Value = MP.iBrixRF;
                    com.Parameters.Add("@iPHRF", SqlDbType.Int).Value = MP.iPHRF;
                    com.Parameters.Add("@iAcidesRF", SqlDbType.Int).Value = MP.iAcidesRF;
                    com.Parameters.Add("@vRequisitosMicrobiolicos", SqlDbType.VarChar).Value = MP.vRequisitosMicrobiolicos;
                    com.Parameters.Add("@vRequisitoRotulado", SqlDbType.VarChar).Value = MP.vRequisitoRotulado;
                    com.Parameters.Add("@vRequisitosEmpaquetado", SqlDbType.VarChar).Value = MP.vRequisitosEmpaquetado;
                    com.Parameters.Add("@vRequisitosPresentacion", SqlDbType.VarChar).Value = MP.vRequisitosPresentacion;
                    com.Parameters.Add("@vCondicionFisicaEntrega", SqlDbType.VarChar).Value = MP.vCondicionFisicaEntrega;
                    com.Parameters.Add("@vCondicionFisicaAlmacenamiento", SqlDbType.VarChar).Value = MP.vCondicionFisicaAlmacenamiento;
                    com.Parameters.Add("@iUsuarioMod", SqlDbType.Int).Value = MP.iUsuarioMod;

                    return com.ExecuteNonQuery();
                }
            }
        }
    }
}