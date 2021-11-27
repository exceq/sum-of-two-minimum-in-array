using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskTwoMinArray.Test
{
    public class Tests
    {
        [TestCase(0)]
        [TestCase(1)]
        public void ThrowsExceptionWithIncorrectArrayLength(int len)
        {
            var array = new int[len];
            Assert.Throws<ArgumentException>(() => ArrayCalculator.GetMinTwoAndSum(array));
        }

        [TestCase(new int[] { 0, 0, 0, 1}, 0)]
        [TestCase(new int[] { -4, -2, 2, 4 ,16}, -6)]
        [TestCase(new int[] { 1, 2 }, 3)]
        public void ValueOfFunctionIsCorrectWithIntArray(int[] array, int expected)
        {
            var actual = ArrayCalculator.GetMinTwoAndSum(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 10, 1, 4.5, -1.5}, -0.5)]
        [TestCase(new double[] { -4.5, -2.4, 2, 4, 16 }, -6.9)]
        [TestCase(new double[] { 0.1, 0.2}, 0.3)]
        public void ValueOfFunctionIsCorrectWithIntArray(double[] array, double expected)
        {
            var actual = ArrayCalculator.GetMinTwoAndSum(array);
            Assert.AreEqual(expected, actual, 0.000000001);
        }

        [TestCase(10000000, false, 1)]
        [TestCase(10000000, true, 1)]
        public void CorrectValueWithALotOfElementsInSequence(int len, bool descending, int expected)
        {
            var seq = GenerateSequence(len, descending);
            var actual = ArrayCalculator.GetMinTwoAndSum(seq);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CorrectValueWithALotOfElementsRandom()
        {
            var rnd = new Random();
            var seq = Enumerable.Range(0, 10000000).OrderBy(x => rnd.Next());
            Assert.AreEqual(1, ArrayCalculator.GetMinTwoAndSum(seq));
        }

        private static IEnumerable<int> GenerateSequence(int len, bool descending = false)
        {
            var seq = Enumerable.Range(0, len);
            return descending ? seq.Reverse(): seq;
        }
    }
}