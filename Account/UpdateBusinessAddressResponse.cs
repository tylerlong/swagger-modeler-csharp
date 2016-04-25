using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class UpdateBusinessAddressResponse
    {

        [JsonProperty("businessAddress")]
        public BusinessAddressInfo BusinessAddress;

        [JsonProperty("company")]
        public string Company;

        [JsonProperty("email")]
        public string Email;

        [JsonProperty("uri")]
        public string Uri;

    }
}
