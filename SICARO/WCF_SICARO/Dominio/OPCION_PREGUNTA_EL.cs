using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class OPCION_PREGUNTA_EL
    {

        ///

        /// Gets or Sets iIdOpcion
        ///
        [DataMember]
        public int iIdOpcion
        {
            get { return _iIdOpcion; }
            set { _iIdOpcion = value; }
        }
        private int _iIdOpcion;

        ///

        /// Gets or Sets iIdPregunta
        ///
        [DataMember]
        public int iIdPregunta
        {
            get { return _iIdPregunta; }
            set { _iIdPregunta = value; }
        }
        private int _iIdPregunta;

        ///

        /// Gets or Sets vEnunciadoOpcion
        ///
        [DataMember]
        public string vEnunciadoOpcion
        {
            get { return _vEnunciadoOpcion; }
            set { _vEnunciadoOpcion = value; }
        }
        private string _vEnunciadoOpcion;

        ///

        /// Gets or Sets iEstadoOpcion
        ///
        [DataMember]
        public int iEstadoOpcion
        {
            get { return _iEstadoOpcion; }
            set { _iEstadoOpcion = value; }
        }
        private int _iEstadoOpcion;

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