using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class TEST_EL
    {

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

        /// Gets or Sets iIdGestorCapacitacion
        ///
        public int iIdGestorCapacitacion
        {
            get { return _iIdGestorCapacitacion; }
            set { _iIdGestorCapacitacion = value; }
        }
        private int _iIdGestorCapacitacion;

        ///

        /// Gets or Sets vDescricionTest
        ///
        public string vDescricionTest
        {
            get { return _vDescricionTest; }
            set { _vDescricionTest = value; }
        }
        private string _vDescricionTest;

        ///

        /// Gets or Sets dFechaTest
        ///
        public DateTime dFechaTest
        {
            get { return _dFechaTest; }
            set { _dFechaTest = value; }
        }
        private DateTime _dFechaTest;

        ///

        /// Gets or Sets iEstadoTest
        ///
        public int iEstadoTest
        {
            get { return _iEstadoTest; }
            set { _iEstadoTest = value; }
        }
        private int _iEstadoTest;

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