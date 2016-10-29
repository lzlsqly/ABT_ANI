using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCRUMFuncPrime;

namespace SCRUMFuncPrimeTests
{
    [TestClass()]
    public class ScrumPrimeTests
    {
        public ArrayList Arr;
        [TestInitialize]
        public void Init()
        {
            Arr = new ArrayList();
        }

        [TestMethod()]
        public void 测试2的整数对应的质因数为2()
        {
            Arr.Add(2);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(2),Arr);
        }

        [TestMethod()]
        public void 测试3的整数对应的质因数为3()
        {
            Arr.Add(3);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(3), Arr);
        }

        [TestMethod()]
        public void 测试4的整数对应的质因数为2_2()
        {
            Arr.Add(2);
            Arr.Add(2);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(4), Arr);
        }


        [TestMethod()]
        public void 测试5的整数对应的质因数为5()
        {
            Arr.Add(5);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(5), Arr);
        }

        [TestMethod()]
        public void 测试6的整数对应的质因数为2_3()
        {
            Arr.Add(2);
            Arr.Add(3);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(6), Arr);
        }

        [TestMethod()]
        public void 测试7的整数对应的质因数为7()
        {
            Arr.Add(7);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(7), Arr);
        }

        [TestMethod()]
        public void 测试8的整数对应的质因数为2_2_2()
        {
            Arr.Add(2);
            Arr.Add(2);
            Arr.Add(2);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(8), Arr);
        }

        [TestMethod()]
        public void 测试9的整数对应的质因数为3_3()
        {
            Arr.Add(3);
            Arr.Add(3);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(9), Arr);

        }

        [TestMethod()]
        public void 测试2_2_2_3_3_3_5_5_7_7_11_13的整数对应的质因数为2_2_2_3_3_3_5_5_7_7_11_13()
        {
            Arr.Add(2);
            Arr.Add(2);
            Arr.Add(2);
            Arr.Add(3);
            Arr.Add(3);
            Arr.Add(3);
            Arr.Add(5);
            Arr.Add(5);
            Arr.Add(7);
            Arr.Add(7);
            Arr.Add(11);
            Arr.Add(13);
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(2 * 2 * 2 * 3 * 3 * 3 * 5 * 5 * 7 * 7 * 11 * 13), Arr);

        }

        [TestMethod()]
        public void 测试小于2的整数对应的质因数为空()
        {
            
            CollectionAssert.AreEqual(ScrumPrime.PrimeBreak(1), Arr);

        }









    }
}