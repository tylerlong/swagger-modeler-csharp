using Newtonsoft.Json;
using System;

namespace RingCentral.Models.RingOut
{
    public class MakeRingOutCallRequest
    {

        [JsonProperty("from")]
        public CallerInfoFrom From;

        [JsonProperty("to")]
        public CallerInfoTo To;

        [JsonProperty("callerId")]
        public CallerInfo CallerId;

        [JsonProperty("playPrompt")]
        public boolean PlayPrompt;

        [JsonProperty("country")]
        public CountryInfo Country;

    }
}
