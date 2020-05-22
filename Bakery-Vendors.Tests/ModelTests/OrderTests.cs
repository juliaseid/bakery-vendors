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
      Order newOrder = new Order("Tuesday", 10, 30);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDay_ReturnsDay_String()
    {
      //Arrange
      string day = "Tuesday";
      Order newOrder = new Order(day, 10, 30);
      //Act
      string result = newOrder.Day;
      //Assert
      Assert.AreEqual(day, result);
    }

    [TestMethod]
    public void GetBread_ReturnsBreadTotal_Int()
    {
      //Arrange
      int bread = 10;
      Order newOrder = new Order("Tuesday", bread, 30);
      //Act
      int result = newOrder.Bread;
      //Assert
      Assert.AreEqual(bread, result);
    }

    [TestMethod]
    public void GetPastry_ReturnsPastryTotal_Int()
    {
      //Arrange
      int pastry = 30;
      Order newOrder = new Order("Tuesday", 10, pastry);
      //Act
      int result = newOrder.Pastry;
      //Assert
      Assert.AreEqual(pastry, result);
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
      int bread01 = 60;
      int bread02 = 10;
      int pastry01 = 30;
      int pastry02 = 20;
      Order newOrder1 = new Order(day01, bread01, pastry01);
      Order newOrder2 = new Order(day02, bread02, pastry02);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};

      //Act
      List<Order> result = Order.GetAll();
      foreach (Order thisOrder in result)
      {
        Console.WriteLine("Output from second GetAll test: " + thisOrder.Day + thisOrder.Bread + " bread" + thisOrder.Pastry + " pastry");
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
      int bread01 = 60;
      int bread02 = 10;
      int pastry01 = 30;
      int pastry02 = 20;
      Order newOrder1 = new Order(day01, bread01, pastry01);
      Order newOrder2 = new Order(day02, bread02, pastry02);
      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void Invoice_ReturnsCorrectTotalForBread_Int()
    {
      //arrange
      string day = "Tuesday";
      int bread = 5;
      int pastry = 0;
      Order newOrder = new Order(day, bread, pastry);
      //Act
      int result = 20;
      int order = newOrder.Invoice();
      //Assert
      Assert.AreEqual(order, result);
    }

    [TestMethod]
    public void Invoice_ReturnsCorrectTotalForPastry_Int()
    {
      //arrange
      string day = "Tuesday";
      int bread = 0;
      int pastry = 5;
      Order newOrder = new Order(day, bread, pastry);
      //Act
      int result = 9;
      int order = newOrder.Invoice();
      //Assert
      Assert.AreEqual(order, result);
    }





  }
}