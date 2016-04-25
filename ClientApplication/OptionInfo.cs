using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class OptionInfo
    {

        [JsonProperty("enabled")]
        public boolean Enabled;

        [JsonProperty("reason")]
        public Reason[] Reason;

    }
}
