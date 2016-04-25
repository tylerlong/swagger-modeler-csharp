using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Conferencing
{
    public class PhoneNumberInfo
    {

        [JsonProperty("country")]
        public CountryInfo Country;

        [JsonProperty("default")]
        public boolean Default;

        [JsonProperty("hasGreeting")]
        public boolean HasGreeting;

        [JsonProperty("location")]
        public string Location;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
