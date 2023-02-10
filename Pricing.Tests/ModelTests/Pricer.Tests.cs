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
  }
}