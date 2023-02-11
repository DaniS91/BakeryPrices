using System.Collections.Generic;
using System.IO;
using System;

// Business Logic Goes Here
// There should be two classes: one for Bread and one for Pastry.

namespace Pricer.Models
{
 public class Bread
 {
  public static int BreadPrice(int items)
  {
    return (items * 5) - ((Convert.ToInt32(Math.Floor(items/3.0)))*5);
  }
 }
}