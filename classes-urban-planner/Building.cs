using System;

namespace Planner
{
  class Building
  {
    // Constructor (same name as Class)
    public Building(string address)
    {
      _address = address;
    }

    // Private Fields
    private string _designer = "Bryan Nilsen";
    private DateTime _dateConstructed;
    private string _address;
    private string _owner = "(no current owner)";

    // Public Read-Write Properties
    public int Stories { get; set; }

    public double Width { get; set; }

    public double Depth { get; set; }

    // Public Read-Only property syntax ( does not have set ability )
    public double Volume
    {
      get
      {
        return Width * Depth * Stories * 3;
      }
    }

    // method
    public void Description()
    {
      Console.WriteLine($"{_address}");
      Console.WriteLine($"-- Designed By: {_designer}");
      Console.WriteLine($"-- Constructed on: {_dateConstructed}");
      Console.WriteLine($"-- Owned by: {_owner}");
      Console.WriteLine($"-- {Volume} cubic feet of space");
      Console.WriteLine("");
    }

    public void Construct()
    {
      _dateConstructed = DateTime.Now;
    }

    public void Purchase(string buyer)
    {
      _owner = buyer;
    }


    // public override string ToString()
    // {
    //   return $"The Building is {Stories} and is {Width} wide, {Depth} deep, and has a volume of {Volume}.";
    // }
  }
}