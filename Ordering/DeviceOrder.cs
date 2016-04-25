using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Ordering
{
    public class DeviceOrder
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("devices")]
        public Devices.DeviceInfo[] Devices;

    }
}
