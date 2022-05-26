using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Ex1()
        {
            char[][] house =
            {
            "  o                o        #######".ToCharArray(),
            "###############             #     #".ToCharArray(),
            "#             #        o    #     #".ToCharArray(),
            "#  X          ###############     #".ToCharArray(),
            "#                                 #".ToCharArray(),
            "###################################".ToCharArray()
        };
            Assert.AreEqual(true, Dinglemouse.AllAlone(house));
        }

        [TestMethod]
        public void Ex2()
        {
            char[][] house =
            {
            "#################             ".ToCharArray(),
            "#     o         #   o         ".ToCharArray(),
            "#          ######        o    ".ToCharArray(),
            "####       #                  ".ToCharArray(),
            "   #       ###################".ToCharArray(),
            "   #                         #".ToCharArray(),
            "   #                  X      #".ToCharArray(),
            "   ###########################".ToCharArray()
        };
            Assert.AreEqual(false, Dinglemouse.AllAlone(house));
        }
    }
}