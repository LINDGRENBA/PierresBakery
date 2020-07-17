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
      Bread breadOrder = new Bread(); //if we pass arguments in future tests, we'll need to add a paramater in ()
      Assert.AreEqual(typeof(Bread), breadOrder);
    }
  }
}