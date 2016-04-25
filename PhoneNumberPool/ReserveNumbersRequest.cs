using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberPool
{
    public class ReserveNumbersRequest
    {

        [JsonProperty("records")]
        public ReserveRecord[] Records;

    }
}
