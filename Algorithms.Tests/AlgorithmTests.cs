using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Algorithms.Tests
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void InsertNumberMethod_11_8_2_8_Returned_35()
        {
            Assert.AreEqual(35, Algorithm.InsertNumber(11, 8, 2, 8));
        }
        [TestMethod]
        public void InsertNumberMethod_8_15_3_8_Returned_120()
        {
            Assert.AreEqual(120, Algorithm.InsertNumber(8, 15, 3, 8));
        }
        [TestMethod]
        public void InsertNumberMethod_15_15_0_0_Returned_15()
        {
            Assert.AreEqual(15, Algorithm.InsertNumber(15, 15, 0, 0));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumberMethod_15_15_8_3_ArgumentOutOfRangeException()
                => Algorithm.InsertNumber(15,15,8,3);
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumberMethod_15_15_neg8_neg3_ArgumentOutOfRangeException()
                => Algorithm.InsertNumber(15, 15, -8, -3);
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumberMethod_20_20_32_45_ArgumentOutOfRangeException()
                => Algorithm.InsertNumber(15, 15, 32, 45);

    }
}
