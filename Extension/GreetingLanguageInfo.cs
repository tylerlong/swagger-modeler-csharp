using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class GreetingLanguageInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("localeCode")]
        public string LocaleCode;

        [JsonProperty("name")]
        public string Name;

    }
}
