using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class Patient :Entity 
    {
        [DataMember]
        public string Name{ get;set;}
        [DataMember]
        public bool Male { get; set;}
        [DataMember]
        public long PESEL { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
    }
}
