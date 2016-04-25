using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class UpdateBusinessAddressRequest
    {

        [JsonProperty("businessAddress")]
        public BusinessAddressInfo BusinessAddress;

        [JsonProperty("company")]
        public string Company;

        [JsonProperty("email")]
        public string Email;

    }
}
