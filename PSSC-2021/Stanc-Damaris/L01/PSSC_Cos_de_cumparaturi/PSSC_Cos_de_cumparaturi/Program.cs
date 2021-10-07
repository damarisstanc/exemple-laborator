using PSSC_Cos_de_cumparaturi.Domain;
using System;
using System.Collections.Generic;
using static PSSC_Cos_de_cumparaturi.Domain.Cart;

namespace PSSC_Cos_de_cumparaturi
{
    class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            var listOfCarts = ReadListOfCarts().ToArray();
            UnvalidatedCart unvalidatedCart = new(listOfCarts);
            ICart result = ValidateCart(unvalidatedCart);
            result.Match(
                whenUnvalidatedCart: unvalidatedResult => unvalidatedCart,
                whenSoldCart: publishedResult => publishedResult,
                whenEmptyCart: invalidResult => invalidResult,
                whenValidatedCart: validatedResult => SoldCart(validatedResult)
            );

            Console.WriteLine("Hello World!");
        }

        private static List<UnvalidatedClient> ReadListOfCarts()
        {
            List<UnvalidatedClient> listOfCarts = new();
            do
            {
                //read registration number and grade and create a list of greads
                var productCode = ReadValue("Product Code: ");
                if (string.IsNullOrEmpty(productCode))
                {
                    break;
                }

                var quantity = ReadValue("Quantity: ");
                if (string.IsNullOrEmpty(quantity))
                {
                    break;
                }

                var address = ReadValue("Address: ");
                if (string.IsNullOrEmpty(address))
                {
                    break;
                }

                listOfCarts.Add(new(productCode, quantity, address));
            } while (true);
            return listOfCarts;
        }

        private static ICart ValidateCart(UnvalidatedCart unvalidatedCart) =>
            random.Next(100) > 50 ?
            new EmptyCart(new List<UnvalidatedClient>())
            : new ValidatedCart(new List<ValidatedClient>());

        private static ICart SoldCart(ValidatedCart validCart) =>
            new SoldCart(new List<ValidatedClient>());

        private static string? ReadValue(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
