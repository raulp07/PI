using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class GESTION_CAPACITACION_EL
    {

        ///

        /// Gets or Sets iIdGestionCapacitacion
        ///
        [DataMember]
        public int iIdGestionCapacitacion
        {
            get { return _iIdGestionCapacitacion; }
            set { _iIdGestionCapacitacion = value; }
        }
        private int _iIdGestionCapacitacion;

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

        /// Gets or Sets iIdRepresentante
        ///
        [DataMember]
        public int iIdRepresentante
        {
            get { return _iIdRepresentante; }
            set { _iIdRepresentante = value; }
        }
        private int _iIdRepresentante;

        ///

        /// Gets or Sets dFechaRealizacionCapacitacion
        ///
        [DataMember]
        public DateTime dFechaRealizacionCapacitacion
        {
            get { return _dFechaRealizacionCapacitacion; }
            set { _dFechaRealizacionCapacitacion = value; }
        }
        private DateTime _dFechaRealizacionCapacitacion;

        ///

        /// Gets or Sets tHoraInicio
        ///
        [DataMember]
        public string tHoraInicio
        {
            get { return _tHoraInicio; }
            set { _tHoraInicio = value; }
        }
        private string _tHoraInicio;

        ///

        /// Gets or Sets tHoraFin
        ///
        [DataMember]
        public string tHoraFin
        {
            get { return _tHoraFin; }
            set { _tHoraFin = value; }
        }
        private string _tHoraFin;

        ///

        /// Gets or Sets iTiempoTest
        ///
        [DataMember]
        public int iTiempoTest
        {
            get { return _iTiempoTest; }
            set { _iTiempoTest = value; }
        }
        private int _iTiempoTest;

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