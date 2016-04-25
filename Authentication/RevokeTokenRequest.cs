using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Authentication
{
    public class RevokeTokenRequest
    {

        [JsonProperty("token")]
        public string Token;

    }
}
