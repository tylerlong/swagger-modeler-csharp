using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Conferencing
{
    public class GetConferencingInfoResponse
    {

        [JsonProperty("allowJoinBeforeHost")]
        public boolean AllowJoinBeforeHost;

        [JsonProperty("hostCode")]
        public string HostCode;

        [JsonProperty("mode")]
        public string Mode;

        [JsonProperty("participantCode")]
        public string ParticipantCode;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

        [JsonProperty("phoneNumbers")]
        public PhoneNumberInfo[] PhoneNumbers;

        [JsonProperty("tapToJoinUri")]
        public string TapToJoinUri;

        [JsonProperty("uri")]
        public string Uri;

    }
}
