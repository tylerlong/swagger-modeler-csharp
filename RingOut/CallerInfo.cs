using Newtonsoft.Json;
using System;

namespace RingCentral.Models.RingOut
{
    public class CallerInfo
    {

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
