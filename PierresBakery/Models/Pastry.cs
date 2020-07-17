namespace PierresBakery //project name
{
  public class Pastry
  {
    public int NumOfPastries { get; set; }
    public int TotalCostForPastries { get; set; }

    public Pastry(int numOfPastries)
    {
      NumOfPastries = numOfPastries;
      TotalCostForPastries = CalculatePastryCost(numOfPastries);
    }

    public int CalculatePastryCost(int numOfPastries)
    {
      if(numOfPastries <= 0)
      {
        return 0;
      }
      else if((numOfPastries == 1) || numOfPastries == 2)
      {
        return numOfPastries*2;
      }
      else
      {
        int timesDivByThree = numOfPastries / 3;
        int remainder = numOfPastries % 3;

        int pastryDeal = timesDivByThree * 5;
        int pastryRegular = remainder * 2;

        return pastryDeal + pastryRegular;
      }
    }

    // public static void ClearAll()
    // {
    //   _
    // }
  }
}