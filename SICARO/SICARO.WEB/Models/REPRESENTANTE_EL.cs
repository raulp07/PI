using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class REPRESENTANTE_EL
    {

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

        /// Gets or Sets iIdProveedor
        ///
        public int iIdProveedor
        {
            get { return _iIdProveedor; }
            set { _iIdProveedor = value; }
        }
        private int _iIdProveedor;

        ///

        /// Gets or Sets vNombreRepresentante
        ///
        public string vNombreRepresentante
        {
            get { return _vNombreRepresentante; }
            set { _vNombreRepresentante = value; }
        }
        private string _vNombreRepresentante;

        ///

        /// Gets or Sets vApellidoPaternoRepresentante
        ///
        public string vApellidoPaternoRepresentante
        {
            get { return _vApellidoPaternoRepresentante; }
            set { _vApellidoPaternoRepresentante = value; }
        }
        private string _vApellidoPaternoRepresentante;

        ///

        /// Gets or Sets vApellidoMaternoRepresentante
        ///
        public string vApellidoMaternoRepresentante
        {
            get { return _vApellidoMaternoRepresentante; }
            set { _vApellidoMaternoRepresentante = value; }
        }
        private string _vApellidoMaternoRepresentante;

        ///

        /// Gets or Sets cDNI
        ///
        public string cDNI
        {
            get { return _cDNI; }
            set { _cDNI = value; }
        }
        private string _cDNI;

        ///

        /// Gets or Sets vCelular
        ///
        public string vCelular
        {
            get { return _vCelular; }
            set { _vCelular = value; }
        }
        private string _vCelular;

        ///

        /// Gets or Sets iTipoRepresentante
        ///
        public int iTipoRepresentante
        {
            get { return _iTipoRepresentante; }
            set { _iTipoRepresentante = value; }
        }
        private int _iTipoRepresentante;

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