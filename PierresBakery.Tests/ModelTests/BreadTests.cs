using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // test methods go here
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread breadOrder = new Bread(5);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }

    [TestMethod]
    public void BreadConstructor_HasNumOfLoavesField_Bread()
    {
      int breadNum = 5;
      Bread deliciousBread = new Bread(breadNum);
      Assert.AreEqual(breadNum, deliciousBread.NumOfLoaves);
    }

    [TestMethod]
    public void CalculateLoafCost_CalculatesTotalCostOfLoaves_Int()
    {
      int numOfLoaves = 2;
      Bread firstBreadOrder = new Bread(numOfLoaves);
      Assert.AreEqual(10, firstBreadOrder.CalculateLoafCost(2));
    }

    [TestMethod]
    public void CalculateExtraLoaves_CalculatesHowManyExtraLoaves_Int()
    {
      int numOfLoaves = 10;
      Bread secondBreadOrder = new Bread(numOfLoaves);
      Assert.AreEqual(5, secondBreadOrder.CalculateExtraLoaves(numOfLoaves));
    }

    [TestMethod]
    public void LoafGetter_GetTotalNumberOfLoavesForOrder_Int()
    {
      int numOfLoaves = 10;
      Bread thirdBreadOrder = new Bread(numOfLoaves);
      Assert.AreEqual(15, thirdBreadOrder.TotalBreadLoaves);
    }

    [TestMethod]
    public void CalculateOrderCost_GetCostOfOrder_Int()
    {
      int numOfLoaves = 2;

      Bread fourthBreadOrder = new Bread(numOfLoaves);

      int totalCostForLoaves = fourthBreadOrder.CalculateLoafCost(numOfLoaves);

      int totalCostForPastries = 5;

      int totalOrderCost = totalCostForLoaves + totalCostForPastries;

      Assert.AreEqual(totalCostForLoaves, fourthBreadOrder.CalculateLoafCost(numOfLoaves));
      
      Assert.AreEqual(totalOrderCost, fourthBreadOrder.CalculateOrderCost(totalCostForLoaves, totalCostForPastries));
    }
  }
}