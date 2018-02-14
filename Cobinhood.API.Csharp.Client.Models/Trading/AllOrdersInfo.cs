﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Cobinhood.API.Csharp.Client.Models.Trading
{
    public class AllOrdersInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("result")]
        public AllOrdersResult Result { get; set; }
    }

    public class OrderDetail
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("trading_pair")]
        public string TradingPair { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("price")]
        public string Price { get; set; }
        [JsonProperty("size")]
        public string Size { get; set; }
        [JsonProperty("filled")]
        public string Filled { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("eq_price")]
        public string EqPrice { get; set; }
    }

    public class AllOrdersResult
    {
        [JsonProperty("orders")]
        public IList<OrderDetail> Orders { get; set; }
    }
}
