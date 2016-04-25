using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class ExtensionInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("partnerId")]
        public string PartnerId;

    }
}
