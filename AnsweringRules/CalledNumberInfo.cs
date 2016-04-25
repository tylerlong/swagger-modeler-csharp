using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class CalledNumberInfo
    {

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
