using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class CreateAccountRequest
    {

        [JsonProperty("mainNumber")]
        public string MainNumber;

        [JsonProperty("operator")]
        public ExtensionInfo Operator;

        [JsonProperty("partnerId")]
        public string PartnerId;

        [JsonProperty("promotionCode")]
        public string PromotionCode;

        [JsonProperty("reservationId")]
        public string ReservationId;

        [JsonProperty("serviceInfo")]
        public ServiceInfo ServiceInfo;

        [JsonProperty("status")]
        public string Status;

    }
}
