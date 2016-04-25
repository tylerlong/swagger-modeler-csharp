using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class Reason
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("message")]
        public string Message;

    }
}
