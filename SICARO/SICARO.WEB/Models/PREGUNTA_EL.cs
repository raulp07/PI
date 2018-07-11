using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class PREGUNTA_EL
    {

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

        /// Gets or Sets iIdTest
        ///
        public int iIdTest
        {
            get { return _iIdTest; }
            set { _iIdTest = value; }
        }
        private int _iIdTest;

        ///

        /// Gets or Sets vEnunciadoPregunta
        ///
        public string vEnunciadoPregunta
        {
            get { return _vEnunciadoPregunta; }
            set { _vEnunciadoPregunta = value; }
        }
        private string _vEnunciadoPregunta;

        ///

        /// Gets or Sets iPuntajePregunta
        ///
        public int iPuntajePregunta
        {
            get { return _iPuntajePregunta; }
            set { _iPuntajePregunta = value; }
        }
        private int _iPuntajePregunta;

        ///

        /// Gets or Sets iTipoRespuestaPregunta
        ///
        public int iTipoRespuestaPregunta
        {
            get { return _iTipoRespuestaPregunta; }
            set { _iTipoRespuestaPregunta = value; }
        }
        private int _iTipoRespuestaPregunta;

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