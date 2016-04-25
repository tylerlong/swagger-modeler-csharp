using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class LocationInfo
    {

        [JsonProperty("areaCode")]
        public string AreaCode;

        [JsonProperty("city")]
        public string City;

        [JsonProperty("npa")]
        public string Npa;

        [JsonProperty("nxx")]
        public string Nxx;

        [JsonProperty("state")]
        public string State;

        [JsonProperty("uri")]
        public string Uri;

    }
}
