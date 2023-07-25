using System;
using System.Runtime.Serialization;

namespace SalesWebMvc.Controllers
{
    [Serializable]
    internal class NotFoundExceception : Exception
    {
        public NotFoundExceception()
        {
        }

        public NotFoundExceception(string message) : base(message)
        {
        }

        public NotFoundExceception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundExceception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}