using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class PhoneNumberExtensionInfo
    {

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("partnerId")]
        public string PartnerId;

        [JsonProperty("uri")]
        public string Uri;

    }
}
