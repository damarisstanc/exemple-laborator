﻿using System;
using System.Runtime.Serialization;

namespace PSSC_Cos_de_cumparaturi.Domain
{
    [Serializable]

    internal class InvalidQuantity : Exception
    {
        public InvalidQuantity()
        {
        }

        public InvalidQuantity(string? message) : base(message)
        {
        }

        public InvalidQuantity(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidQuantity(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
