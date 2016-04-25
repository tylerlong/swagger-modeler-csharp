using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class SecretQuestionInfo
    {

        [JsonProperty("id")]
        public string Id;

        [JsonProperty("languageId")]
        public string LanguageId;

        [JsonProperty("questionText")]
        public string QuestionText;

        [JsonProperty("questionType")]
        public int QuestionType;

        [JsonProperty("showInSignUp")]
        public boolean ShowInSignUp;

    }
}
