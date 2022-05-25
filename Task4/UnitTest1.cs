using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExampleTests()
        {
            Assert.AreEqual(8, Kata.DontGiveMeFive(1, 9));
            Assert.AreEqual(12, Kata.DontGiveMeFive(4, 17));
        }
    }
}