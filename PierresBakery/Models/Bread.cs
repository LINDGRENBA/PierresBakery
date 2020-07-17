namespace PierresBakery //project name
{
  public class Bread
  {
    public int NumOfLoaves { get; set; } 
    public int TotalCostForLoaves { get; set; }

    public Bread(int numOfLoaves)
    {
      NumOfLoaves = numOfLoaves;
      TotalCostForLoaves = CalculateLoafCost(numOfLoaves);
    }

    public int CalculateBreadCost(int numOfLoaves)
    {
      
    }
  }
}