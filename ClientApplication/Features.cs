using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class Features
    {

        [JsonProperty("faxOut")]
        public OptionInfo FaxOut;

        [JsonProperty("ringOut")]
        public OptionInfo RingOut;

        [JsonProperty("sms")]
        public OptionInfo Sms;

        [JsonProperty("voip")]
        public OptionInfo Voip;

    }
}
