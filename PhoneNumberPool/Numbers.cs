using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberPool
{
    public class Numbers
    {

        [JsonProperty("records")]
        public PhoneNumberInfo[] Records;

        [JsonProperty("uri")]
        public string Uri;

    }
}
