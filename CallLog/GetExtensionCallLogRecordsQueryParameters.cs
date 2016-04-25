using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class GetExtensionCallLogRecordsQueryParameters
    {

        [JsonProperty("dateFrom")]
        public string DateFrom;

        [JsonProperty("dateTo")]
        public string DateTo;

        [JsonProperty("direction")]
        public string Direction;

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("view")]
        public string View;

        [JsonProperty("withRecording")]
        public boolean WithRecording;

    }
}
