using System.Collections.Generic;
using System.IO;
using System;

// Business Logic Goes Here
// There should be two classes: one for Bread and one for Pastry.

namespace Pricer.Models
{
 public class Bread
 {
  private static int loafPrice { get; set; } = 5;
  public static int BreadPrice(int items)
  {
    return (items * loafPrice) - ((Convert.ToInt32(Math.Floor(items / 3.0))) * loafPrice);
  }
 }
}