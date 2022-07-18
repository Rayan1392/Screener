using System;
namespace Model.Entities
{
	public class Candle
	{
        public long InsCode { get; set; }
        public string IsinCode { get; set; }
        public string Symbol { get; set; }
        public int Open { get; set; }
        public int High { get; set; }
        public int Low { get; set; }
        public int Close { get; set; }
        public int Last { get; set; }
        public long Vol { get; set; }
        public long Val { get; set; }
        public DateTime TradeDateTime { get; set; }
    }
}

