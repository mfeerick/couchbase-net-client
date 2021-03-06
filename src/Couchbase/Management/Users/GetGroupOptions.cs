using System.Threading;

namespace Couchbase.Management.Users
{
    public class GetGroupOptions
    {
        public CancellationToken CancellationToken { get; set; }

        public GetGroupOptions WithCancellationToken(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            return this;
        }

        public static GetGroupOptions Default => new GetGroupOptions();
    }
}
