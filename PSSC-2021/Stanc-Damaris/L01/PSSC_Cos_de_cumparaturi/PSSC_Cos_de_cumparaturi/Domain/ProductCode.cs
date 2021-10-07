using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PSSC_Cos_de_cumparaturi.Domain
{
    class ProductCode
    {
        private static readonly Regex ValidPattern = new("^AZ[0-9]{9}$");

        public string Value { get; }

        private ProductCode(string value)
        {
            if (ValidPattern.IsMatch(value))
            {
                Value = value;
            }
            else
            {
                throw new InvalidProductCode(""); 
            }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
