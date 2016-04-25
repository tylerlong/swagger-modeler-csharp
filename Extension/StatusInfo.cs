using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class StatusInfo
    {

        [JsonProperty("comment")]
        public string Comment;

        [JsonProperty("reason")]
        public string Reason;

    }
}
