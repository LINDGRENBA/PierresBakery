namespace PierresBakery //project name
{
  public class Pastry
  {
    public int NumOfPastries { get; set; }

    public Pastry(int numOfPastries)
    {
      NumOfPastries = numOfPastries;
    }

    public int CalculatePastryCost(int numOfPastries)
    {
      return 100;
    }
  }
}