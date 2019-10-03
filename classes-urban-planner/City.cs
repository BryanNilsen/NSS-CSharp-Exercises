using System;
using System.Collections.Generic;

namespace Planner
{
  class City
  {

    public City(string cityName, string mayor, string year)
    {
      name = cityName;
      _mayor = mayor;
      _yearEstablished = year;
    }
    // private fields
    public string name = "";
    private string _mayor = "";
    private string _yearEstablished = "";

    public List<Building> buildingList { get; } = new List<Building>();

    public void Add(Building building)
    {
      buildingList.Add(building);
    }

    public override string ToString()
    {
      return $"{name} City was established in {_yearEstablished}. The mayor is {_mayor}.";
    }
  }
}