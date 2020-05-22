using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Order
  {
    public string Day { get; set; }
    public int InvoiceTotal { get; set; }
    public int Id { get; }
    public int Bread { get; set; } 
    public int Pastry { get; set; }
    private static List<Order> _instances = new List<Order> {};
    
    public Order(string day, int bread, int pastry)
    {
      Day = day;
      Bread = bread;
      Pastry = pastry;
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
      return _instances[searchId-1];
    }

    public int Invoice()
    {
      return 0;
    }

  }
}