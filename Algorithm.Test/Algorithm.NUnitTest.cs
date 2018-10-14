namespace Algorithm.Test
{
using System;
using NUnit.Framework;
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(11, 8, 2, 8, ExpectedResult = 35)]
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public int InsertNumberMethod_ChangedNumber(int first, int second, int i, int j)
                => Algorithms.Algorithm.InsertNumber(first, second, i, j);

        [TestCase(11, 8, 2, -8)]
        [TestCase(15, 3, -1, 2)]
        [TestCase(4, 7, 32, 1)]
        [TestCase(3, 6, 4, 45)]
        public void InsertNumberMethod_WrongData_IndexOutOfRangeException(int first, int second, int i, int j)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Algorithms.Algorithm.InsertNumber(first, second, i, j));
        }
    }
}
