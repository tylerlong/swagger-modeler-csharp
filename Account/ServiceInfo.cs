using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class ServiceInfo
    {

        [JsonProperty("billingPlan")]
        public BillingPlanInfo BillingPlan;

        [JsonProperty("brand")]
        public BrandInfo Brand;

        [JsonProperty("servicePlan")]
        public ServicePlanInfo ServicePlan;

        [JsonProperty("targetServicePlan")]
        public TargetServicePlanInfo TargetServicePlan;

        [JsonProperty("uri")]
        public string Uri;

    }
}
