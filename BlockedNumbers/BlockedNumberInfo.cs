using Newtonsoft.Json;
using System;

namespace RingCentral.Models.BlockedNumbers
{
    public class BlockedNumberInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("uri")]
        public string Uri;

    }
}
