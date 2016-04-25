using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberPool
{
    public class GetNumbersQueryParameters
    {

        [JsonProperty("areaCode")]
        public int AreaCode;

        [JsonProperty("countryCode")]
        public string CountryCode;

        [JsonProperty("countryId")]
        public string CountryId;

        [JsonProperty("exclude")]
        public string Exclude;

        [JsonProperty("extendedSearch")]
        public boolean ExtendedSearch;

        [JsonProperty("line")]
        public string Line;

        [JsonProperty("npa")]
        public string Npa;

        [JsonProperty("numberPattern")]
        public string NumberPattern;

        [JsonProperty("nxx")]
        public string Nxx;

        [JsonProperty("paymentType")]
        public string PaymentType;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("smsEnabled")]
        public boolean SmsEnabled;

    }
}
