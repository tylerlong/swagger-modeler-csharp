using Newtonsoft.Json;
using System;

namespace RingCentral.Models.RingOut
{
    public class RingOutInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("status")]
        public RingOutStatusInfo Status;

    }
}
