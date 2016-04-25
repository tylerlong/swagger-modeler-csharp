using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class CompactContactInfo
    {

        [JsonProperty("firstName")]
        public string FirstName;

        [JsonProperty("lastName")]
        public string LastName;

        [JsonProperty("email")]
        public string Email;

    }
}
