using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Authentication
{
    public class RefreshTokenRequest
    {

        [JsonProperty("endpoint_id")]
        public string EndpointId;

        [JsonProperty("grant_type")]
        public string GrantType;

        [JsonProperty("refresh_token")]
        public string RefreshToken;

    }
}
