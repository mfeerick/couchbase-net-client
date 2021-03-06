using System;
using Couchbase.Core.Retry;

namespace Couchbase.KeyValue
{
    public class CollectionOutdatedException : Exception, IRetryable
    {
        public CollectionOutdatedException()
        {
        }

        public CollectionOutdatedException(string message) : base(message)
        {
        }

        public CollectionOutdatedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
