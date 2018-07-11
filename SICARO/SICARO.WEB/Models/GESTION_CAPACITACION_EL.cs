using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class GESTION_CAPACITACION_EL
    {

        ///

        /// Gets or Sets iIdGestionCapacitacion
        ///
        public int iIdGestionCapacitacion
        {
            get { return _iIdGestionCapacitacion; }
            set { _iIdGestionCapacitacion = value; }
        }
        private int _iIdGestionCapacitacion;

        ///

        /// Gets or Sets iIdCapacitacion
        ///
        public int iIdCapacitacion
        {
            get { return _iIdCapacitacion; }
            set { _iIdCapacitacion = value; }
        }
        private int _iIdCapacitacion;

        ///

        /// Gets or Sets iIdRepresentante
        ///
        public int iIdRepresentante
        {
            get { return _iIdRepresentante; }
            set { _iIdRepresentante = value; }
        }
        private int _iIdRepresentante;

        ///

        /// Gets or Sets dFechaRealizacionCapacitacion
        ///
        public DateTime dFechaRealizacionCapacitacion
        {
            get { return _dFechaRealizacionCapacitacion; }
            set { _dFechaRealizacionCapacitacion = value; }
        }
        private DateTime _dFechaRealizacionCapacitacion;

        ///

        /// Gets or Sets tHoraInicio
        ///
        public DateTime tHoraInicio
        {
            get { return _tHoraInicio; }
            set { _tHoraInicio = value; }
        }
        private DateTime _tHoraInicio;

        ///

        /// Gets or Sets tHoraFin
        ///
        public DateTime tHoraFin
        {
            get { return _tHoraFin; }
            set { _tHoraFin = value; }
        }
        private DateTime _tHoraFin;

        ///

        /// Gets or Sets iTiempoTest
        ///
        public int iTiempoTest
        {
            get { return _iTiempoTest; }
            set { _iTiempoTest = value; }
        }
        private int _iTiempoTest;

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