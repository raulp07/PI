using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class CAPACITACION_EL
    {


        ///

        /// Gets or Sets iIdCapacitacion
        ///
        [DataMember]
        public int iIdCapacitacion
        {
            get { return _iIdCapacitacion; }
            set { _iIdCapacitacion = value; }
        }
        private int _iIdCapacitacion;

        ///

        /// Gets or Sets vCodCapacitacion
        ///
        [DataMember]
        public string vCodCapacitacion
        {
            get { return _vCodCapacitacion; }
            set { _vCodCapacitacion = value; }
        }
        private string _vCodCapacitacion;

        ///

        /// Gets or Sets vTemaCapacitacion
        ///
        [DataMember]

        public string vTemaCapacitacion
        {
            get { return _vTemaCapacitacion; }
            set { _vTemaCapacitacion = value; }
        }
        private string _vTemaCapacitacion;

        ///

        /// Gets or Sets dFechaPropuestaCapacitacion
        ///
        [DataMember]
        public DateTime dFechaPropuestaCapacitacion
        {
            get { return _dFechaPropuestaCapacitacion; }
            set { _dFechaPropuestaCapacitacion = value; }
        }
        private DateTime _dFechaPropuestaCapacitacion;

        ///

        /// Gets or Sets iEstadoCapactiacion
        ///
        [DataMember]
        public int iEstadoCapactiacion
        {
            get { return _iEstadoCapactiacion; }
            set { _iEstadoCapactiacion = value; }
        }
        private int _iEstadoCapactiacion;

        ///

        /// Gets or Sets iEstadoComunicacionCapacitacion
        ///
        [DataMember]
        public int iEstadoComunicacionCapacitacion
        {
            get { return _iEstadoComunicacionCapacitacion; }
            set { _iEstadoComunicacionCapacitacion = value; }
        }
        private int _iEstadoComunicacionCapacitacion;

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