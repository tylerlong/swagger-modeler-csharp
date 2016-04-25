using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Devices
{
    public class GetExtensionDeviceListResponse
    {

        [JsonProperty("records")]
        public DeviceInfo[] Records;

        [JsonProperty("navigation")]
        public NavigationInfo Navigation;

        [JsonProperty("paging")]
        public PagingInfo Paging;

    }
}
