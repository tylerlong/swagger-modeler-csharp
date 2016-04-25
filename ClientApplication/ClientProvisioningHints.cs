using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class ClientProvisioningHints
    {

        [JsonProperty("appVersionUpgrade")]
        public ClientProvisioningHint AppVersionUpgrade;

        [JsonProperty("trialState")]
        public ClientProvisioningHint TrialState;

        [JsonProperty("userCredentialState")]
        public ClientProvisioningHint UserCredentialState;

    }
}
