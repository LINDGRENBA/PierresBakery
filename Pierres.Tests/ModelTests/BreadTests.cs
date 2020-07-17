using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres;

namespace Pierres.Tests
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
  }
}