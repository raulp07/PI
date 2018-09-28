using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class CONTROLPRODUCCION_EL
    {

        ///

        /// Gets or Sets idControlProduccion
        ///
        public int idControlProduccion
        {
            get { return _idControlProduccion; }
            set { _idControlProduccion = value; }
        }
        private int _idControlProduccion;

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

        /// Gets or Sets tipoPronostico
        ///
        public string tipoPronostico
        {
            get { return _tipoPronostico; }
            set { _tipoPronostico = value; }
        }
        private string _tipoPronostico;

        ///

        /// Gets or Sets fechaProduccion
        ///
        public DateTime fechaProduccion
        {
            get { return _fechaProduccion; }
            set { _fechaProduccion = value; }
        }
        private DateTime _fechaProduccion;

        ///

        /// Gets or Sets cantidadProducida
        ///
        public int cantidadProducida
        {
            get { return _cantidadProducida; }
            set { _cantidadProducida = value; }
        }
        private int _cantidadProducida;

        ///

        /// Gets or Sets idActividadControlProduccion
        ///
        public int idActividadControlProduccion
        {
            get { return _idActividadControlProduccion; }
            set { _idActividadControlProduccion = value; }
        }
        private int _idActividadControlProduccion;

        ///

        /// Gets or Sets indicador
        ///
        public string indicador
        {
            get { return _indicador; }
            set { _indicador = value; }
        }
        private string _indicador;
    }
}