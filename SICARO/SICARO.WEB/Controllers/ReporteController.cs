using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SICARO.WEB.Controllers
{
    public class ReporteController : Controller
    {
        // GET: Reporte
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public JsonResult GenerarReporte()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection("Data Source='BDICAROV1.mssql.somee.com';Initial Catalog=BDICAROV1;user=sefiroth_SQLLogin_1;password=2llanx2cd9;"))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand("sp_reporte", con))
                {
                    com.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(com);

                    da.Fill(ds);
                    //dtReporte = ds.Tables[0];
                }
            }
            List<reporteACTIVIDADCONTROLPRODUCCION> listAP = new List<reporteACTIVIDADCONTROLPRODUCCION>();
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                reporteACTIVIDADCONTROLPRODUCCION r = new reporteACTIVIDADCONTROLPRODUCCION();
                r.Tiempoinicial = item["Tiempoinicial"].ToString();
                r.TiempoFinal = item["TiempoFinal"].ToString();
                r.tiempototalmezclado = item["tiempototalmezclado"].ToString();
                r.tiempototalreposo = item["tiempototalreposo"].ToString();
                r.tiempototalfiltrado = item["tiempototalfiltrado"].ToString();
                r.tiempototalllenado = item["tiempototalllenado"].ToString();
                r.tiempototalencajonado = item["tiempototalencajonado"].ToString();
                listAP.Add(r);
            }

            List<reporteMateriaPrima> listrm = new List<reporteMateriaPrima>();
            foreach (DataRow item in ds.Tables[1].Rows)
            {
                reporteMateriaPrima r = new reporteMateriaPrima();
                r.vnombremateriaprima = item["vnombremateriaprima"].ToString();
                r.tipopronostico = item["tipopronostico"].ToString();
                r.indicador = item["indicador"].ToString();
                listrm.Add(r);
            }

            

            List<reporteCAPACITACION> listM = new List<reporteCAPACITACION>();
            foreach (DataRow item in ds.Tables[2].Rows)
            {
                reporteCAPACITACION r = new reporteCAPACITACION();
                r.vcodcapacitacion = item["vcodcapacitacion"].ToString();
                r.vtemacapacitacion = item["vtemacapacitacion"].ToString();
                r.dfechapropuestacapacitacion = item["dfechapropuestacapacitacion"].ToString();
                r.cantidadcapacitados = item["cantidadcapacitados"].ToString();
                r.cantidad = item["cantidad"].ToString();
                listM.Add(r);
            }

            List<reportePROVEEDOR> listP = new List<reportePROVEEDOR>();
            foreach (DataRow item in ds.Tables[3].Rows)
            {
                reportePROVEEDOR r = new reportePROVEEDOR();
                r.vnombreproveedor = item["vnombreproveedor"].ToString();
                r.vnombremateriaprima = item["vnombremateriaprima"].ToString();
                r.icondiciones = item["icondiciones"].ToString();
                r.puntaje = item["puntaje"].ToString();

                listP.Add(r);
            }




            return Json(new { listrm = listrm, listAP = listAP, listM = listM, listP = listP }, JsonRequestBehavior.AllowGet);
        }



    }

    public class reporteMateriaPrima
    {
        public string vnombremateriaprima { get; set; }
        public string tipopronostico { get; set; }
        public string indicador { get; set; }
    }
    public class reporteACTIVIDADCONTROLPRODUCCION
    {
        public string Tiempoinicial { get; set; }
        public string TiempoFinal { get; set; }
        public string tiempototalmezclado { get; set; }
        public string tiempototalreposo { get; set; }
        public string tiempototalfiltrado { get; set; }
        public string tiempototalllenado { get; set; }
        public string tiempototalencajonado { get; set; }
    }
    public class reporteCAPACITACION
    {
        public string vcodcapacitacion { get; set; }
        public string vtemacapacitacion { get; set; }
        public string dfechapropuestacapacitacion { get; set; }

        public string cantidadcapacitados { get; set; }
        public string cantidad { get; set; }
    }
    public class reportePROVEEDOR
    {
        public string vnombreproveedor { get; set; }
        public string vnombremateriaprima { get; set; }
        public string icondiciones { get; set; }
        public string puntaje { get; set; }
    }
    public class grupoReporte
    {
        public reporteMateriaPrima _reporteMateriaPrima { get; set; }
        public reporteACTIVIDADCONTROLPRODUCCION _reporteACTIVIDADCONTROLPRODUCCION { get; set; }
        public reporteCAPACITACION _reporteCAPACITACION { get; set; }
        public reportePROVEEDOR _reportePROVEEDOR { get; set; }
    }
}