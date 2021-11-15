using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using FNCE631.Methods;

namespace FNCE631 {
	public partial class Form1:Form {

		// Input and output paths
		string path;
		string outPutFolder;
		string symbol;
		DateTime startDate;
		DateTime endDate;
		string outPutFileName;



		// The records
		List<CryptoRecord> records = new List<CryptoRecord>();

		public Form1() {
			InitializeComponent();
		}


		/// <summary>
		/// This just gets the data from the csv and gets the path to the right file. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click( object sender, EventArgs e ) {
			if ( CsvFileDialog.ShowDialog() == DialogResult.OK ) {
				tbFilePath.Text = CsvFileDialog.FileName;
				path = CsvFileDialog.FileName;
			}
		}

		/// <summary>
		/// This is just the dialog for the output file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOutPutDialog_Click( object sender, EventArgs e ) {
			if ( OutputFolderDialog.ShowDialog() == DialogResult.OK ) {
				tbOutputPath.Text = OutputFolderDialog.SelectedPath;
				outPutFolder = OutputFolderDialog.SelectedPath;
			}
		}


		// !!!!!!!!!!!!!!!!!!!Start Here!!!!!!!!!!!!!!
		private void btnPlotData_Click( object sender, EventArgs e ) {

			chrtCoinAndMa.Series["Value"].Points.Clear();
			// Check if we have a path for data...
			if ( path == null ) {
				// IF not...
				MessageBox.Show( "Input filepath not specified, dumbass." );
			} else {
				// If we do,  parse it out to a list
				records = ParseData();

				// Clear the legends for a new run
				ClearCharts();

				// Chart the initial values. 
				ChartValues( records );
			}
		}

		private void ClearCharts() {
			var seriesArray = new string[]{"Moving Average", "N-MA", "M-MA", "Exp-MA" };

			foreach ( var series in seriesArray ) {
				chrtCoinAndMa.Series[series].IsVisibleInLegend = false;
				chrtCoinAndMa.Series[series].Points.Clear();
			}

			chrtPortfolio.Series["Portfolio Value"].Points.Clear();
		}

		private List<CryptoRecord> ParseData() {
			string[] values = System.IO.File.ReadAllLines(path);
			var numSamples = values.Length;
			List<CryptoRecord> records = new List<CryptoRecord>();

			// Display the source data
			lblSource.Text = values[0];


			// The first two lines are headings that we dont care about,  we know what they are going to be since its constant. 
			for ( var i = 2; i < numSamples; i++ ) {
				// Split the comma deliniated values. 
				var data = values[i].Split(',');

				// If there is no data there yet,  dont keep it, some coins dont have 5 years of data to work with. 
				if ( data[3] == "0.0" && data[4] == "0.0" && data[5] == "0.0" && data[6] == "0.0" ) {
					continue;
				}

				// Create new objects for each line. 
				var record = new CryptoRecord();
				record.unixDate = Int32.Parse( data[0] );
				record.date = Convert.ToDateTime( data[1] );
				record.symbol = data[2];
				record.open = Convert.ToDouble( data[3] );
				record.high = Convert.ToDouble( data[4] );
				record.low = Convert.ToDouble( data[5] );
				record.close = Convert.ToDouble( data[6] );
				record.volumeCoin = Convert.ToDouble( data[7] );
				record.volumeUSD = Convert.ToDouble( data[8] );

				// Add it to our new Record List. 
				records.Add( record );
			}

			// Display the Symbol
			symbol = records[0].symbol;
			lblSymbol.Text = symbol;

			// Display the dates
			startDate = records.Min( x => x.date );

			endDate = records.Max( x => x.date );

			lblDates.Text = $"{startDate.ToString("d")}   to   {endDate.ToString("d")}";

			// We need to sort this so it is by oldest first. 
			var sortedRecords = records.OrderBy(x => x.unixDate).ToList();
			records = sortedRecords;

			// Let the user know we are done. 
			lblParseProgress.Text = "Parsing Complete";

			return records;
		}


		/// <summary>
		/// This shit just writes records to a csv
		/// </summary>
		/// <param name="records"></param>
		private void WriteRecords<T>( List<T> records ) {

			try {
				outPutFileName = tbExportFileName.Text;
				if ( outPutFileName == null || tbOutputPath == null ) {
					MessageBox.Show( "You need to specify a export file name and path, dumbass." );
				} else {
					// This shit just writes the data to a new csv

					var configuration = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);

					var streamOutputFilePath = $"{outPutFolder}\\{outPutFileName}.csv";

					using ( var writer = new StreamWriter( streamOutputFilePath ) )
					using ( var csvWriter = new CsvWriter( writer, configuration ) ) {
						csvWriter.WriteHeader<T>();
						csvWriter.NextRecord();
						foreach ( var record in records ) {
							csvWriter.WriteRecord( record );
							csvWriter.NextRecord();
						}

					}
				}
			} catch {
				MessageBox.Show("There was an error exporting the data, close the file you are trying to export to.");
			}


		}

		/// <summary>
		/// This just charts the values as depicted. 
		/// </summary>
		/// <param name="records"></param>
		private void ChartValues( List<CryptoRecord> records ) {
			chrtCoinAndMa.Series["Value"].LegendText = "Value";

			foreach ( var record in records ) {
				chrtCoinAndMa.Series["Value"].Points.AddXY( record.date, record.close );
			}
		}


		private void btnMaMethodCalculate_Click( object sender, EventArgs e ) {
			try {
				ClearCharts();
				// Take the seed amount from the UI
				var seed = Convert.ToDouble(tbSeedMoney.Text);
				// Get the number of moving average days that we want from the UI
				var movingAverageDays = Convert.ToInt32(tbMovingAverageDays.Text);

				if ( seed < 1.0 || movingAverageDays <= 1 ) {
					MessageBox.Show( "You must have a seed value more than $1.00, and moving average days greater than 1, idiot." );
				} else {
					var maRecords = Methods.MovingAverage.CalculateMAMethod(records, seed, movingAverageDays);
					ChartData( maRecords );

					var annualizedReturn = CalculateReturn(maRecords[maRecords.Count-1].portfolioValue, seed);

					var resultsString = new string[] {symbol, "MA", startDate.ToString("d"), endDate.ToString("d"), seed.ToString(), movingAverageDays.ToString(), "", "", annualizedReturn.ToString("P2") };

					LogResults( resultsString );
				}
			} catch {
				MessageBox.Show( "You must have a seed value more than $1.00, and moving average days greater than 1, idiot." );
			}
		}

		/// <summary>
		/// Charts the Values for a Moving Average Detail
		/// </summary>
		/// <param name="records"></param>
		private void ChartData( List<CryptoRecordMovingAverage> records ) {

			// Chart the moving average values
			chrtCoinAndMa.Series["Moving Average"].IsVisibleInLegend = true;


			// Chart the Portfolio Values
			chrtPortfolio.Series["Portfolio Value"].LegendText = "Portfolio Value";

			foreach ( var record in records ) {
				chrtCoinAndMa.Series["Moving Average"].Points.AddXY( record.date, record.movingAverage );
				chrtPortfolio.Series["Portfolio Value"].Points.AddXY( record.date, record.portfolioValue );
			}

			// And also make a new output csv with the new data
			if ( cbExportData.Checked )
				WriteRecords( records );
		}

		private void btnNMCalculate_Click( object sender, EventArgs e ) {

			try {
				ClearCharts();
				var seed = Convert.ToDouble(tbNMSeed.Text);
				var nValue = Convert.ToInt32(tbNValue.Text);
				var mValue = Convert.ToInt32(tbMValue.Text);

				if ( seed < 1.0 || nValue < 1 || mValue < 2 || nValue >= mValue ) {
					MessageBox.Show( "You must have a seed value more than $1.00, and N and M must be natural numbers, and N < M, idiot." );
				} else {
					var nmRecords = MNMovingAverage.CalculateNmMethod(records, seed, nValue, mValue);
					ChartData( nmRecords );

					var annualizedReturn = CalculateReturn(nmRecords[nmRecords.Count-1].portfolioValue, seed);

					var resultsString = new string[] {symbol, "N-M MA", startDate.ToString("d"), endDate.ToString("d"), seed.ToString(), nValue.ToString(), mValue.ToString(), "", annualizedReturn.ToString("P2") };

					LogResults( resultsString );
				}
			} catch {
				MessageBox.Show( "You must have a seed value more than $1.00, and N and M must be natural numbers, and N < M, idiot." );
			}

		}

		private void ChartData( List<CryptoRecordNM> records ) {

			chrtCoinAndMa.Series["N-MA"].IsVisibleInLegend = true;
			chrtCoinAndMa.Series["M-MA"].IsVisibleInLegend = true;
			chrtPortfolio.Series["Portfolio Value"].LegendText = "Portfolio Value";

			foreach ( var record in records ) {
				chrtPortfolio.Series["Portfolio Value"].Points.AddXY( record.date, record.portfolioValue );
				chrtCoinAndMa.Series["N-MA"].Points.AddXY( record.date, record.movingAverageN );
				chrtCoinAndMa.Series["M-MA"].Points.AddXY( record.date, record.movingAverageM );
			}

			// And also make a new output csv with the new data
			if ( cbExportData.Checked )
				WriteRecords( records );
		}

		private void btnExpCalculate_Click( object sender, EventArgs e ) {
			try {
				ClearCharts();
				var seed = Convert.ToDouble(tbExpSeed.Text);
				var smoothing = Convert.ToDouble(tbExpSmoothing.Text);
				var days = Convert.ToInt32(tbExpDays.Text);

				if ( seed < 1.0 || smoothing < 0.1 || days <= 1 ) {
					MessageBox.Show( "You must have a seed value more than $1.00, and smoothing more than 0.1, and days more than 1,  idiot." );
				} else {
					var expRecords = Methods.ExpMovingAverage.CalculateExpMethod(records, seed, smoothing, days);
					ChartData( expRecords );

					var annualizedReturn = CalculateReturn(expRecords[expRecords.Count-1].portfolioValue, seed);

					var resultsString = new string[] {symbol, "ExpMA", startDate.ToString("d"), endDate.ToString("d"), seed.ToString(), days.ToString(),"", "", annualizedReturn.ToString("P2") };

					LogResults( resultsString );
				}
			} catch {
				MessageBox.Show( "You must have a seed value more than $1.00, and smoothing more than 0.1, and days more than 1,  idiot." );
			}
		}

		private void ChartData( List<CryptoRecordExp> records ) {
			chrtCoinAndMa.Series["Exp-MA"].IsVisibleInLegend = true;
			chrtPortfolio.Series["Portfolio Value"].LegendText = "Portfolio Value";

			foreach ( var record in records ) {
				chrtPortfolio.Series["Portfolio Value"].Points.AddXY( record.date, record.portfolioValue );
				chrtCoinAndMa.Series["Exp-MA"].Points.AddXY( record.date, record.expMovingAverage );
			}



			// And also make a new output csv with the new data
			if ( cbExportData.Checked )
				WriteRecords( records );
		}




		private void btnBuyHoldCalculate_Click( object sender, EventArgs e ) {
			try {
				ClearCharts();
				var seed = Convert.ToDouble(tbBuyHoldSeed.Text);

				if ( seed < 1.0 ) {
					MessageBox.Show( "You must have a seed value more than $1.00,  idiot." );
				} else {
					var bhRecords = Methods.BuyAndHold.CalculateBuyHoldMethod(records, seed);
					ChartData( bhRecords );

					var annualizedReturn = CalculateReturn(bhRecords[bhRecords.Count-1].portfolioValue, seed);

					var resultsString = new string[] {symbol, "BuyHold", startDate.ToString("d"), endDate.ToString("d"), seed.ToString(), "","", "", annualizedReturn.ToString("P2") };

					LogResults( resultsString );
				}
			} catch {
				MessageBox.Show( "You must have a seed value more than $1.00, and smoothing more than 0.1, and days more than 1,  idiot." );
			}
		}


		private void ChartData( List<CryptoRecord> records ) {

			chrtPortfolio.Series["Portfolio Value"].LegendText = "Portfolio Value";

			foreach ( var record in records ) {
				chrtPortfolio.Series["Portfolio Value"].Points.AddXY( record.date, record.portfolioValue );
			}

			// And also make a new output csv with the new data
			if ( cbExportData.Checked )
				WriteRecords( records );
		}



		private void LogResults( string[] results ) {
			dgResults.Rows.Add( results );
		}

		private double CalculateReturn(double value, double seed ) {
			var days = (endDate - startDate).TotalDays;
			var yearsHeld = days/365;
			var annualizedReturn = Math.Pow(((value/seed)),(1/yearsHeld))-1;
			return annualizedReturn;
		}
	}


}
