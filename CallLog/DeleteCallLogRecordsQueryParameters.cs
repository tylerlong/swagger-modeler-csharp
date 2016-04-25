using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class DeleteCallLogRecordsQueryParameters
    {

        [JsonProperty("dateTo")]
        public string DateTo;

    }
}
