using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class PRONOSTICO_EL
    {
        ///

        /// Gets or Sets idPronostico
        ///
        public int idPronostico
        {
            get { return _idPronostico; }
            set { _idPronostico = value; }
        }
        private int _idPronostico;

        ///

        /// Gets or Sets tipoPronostico
        ///
        public string tipoPronostico
        {
            get { return _tipoPronostico; }
            set { _tipoPronostico = value; }
        }
        private string _tipoPronostico;

        ///

        /// Gets or Sets idProveedor
        ///
        public int idProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }
        private int _idProveedor;

        ///

        /// Gets or Sets idProducto
        ///
        public int idProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        private int _idProducto;

        ///

        /// Gets or Sets idInsumo
        ///
        public int idInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }
        private int _idInsumo;

        ///

        /// Gets or Sets idActividadProduccion
        ///
        public int idActividadProduccion
        {
            get { return _idActividadProduccion; }
            set { _idActividadProduccion = value; }
        }
        private int _idActividadProduccion;

        ///

        /// Gets or Sets cantidad
        ///
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private int _cantidad;

        ///

        /// Gets or Sets unidadDeMedida
        ///
        public string unidadDeMedida
        {
            get { return _unidadDeMedida; }
            set { _unidadDeMedida = value; }
        }
        private string _unidadDeMedida;
    }
}