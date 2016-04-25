using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class RegionalSettings
    {

        [JsonProperty("homeCountry")]
        public CountryInfo HomeCountry;

        [JsonProperty("timezone")]
        public TimezoneInfo Timezone;

        [JsonProperty("language")]
        public LanguageInfo Language;

        [JsonProperty("greetingLanguage")]
        public GreetingLanguageInfo GreetingLanguage;

        [JsonProperty("formattingLocale")]
        public FormattingLocaleInfo FormattingLocale;

    }
}
