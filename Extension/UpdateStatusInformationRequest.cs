using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class UpdateStatusInformationRequest
    {

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("statusInfo")]
        public StatusInfo StatusInfo;

    }
}
