using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests 
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastryOrder = new Pastry(3); 
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }

    [TestMethod]
    public void PastryConstructor_HasNumOfPastries_Pastry()
    {
      int pastryNum = 3;
      Pastry yummyPastries = new Pastry(pastryNum);
      Assert.AreEqual(pastryNum, yummyPastries.NumOfPastries);
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesTotalCostOfPastries_Int()
    {
      int numOfPastries = 5;
      Pastry firstPastryOrder = new Pastry(numOfPastries);
      Assert.AreEqual(9, firstPastryOrder.CalculatePastryCost(5));
    }

    [TestMethod]
    public void CalculatePastryCost_CalculateComplexTotalPastryCost_Int()
    {
      int numOfPastries = 20;
      Pastry allThePastries = new Pastry(numOfPastries);
      Assert.AreEqual(34, allThePastries.TotalCostForPastries);
    }
  }
}