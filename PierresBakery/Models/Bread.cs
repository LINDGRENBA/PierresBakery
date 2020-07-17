namespace PierresBakery //project name
{
  public class Bread
  {
    //declare auto implemented property
    public int NumOfLoaves { get; set; } 

    // now create the constructor function
    public Bread(int numOfLoaves)
    {
      NumOfLoaves = numOfLoaves;
    }

    public int CalculateBreadCost(int numOfLoaves)
    {
      return 5;
    }
  }
}