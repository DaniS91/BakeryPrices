using System.Collections.Generic;
using System.IO;
using System;

// Business Logic Goes Here
// There should be two classes: one for Bread and one for Pastry.

namespace Pricer.Models
{
  public class Bread
  {
    private static int loafUnitPrice { get; set; } = 5;
    public static int BreadPrice(int items)
    {
      return (items * loafUnitPrice) - ((Convert.ToInt32(Math.Floor(items / 3.0))) * loafUnitPrice);
    }
  }

  public class Pastry
  {
    private static int pastryUnitPrice { get; set; } = 2;
    public static int PastryPrice(int items)
    {
      return 0;
    }
  }
}