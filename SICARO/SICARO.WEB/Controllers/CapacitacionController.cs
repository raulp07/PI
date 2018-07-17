using SICARO.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SICARO.WEB.Controllers
{
    public class CapacitacionController : Controller
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        // GET: Capacitacion
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public JsonResult ListaCapacitacion()
        {
            try
            {
                List<CAPACITACION_EL> ListaCAPACITACION = new List<CAPACITACION_EL>();
                ListaCAPACITACION = js.Deserialize<List<CAPACITACION_EL>>(Utilitario.Accion.ConectREST("CAPACITACION", "POST","{ }"));
                return Json(new { ListaCAPACITACION = ListaCAPACITACION }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new { ListaCAPACITACION = "" }, JsonRequestBehavior.AllowGet);
            }
        }
        
        [HttpPost]
        public JsonResult ListaPersonal()
        {
            List<PERSONAL_EL> ListaPersonal = new List<PERSONAL_EL>();
            ListaPersonal =js.Deserialize<List<PERSONAL_EL>>(Utilitario.Accion.ConectREST("PERSONAL", "POST", "{ }"));
            return Json(new { ListaPersonal= ListaPersonal ,JsonRequestBehavior.AllowGet});
        }

        [HttpPost]
        public JsonResult RegistrarCapacitacion(GESTION_CAPACITACION_EL GestionCapacitacion,List<PREGUNTA_EL> _Preguntas, List<OPCION_PREGUNTA_EL> _Respuestas)
        {
            string perosnalizaicon = "1";
            string postdata = js.Serialize(GestionCapacitacion);
            int respuesta = js.Deserialize<int>(Utilitario.Accion.ConectREST("ICAPACITACION", "POST", postdata));

            foreach (PREGUNTA_EL item in _Preguntas)
            {
                string postdataP = js.Serialize(item);
                int respuestaP = js.Deserialize<int>(Utilitario.Accion.ConectREST("IPREGUNTA", "POST", postdataP));
                foreach (OPCION_PREGUNTA_EL itemR in _Respuestas)
                {
                    if (item.iIdPregunta == itemR.iIdPregunta)
                    {
                        string postdataR = js.Serialize(itemR);
                        int respuestaR = js.Deserialize<int>(Utilitario.Accion.ConectREST("IOPCION_PREGUNTA", "POST", postdataR));
                    }
                }
            }

            
            


            return Json(new { perosnalizaicon = perosnalizaicon, JsonRequestBehavior.AllowGet });
        }

        // GET: Capacitacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Capacitacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Capacitacion/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Capacitacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Capacitacion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Capacitacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Capacitacion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
