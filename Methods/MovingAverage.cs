﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNCE631.Methods {
	static class MovingAverage {

		// Constants
		const string LONG_SIGNAL = "Long";
		const string SHORT_SIGNAL = "Short";

		/// <summary>
		/// This just converts things to the right class to use
		/// </summary>
		/// <param name="originalRecords"></param>
		/// <returns></returns>
		private static List<CryptoRecordMovingAverage> ConvertToClass(List<CryptoRecord> originalRecords ) {
			

			List<CryptoRecordMovingAverage> records = new List<CryptoRecordMovingAverage>();

			foreach(var record in originalRecords ) {
				var newRecord = new CryptoRecordMovingAverage{ 
					unixDate = record.unixDate,
					date = record.date,
					symbol = record.symbol,
					open = record.open,
					high = record.high,
					low = record.low,
					close = record.close,
					volumeCoin = record.volumeCoin,
					volumeUSD = record.volumeUSD
				};
				records.Add(newRecord);
			}

			return records;

		}

		/// <summary>
		/// Calculates the moving averages for N days
		/// </summary>
		/// <param name="records"></param>
		/// <param name="movingAverageDays"></param>
		private static void CalculateMovingAverage( List<CryptoRecordMovingAverage> records, int movingAverageDays) {
			for(var i = 0; i < records.Count; i++ ) {
				// Cant calculate a moving average for the days less than the value of moving average
				if(i < movingAverageDays-1) continue;

				// Sum the last X days. 
				double numerator = 0.0;
				for(var j = 0; j < movingAverageDays; j++ ) {
					numerator += records[i-j].close;
				}
				// divide it by the MA day count, and insert it into the object. 
				records[i].movingAverage = numerator/movingAverageDays;
			}
		}

		/// <summary>
		/// Calculates the portfolio return of the MA method. 
		/// </summary>
		/// <param name="originalRecords"></param>
		/// <param name="seed"></param>
		/// <param name="movingAverageDays"></param>
		/// <returns></returns>
		public static List<CryptoRecordMovingAverage> CalculateMAMethod(List<CryptoRecord> originalRecords, double seed, int movingAverageDays ) {

			// Get the records in the right object format.
			var records = ConvertToClass(originalRecords);

			CalculateMovingAverage(records, movingAverageDays);

			// Were starting with a long position
			var longPosition = true;
		
			// Since we start in a long position,  we will buy on the first iteration,  and use our entire seed to purchace coin. 
			var initialCoins = seed/records[0].close;

			// For each of the records...
			for(var i = 0; i < records.Count; i++ ) {
				// Check and see that we are far enough in the records,  if less than the number of days in the moving average, we will assume the long position still. 
				if(i < movingAverageDays-1 ) {
					// Initial Coins
					records[i].coins = initialCoins;
					// Initial portfolio value based off the close value of that day.
					records[i].portfolioValue = records[i].coins * records[i].close;
					// State we are still in a long position
					records[i].signal = LONG_SIGNAL;
				// If we are in the long position, and we want to maintain in that long position...
				} else if (longPosition && records[i].close > records[i].movingAverage) {
					// We will have the same number of coins...
					records[i].coins = records[i-1].coins;
					// And our value will update for that day
					records[i].portfolioValue = records[i].coins * records[i].close;
					// State we are still in a long position
					records[i].signal = LONG_SIGNAL;
				// If we are in a long position, and we do not want to maintain that position...	
				} else if (longPosition && records[i].close < records[i].movingAverage ) {
					// We will sell all the coin we have for that days close value...
					records[i].portfolioValue = records[i-1].coins * records[i].close;
					// Leaving us with no coins...
					records[i].coins = 0.0;
					// And changing our position to short
					longPosition = false;
					// Show that we are now in a short position
					records[i].signal = SHORT_SIGNAL;
				// If we are currently not long in position, and we want to be in a long position...
				} else if (!longPosition && records[i].close > records[i].movingAverage ) {
					// We buy all the coin we can with our value...
					records[i].coins = records[i-1].portfolioValue/records[i].close;
					// And the value of our portfolio is the same,  but the in equivalent coin of that day...
					records[i].portfolioValue = records[i].coins * records[i].close;
					// And we change our position. 
					longPosition = true;
					// Show that we are in a long position
					records[i].signal = LONG_SIGNAL;
				// If we are not in a long position,  and we want to retain this...
				} else if (!longPosition && records[i].close < records[i].movingAverage ) {
					// Our portfolio value does not change since we are holding cash...
					records[i].portfolioValue = records[i-1].portfolioValue;
					// and we will have the same number of coins as the day before....none. 
					records[i].coins = records[i-1].coins;
					// Show that we are in a short position. 
					records[i].signal = SHORT_SIGNAL;
				// If they are the same, do nothing, maintain the existing position, for both long and short positions
				} else if (longPosition && records[i].close == records[i].movingAverage ) {
					//In a long position,  we have coin,  so the value will change based on they day close, but the coins will stay the same
					records[i].coins = records[i-1].coins;
					records[i].portfolioValue = records[i].coins * records[i].close;
					records[i].signal = records[i-1].signal;
				} else if (!longPosition && records[i].close == records[i].movingAverage ) {
					// In a short position,  we have cash, but no coin... the value of the portfolio wont change, and we still have zero coin, same as day before. 
					records[i].coins = records[i-1].coins;
					records[i].portfolioValue = records[i-1].portfolioValue;
					records[i].signal = records[i-1].signal;
				}

			}		

			return records;
		}
		
	}
	
}
