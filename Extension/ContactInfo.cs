using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class ContactInfo
    {

        [JsonProperty("firstName")]
        public string FirstName;

        [JsonProperty("lastName")]
        public string LastName;

        [JsonProperty("company")]
        public string Company;

        [JsonProperty("email")]
        public string Email;

        [JsonProperty("businessPhone")]
        public string BusinessPhone;

        [JsonProperty("mobilePhone")]
        public string MobilePhone;

        [JsonProperty("businessAddress")]
        public ContactAddressInfo BusinessAddress;

    }
}
