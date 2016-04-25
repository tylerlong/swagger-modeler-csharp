using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberPool
{
    public class PhoneNumberInfo
    {

        [JsonProperty("formattedNumber")]
        public string FormattedNumber;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("rank")]
        public int Rank;

        [JsonProperty("vanityPattern")]
        public string VanityPattern;

    }
}
