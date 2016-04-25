using Newtonsoft.Json;
using System;

namespace RingCentral.Models.CallLog
{
    public class CallerInfo
    {

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("location")]
        public string Location;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
