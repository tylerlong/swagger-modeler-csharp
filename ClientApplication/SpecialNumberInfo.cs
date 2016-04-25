using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class SpecialNumberInfo
    {

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("features")]
        public Features Features;

    }
}
