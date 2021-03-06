using System.Threading;

namespace Couchbase.Management.Collections
{
    public class GetScopeOptions
    {
        public CancellationToken CancellationToken { get; set; }

        public GetScopeOptions WithCancellationToken(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            return this;
        }

        public static GetScopeOptions Default => new GetScopeOptions();
    }
}
