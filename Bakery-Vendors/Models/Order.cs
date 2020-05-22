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
      Id = _instances.Count;
      _instances.Add(this);
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

  }
}