using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Authentication
{
    public class ClientCredentialsResponse
    {

        [JsonProperty("access_token")]
        public string AccessToken;

        [JsonProperty("endpoint_id")]
        public string EndpointId;

        [JsonProperty("expires_in")]
        public int ExpiresIn;

        [JsonProperty("scope")]
        public string Scope;

        [JsonProperty("token_type")]
        public string TokenType;

    }
}
