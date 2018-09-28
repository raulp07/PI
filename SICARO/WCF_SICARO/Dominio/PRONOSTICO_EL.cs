using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class PRONOSTICO_EL
    {
        ///

        /// Gets or Sets idPronostico
        ///
       [DataMember]
        public int idPronostico
        {
            get { return _idPronostico; }
            set { _idPronostico = value; }
        }
        private int _idPronostico;

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

        /// Gets or Sets idProveedor
        ///
        [DataMember]
        public int idProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }
        private int _idProveedor;

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

        /// Gets or Sets idInsumo
        ///
        [DataMember]
        public int idInsumo
        {
            get { return _idInsumo; }
            set { _idInsumo = value; }
        }
        private int _idInsumo;

        ///

        /// Gets or Sets idActividadProduccion
        ///
        [DataMember]
        public int idActividadProduccion
        {
            get { return _idActividadProduccion; }
            set { _idActividadProduccion = value; }
        }
        private int _idActividadProduccion;

        ///

        /// Gets or Sets cantidad
        ///
        [DataMember]
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private int _cantidad;

        ///

        /// Gets or Sets unidadDeMedida
        ///
        [DataMember]
        public string unidadDeMedida
        {
            get { return _unidadDeMedida; }
            set { _unidadDeMedida = value; }
        }
        private string _unidadDeMedida;

    }
}