using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICARO.WEB.Models
{
    public class PROVEEDOR_EL
    {
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

        /// Gets or Sets vNombreProveedor
        ///
        public string vNombreProveedor
        {
            get { return _vNombreProveedor; }
            set { _vNombreProveedor = value; }
        }
        private string _vNombreProveedor;

        ///

        /// Gets or Sets vRUC
        ///
        public string vRUC
        {
            get { return _vRUC; }
            set { _vRUC = value; }
        }
        private string _vRUC;

        ///

        /// Gets or Sets vTelefono
        ///
        public string vTelefono
        {
            get { return _vTelefono; }
            set { _vTelefono = value; }
        }
        private string _vTelefono;

        ///

        /// Gets or Sets vNroLicenciaMunicipal
        ///
        public string vNroLicenciaMunicipal
        {
            get { return _vNroLicenciaMunicipal; }
            set { _vNroLicenciaMunicipal = value; }
        }
        private string _vNroLicenciaMunicipal;

        ///

        /// Gets or Sets vNroInspeccionSanitaria
        ///
        public string vNroInspeccionSanitaria
        {
            get { return _vNroInspeccionSanitaria; }
            set { _vNroInspeccionSanitaria = value; }
        }
        private string _vNroInspeccionSanitaria;

        ///

        /// Gets or Sets iEstadoEmpresa
        ///
        public int iEstadoEmpresa
        {
            get { return _iEstadoEmpresa; }
            set { _iEstadoEmpresa = value; }
        }
        private int _iEstadoEmpresa;

        ///

        /// Gets or Sets iTipoEmpresa
        ///
        public int iTipoEmpresa
        {
            get { return _iTipoEmpresa; }
            set { _iTipoEmpresa = value; }
        }
        private int _iTipoEmpresa;

        ///

        /// Gets or Sets iUbigeo
        ///
        public int iUbigeo
        {
            get { return _iUbigeo; }
            set { _iUbigeo = value; }
        }
        private int _iUbigeo;

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