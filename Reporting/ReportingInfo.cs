using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Reporting
{
    public class ReportingInfo
    {

        [JsonProperty("views")]
        public ViewInfo[] Views;

    }
}
