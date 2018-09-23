using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class ElementosSaliente
    {

        [DataMember]
        public stats stats { get; set; }

        [DataMember]
        public question_more_success question_more_success { get; set; }

        [DataMember]
        public question_less_success question_less_success { get; set; }


    }
}