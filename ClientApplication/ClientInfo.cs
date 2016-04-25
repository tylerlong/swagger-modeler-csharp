using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class ClientInfo
    {

        [JsonProperty("client")]
        public ClientApplicationInfo Client;

        [JsonProperty("provisioning")]
        public ClientProvisioningInfo Provisioning;

    }
}
