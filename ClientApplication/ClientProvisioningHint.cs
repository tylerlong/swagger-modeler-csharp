using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class ClientProvisioningHint
    {

        [JsonProperty("actionRequired")]
        public boolean ActionRequired;

        [JsonProperty("expiresIn")]
        public int ExpiresIn;

    }
}
