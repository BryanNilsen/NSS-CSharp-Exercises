using System;
using System.Collections.Generic;

namespace stocks
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> stocks = new Dictionary<string, string>();
      stocks.Add("GM", "General Motors");
      stocks.Add("BRY", "Berry Petroleum Corp.");
      stocks.Add("AAPL", "Apple");
      stocks.Add("VZ", "Verizon");


      Dictionary<string, List<double>> portfolio = new Dictionary<string, List<double>>();
      portfolio.Add("GM", new List<double>() { { 1214.90 }, { 4892.12 }, { 984.98 } });
      portfolio.Add("AAPL", new List<double>() { { 3764.33 }, { 1812.41 } });
      portfolio.Add("BRY", new List<double>() { { 3764.33 }, { 1812.41 } });
      portfolio.Add("VZ", new List<double>() { { 104.20 }, { 536.02 } });

      foreach (KeyValuePair<string, List<double>> purchase in portfolio)
      {
        string companyName = "";
        foreach (KeyValuePair<string, string> company in stocks)
        {
          if (company.Key == purchase.Key)
          {
            companyName = company.Value;
          }
        }

        double sum = 0;
        foreach (double price in purchase.Value)
        {
          sum += price;
        }
        Console.WriteLine($"Investor has spent a total of ${sum} on the ({purchase.Key}) stock for {companyName}");
      };
    }
  }
}
