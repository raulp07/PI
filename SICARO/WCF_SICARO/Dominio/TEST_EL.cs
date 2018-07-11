using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class TEST_EL
    {

        ///

        /// Gets or Sets iIdTest
        ///
        [DataMember]
        public int iIdTest
        {
            get { return _iIdTest; }
            set { _iIdTest = value; }
        }
        private int _iIdTest;

        ///

        /// Gets or Sets iIdGestorCapacitacion
        ///
        [DataMember]
        public int iIdGestorCapacitacion
        {
            get { return _iIdGestorCapacitacion; }
            set { _iIdGestorCapacitacion = value; }
        }
        private int _iIdGestorCapacitacion;

        ///

        /// Gets or Sets vDescricionTest
        ///
        [DataMember]
        public string vDescricionTest
        {
            get { return _vDescricionTest; }
            set { _vDescricionTest = value; }
        }
        private string _vDescricionTest;

        ///

        /// Gets or Sets dFechaTest
        ///
        [DataMember]
        public DateTime dFechaTest
        {
            get { return _dFechaTest; }
            set { _dFechaTest = value; }
        }
        private DateTime _dFechaTest;

        ///

        /// Gets or Sets iEstadoTest
        ///
        [DataMember]
        public int iEstadoTest
        {
            get { return _iEstadoTest; }
            set { _iEstadoTest = value; }
        }
        private int _iEstadoTest;

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