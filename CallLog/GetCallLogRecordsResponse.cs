using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class GetCallLogRecordsResponse
    {

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

        [JsonProperty("records")]
        public CallLogRecord[] Records;

    }
}
