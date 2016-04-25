using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Common
{
    public class LanguageInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("greeting")]
        public boolean Greeting;

        [JsonProperty("formattingLocale")]
        public boolean FormattingLocale;

        [JsonProperty("localeCode")]
        public string LocaleCode;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("ui")]
        public boolean Ui;

    }
}
