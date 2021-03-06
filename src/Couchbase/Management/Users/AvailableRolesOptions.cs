using System.Threading;

namespace Couchbase.Management.Users
{
    public class AvailableRolesOptions
    {
        public CancellationToken CancellationToken { get; set; }

        public AvailableRolesOptions WithCancellationToken(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            return this;
        }

        public static AvailableRolesOptions Default => new AvailableRolesOptions();
    }
}
