using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class REPRESENTANTE_EL
    {

        ///

        /// Gets or Sets iIdRepresentante
        ///
        [DataMember]
        public int iIdRepresentante
        {
            get { return _iIdRepresentante; }
            set { _iIdRepresentante = value; }
        }
        private int _iIdRepresentante;

        ///

        /// Gets or Sets iIdProveedor
        ///
        [DataMember]
        public int iIdProveedor
        {
            get { return _iIdProveedor; }
            set { _iIdProveedor = value; }
        }
        private int _iIdProveedor;

        ///

        /// Gets or Sets vNombreRepresentante
        ///
        [DataMember]
        public string vNombreRepresentante
        {
            get { return _vNombreRepresentante; }
            set { _vNombreRepresentante = value; }
        }
        private string _vNombreRepresentante;

        ///

        /// Gets or Sets vApellidoPaternoRepresentante
        ///
        [DataMember]
        public string vApellidoPaternoRepresentante
        {
            get { return _vApellidoPaternoRepresentante; }
            set { _vApellidoPaternoRepresentante = value; }
        }
        private string _vApellidoPaternoRepresentante;

        ///

        /// Gets or Sets vApellidoMaternoRepresentante
        ///
        [DataMember]
        public string vApellidoMaternoRepresentante
        {
            get { return _vApellidoMaternoRepresentante; }
            set { _vApellidoMaternoRepresentante = value; }
        }
        private string _vApellidoMaternoRepresentante;

        ///

        /// Gets or Sets cDNI
        ///
        [DataMember]
        public string cDNI
        {
            get { return _cDNI; }
            set { _cDNI = value; }
        }
        private string _cDNI;

        ///

        /// Gets or Sets vCelular
        ///
        [DataMember]
        public string vCelular
        {
            get { return _vCelular; }
            set { _vCelular = value; }
        }
        private string _vCelular;

        ///

        /// Gets or Sets iTipoRepresentante
        ///
        [DataMember]
        public int iTipoRepresentante
        {
            get { return _iTipoRepresentante; }
            set { _iTipoRepresentante = value; }
        }
        private int _iTipoRepresentante;

        ///

        /// Gets or Sets iUsuarioCrea
        ///
        [DataMember]
        public int iUsuarioCrea
        {
            get { return _iUsuarioCrea; }
            set { _iUsuarioCrea = value; }
        }
        private int _iUsuarioCrea;

        ///

        /// Gets or Sets dFechaCrea
        ///
        [DataMember]
        public DateTime dFechaCrea
        {
            get { return _dFechaCrea; }
            set { _dFechaCrea = value; }
        }
        private DateTime _dFechaCrea;

        ///

        /// Gets or Sets iUsuarioMod
        ///
        [DataMember]
        public int iUsuarioMod
        {
            get { return _iUsuarioMod; }
            set { _iUsuarioMod = value; }
        }
        private int _iUsuarioMod;

        ///

        /// Gets or Sets dFechaMod
        ///
        [DataMember]
        public DateTime dFechaMod
        {
            get { return _dFechaMod; }
            set { _dFechaMod = value; }
        }
        private DateTime _dFechaMod;
    }
}