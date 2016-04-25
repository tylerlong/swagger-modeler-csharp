using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Conferencing
{
    public class GetConferencingInfoQueryParameters
    {

        [JsonProperty("countryId")]
        public string CountryId;

    }
}
