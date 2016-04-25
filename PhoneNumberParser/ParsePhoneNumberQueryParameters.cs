using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberParser
{
    public class ParsePhoneNumberQueryParameters
    {

        [JsonProperty("homeCountry")]
        public string HomeCountry;

        [JsonProperty("nationalAsPriority")]
        public boolean NationalAsPriority;

    }
}
