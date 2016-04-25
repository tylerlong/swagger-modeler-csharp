using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class UpdateContactInformationRequest
    {

        [JsonProperty("contact")]
        public ContactInfo Contact;

        [JsonProperty("regionalSettings")]
        public CompactRegionalSettings RegionalSettings;

        [JsonProperty("setupWizardState")]
        public string SetupWizardState;

        [JsonProperty("department")]
        public string Department;

    }
}
