using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class CAPACITACION_EL
    {


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

        /// Gets or Sets vCodCapacitacion
        ///
        public string vCodCapacitacion
        {
            get { return _vCodCapacitacion; }
            set { _vCodCapacitacion = value; }
        }
        private string _vCodCapacitacion;

        ///

        /// Gets or Sets vTemaCapacitacion
        ///
        public string vTemaCapacitacion
        {
            get { return _vTemaCapacitacion; }
            set { _vTemaCapacitacion = value; }
        }
        private string _vTemaCapacitacion;

        ///

        /// Gets or Sets dFechaPropuestaCapacitacion
        ///
        public DateTime dFechaPropuestaCapacitacion
        {
            get { return _dFechaPropuestaCapacitacion; }
            set { _dFechaPropuestaCapacitacion = value; }
        }
        private DateTime _dFechaPropuestaCapacitacion;

        ///

        /// Gets or Sets iEstadoCapactiacion
        ///
        public int iEstadoCapactiacion
        {
            get { return _iEstadoCapactiacion; }
            set { _iEstadoCapactiacion = value; }
        }
        private int _iEstadoCapactiacion;

        ///

        /// Gets or Sets iEstadoComunicacionCapacitacion
        ///
        public int iEstadoComunicacionCapacitacion
        {
            get { return _iEstadoComunicacionCapacitacion; }
            set { _iEstadoComunicacionCapacitacion = value; }
        }
        private int _iEstadoComunicacionCapacitacion;

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