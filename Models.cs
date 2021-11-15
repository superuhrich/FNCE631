using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNCE631 {
	class Models {
	}

	public class CryptoRecord {
		public int unixDate {get; set;}
		public DateTime date {get; set;}
		public string symbol {get; set;}
		public double open {get; set;}
		public double high {get; set;}
		public double low {get; set;}
		public double close {get; set;}
		public double volumeCoin {get; set;}
		public double volumeUSD {get; set;}
		public string signal {get; set;}
		public double portfolioValue {get; set;}
		public double coins {get; set;}
	}


	public class CryptoRecordMovingAverage: CryptoRecord {
		public double movingAverage {get; set;}

	}

	public class CryptoRecordNM: CryptoRecord {
		public double movingAverageN {get; set;}
		public double movingAverageM {get; set;}
	}

	public class CryptoRecordExp:CryptoRecord {
		public double expMovingAverage {get; set;}
		public double simpleMovingAverage {get; set;}
	}
}
