using System;
using System.Runtime.Serialization;

namespace craftersmine.Packager.Lib.Core.Exceptions
{
    /// <summary>
    /// Throws if readed package corrupted
    /// </summary>
    [Serializable]
    public class PackageCorruptedException : Exception
    {
        public PackageCorruptedException()
        {
        }

        public PackageCorruptedException(string message) : base(message)
        {
        }

        public PackageCorruptedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PackageCorruptedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}