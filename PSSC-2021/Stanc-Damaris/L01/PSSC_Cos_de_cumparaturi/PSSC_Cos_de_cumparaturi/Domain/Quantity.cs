using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_Cos_de_cumparaturi.Domain
{
    class Quantity
    {
        public decimal Value { get; }

        public Quantity(decimal value)
        {
            if (value > 0 && value <= 10)
            {
                Value = value;
            }
            else
            {
                throw new InvalidQuantityException($"Maximum 10 pieces."); 
            }
        }
        public override string ToString()
        {
            return $"{Value:0.##}";
        }
    }
}
