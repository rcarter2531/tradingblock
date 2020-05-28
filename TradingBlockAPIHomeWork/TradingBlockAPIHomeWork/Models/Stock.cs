using System;
using System.Collections.Generic;
namespace TradingBlockAPIHomeWork.Models
{
    public class Stock
    {
            public string symbol { get; set; }
            public string companyName { get; set; }
            public string primaryExchange { get; set; }
            public string calculationPrice { get; set; }
            
            public double iexClose { get; set; }
            public int iexCloseTime { get; set; }
            public int marketCap { get; set; }
            public double peRatio { get; set; }
            public double week52High { get; set; }
            public double week52Low { get; set; }
            public double ytdChange { get; set; }
            public int lastTradeTime { get; set; }
            public bool isUSMarketOpen { get; set; }

    }
}
