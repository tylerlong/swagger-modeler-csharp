using Newtonsoft.Json;
using System;

namespace RingCentral.Models.AddressBook
{
    public class PersonalContactInfo
    {

        [JsonProperty("assistantPhone")]
        public string AssistantPhone;

        [JsonProperty("availability")]
        public string Availability;

        [JsonProperty("birthday")]
        public string Birthday;

        [JsonProperty("businessAddress")]
        public ContactAddressInfo BusinessAddress;

        [JsonProperty("businessFax")]
        public string BusinessFax;

        [JsonProperty("businessPhone")]
        public string BusinessPhone;

        [JsonProperty("businessPhone2")]
        public string BusinessPhone2;

        [JsonProperty("callbackPhone")]
        public string CallbackPhone;

        [JsonProperty("carPhone")]
        public string CarPhone;

        [JsonProperty("company")]
        public string Company;

        [JsonProperty("companyPhone")]
        public string CompanyPhone;

        [JsonProperty("email")]
        public string Email;

        [JsonProperty("email2")]
        public string Email2;

        [JsonProperty("email3")]
        public string Email3;

        [JsonProperty("firstName")]
        public string FirstName;

        [JsonProperty("homeAddress")]
        public ContactAddressInfo HomeAddress;

        [JsonProperty("homePhone")]
        public string HomePhone;

        [JsonProperty("homePhone2")]
        public string HomePhone2;

        [JsonProperty("id")]
        public int Id;

        [JsonProperty("jobTitle")]
        public string JobTitle;

        [JsonProperty("lastName")]
        public string LastName;

        [JsonProperty("middleName")]
        public string MiddleName;

        [JsonProperty("mobilePhone")]
        public string MobilePhone;

        [JsonProperty("nickName")]
        public string NickName;

        [JsonProperty("notes")]
        public string Notes;

        [JsonProperty("otherAddress")]
        public ContactAddressInfo OtherAddress;

        [JsonProperty("otherFax")]
        public string OtherFax;

        [JsonProperty("otherPhone")]
        public string OtherPhone;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("webPage")]
        public string WebPage;

    }
}
