using System;
using PierresBakery;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Welcome to Pierre's Bakery. Would you like to order something? (Write 'Yes' if you'd like to order / Write 'No' if you're just looking )");
      string customerResponse = Console.ReadLine();
      if(customerResponse.ToUpper() == "YES")
      {
        Console.WriteLine("How many loaves of bread would you like today? There's a buy 2, get 1 free special. If you don't want any bread, please enter 0.");
        Console.WriteLine("Cost of bread is $5 per loaf.");
        string stringBreadRequest = Console.ReadLine();
        int breadRequest = int.Parse(stringBreadRequest);

        Console.WriteLine("How many pastries would you like today? If you don't want pastries, please enter 0.");
        Console.WriteLine("Pastries are 1 for $2 or 3 for $5");
        string stringPastryRequest = Console.ReadLine();
        int pastryRequest = int.Parse(stringPastryRequest);

        Bread breadOrder = new Bread(breadRequest);
        Pastry pastryOrder = new Pastry(pastryRequest);

        Console.WriteLine("Your total today will be $" + breadOrder.CalculateOrderCost(breadOrder.TotalCostForLoaves, pastryOrder.TotalCostForPastries));
        Console.WriteLine(pastryOrder);
        
      }
      else
      {
        Console.WriteLine("That's just fine! Have a look and enjoy the smells. Thanks for stopping by!");
      }
      // user should receive cost for bread and pastries with specials included

      

      // return the cost of the order
      // return a summary of their order

      
    }
  }
}