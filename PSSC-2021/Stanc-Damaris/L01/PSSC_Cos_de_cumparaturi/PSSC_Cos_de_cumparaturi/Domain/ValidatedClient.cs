using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_Cos_de_cumparaturi.Domain
{
    public record ValidatedClient(ProductCode ProductCode, Quantity Quantity, Address Address);
}
