using Newtonsoft.Json;
using System;

namespace RingCentral.Models.RingOut
{
    public class RingOutStatusInfo
    {

        [JsonProperty("callStatus")]
        public string CallStatus;

        [JsonProperty("calleeStatus")]
        public string CalleeStatus;

        [JsonProperty("callerStatus")]
        public string CallerStatus;

    }
}
