using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberPool
{
    public class ReserveRecord
    {

        [JsonProperty("error")]
        public string Error;

        [JsonProperty("formattedNumber")]
        public string FormattedNumber;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("reservationId")]
        public string ReservationId;

        [JsonProperty("reservedTill")]
        public string ReservedTill;

        [JsonProperty("status")]
        public string Status;

    }
}
