using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class CallerInfo
    {

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("faxErrorCode")]
        public string FaxErrorCode;

        [JsonProperty("location")]
        public string Location;

        [JsonProperty("messageStatus")]
        public string MessageStatus;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("phoneNumber")]
        public string PhoneNumber;

    }
}
