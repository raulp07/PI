using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class OPCION_PREGUNTA_EL
    {

        ///

        /// Gets or Sets iIdOpcion
        ///
        public int iIdOpcion
        {
            get { return _iIdOpcion; }
            set { _iIdOpcion = value; }
        }
        private int _iIdOpcion;

        ///

        /// Gets or Sets iIdPregunta
        ///
        public int iIdPregunta
        {
            get { return _iIdPregunta; }
            set { _iIdPregunta = value; }
        }
        private int _iIdPregunta;

        ///

        /// Gets or Sets vEnunciadoOpcion
        ///
        public string vEnunciadoOpcion
        {
            get { return _vEnunciadoOpcion; }
            set { _vEnunciadoOpcion = value; }
        }
        private string _vEnunciadoOpcion;

        ///

        /// Gets or Sets iEstadoOpcion
        ///
        public int iEstadoOpcion
        {
            get { return _iEstadoOpcion; }
            set { _iEstadoOpcion = value; }
        }
        private int _iEstadoOpcion;

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