using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Domain.Entities
{
    [ServiceContract]
    public class FizzBuzzModel
    {
        [DataContract]
        public class FizzBuzzRequest
        {
            [DataMember]
            public int StartNumber { get; set; }
        }

        [DataContract]
        public class FizzBuzzResponse
        {
            [DataMember]
            public List<string> Series { get; set; }
        }
        
    }
}
