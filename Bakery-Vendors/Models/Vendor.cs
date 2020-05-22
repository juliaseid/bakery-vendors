using System.Collections.Generic;

namespace BakeryVendors.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Contact { get; set; }
    public string BusinessType { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Id { get; }
    public List<Order> AllOrders { get; set; }

    public Vendor(string businessName, string phoneNumber)
    {
      Name = businessName;
      PhoneNumber = phoneNumber;
      _instances.Add(this);
      Id = _instances.Count;
      AllOrders = new List<Order>{};
    }

    public Vendor(string businessName, string phoneNumber, string contactName, string businessType, string email)
    :this(businessName, phoneNumber)
    {
      Contact = contactName;
      BusinessType = businessType;
      Email = email;
      Id = _instances.Count;
      AllOrders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    {
      AllOrders.Add(order);
    }


  }
}