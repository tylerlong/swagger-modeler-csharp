using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Authentication
{
    public class CreateAccountCentricSessionRequest
    {

        [JsonProperty("access_token_ttl")]
        public int AccessTokenTtl;

        [JsonProperty("account_id")]
        public string AccountId;

        [JsonProperty("brand_id")]
        public int BrandId;

        [JsonProperty("endpoint_id")]
        public string EndpointId;

        [JsonProperty("grant_type")]
        public string GrantType;

        [JsonProperty("partner_account_id")]
        public string PartnerAccountId;

    }
}
