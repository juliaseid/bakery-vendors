using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryVendors.Models;
using System.Collections.Generic;
using System;

namespace BakeryVendors.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Jo's Market", "JoJo", "retail");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsBusinessName_String()
    {
      //Arrange
      string businessName = "Jo's Test Market";
      Vendor newVendor = new Vendor(businessName, "JoJo", "retail");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(businessName, result);
    }

    [TestMethod]
    public void GetContact_ReturnsContactName_String()
    {
      //Arrange
      string contactName = "JoJo";
      Vendor newVendor = new Vendor("Jo's Test Market", contactName, "retail");

      //Act
      string result = newVendor.Contact;

      //Assert
      Assert.AreEqual(contactName, result);
    }

    [TestMethod]
    public void GetBusiness_ReturnsBusinessType_String()
    {
      //Arrange
      string businessType = "retail";
      Vendor newVendor = new Vendor("Jo's Test Market", "JoJo", businessType);

      //Act
      string result = newVendor.BusinessType;

      //Assert
      Assert.AreEqual(businessType, result);
    }


    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Jo's Test Market";
      string contact = "JoJo";
      string business = "retail";
      Vendor newVendor = new Vendor(name, contact, business);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_CategoryList()
    {
      //Arrange
      string name01 = "Jo's Test Market";
      string name02 = "Sam's Sampler";
      string contact01 = "JoJo";
      string contact02 = "Sam";
      string business01 = "retail";
      string business02 = "cafe";
      Vendor newVendor1 = new Vendor(name01, contact01, business01);
      Vendor newVendor2 = new Vendor(name02, contact02, business02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Jo's Test Market";
      string name02 = "Sam's Spot";
      string contact01 = "JoJo";
      string contact02 = "Sam";
      string business01 = "retail";
      string business02 = "cafe";
      Vendor newVendor1 = new Vendor(name01, contact01, business01);
      Vendor newVendor2 = new Vendor(name02, contact02, business02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string name01 = "Jo's Test Market";
      string contact01 = "JoJo";
      string business01 = "retail";
      Vendor newVendor1 = new Vendor(name01, contact01, business01);
      string day = "Tuesday";
      int invoice = 60;
      Order newOrder = new Order(day, invoice);
      List<Order> newList = new List<Order> { newOrder };
      newVendor1.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor1.AllOrders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
  }
}