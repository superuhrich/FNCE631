using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNCE631.Methods {
	class BuyAndHold {

		/// <summary>
		/// Calculates the portfolio return of the MA method. 
		/// </summary>
		/// <param name="records"></param>
		/// <param name="seed"></param>
		/// <returns></returns>
		public static List<CryptoRecord> CalculateBuyHoldMethod(List<CryptoRecord> records, double seed) {

			// This is the simplest one,  buy on day one of records,  and hold till the end and then sell.  
			var initialCoins = seed/records[0].close;

			// Calculate the value of the portfolio on each day of the records
			for(var i = 0; i < records.Count; i++ ) {
				// We never change the number of coins we have
				records[i].coins = initialCoins;
				// And the value of the portfolio only changes with the value of coins. 
				records[i].portfolioValue = records[i].coins * records[i].close;
			}

			return records;
		}
	}
}
