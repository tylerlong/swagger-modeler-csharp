using Newtonsoft.Json;
using System;

namespace RingCentral.Models.Common
{
    public class PagingInfo
    {

        [JsonProperty("page")]
        public int Page;

        [JsonProperty("perPage")]
        public int PerPage;

        [JsonProperty("pageStart")]
        public int PageStart;

        [JsonProperty("pageEnd")]
        public int PageEnd;

        [JsonProperty("totalPages")]
        public int TotalPages;

        [JsonProperty("totalElements")]
        public int TotalElements;

    }
}
