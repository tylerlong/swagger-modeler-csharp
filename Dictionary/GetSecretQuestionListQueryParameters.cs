using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Dictionary
{
    public class GetSecretQuestionListQueryParameters
    {

        [JsonProperty("signupOnly")]
        public boolean SignupOnly;

    }
}
