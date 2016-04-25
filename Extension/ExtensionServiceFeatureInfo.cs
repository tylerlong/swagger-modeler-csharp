using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class ExtensionServiceFeatureInfo
    {

        [JsonProperty("enabled")]
        public boolean Enabled;

        [JsonProperty("featureName")]
        public string FeatureName;

        [JsonProperty("reason")]
        public string Reason;

    }
}
