using Newtonsoft.Json;
using System;

namespace RingCentral.Models.ClientApplication
{
    public class ClientProvisioningWebURIs
    {

        [JsonProperty("appDownload")]
        public string AppDownload;

        [JsonProperty("appDownloadFile")]
        public string AppDownloadFile;

        [JsonProperty("expressSetupMobile")]
        public string ExpressSetupMobile;

        [JsonProperty("meetingsAppDownload")]
        public string MeetingsAppDownload;

        [JsonProperty("mobileWebBilling")]
        public string MobileWebBilling;

        [JsonProperty("mobileWebCallHandling")]
        public string MobileWebCallHandling;

        [JsonProperty("mobileWebInternationalCalling")]
        public string MobileWebInternationalCalling;

        [JsonProperty("mobileWebNotifications")]
        public string MobileWebNotifications;

        [JsonProperty("mobileWebPhoneSystem")]
        public string MobileWebPhoneSystem;

        [JsonProperty("mobileWebReporting")]
        public string MobileWebReporting;

        [JsonProperty("mobileWebResetPassword")]
        public string MobileWebResetPassword;

        [JsonProperty("mobileWebTellAFriend")]
        public string MobileWebTellAFriend;

        [JsonProperty("mobileWebTrialUpgrade")]
        public string MobileWebTrialUpgrade;

        [JsonProperty("mobileWebUserSettings")]
        public string MobileWebUserSettings;

        [JsonProperty("serviceWebBilling")]
        public string ServiceWebBilling;

        [JsonProperty("serviceWebHome")]
        public string ServiceWebHome;

        [JsonProperty("serviceWebPhoneSystem")]
        public string ServiceWebPhoneSystem;

        [JsonProperty("serviceWebResetPassword")]
        public string ServiceWebResetPassword;

        [JsonProperty("serviceWebTellAFriend")]
        public string ServiceWebTellAFriend;

        [JsonProperty("serviceWebUserSettings")]
        public string ServiceWebUserSettings;

        [JsonProperty("signUp")]
        public string SignUp;

        [JsonProperty("support")]
        public string Support;

    }
}
