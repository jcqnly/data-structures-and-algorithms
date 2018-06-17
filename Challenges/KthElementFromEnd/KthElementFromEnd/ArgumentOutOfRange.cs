using System;
using System.Runtime.Serialization;

namespace KthElementFromEnd
{
    [Serializable]
    internal class ArgumentOutOfRange : Exception
    {
        public ArgumentOutOfRange()
        {
        }

        public ArgumentOutOfRange(string message) : base(message)
        {
        }

        public ArgumentOutOfRange(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumentOutOfRange(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}