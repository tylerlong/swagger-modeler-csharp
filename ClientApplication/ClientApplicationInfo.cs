using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class ClientApplicationInfo
    {

        [JsonProperty("appId")]
        public string AppId;

        [JsonProperty("appName")]
        public string AppName;

        [JsonProperty("appPlatform")]
        public string AppPlatform;

        [JsonProperty("appPlatformVersion")]
        public string AppPlatformVersion;

        [JsonProperty("appVersion")]
        public string AppVersion;

        [JsonProperty("detected")]
        public boolean Detected;

        [JsonProperty("locale")]
        public string Locale;

        [JsonProperty("userAgent")]
        public string UserAgent;

    }
}
