using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class CreateUpdateCustomDataRequest
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("value")]
        public string Value;

    }
}
