using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Ordering
{
    public class CreateDeviceOrderResponse
    {

        [JsonProperty("devices")]
        public Devices.DeviceInfo[] Devices;

    }
}
