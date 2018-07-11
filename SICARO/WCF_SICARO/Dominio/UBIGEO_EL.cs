using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class UBIGEO_EL
    {
        ///

        /// Gets or Sets vCodDpto
        ///
        [DataMember]
        public string vCodDpto
        {
            get { return _vCodDpto; }
            set { _vCodDpto = value; }
        }
        private string _vCodDpto;

        ///

        /// Gets or Sets vCodProv
        ///
        [DataMember]
        public string vCodProv
        {
            get { return _vCodProv; }
            set { _vCodProv = value; }
        }
        private string _vCodProv;

        ///

        /// Gets or Sets vCodDist
        ///
        [DataMember]
        public string vCodDist
        {
            get { return _vCodDist; }
            set { _vCodDist = value; }
        }
        private string _vCodDist;

        ///

        /// Gets or Sets vNombre
        ///
        [DataMember]
        public string vNombre
        {
            get { return _vNombre; }
            set { _vNombre = value; }
        }
        private string _vNombre;
    }
}