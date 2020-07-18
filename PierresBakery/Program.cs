using System;
using PierresBakery;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello! Welcome to Pierre's Bakery. Would you like to order something?");
      Console.Write("(Write 'Yes' if you'd like to order / Write 'No' if you're just looking ) : ");
      string customerResponse = Console.ReadLine().ToUpper();
      Console.WriteLine("------------------");

      if(customerResponse == "YES")
      {
        //BREAD ORDER
        Console.WriteLine("The cost of bread is $5 per loaf. There's a buy 2, get 1 free special.");
        Console.WriteLine("If you don't want any bread, please enter 0.");
        Console.Write("How many loaves of bread would you like today? (Please enter a whole number) : ");
        string stringBreadRequest = Console.ReadLine();
        int breadRequest = int.Parse(stringBreadRequest);
        Bread breadOrder = new Bread(breadRequest);
        Console.WriteLine("You've requested " + breadRequest + " loaves of bread. With today's special, that means you'll receive " + breadOrder.ExtraLoaves + " extra loaf/loaves of bread.");
        Console.WriteLine("------------------");

        //PASTRY ORDER
        Console.WriteLine("Pastries are 1 for $2 or 3 for $5");
        Console.WriteLine("If you don't want pastries, please enter 0.");
        Console.Write("How many pastries would you like today? (Please enter a whole number) : ");
        string stringPastryRequest = Console.ReadLine();
        int pastryRequest = int.Parse(stringPastryRequest);
        Pastry pastryOrder = new Pastry(pastryRequest);
        Console.WriteLine("You've requested " + pastryRequest + " pastries.");
        Console.WriteLine("------------------");

        if((breadOrder.NumOfLoaves == 0) && (pastryOrder.NumOfPastries == 0))
        {
          Console.WriteLine("Hmmm. Sounds like you don't really want to order anything today. That's okay! Have a look around if you like and let me know if you change your mind.");
        }
        else
        {
          //ORDER TOTAL
          Console.WriteLine("Your total today will be $" + breadOrder.CalculateOrderCost(breadOrder.TotalCostForLoaves, pastryOrder.TotalCostForPastries) + ".00");
          Console.Write("Would you like a copy of your receipt? (Yes / No) : ");
          string wantReceipt = Console.ReadLine().ToUpper();
          
          if(wantReceipt == "YES")
          {
            Console.WriteLine("Here's a copy of your receipt : ");
            Console.WriteLine("------------------");
            Console.WriteLine(breadOrder.NumOfLoaves + " loaf/loaves of bread, for a total of " + breadOrder.TotalBreadLoaves + " loaf/loaves with our buy 2 get 1 free special : $" + breadOrder.TotalCostForLoaves + ".00");
            Console.WriteLine(pastryOrder.NumOfPastries + " pastries : $" + pastryOrder.TotalCostForPastries + ".00");
            Console.WriteLine("Today's Total : " + breadOrder.CalculateOrderCost(breadOrder.TotalCostForLoaves, pastryOrder.TotalCostForPastries) + ".00");
            Console.WriteLine("Thank you for your business and have a nice day!");
          }
          else
          {
            Console.WriteLine("Have a nice day, then. Thank you for your business!");
          }        
        }
      }
      else
      {
        Console.WriteLine("That's just fine! Have a look and enjoy the smells. Thanks for stopping by!");
      }      
    }
  }
}