using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Devices
{
    public class EmergencyAddressInfo
    {

        [JsonProperty("customerName")]
        public string CustomerName;

        [JsonProperty("street")]
        public string Street;

        [JsonProperty("street2")]
        public string Street2;

        [JsonProperty("city")]
        public string City;

        [JsonProperty("state")]
        public string State;

        [JsonProperty("zip")]
        public string Zip;

        [JsonProperty("country")]
        public string Country;

    }
}
