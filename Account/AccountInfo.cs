using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class AccountInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("mainNumber")]
        public string MainNumber;

        [JsonProperty("operator")]
        public ExtensionInfo Operator;

        [JsonProperty("partnerId")]
        public string PartnerId;

        [JsonProperty("serviceInfo")]
        public ServiceInfo ServiceInfo;

        [JsonProperty("setupWizardState")]
        public string SetupWizardState;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("statusInfo")]
        public StatusInfo StatusInfo;

        [JsonProperty("uri")]
        public string Uri;

    }
}
