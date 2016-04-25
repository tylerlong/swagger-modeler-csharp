using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Reporting
{
    public class SchedulesInfo
    {

        [JsonProperty("scheduleId")]
        public string ScheduleId;

        [JsonProperty("recurrence")]
        public RecurrenceInfo[] Recurrence;

        [JsonProperty("viewType")]
        public string ViewType;

        [JsonProperty("attachments")]
        public AttachmentInfo[] Attachments;

        [JsonProperty("pages")]
        public string[] Pages;

        [JsonProperty("recipients")]
        public string[] Recipients;

    }
}
