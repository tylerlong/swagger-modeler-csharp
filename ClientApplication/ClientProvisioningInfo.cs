using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class ClientProvisioningInfo
    {

        [JsonProperty("hints")]
        public ClientProvisioningHints Hints;

        [JsonProperty("webUris")]
        public ClientProvisioningWebURIs WebUris;

    }
}
