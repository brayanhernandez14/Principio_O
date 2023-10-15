using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace ArdalisRating
{
    public class PolicyDeserializer
    {
        public Policy DeserializePolicy(string policyJson)
        {
            return JsonConvert.DeserializeObject<Policy>(policyJson, new StringEnumConverter());
        }
    }
}
