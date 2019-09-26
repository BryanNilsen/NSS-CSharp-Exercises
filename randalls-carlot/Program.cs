using System;
using System.Collections.Generic;
namespace randalls_carlot
{
  class Program
  {
    static void Main(string[] args)
    {

      Dictionary<string, List<Dictionary<string, Dictionary<string, string>>>> vehicles = new Dictionary<string, List<Dictionary<string, Dictionary<string, string>>>>();

      // FIRST VEHICLE DATA DICTIONARIES
      Dictionary<string, string> vehicle1 = new Dictionary<string, string>(){
              {"year", "2008"},
              {"model", "Damfresh"},
              {"make", "Biotraxquote"},
              {"color", "sky magenta"}
          };
      Dictionary<string, string> sagent1 = new Dictionary<string, string>(){
              {"mobile", "(896) 478-6975"},
              {"last_Name", "Botsford"},
              {"first_Name", "Shaina"}
          };
      Dictionary<string, string> credit1 = new Dictionary<string, string>(){
              {"credit_provider", "J.P.Morgan Chase & Co"},
              {"account", "601109582720302"}
          };

      // SECOND VEHICLE DATA DICTIONARIES
      Dictionary<string, string> vehicle2 = new Dictionary<string, string>(){
              {"year", "2010"},
              {"model", "Hotquadtrax"},
              {"make", "Transtintechno"},
              {"color", "robin egg blue"}
          };

      Dictionary<string, string> sagent2 = new Dictionary<string, string>(){
              {"mobile", "562.300.2912"},
              {"last_Name", "Davis"},
              {"first_Name", "Gerardo"}
          };
      Dictionary<string, string> credit2 = new Dictionary<string, string>(){
              {"credit_provider", "PNC Financial Services"},
              {"account", "34578280562836"}
          };

      // CREATE LIST OF VEHICLE DICTIONARIES
      Dictionary<string, Dictionary<string, string>> vehicle1Dict = new Dictionary<string, Dictionary<string, string>>();
      vehicle1Dict.Add("vehicle", vehicle1);
      vehicle1Dict.Add("sales_agent", sagent1);
      vehicle1Dict.Add("credit", credit1);

      Dictionary<string, Dictionary<string, string>> vehicle2Dict = new Dictionary<string, Dictionary<string, string>>();
      vehicle2Dict.Add("vehicle", vehicle2);
      vehicle2Dict.Add("sales_agent", sagent2);
      vehicle2Dict.Add("credit", credit2);



      foreach (KeyValuePair<string, Dictionary<string, string>> entry in vehicle2Dict)
      {

        Console.WriteLine(entry.Key);
        foreach (KeyValuePair<string, string> item in entry.Value)
        {
          Console.WriteLine($"  {item.Key}: {item.Value}");

        }

      }

      // foreach (KeyValuePair<string, string> entry in credit1)
      // {
      //   Console.WriteLine(entry);
      // }

    }
  }
}
