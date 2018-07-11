using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class EVALUACIONPROVEEDORPREGUNTA_EL
    {


        ///

        /// Gets or Sets iIdEvaluacionProveedorPregunta
        ///
        [DataMember]
        public int iIdEvaluacionProveedorPregunta
        {
            get { return _iIdEvaluacionProveedorPregunta; }
            set { _iIdEvaluacionProveedorPregunta = value; }
        }
        private int _iIdEvaluacionProveedorPregunta;

        ///

        /// Gets or Sets iIdEvaluacionProveedor
        ///
        [DataMember]
        public int iIdEvaluacionProveedor
        {
            get { return _iIdEvaluacionProveedor; }
            set { _iIdEvaluacionProveedor = value; }
        }
        private int _iIdEvaluacionProveedor;

        ///

        /// Gets or Sets iIdMateriaPrima
        ///
        [DataMember]
        public int iIdMateriaPrima
        {
            get { return _iIdMateriaPrima; }
            set { _iIdMateriaPrima = value; }
        }
        private int _iIdMateriaPrima;

        ///

        /// Gets or Sets vObservacion
        ///
        [DataMember]
        public string vObservacion
        {
            get { return _vObservacion; }
            set { _vObservacion = value; }
        }
        private string _vObservacion;

        ///

        /// Gets or Sets dFecha
        ///
        [DataMember]
        public DateTime dFecha
        {
            get { return _dFecha; }
            set { _dFecha = value; }
        }
        private DateTime _dFecha;

        ///

        /// Gets or Sets iPuntajeTotal
        ///
        [DataMember]
        public int iPuntajeTotal
        {
            get { return _iPuntajeTotal; }
            set { _iPuntajeTotal = value; }
        }
        private int _iPuntajeTotal;

        ///

        /// Gets or Sets iPorcentajeCumplimiento
        ///
        [DataMember]
        public int iPorcentajeCumplimiento
        {
            get { return _iPorcentajeCumplimiento; }
            set { _iPorcentajeCumplimiento = value; }
        }
        private int _iPorcentajeCumplimiento;

        ///

        /// Gets or Sets iUsuarioCrea
        ///
        [DataMember]
        public int iUsuarioCrea
        {
            get { return _iUsuarioCrea; }
            set { _iUsuarioCrea = value; }
        }
        private int _iUsuarioCrea;

        ///

        /// Gets or Sets dFechaCrea
        ///
        [DataMember]
        public DateTime dFechaCrea
        {
            get { return _dFechaCrea; }
            set { _dFechaCrea = value; }
        }
        private DateTime _dFechaCrea;

        ///

        /// Gets or Sets iUsuarioMod
        ///
        [DataMember]
        public int iUsuarioMod
        {
            get { return _iUsuarioMod; }
            set { _iUsuarioMod = value; }
        }
        private int _iUsuarioMod;

        ///

        /// Gets or Sets dFechaMod
        ///
        [DataMember]
        public DateTime dFechaMod
        {
            get { return _dFechaMod; }
            set { _dFechaMod = value; }
        }
        private DateTime _dFechaMod;
    }
}