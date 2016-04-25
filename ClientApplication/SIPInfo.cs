using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class SIPInfo
    {

        [JsonProperty("username")]
        public string Username;

        [JsonProperty("password")]
        public string Password;

        [JsonProperty("authorizationId")]
        public string AuthorizationId;

        [JsonProperty("domain")]
        public string Domain;

        [JsonProperty("outboundProxy")]
        public string OutboundProxy;

        [JsonProperty("transport")]
        public string Transport;

        [JsonProperty("certificate")]
        public string Certificate;

    }
}
