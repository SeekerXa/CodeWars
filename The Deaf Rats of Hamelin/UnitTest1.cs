namespace The_Deaf_Rats_of_Hamelin
{
    [TestClass]
    public class UnitTest1
    {
 

        
        [TestMethod]

        public void Basic_Test(string town, int expected)
        {

            Assert.AreEqual(0, Dinglemouse.CountDeafRats("~O~O~O~O P"));
            Assert.AreEqual(1, Dinglemouse.CountDeafRats("P O~ O~ ~O O~"));
            Assert.AreEqual(2, Dinglemouse.CountDeafRats("~O~O~O~OP~O~OO~"));
        }
    }
}