using System;
using System.Runtime.Serialization;

namespace craftersmine.Packager.Lib.Core.Exceptions
{
    /// <summary>
    /// Throws if package have invalid or unsupported packager verion
    /// </summary>
    [Serializable]
    public class InvalidVersionException : Exception
    {
        private int version;
        public int PackageVersion { get { return version; } }

        public InvalidVersionException()
        {
        }

        public InvalidVersionException(int version)
        {
            this.version = version;
        }

        public InvalidVersionException(string message) : base(message)
        {
        }

        public InvalidVersionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidVersionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}