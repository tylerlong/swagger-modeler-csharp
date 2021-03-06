using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberParser
{
    public class PhoneNumberInfo
    {

        [JsonProperty("areaCode")]
        public string AreaCode;

        [JsonProperty("country")]
        public CountryInfo[] Country;

        [JsonProperty("dialable")]
        public string Dialable;

        [JsonProperty("e164")]
        public string E164;

        [JsonProperty("formattedInternational")]
        public string FormattedInternational;

        [JsonProperty("formattedNational")]
        public string FormattedNational;

        [JsonProperty("normalized")]
        public string Normalized;

        [JsonProperty("originalString")]
        public string OriginalString;

        [JsonProperty("special")]
        public boolean Special;

    }
}
