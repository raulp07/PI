﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF_SICARO.Dominio;
using WCF_SICARO.Persistencia;

namespace WCF_SICARO
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFICARO : IWCFICARO
    {

        // CAPACITACION ==================================================
        public List<CAPACITACION_EL> GetAllCAPACITACION(CAPACITACION_EL C)
        {
            return CAPACITACION_DA.Accion.GetAllCAPACITACION(C);
        }
        //================================================================

        // GESTION CAPACITACION ==================================================
        public List<GESTION_CAPACITACION_EL> GetAllGESTION_CAPACITACION(GESTION_CAPACITACION_EL GC)
        {
            return GESTION_CAPACITACION_DA.Accion.GetAllGESTION_CAPACITACION(GC);
        }
        public int InsertGESTION_CAPACITACION(GESTION_CAPACITACION_EL GC)
        {
            return GESTION_CAPACITACION_DA.Accion.InsertGESTION_CAPACITACION(GC);
        }
        public int UpdateGESTION_CAPACITACION(GESTION_CAPACITACION_EL GC)
        {
            return GESTION_CAPACITACION_DA.Accion.UpdateGESTION_CAPACITACION(GC);
        }
        //================================================================

        // TEST ==================================================
        public List<TEST_EL> GetAllTEST(TEST_EL T)
        {
            return TEST_DA.Accion.GetAllTEST(T);
        }
        public int InsertTEST(TEST_EL T)
        {
            return TEST_DA.Accion.InsertTEST(T);
        }
        public int UpdateTEST(TEST_EL T)
        {
            return TEST_DA.Accion.UpdateTEST(T);
        }
        //================================================================

        // PREGUNTA ==================================================
        public List<PREGUNTA_EL> GetAllPREGUNTA(PREGUNTA_EL P)
        {
            return PREGUNTA_DA.Accion.GetAllPREGUNTA(P);
        }
        public int InsertPREGUNTA(PREGUNTA_EL P)
        {
            return PREGUNTA_DA.Accion.InsertPREGUNTA(P);
        }
        public int UpdatePREGUNTA(PREGUNTA_EL P)
        {
            return PREGUNTA_DA.Accion.UpdatePREGUNTA(P);
        }
        //================================================================

        // OPCION PREGUNTA ==================================================
        public List<OPCION_PREGUNTA_EL> GetAllOPCION_PREGUNTA(OPCION_PREGUNTA_EL OP)
        {
            return OPCION_PREGUNTA_DA.Accion.GetAllOPCION_PREGUNTA(OP);
        }
        public int InsertOPCION_PREGUNTA(OPCION_PREGUNTA_EL OP)
        {
            return OPCION_PREGUNTA_DA.Accion.InsertOPCION_PREGUNTA(OP);
        }
        public int UpdateOPCION_PREGUNTA(OPCION_PREGUNTA_EL OP)
        {
            return OPCION_PREGUNTA_DA.Accion.UpdateOPCION_PREGUNTA(OP);
        }
        //================================================================

        // REPRESENTANTE ==================================================
        public List<REPRESENTANTE_EL> GetAllREPRESENTANTE(REPRESENTANTE_EL R)
        {
            return REPRESENTANTE_DA.Accion.GetAllREPRESENTANTE(R);
        }
        public int InsertREPRESENTANTE(REPRESENTANTE_EL R)
        {
            return REPRESENTANTE_DA.Accion.InsertREPRESENTANTE(R);
        }
        public int UpdateREPRESENTANTE(REPRESENTANTE_EL R)
        {
            return REPRESENTANTE_DA.Accion.UpdateREPRESENTANTE(R);
        }
        //================================================================

        // PERSONAL ==================================================
        public List<PERSONAL_EL> GetAllPERSONAL(PERSONAL_EL P)
        {
            return PERSONAL_DA.Accion.GetAllPERSONAL(P);
        }
        public int InsertPERSONAL(PERSONAL_EL P)
        {
            return PERSONAL_DA.Accion.InsertPERSONAL(P);
        }
        public int UpdatePERSONAL(PERSONAL_EL P)
        {
            return PERSONAL_DA.Accion.UpdatePERSONAL(P);
        }
        //================================================================

        // PROVEEDOR ==================================================
        public List<PROVEEDOR_EL> GetAllPROVEEDOR(PROVEEDOR_EL P)
        {
            return PROVEEDOR_DA.Accion.GetAllPROVEEDOR(P);
        }
        //================================================================


    }
}