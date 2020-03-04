﻿using System;
using System.Runtime.Serialization;

namespace Contraly.Portal.Core.Exceptions
{
    [Serializable]
    public class ApiServerException : Exception
    {
        public ApiServerException()
        {
        }

        public ApiServerException(string message) : base(message)
        {
        }

        public ApiServerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApiServerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
