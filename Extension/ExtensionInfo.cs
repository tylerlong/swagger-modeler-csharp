using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Extension
{
    public class ExtensionInfo
    {

        [JsonProperty("contact")]
        public ContactInfo Contact;

        [JsonProperty("departments")]
        public DepartmentInfo Departments;

        [JsonProperty("extensionNumber")]
        public string ExtensionNumber;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("partnerId")]
        public string PartnerId;

        [JsonProperty("permissions")]
        public ExtensionPermissions Permissions;

        [JsonProperty("profileImage")]
        public ProfileImageInfo ProfileImage;

        [JsonProperty("references")]
        public ReferenceInfo[] References;

        [JsonProperty("regionalSettings")]
        public RegionalSettings RegionalSettings;

        [JsonProperty("serviceFeatures")]
        public ExtensionServiceFeatureInfo[] ServiceFeatures;

        [JsonProperty("setupWizardState")]
        public string SetupWizardState;

        [JsonProperty("status")]
        public string Status;

        [JsonProperty("statusInfo")]
        public StatusInfo StatusInfo;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("uri")]
        public string Uri;

    }
}
