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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };
      // Act
      List<Order> result = Order.GetAll();
      foreach (Order thisOrder in result)
      {
        Console.WriteLine("Output from empty list GetAll test: " + thisOrder.Day);
      }
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string day01 = "Tuesday";
      string day02 = "Thursday";
      int invoice01 = 60;
      int invoice02 = 80;
      Order newOrder1 = new Order(day01, invoice01);
      Order newOrder2 = new Order(day02, invoice02);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};

      //Act
      List<Order> result = Order.GetAll();
      foreach (Order thisOrder in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisOrder.Day + ", $" + thisOrder.InvoiceTotal);
      }

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string day01 = "Tuesday";
      string day02 = "Thursday";
      int invoice01 = 60;
      int invoice02 = 80;
      Order newOrder1 = new Order(day01, invoice01);
      Order newOrder2 = new Order(day02, invoice02);
      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }







  }
}