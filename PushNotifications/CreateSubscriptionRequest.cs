using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class CreateSubscriptionRequest
    {

        [JsonProperty("deliveryMode")]
        public DeliveryMode DeliveryMode;

        [JsonProperty("eventFilters")]
        public string[] EventFilters;

    }
}
