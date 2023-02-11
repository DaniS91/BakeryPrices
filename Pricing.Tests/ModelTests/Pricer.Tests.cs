using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Pricer.Models;

namespace Pricer.TestTools
{
  [TestClass]
  public class PriceTests
  {
    [TestMethod]
    public void BreadPrice_ReturnsBaselineBreadPrice_Int()
    {
      int items = 1;
      int result = Bread.BreadPrice(items);
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void BreadPrice_ReturnsBreadPriceWithDeal_Int()
    {
      int items = 27;
      int result = Bread.BreadPrice(items);
      Assert.AreEqual(90, result);
    }
    [TestMethod]
    public void PastryPrice_ReturnsBaselinePastryPrice_Int()
    {
      int items = 1;
      int result = Pastry.PastryPrice(items);
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void PastryPrice_ReturnsPastryPriceWithDeal_Int()
    {
      int items = 8;
      int result = Pastry.PastryPrice(items);
      Assert.AreEqual(12, result);
    }
  }
}