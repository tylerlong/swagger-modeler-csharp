using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AnsweringRules
{
    public class VoicemailInfo
    {

        [JsonProperty("enabled")]
        public boolean Enabled;

        [JsonProperty("recipient")]
        public RecipientInfo Recipient;

    }
}
