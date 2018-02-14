﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Cobinhood.API.Csharp.Client.Models.Trading
{
    public class TradeHistoryInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("result")]
        public TradeHistoryResult Result { get; set; }
    }

    public class TradeHistoryResult
    {
        [JsonProperty("trades")]
        public IEnumerable<TradeDetail> Trades { get; set; }
    }
}
