using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class SIPData
    {

        [JsonProperty("toTag")]
        public string ToTag;

        [JsonProperty("fromTag")]
        public string FromTag;

        [JsonProperty("remoteUri")]
        public string RemoteUri;

        [JsonProperty("localUri")]
        public string LocalUri;

    }
}
