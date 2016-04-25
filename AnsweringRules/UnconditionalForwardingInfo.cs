using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class UnconditionalForwardingInfo
    {

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
