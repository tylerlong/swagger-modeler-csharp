using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class RecipientInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

    }
}
