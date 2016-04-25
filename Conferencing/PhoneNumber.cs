using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Conferencing
{
    public class PhoneNumber
    {

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("default")]
        public boolean Default;

    }
}
