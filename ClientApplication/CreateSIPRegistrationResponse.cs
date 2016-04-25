using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class CreateSIPRegistrationResponse
    {

        [JsonProperty("device")]
        public Device Device;

        [JsonProperty("sipInfo")]
        public SIPInfo[] SipInfo;

        [JsonProperty("sipFlags")]
        public SIPFlags SipFlags;

    }
}
