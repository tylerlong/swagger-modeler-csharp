using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Ordering
{
    public class CreateDeviceOrderRequest
    {

        [JsonProperty("devices")]
        public Devices.DeviceInfo[] Devices;

    }
}
