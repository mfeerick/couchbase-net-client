using System.Threading;

namespace Couchbase.Management.Users
{
    public class GetAllGroupsOptions
    {
        public CancellationToken CancellationToken { get; set; }

        public GetAllGroupsOptions WithCancellationToken(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            return this;
        }

        public static GetAllGroupsOptions Default => new GetAllGroupsOptions();
    }
}
