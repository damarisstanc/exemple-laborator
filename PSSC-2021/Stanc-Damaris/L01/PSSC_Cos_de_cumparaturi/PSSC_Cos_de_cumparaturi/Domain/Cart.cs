using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSSC_Cos_de_cumparaturi.Domain
{
    [AsChoice]
    public static partial class Cart
    {
        public interface ICart { }

        public record EmptyCart(IReadOnlyCollection<UnvalidatedClient> CartList) : ICart;

        public record UnvalidatedCart(IReadOnlyCollection<UnvalidatedClient> CartList, string reason) : ICart;

        public record ValidatedCart(IReadOnlyCollection<ValidatedClient> CartList) : ICart;

        public record SoldCart(IReadOnlyCollection<ValidatedClient> CartList) : ICart;
    }
}
