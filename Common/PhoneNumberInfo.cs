using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Common
{
    public class PhoneNumberInfo
    {

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("country")]
        public CountryInfo Country;

        [JsonProperty("extension")]
        public ExtensionInfo Extension;

        [JsonProperty("features")]
        public string[] Features;

        [JsonProperty("location")]
        public string Location;

        [JsonProperty("paymentType")]
        public string PaymentType;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("usageType")]
        public string UsageType;

    }
}
