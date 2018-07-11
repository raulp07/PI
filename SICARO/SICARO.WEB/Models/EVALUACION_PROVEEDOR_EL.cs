using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class EVALUACION_PROVEEDOR_EL
    {


        ///

        /// Gets or Sets iIdEvaluacionProveedor
        ///
        public int iIdEvaluacionProveedor
        {
            get { return _iIdEvaluacionProveedor; }
            set { _iIdEvaluacionProveedor = value; }
        }
        private int _iIdEvaluacionProveedor;

        ///

        /// Gets or Sets iIdProveedor
        ///
        public int iIdProveedor
        {
            get { return _iIdProveedor; }
            set { _iIdProveedor = value; }
        }
        private int _iIdProveedor;

        ///

        /// Gets or Sets iCalidadProducto
        ///
        public int iCalidadProducto
        {
            get { return _iCalidadProducto; }
            set { _iCalidadProducto = value; }
        }
        private int _iCalidadProducto;

        ///

        /// Gets or Sets iPrecio
        ///
        public int iPrecio
        {
            get { return _iPrecio; }
            set { _iPrecio = value; }
        }
        private int _iPrecio;

        ///

        /// Gets or Sets iCondiciones
        ///
        public int iCondiciones
        {
            get { return _iCondiciones; }
            set { _iCondiciones = value; }
        }
        private int _iCondiciones;

        ///

        /// Gets or Sets dFechaEvaluacion
        ///
        public DateTime dFechaEvaluacion
        {
            get { return _dFechaEvaluacion; }
            set { _dFechaEvaluacion = value; }
        }
        private DateTime _dFechaEvaluacion;

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