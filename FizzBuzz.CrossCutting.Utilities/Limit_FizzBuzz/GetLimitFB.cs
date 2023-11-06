using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CrossCutting.Utilities.Limit_FizzBuzz
{
    public class GetLimitFB : IGetLimitFB
    {
        public string GetLimit()
        {
            string Limit = ConfigurationManager.AppSettings["FizzBuzzLimit"];

            return Limit;
        }
    }
}
