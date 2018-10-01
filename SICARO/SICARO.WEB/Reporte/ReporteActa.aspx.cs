using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using DALC4NET;
using System.Data.SqlClient;

namespace SICARO.WEB.Reporte
{
    public partial class ReporteActa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.EnableExternalImages = true;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reporte/rptActa.rdlc");

                DataTable dtReporte = new DataTable();
                using (SqlConnection con = new SqlConnection("Data Source='BDICAROV1.mssql.somee.com';Initial Catalog=BDICAROV1;user=sefiroth_SQLLogin_1;password=2llanx2cd9;"))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand("sp_reporte", con))
                    {
                        com.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(com);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dtReporte = ds.Tables[0];
                    }
                }


                    //DBHelper dbhelper = new DBHelper(
                    //"Data Source='BDICAROV1.mssql.somee.com';Initial Catalog=BDICAROV1;user=sefiroth_SQLLogin_1;password=2llanx2cd9;",
                    //"System.Data.SqlClient"
                    //);

               
                
                //dtReporte = dbhelper.ExecuteDataTable(consulta);
                ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DatosActaControlProduccion", dtReporte));

                //List<SICARO.WEB.RPTDataSet.datosreporte.ACTIVIDADCONTROLPRODUCCIONRow> reporte = null;
                //using (SICARO.WEB.RPTDataSet.datosreporte dc = new SICARO.WEB.RPTDataSet.datosreporte())
                //{
                //    reporte = dc.ACTIVIDADCONTROLPRODUCCION.ToList();
                //    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reporte/rptActa.rdlc");
                //    ReportViewer1.LocalReport.DataSources.Clear();
                //    ReportDataSource rdc = new ReportDataSource("datosreporte", reporte);
                //    ReportViewer1.LocalReport.DataSources.Add(rdc);
                //    ReportViewer1.LocalReport.Refresh();
                //}
            }
        }
    }
}