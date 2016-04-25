using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Authentication
{
    public class TokenInfo
    {

        [JsonProperty("access_token")]
        public string AccessToken;

        [JsonProperty("endpoint_id")]
        public string EndpointId;

        [JsonProperty("expires_in")]
        public int ExpiresIn;

        [JsonProperty("owner_id")]
        public string OwnerId;

        [JsonProperty("refresh_token")]
        public string RefreshToken;

        [JsonProperty("refresh_token_expires_in")]
        public int RefreshTokenExpiresIn;

        [JsonProperty("scope")]
        public string Scope;

        [JsonProperty("token_type")]
        public string TokenType;

    }
}
