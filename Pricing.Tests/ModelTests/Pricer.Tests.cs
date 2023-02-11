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
  }
}