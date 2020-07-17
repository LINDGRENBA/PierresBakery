using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres;

namespace Pierres.Tests
{
  [TestClass]
  public class PastryTests
  {
    // test methods go here
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastryOrder = new Pastry(); //if we pass arguments in future tests, we'll need to add a paramater in ()
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }
  }
}