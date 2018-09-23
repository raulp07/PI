using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_SICARO.Dominio
{
    public class question_more_success
    {
        [DataMember]
        public string question { get; set; }

        [DataMember]
        public string evaluated { get; set; }
    }
}