using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Devices
{
    public class ModelInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("addons")]
        public string[] Addons;

        [JsonProperty("count")]
        public int Count;

    }
}
