using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberParser
{
    public class ParsePhoneNumberRequest
    {

        [JsonProperty("originalStrings")]
        public string[] OriginalStrings;

    }
}
