using System;
using System.Runtime.Serialization;

namespace craftersmine.Packager.Lib.Core.Exceptions
{
    /// <summary>
    /// Throws if readed file have invalid type or corrupted head
    /// </summary>
    [Serializable]
    public class InvalidFiletypeException : Exception
    {
        public InvalidFiletypeException()
        {
        }

        public InvalidFiletypeException(string message) : base(message)
        {
        }

        public InvalidFiletypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidFiletypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}