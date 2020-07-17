namespace PierresBakery //project name
{
  public class Bread
  {
    public int NumOfLoaves { get; set; } 
    public int TotalCostForLoaves { get; set; }
    public int ExtraLoaves { get; set; }
    public int TotalBreadLoaves { get; set; }

    public Bread(int numOfLoaves)
    {
      NumOfLoaves = numOfLoaves;
      TotalCostForLoaves = CalculateLoafCost(numOfLoaves);
      ExtraLoaves = CalculateExtraLoaves(numOfLoaves);
      TotalBreadLoaves = NumOfLoaves + -1;
    }

    public int CalculateLoafCost(int numOfLoaves)
    {
      if(numOfLoaves <= 0)
      {
        return 0;
      }
      else
      {
        return numOfLoaves * 5;
      }
    }

    public int CalculateExtraLoaves(int numOfLoaves)
    {
      if(numOfLoaves < 2)
      {
        return 0;
      }
      else
      {
        int extras = numOfLoaves / 2;
        return extras;
      }
    }
  }
}