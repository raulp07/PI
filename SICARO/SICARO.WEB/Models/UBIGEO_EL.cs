using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class UBIGEO_EL
    {
        ///

        /// Gets or Sets vCodDpto
        ///
        public string vCodDpto
        {
            get { return _vCodDpto; }
            set { _vCodDpto = value; }
        }
        private string _vCodDpto;

        ///

        /// Gets or Sets vCodProv
        ///
        public string vCodProv
        {
            get { return _vCodProv; }
            set { _vCodProv = value; }
        }
        private string _vCodProv;

        ///

        /// Gets or Sets vCodDist
        ///
        public string vCodDist
        {
            get { return _vCodDist; }
            set { _vCodDist = value; }
        }
        private string _vCodDist;

        ///

        /// Gets or Sets vNombre
        ///
        public string vNombre
        {
            get { return _vNombre; }
            set { _vNombre = value; }
        }
        private string _vNombre;
    }
}