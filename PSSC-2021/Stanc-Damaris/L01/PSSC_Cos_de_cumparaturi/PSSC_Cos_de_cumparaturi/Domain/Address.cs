using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PSSC_Cos_de_cumparaturi.Domain
{
    class Address
    {
        private static readonly Regex ValidPattern = new("^[A-Za-z0-9, .]+$");

        public string Value { get; }

        private Address(string value)
        {
            if (ValidPattern.IsMatch(value))
            {
                Value = value;
            }
            else
            {
                throw new InvalidAddress("");  
            }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
