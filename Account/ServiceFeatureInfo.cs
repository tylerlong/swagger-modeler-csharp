using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class ServiceFeatureInfo
    {

        [JsonProperty("enabled")]
        public boolean Enabled;

        [JsonProperty("featureName")]
        public string FeatureName;

    }
}
