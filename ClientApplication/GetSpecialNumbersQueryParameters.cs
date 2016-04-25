using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class GetSpecialNumbersQueryParameters
    {

        [JsonProperty("countryId")]
        public int CountryId;

    }
}
