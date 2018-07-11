using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class PERSONAL_EL
    {

        ///

        /// Gets or Sets iIdPersonal
        ///
        [DataMember]
        public int iIdPersonal
        {
            get { return _iIdPersonal; }
            set { _iIdPersonal = value; }
        }
        private int _iIdPersonal;

        ///

        /// Gets or Sets vCodPersonal
        ///
        [DataMember]
        public string vCodPersonal
        {
            get { return _vCodPersonal; }
            set { _vCodPersonal = value; }
        }
        private string _vCodPersonal;

        ///

        /// Gets or Sets vNombrePersonal
        ///
        [DataMember]
        public string vNombrePersonal
        {
            get { return _vNombrePersonal; }
            set { _vNombrePersonal = value; }
        }
        private string _vNombrePersonal;

        ///

        /// Gets or Sets vApellidoPaternoPersonal
        ///
        [DataMember]
        public string vApellidoPaternoPersonal
        {
            get { return _vApellidoPaternoPersonal; }
            set { _vApellidoPaternoPersonal = value; }
        }
        private string _vApellidoPaternoPersonal;

        ///

        /// Gets or Sets vApellidoMaternoPersonal
        ///
        [DataMember]
        public string vApellidoMaternoPersonal
        {
            get { return _vApellidoMaternoPersonal; }
            set { _vApellidoMaternoPersonal = value; }
        }
        private string _vApellidoMaternoPersonal;

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

        /// Gets or Sets dFechaNacimiento
        ///
        [DataMember]
        public DateTime dFechaNacimiento
        {
            get { return _dFechaNacimiento; }
            set { _dFechaNacimiento = value; }
        }
        private DateTime _dFechaNacimiento;

        ///

        /// Gets or Sets vDomicilio
        ///
        [DataMember]
        public string vDomicilio
        {
            get { return _vDomicilio; }
            set { _vDomicilio = value; }
        }
        private string _vDomicilio;

        ///

        /// Gets or Sets iIdArea
        ///
        [DataMember]
        public int iIdArea
        {
            get { return _iIdArea; }
            set { _iIdArea = value; }
        }
        private int _iIdArea;

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

        /// Gets or Sets iTipoPersonal
        ///
        [DataMember]
        public int iTipoPersonal
        {
            get { return _iTipoPersonal; }
            set { _iTipoPersonal = value; }
        }
        private int _iTipoPersonal;

        ///

        /// Gets or Sets iEstadoPersonal
        ///
        [DataMember]
        public int iEstadoPersonal
        {
            get { return _iEstadoPersonal; }
            set { _iEstadoPersonal = value; }
        }
        private int _iEstadoPersonal;

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