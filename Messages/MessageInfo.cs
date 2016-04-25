using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Messages
{
    public class MessageInfo
    {

        [JsonProperty("attachments")]
        public MessageAttachmentInfo[] Attachments;

        [JsonProperty("availability")]
        public string Availability;

        [JsonProperty("conversationId")]
        public long ConversationId;

        [JsonProperty("creationTime")]
        public string CreationTime;

        [JsonProperty("deliveryErrorCode")]
        public string DeliveryErrorCode;

        [JsonProperty("direction")]
        public string Direction;

        [JsonProperty("faxPageCount")]
        public int FaxPageCount;

        [JsonProperty("faxResolution")]
        public string FaxResolution;

        [JsonProperty("from")]
        public CallerInfo From;

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime;

        [JsonProperty("messageStatus")]
        public string MessageStatus;

        [JsonProperty("pgToDepartment")]
        public boolean PgToDepartment;

        [JsonProperty("priority")]
        public string Priority;

        [JsonProperty("readStatus")]
        public string ReadStatus;

        [JsonProperty("smsDeliveryTime")]
        public string SmsDeliveryTime;

        [JsonProperty("smsSendingAttemptsCount")]
        public int SmsSendingAttemptsCount;

        [JsonProperty("subject")]
        public string Subject;

        [JsonProperty("to")]
        public CallerInfo[] To;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("uri")]
        public string Uri;

        [JsonProperty("vmTranscriptionStatus")]
        public string VmTranscriptionStatus;

    }
}
