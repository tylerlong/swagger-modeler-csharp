using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class RenewSubscriptionQueryParameters
    {

        [JsonProperty("aggregated")]
        public boolean Aggregated;

    }
}
