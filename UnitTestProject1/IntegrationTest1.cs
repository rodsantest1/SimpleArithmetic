using ClassLibrary1Core;
using ClassLibrary1CoreService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class IntegrationTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            //arrange
            int expected = 3;
            int actual = 0;
            //act
            actual = await ArithmeticAPIClient.AddNumbersAsync("1", "2");
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task TestMethod2()
        {
            //arrange
            int expected = 0;
            int actual = 0;
            //act
            actual = await ArithmeticAPIClient.AddNumbersAsync(null, null);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public async Task TestMethod3()
        {
            //arrange
            int expected = 0;
            int actual = 0;
            //act
            actual = await ArithmeticAPIClient.AddNumbersAsync("0", "0");
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
