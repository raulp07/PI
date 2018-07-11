using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class MATERIA_PRIMA_EL
    {
        ///

        /// Gets or Sets iIdMateriaPrima
        ///
        [DataMember]
        public int iIdMateriaPrima
        {
            get { return _iIdMateriaPrima; }
            set { _iIdMateriaPrima = value; }
        }
        private int _iIdMateriaPrima;

        ///

        /// Gets or Sets vCodMateriaPrima
        ///
        [DataMember]
        public string vCodMateriaPrima
        {
            get { return _vCodMateriaPrima; }
            set { _vCodMateriaPrima = value; }
        }
        private string _vCodMateriaPrima;

        ///

        /// Gets or Sets vNombreMateriaPrima
        ///
        [DataMember]
        public string vNombreMateriaPrima
        {
            get { return _vNombreMateriaPrima; }
            set { _vNombreMateriaPrima = value; }
        }
        private string _vNombreMateriaPrima;

        ///

        /// Gets or Sets vDescripcionMateriaPrima
        ///
        [DataMember]
        public string vDescripcionMateriaPrima
        {
            get { return _vDescripcionMateriaPrima; }
            set { _vDescripcionMateriaPrima = value; }
        }
        private string _vDescripcionMateriaPrima;

        ///

        /// Gets or Sets iOlorCS
        ///
        [DataMember]
        public int iOlorCS
        {
            get { return _iOlorCS; }
            set { _iOlorCS = value; }
        }
        private int _iOlorCS;

        ///

        /// Gets or Sets iColorCS
        ///
        [DataMember]
        public int iColorCS
        {
            get { return _iColorCS; }
            set { _iColorCS = value; }
        }
        private int _iColorCS;

        ///

        /// Gets or Sets iSaborCS
        ///
        [DataMember]
        public int iSaborCS
        {
            get { return _iSaborCS; }
            set { _iSaborCS = value; }
        }
        private int _iSaborCS;

        ///

        /// Gets or Sets iTexturaCS
        ///
        [DataMember]
        public int iTexturaCS
        {
            get { return _iTexturaCS; }
            set { _iTexturaCS = value; }
        }
        private int _iTexturaCS;

        ///

        /// Gets or Sets iBrixRF
        ///
        [DataMember]
        public int iBrixRF
        {
            get { return _iBrixRF; }
            set { _iBrixRF = value; }
        }
        private int _iBrixRF;

        ///

        /// Gets or Sets iPHRF
        ///
        [DataMember]
        public int iPHRF
        {
            get { return _iPHRF; }
            set { _iPHRF = value; }
        }
        private int _iPHRF;

        ///

        /// Gets or Sets iAcidesRF
        ///
        [DataMember]
        public int iAcidesRF
        {
            get { return _iAcidesRF; }
            set { _iAcidesRF = value; }
        }
        private int _iAcidesRF;

        ///

        /// Gets or Sets vRequisitosMicrobiolicos
        ///
        [DataMember]
        public string vRequisitosMicrobiolicos
        {
            get { return _vRequisitosMicrobiolicos; }
            set { _vRequisitosMicrobiolicos = value; }
        }
        private string _vRequisitosMicrobiolicos;

        ///

        /// Gets or Sets vRequisitoRotulado
        ///
        [DataMember]
        public string vRequisitoRotulado
        {
            get { return _vRequisitoRotulado; }
            set { _vRequisitoRotulado = value; }
        }
        private string _vRequisitoRotulado;

        ///

        /// Gets or Sets vRequisitosEmpaquetado
        ///
        [DataMember]
        public string vRequisitosEmpaquetado
        {
            get { return _vRequisitosEmpaquetado; }
            set { _vRequisitosEmpaquetado = value; }
        }
        private string _vRequisitosEmpaquetado;

        ///

        /// Gets or Sets vRequisitosPresentacion
        ///
        [DataMember]
        public string vRequisitosPresentacion
        {
            get { return _vRequisitosPresentacion; }
            set { _vRequisitosPresentacion = value; }
        }
        private string _vRequisitosPresentacion;

        ///

        /// Gets or Sets vCondicionFisicaEntrega
        ///
        [DataMember]
        public string vCondicionFisicaEntrega
        {
            get { return _vCondicionFisicaEntrega; }
            set { _vCondicionFisicaEntrega = value; }
        }
        private string _vCondicionFisicaEntrega;

        ///

        /// Gets or Sets vCondicionFisicaAlmacenamiento
        ///
        [DataMember]
        public string vCondicionFisicaAlmacenamiento
        {
            get { return _vCondicionFisicaAlmacenamiento; }
            set { _vCondicionFisicaAlmacenamiento = value; }
        }
        private string _vCondicionFisicaAlmacenamiento;

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