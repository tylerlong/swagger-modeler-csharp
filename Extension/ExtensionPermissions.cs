using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class ExtensionPermissions
    {

        [JsonProperty("admin")]
        public PermissionInfo Admin;

        [JsonProperty("internationalCalling")]
        public PermissionInfo InternationalCalling;

    }
}
