using System;
using System.IO;
using System.Runtime.Serialization;

namespace BestPractices
{
    [Serializable]
    internal class CustomException : ApplicationException
    {
        private IOException ex;

        public CustomException()
        {
        }

        public CustomException(IOException ex)
        {
            this.ex = ex;
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}