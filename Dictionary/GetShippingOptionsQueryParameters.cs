using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class GetShippingOptionsQueryParameters
    {

        [JsonProperty("brandId")]
        public int BrandId;

        [JsonProperty("quantity")]
        public int Quantity;

        [JsonProperty("servicePlanId")]
        public int ServicePlanId;

    }
}
