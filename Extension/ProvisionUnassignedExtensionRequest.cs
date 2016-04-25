using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class ProvisionUnassignedExtensionRequest
    {

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("contact")]
        public CompactContactInfo Contact;

    }
}
