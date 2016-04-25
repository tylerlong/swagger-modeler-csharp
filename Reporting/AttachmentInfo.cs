using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Reporting
{
    public class AttachmentInfo
    {

        [JsonProperty("csv")]
        public boolean Csv;

        [JsonProperty("pdf")]
        public boolean Pdf;

    }
}
