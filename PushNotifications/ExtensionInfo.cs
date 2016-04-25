using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class ExtensionInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("lineId")]
        public string LineId;

    }
}
