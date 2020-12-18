using System;
using System.Collections.Generic;

namespace Vendor.Models
{

  public class Order
  {
    public string Name { get; set; }
    public string Date { get; set; }
    public string Desc { get; set; }
    public string Cost { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string name, string date, string desc, string cost)
    {
      Name = name;
      Date = date;
      Desc = desc;
      Cost = cost;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}