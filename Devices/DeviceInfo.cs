using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Devices
{
    public class DeviceInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("sku")]
        public string Sku;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("serial")]
        public string Serial;

        [JsonProperty("computerName")]
        public string ComputerName;

        [JsonProperty("model")]
        public ModelInfo Model;

        [JsonProperty("extension")]
        public ExtensionInfo Extension;

        [JsonProperty("emergencyServiceAddress")]
        public EmergencyAddressInfo EmergencyServiceAddress;

        [JsonProperty("phoneLines")]
        public PhoneLinesInfo PhoneLines;

        [JsonProperty("shipping")]
        public ShippingInfo Shipping;

        [JsonProperty("boxBillingId")]
        public int BoxBillingId;

    }
}
