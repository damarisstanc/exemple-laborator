using System;
using System.Runtime.Serialization;

namespace PSSC_Cos_de_cumparaturi.Domain
{
    [Serializable]
    
    internal class InvalidAddress : Exception
    {
        public InvalidAddress()
        {
        }

        public InvalidAddress(string? message) : base(message)
        {
        }

        public InvalidAddress(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidAddress(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
