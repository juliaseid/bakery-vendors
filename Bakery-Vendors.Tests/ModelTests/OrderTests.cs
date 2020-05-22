using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendors.Models;

namespace BakeryVendors.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesNewInstanceofOrder_Order()
    {
      Order newOrder = new Order("Tuesday", 60);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }


  }
}