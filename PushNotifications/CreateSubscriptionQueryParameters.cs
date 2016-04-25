using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class CreateSubscriptionQueryParameters
    {

        [JsonProperty("aggregated")]
        public boolean Aggregated;

    }
}
