using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PushNotifications
{
    public class DeliveryMode
    {

        [JsonProperty("address")]
        public string Address;

        [JsonProperty("encryption")]
        public boolean Encryption;

        [JsonProperty("encryptionAlgorithm")]
        public string EncryptionAlgorithm;

        [JsonProperty("encryptionKey")]
        public string EncryptionKey;

        [JsonProperty("secretKey")]
        public string SecretKey;

        [JsonProperty("subscriberKey")]
        public string SubscriberKey;

        [JsonProperty("transportType")]
        public string TransportType;

    }
}
