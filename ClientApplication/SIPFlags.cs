using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class SIPFlags
    {

        [JsonProperty("voipFeatureEnabled")]
        public boolean VoipFeatureEnabled;

        [JsonProperty("voipCountryBlocked")]
        public boolean VoipCountryBlocked;

        [JsonProperty("outboundCallsEnabled")]
        public boolean OutboundCallsEnabled;

    }
}
