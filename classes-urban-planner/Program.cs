using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building building1 = new Building("123 Happy Street");
      building1.Stories = 3;
      building1.Width = 48.5;
      building1.Depth = 77;
      building1.Construct();
      building1.Purchase("Mike Styles");
      // building1.Description();

      Building building2 = new Building("245 Sad Lane");
      building2.Stories = 5;
      building2.Width = 54;
      building2.Depth = 37;
      building2.Construct();
      building2.Purchase("Bobby Brady");
      // building2.Description();
      // Console.WriteLine(building) - uses default or override;

      City city1 = new City("New York", "Bill DeBlasio", "1790");
      Console.WriteLine(city1);
      city1.Add(building1);
      city1.Add(building2);
      Console.WriteLine($"----- Buildings of {city1.name} -----");
      foreach (Building building in city1.buildingList)
      {
        building.Description();
      };
    }
  }
}
