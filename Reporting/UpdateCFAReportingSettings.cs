using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Reporting
{
    public class UpdateCFAReportingSettings
    {

        [JsonProperty("views")]
        public ViewInfo[] Views;

    }
}
