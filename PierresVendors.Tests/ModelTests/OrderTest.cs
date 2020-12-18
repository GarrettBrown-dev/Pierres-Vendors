using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System.Collections.Generic;
using System;

namespace PierresVendors.Tests
{
    [TestClass]
    public class OrderTest : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("test", "test", "test", "test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
        string name = "P-Diddy";
        string date = "03/15/2019";
        string desc = "Rappers Are Cool Event.";
        string cost = "$50,000";

        Order newOrder = new Order(name, date, desc, cost);
        string result1 = newOrder.Name;
        string result2 = newOrder.Date;
        string result3 = newOrder.Desc;
        string result4 = newOrder.Cost;

        Assert.AreEqual(name, result1);
        Assert.AreEqual(date, result2);
        Assert.AreEqual(desc, result3);
        Assert.AreEqual(cost, result4);
        }
        [TestMethod]
        public void SetName_SetName_String()
        {
        string name = "P-Diddy";
        Order newOrder = new Order(name, "03/15/2019", "Rappers Are Cool Event", "$50,000");

        string updatedName = "Flavor-FLAVE";
        newOrder.Name = updatedName;
        string result = newOrder.Name;

        Assert.AreEqual(updatedName, result);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
        List<Order> newList = new List<Order> { };

        List<Order> result = Order.GetAll();

        CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
        string name1 = "P-Diddy";
        string name2 = "Flavor-FLAVE";
        Order newOrder1 = new Order(name1, "03/15/2019", "Rappers Are Cool Event", "$50,000");
        Order newOrder2 = new Order(name2, "02/14/2020", "Flavor of Love Reunion", "$100,000");
        List<Order> newList = new List<Order> { newOrder, newOrder2 };

        List<Order> result = Order.GetAll();

        CollectionAssert.AreEqual(newList, result);
        }

    }

}