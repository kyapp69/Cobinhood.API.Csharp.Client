﻿using Cobinhood.API.Csharp.Client.Models.General;
using Newtonsoft.Json;

namespace Cobinhood.API.Csharp.Client.Models.Wallet
{
    public class AllDepositsInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("result")]
        public AllDepositsResult Result { get; set; }
        [JsonProperty("error")]
        public Error Error { get; set; }
    }

    public class AllDepositsResult
    {
        [JsonProperty("deposits")]
        public Deposit Deposits { get; set; }
    }
}
