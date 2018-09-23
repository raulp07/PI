using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class DETALLE_CAPACITACION_PERSONAL_EL
    {
        ///

        /// Gets or Sets iIdDetalleCapacitacionPersonal
        ///
        public int iIdDetalleCapacitacionPersonal
        {
            get { return _iIdDetalleCapacitacionPersonal; }
            set { _iIdDetalleCapacitacionPersonal = value; }
        }
        private int _iIdDetalleCapacitacionPersonal;

        ///

        /// Gets or Sets iIdCapacitacionPersonal
        ///
        public int iIdCapacitacionPersonal
        {
            get { return _iIdCapacitacionPersonal; }
            set { _iIdCapacitacionPersonal = value; }
        }
        private int _iIdCapacitacionPersonal;

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

        /// Gets or Sets iIdOpcion
        ///
        public int iIdOpcion
        {
            get { return _iIdOpcion; }
            set { _iIdOpcion = value; }
        }
        private int _iIdOpcion;

        ///

        /// Gets or Sets iEstadoRespuesta
        ///
        public int iEstadoRespuesta
        {
            get { return _iEstadoRespuesta; }
            set { _iEstadoRespuesta = value; }
        }
        private int _iEstadoRespuesta;

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