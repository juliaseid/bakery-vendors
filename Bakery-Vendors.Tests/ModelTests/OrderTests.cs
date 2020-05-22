using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendors.Models;

namespace BakeryVendors.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesNewInstanceofOrder_Order()
    {
      Order newOrder = new Order("Tuesday", 60);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDay_ReturnsDay_String()
    {
      //Arrange
      string day = "Tuesday";
      Order newOrder = new Order(day, 60);
      //Act
      string result = newOrder.Day;
      //Assert
      Assert.AreEqual(day, result);
    }

    [TestMethod]
    public void GetInvoice_ReturnsInvoiceTotal_Int()
    {
      //Arrange
      int invoice = 60;
      Order newOrder = new Order("Tuesday", invoice);
      //Act
      int result = newOrder.InvoiceTotal;
      //Assert
      Assert.AreEqual(invoice, result);
    }



  }
}