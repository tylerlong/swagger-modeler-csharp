using Newtonsoft.Json;
using System;

namespace RingCentral.Models.PhoneNumberPool
{
    public class ReserveNumbersResponse
    {

        [JsonProperty("records")]
        public ReserveRecord[] Records;

    }
}
