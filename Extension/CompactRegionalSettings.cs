using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class CompactRegionalSettings
    {

        [JsonProperty("timezone")]
        public CompactTimezone Timezone;

        [JsonProperty("language")]
        public CompactLanguage Language;

        [JsonProperty("greetingLanguage")]
        public CompactGreetingLanguage GreetingLanguage;

        [JsonProperty("formattingLocale")]
        public CompactFormattingLocale FormattingLocale;

    }
}
