using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class UpdatePasswordPinRequest
    {

        [JsonProperty("ivrPin")]
        public string IvrPin;

        [JsonProperty("password")]
        public string Password;

    }
}
