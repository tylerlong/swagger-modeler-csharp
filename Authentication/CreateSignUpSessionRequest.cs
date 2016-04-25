using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Authentication
{
    public class CreateSignUpSessionRequest
    {

        [JsonProperty("access_token_ttl")]
        public int AccessTokenTtl;

        [JsonProperty("brand_id")]
        public int BrandId;

        [JsonProperty("endpoint_id")]
        public string EndpointId;

        [JsonProperty("grant_type")]
        public string GrantType;

    }
}
