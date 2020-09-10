using ClassLibrary1Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int expected = 3;
            int actual = 0;
            //act
            actual = Class1.AddNumbers("1", "2");
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
