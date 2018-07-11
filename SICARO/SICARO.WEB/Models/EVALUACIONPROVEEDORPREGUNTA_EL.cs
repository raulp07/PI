using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class EVALUACIONPROVEEDORPREGUNTA_EL
    {


        ///

        /// Gets or Sets iIdEvaluacionProveedorPregunta
        ///
        public int iIdEvaluacionProveedorPregunta
        {
            get { return _iIdEvaluacionProveedorPregunta; }
            set { _iIdEvaluacionProveedorPregunta = value; }
        }
        private int _iIdEvaluacionProveedorPregunta;

        ///

        /// Gets or Sets iIdEvaluacionProveedor
        ///
        public int iIdEvaluacionProveedor
        {
            get { return _iIdEvaluacionProveedor; }
            set { _iIdEvaluacionProveedor = value; }
        }
        private int _iIdEvaluacionProveedor;

        ///

        /// Gets or Sets iIdMateriaPrima
        ///
        public int iIdMateriaPrima
        {
            get { return _iIdMateriaPrima; }
            set { _iIdMateriaPrima = value; }
        }
        private int _iIdMateriaPrima;

        ///

        /// Gets or Sets vObservacion
        ///
        public string vObservacion
        {
            get { return _vObservacion; }
            set { _vObservacion = value; }
        }
        private string _vObservacion;

        ///

        /// Gets or Sets dFecha
        ///
        public DateTime dFecha
        {
            get { return _dFecha; }
            set { _dFecha = value; }
        }
        private DateTime _dFecha;

        ///

        /// Gets or Sets iPuntajeTotal
        ///
        public int iPuntajeTotal
        {
            get { return _iPuntajeTotal; }
            set { _iPuntajeTotal = value; }
        }
        private int _iPuntajeTotal;

        ///

        /// Gets or Sets iPorcentajeCumplimiento
        ///
        public int iPorcentajeCumplimiento
        {
            get { return _iPorcentajeCumplimiento; }
            set { _iPorcentajeCumplimiento = value; }
        }
        private int _iPorcentajeCumplimiento;

        ///

        /// Gets or Sets iUsuarioCrea
        ///
        public int iUsuarioCrea
        {
            get { return _iUsuarioCrea; }
            set { _iUsuarioCrea = value; }
        }
        private int _iUsuarioCrea;

        ///

        /// Gets or Sets dFechaCrea
        ///
        public DateTime dFechaCrea
        {
            get { return _dFechaCrea; }
            set { _dFechaCrea = value; }
        }
        private DateTime _dFechaCrea;

        ///

        /// Gets or Sets iUsuarioMod
        ///
        public int iUsuarioMod
        {
            get { return _iUsuarioMod; }
            set { _iUsuarioMod = value; }
        }
        private int _iUsuarioMod;

        ///

        /// Gets or Sets dFechaMod
        ///
        public DateTime dFechaMod
        {
            get { return _dFechaMod; }
            set { _dFechaMod = value; }
        }
        private DateTime _dFechaMod;
    }
}