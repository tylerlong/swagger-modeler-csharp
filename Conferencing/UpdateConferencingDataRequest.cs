using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Conferencing
{
    public class UpdateConferencingDataRequest
    {

        [JsonProperty("phoneNumbers")]
        public PhoneNumber[] PhoneNumbers;

        [JsonProperty("allowJoinBeforeHost")]
        public boolean AllowJoinBeforeHost;

    }
}
