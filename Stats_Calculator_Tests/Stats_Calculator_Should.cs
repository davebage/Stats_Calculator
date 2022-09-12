using NUnit.Framework;
using Stats_Calculator;

namespace Stats_Calculator_Tests
{
    public class Stats_Calculator_Should
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 48, 32, 27, 3, 49, 11, -6, 44, 3 }, -6)]
        [TestCase(new int[] { 7, 50, 21, 31, 28, 32, 33, 30, 45 }, 7)]
        [TestCase(new int[] { 3, 10, -7, 47, 29, 17, 19, 48, 30 }, -7)]
        public void find_smallest_value_in_sequence(int[] statValues, int expectedResult)
        {
            StatsCalculator statsCalculator = new StatsCalculator();

            int smallestValue = statsCalculator.FindSmallestValue(statValues);

            Assert.That(smallestValue, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 48, 32, 27, 3, 49, 11, -6, 44, 3 }, 49)]
        [TestCase(new int[] { 7, 50, 21, 31, 28, 32, 33, 30, 45 }, 50)]
        [TestCase(new int[] { 3, 10, -7, 47, 29, 17, 19, 48, 30 }, 48)]
        public void find_largest_value_in_sequence(int[] statValues, int expectedResult)
        {
            StatsCalculator statsCalculator = new StatsCalculator();

            int largestValue = statsCalculator.FindLargestValue(statValues);

            Assert.That(largestValue, Is.EqualTo(expectedResult));
        }


        [Test]
        [TestCase(new int[] { 48, 32, 27, 3, 49, 11, -6, 44, 3 }, 9)]
        [TestCase(new int[] { 7, 50, 21, 31, 28 }, 5)]
        [TestCase(new int[] { 3, 10, -7, 47, 29, 17, 19 }, 7)]
        public void count_number_of_elements_in_sequence(int[] statValues, int expectedResult)
        {
            StatsCalculator statsCalculator = new StatsCalculator();

            int numberOfElements = statsCalculator.CountElements(statValues);

            Assert.That(numberOfElements, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 48, 32, 27, 3, 49, 11, -6, 44, 3 }, 23.444444444444443)]
        [TestCase(new int[] { 7, 50, 21, 31, 28 }, 27.4)]
        [TestCase(new int[] { 3, 10, -7, 47, 29, 17, 19 }, 16.857142857142858)]
        public void average_value_of_elements_in_sequence(int[] statValues, double expectedResult)
        {
            StatsCalculator statsCalculator = new StatsCalculator();

            double averageValue = statsCalculator.Average(statValues);

            Assert.That(averageValue, Is.EqualTo(expectedResult));
        }



    }
}