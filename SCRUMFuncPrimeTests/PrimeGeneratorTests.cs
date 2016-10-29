using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCRUMFuncPrime;

namespace SCRUMFuncPrimeTests
{
    [TestClass]
    public class PrimeGeneratorTests
    {
        public int[] NullArray;

        [TestInitialize]
        public void Init()
        {
            NullArray = new int[24];
        }
        [TestMethod()]
        public void GeneratePrimesTest()
        {
            NullArray= PrimeGenerator.GeneratePrimes(0);
            Assert.AreEqual(0, NullArray.Length);

            NullArray = PrimeGenerator.GeneratePrimes(2);
            Assert.AreEqual(1, NullArray.Length);
            Assert.AreEqual(2, NullArray[0]);

            NullArray = PrimeGenerator.GeneratePrimes(3);
            Assert.AreEqual(2, NullArray.Length);
            Assert.AreEqual(2, NullArray[0]);
            Assert.AreEqual(3, NullArray[1]);

            NullArray = PrimeGenerator.GeneratePrimes(100);
            Assert.AreEqual(25, NullArray.Length);
            Assert.AreEqual(97, NullArray[24]);
        }
    }
}
