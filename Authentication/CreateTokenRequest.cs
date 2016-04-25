using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Authentication
{
    public class CreateTokenRequest
    {

        [JsonProperty("grant_type")]
        public string GrantType;

        [JsonProperty("access_token_ttl")]
        public int AccessTokenTtl;

        [JsonProperty("refresh_token_ttl")]
        public int RefreshTokenTtl;

        [JsonProperty("username")]
        public string Username;

        [JsonProperty("extension")]
        public string Extension;

        [JsonProperty("password")]
        public string Password;

        [JsonProperty("scope")]
        public string Scope;

        [JsonProperty("endpoint_id")]
        public string EndpointId;

    }
}
