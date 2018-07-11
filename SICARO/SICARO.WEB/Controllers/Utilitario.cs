using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace SICARO.WEB.Controllers
{
    public class Utilitario
    {

        private static Utilitario accion;
        private Utilitario() { }
        public static Utilitario Accion
        {
            get
            {
                if (accion == null)
                {
                    accion = new Utilitario();
                }
                return accion;
            }
        }

        private static JavaScriptSerializer js;
        public static JavaScriptSerializer js_
        {
            get
            {
                if (js == null)
                {
                    js = new JavaScriptSerializer();
                }
                return js;
            }
        }



        public static string urlSite = ConfigurationManager.AppSettings["urlWS"];
        public string ConectREST(string url, string method, string postdata = "")
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(urlSite + "WCFICARO.svc/" + url);
                HttpWebResponse res = null;
                StreamReader reader = null;
                switch (method)
                {
                    case "GET":
                        req.Method = method;
                        res = (HttpWebResponse)req.GetResponse();
                        reader = new StreamReader(res.GetResponseStream());
                        return reader.ReadToEnd();
                    case "POST":
                        byte[] data = Encoding.UTF8.GetBytes(postdata);
                        req.Method = method;
                        req.ContentLength = data.Length;
                        req.ContentType = "application/json";
                        var reqStream = req.GetRequestStream();
                        reqStream.Write(data, 0, data.Length);
                        res = (HttpWebResponse)req.GetResponse();
                        reader = new StreamReader(res.GetResponseStream());
                        return reader.ReadToEnd();
                    default: return "";
                }
            }
            catch (Exception e)
            {
                throw new ArgumentNullException(e.Message);
            }

        }
    }
}