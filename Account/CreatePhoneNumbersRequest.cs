using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class CreatePhoneNumbersRequest
    {

        [JsonProperty("extensionId")]
        public ExtensionInfo ExtensionId;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("reservationId")]
        public string ReservationId;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("usageType")]
        public string UsageType;

        [JsonProperty("vanityPattern")]
        public string VanityPattern;

    }
}
