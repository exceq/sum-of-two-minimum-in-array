using System;

namespace TaskTwoMinArray
{
    class Program
    {
        static void Main()
        {
            var intArray = new int[] { 1, -4, 3, 45, 6, 10 };
            var doubleArray = new double[] { 1, -4.5, 3, 45, 6, 10 };
            var sumInts = ArrayCalculator.GetMinTwoAndSum(intArray);
            var sumDoubles = ArrayCalculator.GetMinTwoAndSum(doubleArray);
            Console.WriteLine(sumInts);
            Console.WriteLine(sumDoubles);
        }
    }
}
