using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class CompactDeliveryMode
    {

        [JsonProperty("encryption")]
        public boolean Encryption;

        [JsonProperty("transportType")]
        public string TransportType;

    }
}
