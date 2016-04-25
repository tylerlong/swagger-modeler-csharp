using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class SubscriptionInfo
    {

        [JsonProperty("creationTime")]
        public string CreationTime;

        [JsonProperty("deliveryMode")]
        public DeliveryMode DeliveryMode;

        [JsonProperty("eventFilters")]
        public string[] EventFilters;

        [JsonProperty("expirationTime")]
        public string ExpirationTime;

        [JsonProperty("expiresIn")]
        public int ExpiresIn;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("uri")]
        public string Uri;

    }
}
