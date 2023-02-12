using System;
using System.Collections.Generic;
using Pricer.Models;

namespace Pricing
{
 public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to...");
      Console.WriteLine(".____ ___ _____ ____  ____  _____ ____    ____    _    _  _______ ______   __");
      Console.WriteLine("|  _ \\_ _| ____|  _ \\|  _ \\| ____/ ___|  | __ )  / \\  | |/ / ____|  _ \\ \\ / /");
      Console.WriteLine("| |_) | ||  _| | |_) | |_) |  _| \\___ \\  |  _ \\ / _ \\ | ' /|  _| | |_) \\ V / ");
      Console.WriteLine("|  __/| || |___|  _ <|  _ <| |___ ___) | | |_) / ___ \\| . \\| |___|  _ < | |  ");
      Console.WriteLine("|_|  |___|_____|_| \\_\\_| \\_\\_____|____/  |____/_/   \\_\\_|\\_\\_____|_| \\_\\|_|  ");
      Console.WriteLine("Bread of the Day ($5 per loaf): Sourdough Round Loafs");
      Console.WriteLine("Pastry of the Day ($2 per item): Guava & Cream Cheese Danish");
      Console.WriteLine("Bread Deal: Buy 2 get 1 free || Pastry Deal: Buy 3 get 1 free");
      Console.WriteLine("Please note: This is a family-owned, artisan bakery. Please limit orders amounts to whole items between 0-40 per type.");
      Console.WriteLine("How many bread loaves would you like to order today?");
      int breadItems = Int32.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like to order today?");
      int pastryItems = Int32.Parse(Console.ReadLine());
      if (breadItems < 0 || pastryItems < 0)
      {
        Console.WriteLine("Please restart with valid quantities or place a special order");
        Environment.Exit(0);
      }
      if (breadItems > 40 || pastryItems > 40)
      {
        Console.WriteLine("Please call our store to place a special order");
        Environment.Exit(0);
      }
      else
      {
      Console.WriteLine(CustomerOrder.OrderTotal(breadItems, pastryItems));
      Console.WriteLine("Please type your name and number to place order:");
      string customerInfo = Console.ReadLine();
      Console.WriteLine("Thank you for your order! We will contact you when your items are ready for pickup!");
      }
    }
  }
}
