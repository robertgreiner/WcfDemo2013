using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfInAction
{
    [DataContract]
    public class StringData
    {
        [DataMember]
        public string OriginalString { get; set; }
        [DataMember]
        public string FlippedCaseString { get; set; }
    }
}
