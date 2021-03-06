using System;
using System.Net.Http;
using Couchbase.Core.Logging;
using Couchbase.Query;

namespace Couchbase.Diagnostics
{
    /// <summary>
    /// Tests a search URI that previously failed to see if it's back online again.
    /// </summary>
    internal class SearchUriTester : UriTesterBase
    {
        public SearchUriTester(HttpClient httpClient)
            : base(httpClient, LogManager.CreateLogger<SearchUriTester>())
        {
        }

        protected override string NodeType
        {
            get { return "Search"; }
        }

        protected override Uri GetPingUri(FailureCountingUri uri)
        {
            return new Uri(uri, "/api/ping");
        }
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2017 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion
