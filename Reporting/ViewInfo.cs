using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Reporting
{
    public class ViewInfo
    {

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("pages")]
        public PagesInfo[] Pages;

        [JsonProperty("schedules")]
        public SchedulesInfo[] Schedules;

    }
}
