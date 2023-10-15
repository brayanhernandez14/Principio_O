using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ArdalisRating
{
    public class PolicyLoader
    {
        public string LoadPolicyFromJsonFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
