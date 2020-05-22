using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Order
  {
    public string Day { get; set; }
    public int InvoiceTotal { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};
    
    public Order(string day, int invoiceTotal)
    {
      Day = day;
      InvoiceTotal = invoiceTotal;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // public static List<Item> GetAll()
    // {
    //   return _instances;
    // }
    
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    // public static Item Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }

  }
}