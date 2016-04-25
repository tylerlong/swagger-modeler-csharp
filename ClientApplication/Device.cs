using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class Device
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("serial")]
        public string Serial;

        [JsonProperty("computerName")]
        public string ComputerName;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("sku")]
        public string Sku;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("extension")]
        public ExtensionInfo Extension;

        [JsonProperty("phoneLines")]
        public PhoneLine[] PhoneLines;

    }
}
