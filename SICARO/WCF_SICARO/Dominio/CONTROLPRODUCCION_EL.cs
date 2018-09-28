using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class CONTROLPRODUCCION_EL
    {
        ///

        /// Gets or Sets idControlProduccion
        ///
        [DataMember]
        public int idControlProduccion
        {
            get { return _idControlProduccion; }
            set { _idControlProduccion = value; }
        }
        private int _idControlProduccion;

        ///

        /// Gets or Sets idProducto
        ///
        [DataMember]
        public int idProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        private int _idProducto;

        ///

        /// Gets or Sets tipoPronostico
        ///
        [DataMember]
        public string tipoPronostico
        {
            get { return _tipoPronostico; }
            set { _tipoPronostico = value; }
        }
        private string _tipoPronostico;

        ///

        /// Gets or Sets fechaProduccion
        ///
        [DataMember]
        public DateTime fechaProduccion
        {
            get { return _fechaProduccion; }
            set { _fechaProduccion = value; }
        }
        private DateTime _fechaProduccion;

        ///

        /// Gets or Sets cantidadProducida
        ///
        [DataMember]
        public int cantidadProducida
        {
            get { return _cantidadProducida; }
            set { _cantidadProducida = value; }
        }
        private int _cantidadProducida;

        ///

        /// Gets or Sets idActividadControlProduccion
        ///
        [DataMember]
        public int idActividadControlProduccion
        {
            get { return _idActividadControlProduccion; }
            set { _idActividadControlProduccion = value; }
        }
        private int _idActividadControlProduccion;

        ///

        /// Gets or Sets indicador
        ///
        [DataMember]
        public string indicador
        {
            get { return _indicador; }
            set { _indicador = value; }
        }
        private string _indicador;
    }
}