using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCRUMFuncPrime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUMFuncPrime.Tests
{
    [TestClass()]
    public class SCRUMPrimeTests
    {
        public ArrayList arr;
        [TestInitialize]
        public void init()
        {
            arr = new ArrayList();
        }

        [TestMethod()]
        public void 测试2的整数对应的质因数为2()
        {
            arr.Add(2);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(2),arr);
        }

        [TestMethod()]
        public void 测试3的整数对应的质因数为3()
        {
            arr.Add(3);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(3), arr);
        }

        [TestMethod()]
        public void 测试4的整数对应的质因数为2_2()
        {
            arr.Add(2);
            arr.Add(2);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(4), arr);
        }


        [TestMethod()]
        public void 测试5的整数对应的质因数为5()
        {
            arr.Add(5);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(5), arr);
        }

        [TestMethod()]
        public void 测试6的整数对应的质因数为2_3()
        {
            arr.Add(2);
            arr.Add(3);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(6), arr);
        }

        [TestMethod()]
        public void 测试7的整数对应的质因数为7()
        {
            arr.Add(7);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(7), arr);
        }

        [TestMethod()]
        public void 测试8的整数对应的质因数为2_2_2()
        {
            arr.Add(2);
            arr.Add(2);
            arr.Add(2);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(8), arr);
        }

        [TestMethod()]
        public void 测试9的整数对应的质因数为3_3()
        {
            arr.Add(3);
            arr.Add(3);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(9), arr);

        }

        [TestMethod()]
        public void 测试2_2_2_3_3_3_5_5_7_7_11_13的整数对应的质因数为2_2_2_3_3_3_5_5_7_7_11_13()
        {
            arr.Add(2);
            arr.Add(2);
            arr.Add(2);
            arr.Add(3);
            arr.Add(3);
            arr.Add(3);
            arr.Add(5);
            arr.Add(5);
            arr.Add(7);
            arr.Add(7);
            arr.Add(11);
            arr.Add(13);
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(2 * 2 * 2 * 3 * 3 * 3 * 5 * 5 * 7 * 7 * 11 * 13), arr);

        }

        [TestMethod()]
        public void 测试小于2的整数对应的质因数为空()
        {
            
            CollectionAssert.AreEqual(SCRUMPrime.PrimeBreak(1), arr);

        }









    }
}