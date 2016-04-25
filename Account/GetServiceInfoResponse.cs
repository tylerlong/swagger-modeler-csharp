using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class GetServiceInfoResponse
    {

        [JsonProperty("limits")]
        public AccountLimits[] Limits;

        [JsonProperty("serviceFeatures")]
        public ServiceFeatureInfo[] ServiceFeatures;

        [JsonProperty("servicePlanName")]
        public string ServicePlanName;

        [JsonProperty("uri")]
        public string Uri;

    }
}
