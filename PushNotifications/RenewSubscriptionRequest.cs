using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class RenewSubscriptionRequest
    {

        [JsonProperty("eventFilters")]
        public string[] EventFilters;

    }
}
