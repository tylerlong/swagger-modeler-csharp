using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class UpdatePartnerIdRequest
    {

        [JsonProperty("partnerId")]
        public string PartnerId;

    }
}
