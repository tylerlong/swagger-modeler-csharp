using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Account
{
    public class AccountLimits
    {

        [JsonProperty("freeSoftPhoneLinesPerExtension")]
        public int FreeSoftPhoneLinesPerExtension;

        [JsonProperty("maxMonitoredExtensionsPerUser")]
        public int MaxMonitoredExtensionsPerUser;

        [JsonProperty("meetingSize")]
        public int MeetingSize;

    }
}
