using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Chapter
{
  class Program
  {
    static void Main(string[] args)
    {
      // Restriction/Filtering Operations
      // Find the words in the collection that start with the letter 'L'
      List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
      IEnumerable<string> LFruits = from fruit in fruits
                                    where fruit.StartsWith("L")
                                    select fruit;

      foreach (string fruit in LFruits)
      {
        Console.WriteLine(fruit);
      }

      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>()
      {
          15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };

      IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);
      foreach (int num in fourSixMultiples)
      {
        Console.WriteLine(num.ToString());
      }


      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

      List<string> namesDescendQuery = (from name in names
                                        orderby name descending
                                        select name).ToList();

      IEnumerable<string> namesDescendQueryIE = from name in names
                                                orderby name descending
                                                select name;

      Console.WriteLine("Names OrderByDescending:");
      List<string> descend = names.OrderByDescending(n => n).ToList();
      foreach (string name in descend)
      {
        Console.WriteLine(name);
      }

      // Build a collection of these numbers sorted in ascending order
      List<int> numbers2 = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

      List<int> sortedNumbers2 = numbers2.OrderBy(num => num).ToList();
      Console.WriteLine("Sorted Numbers:");
      foreach (int num in sortedNumbers2)
      {
        Console.WriteLine(num.ToString());
      }


      // Aggregate Operations
      // Output how many numbers are in this list
      List<int> numbers3 = new List<int>()
          {
              15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
          };

      Console.WriteLine($"AGGREGATE COUNT: {numbers3.Count.ToString()}");

      // How much money have we made?
      List<double> purchases = new List<double>()
          {
              2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
          };
      Console.WriteLine($"TOTAL MONEY MADE FROM PURCHASES: {Math.Round(purchases.Sum(), 2).ToString()}");

      // What is our most expensive product?
      List<double> prices = new List<double>()
          {
              879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
          };
      Console.WriteLine($"MOST EXPENSIVE: {prices.Max().ToString()}");


      // Partitioning Operations
      // Store each number in the following List until a perfect square
      // is detected.


      Console.WriteLine($"List all numbers until you reach a perfect square.");
      List<int> wheresSquaredo = new List<int>()
          {
              66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
          };

      List<int> hipToBeSquare = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0)
          // {
          // double result = Math.Sqrt(num);
          // bool isSquare = Math.Sqrt(num) % 1 != 0;
          // return isSquare;
          // })
          .ToList();

      foreach (int num in hipToBeSquare)
      {
        Console.WriteLine(num);
      }
      // Create some banks and store in a List
      List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

      // Using Custom Types
      Console.WriteLine($"USING CUSTOM TYPES:");
      List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Bryan Nilsen", Balance=8700000.00, Bank="CITI"},
            new Customer(){ Name="Andy Collins", Balance=1430000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

      /*
        Given the same customer set, display how many millionaires per bank.
        Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

        Example Output:
        WF 2
        BOA 1
        FTB 1
        CITI 1
      */
      var enumerable = customers.Where(customer => customer.Balance >= 1000000)
      .GroupBy(customer => customer.Bank);

      foreach (var group in enumerable)
      {
        var groupKey = group.Key;
        Console.WriteLine($"Bank:{groupKey}, Millionaire Count:{group.Count()}");

        foreach (var groupedItem in group)
          Console.WriteLine($"Name: {groupedItem.Name}");
      }


      /*
      TASK:
      As in the previous exercise, you're going to output the millionaires,
      but you will also display the full name of the bank. You also need
      to sort the millionaires' names, ascending by their LAST name.

      Example output:
          Tina Fey at Citibank
          Joe Landy at Wells Fargo
          Sarah Ng at First Tennessee
          Les Paul at Wells Fargo
          Peg Vale at Bank of America

      EXAMPLE (JOIN)
          https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.join?view=netframework-4.8#System_Linq_Enumerable_Join__4_System_Collections_Generic_IEnumerable___0__System_Collections_Generic_IEnumerable___1__System_Func___0___2__System_Func___1___2__System_Func___0___1___3__
      */


      List<ReportItem> millionaireReport = banks.Join(customers,
          bank => bank.Symbol,
          customer => customer.Bank,
          (bank, customer) => new ReportItem { CustomerName = customer.Name, BankName = bank.Name }
          ).OrderBy(c => c.CustomerName.Split(" ").Last()).ToList();

      foreach (var item in millionaireReport)
      {
        Console.WriteLine($"Sorted: {item.CustomerName} at {item.BankName}");
      }

      // finding just millionaires and listing their full bank name
      var richReport = customers
      .Where(c => c.Balance >= 1000000)
      .Join(
        banks,
      cust => cust.Bank,
      bank => bank.Symbol,
      (cust, bank) => new ReportItem { CustomerName = cust.Name, BankName = bank.Name }
      )
      .ToList();
      foreach (var item in richReport)
      {
        Console.WriteLine($"{item.CustomerName} at {item.BankName}");
      }
    }
  }

  // Build a collection of customers who are millionaires
  public class Customer
  {
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
  }

  // Define a bank
  public class Bank
  {
    public string Symbol { get; set; }
    public string Name { get; set; }
  }

  public class ReportItem
  {
    public string CustomerName { get; set; }
    public string BankName { get; set; }
  }
}



