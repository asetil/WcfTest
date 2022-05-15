using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace CalculatorService.Model
{
    [DataContract]
    public class CalculateItem
    {
        [DataMember]
        public string Operation { get; set; }

        [DataMember]
        public List<int> ValueList { get; set; }
    }
}