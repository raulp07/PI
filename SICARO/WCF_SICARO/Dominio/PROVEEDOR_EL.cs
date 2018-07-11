using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class PROVEEDOR_EL
    {
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

        /// Gets or Sets vNombreProveedor
        ///
        [DataMember]
        public string vNombreProveedor
        {
            get { return _vNombreProveedor; }
            set { _vNombreProveedor = value; }
        }
        private string _vNombreProveedor;

        ///

        /// Gets or Sets vRUC
        ///
        [DataMember]
        public string vRUC
        {
            get { return _vRUC; }
            set { _vRUC = value; }
        }
        private string _vRUC;

        ///

        /// Gets or Sets vTelefono
        ///
        [DataMember]
        public string vTelefono
        {
            get { return _vTelefono; }
            set { _vTelefono = value; }
        }
        private string _vTelefono;

        ///

        /// Gets or Sets vNroLicenciaMunicipal
        ///
        [DataMember]
        public string vNroLicenciaMunicipal
        {
            get { return _vNroLicenciaMunicipal; }
            set { _vNroLicenciaMunicipal = value; }
        }
        private string _vNroLicenciaMunicipal;

        ///

        /// Gets or Sets vNroInspeccionSanitaria
        ///
        [DataMember]
        public string vNroInspeccionSanitaria
        {
            get { return _vNroInspeccionSanitaria; }
            set { _vNroInspeccionSanitaria = value; }
        }
        private string _vNroInspeccionSanitaria;

        ///

        /// Gets or Sets iEstadoEmpresa
        ///
        [DataMember]
        public int iEstadoEmpresa
        {
            get { return _iEstadoEmpresa; }
            set { _iEstadoEmpresa = value; }
        }
        private int _iEstadoEmpresa;

        ///

        /// Gets or Sets iTipoEmpresa
        ///
        [DataMember]
        public int iTipoEmpresa
        {
            get { return _iTipoEmpresa; }
            set { _iTipoEmpresa = value; }
        }
        private int _iTipoEmpresa;

        ///

        /// Gets or Sets iUbigeo
        ///
        [DataMember]
        public int iUbigeo
        {
            get { return _iUbigeo; }
            set { _iUbigeo = value; }
        }
        private int _iUbigeo;

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