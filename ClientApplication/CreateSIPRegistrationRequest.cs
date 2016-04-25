using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class CreateSIPRegistrationRequest
    {

        [JsonProperty("device")]
        public CompactDevice Device;

        [JsonProperty("sipInfo")]
        public CompactSIPInfo[] SipInfo;

    }
}
