using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class CompactDevice
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("appExternalId")]
        public string AppExternalId;

        [JsonProperty("computerName")]
        public string ComputerName;

    }
}
