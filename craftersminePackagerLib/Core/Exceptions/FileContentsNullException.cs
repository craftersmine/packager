using System;
using System.Runtime.Serialization;

namespace craftersmine.Packager.Lib.Core.Exceptions
{
    /// <summary>
    /// Throws if readed file haven't data to be written or null
    /// </summary>
    [Serializable]
    public class FileContentsNullException : Exception
    {
        public FileContentsNullException()
        {
        }

        public FileContentsNullException(string message) : base(message)
        {
        }

        public FileContentsNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FileContentsNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}