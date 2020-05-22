using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryVendors.Models;

namespace BakeryVendors.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }

    [HttpGet("vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorPhone, string contactName, string businessType, string email)
    {
      Vendor newVendor = new Vendor(vendorName, vendorPhone, contactName, businessType, email);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> allOrders = selectedVendor.AllOrders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", allOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDay, int invoice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDay, invoice);
      foundVendor.AddOrder(newOrder);
      List<Order> allOrders = foundVendor.AllOrders;
      model.Add("orders", allOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }


  }

}