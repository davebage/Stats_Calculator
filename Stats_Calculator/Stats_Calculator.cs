namespace Stats_Calculator
{
    public class StatsCalculator
    {
        public int FindSmallestValue(int[] statValues)
        {
            return statValues.Min();
        }

        public int FindLargestValue(int[] statValues)
        {
            return statValues.Max();
        }

        public int CountElements(int[] statValues)
        {
            return statValues.Length;
        }

        public double Average(int[] statValues)
        {
            return statValues.Average();
        }
    }
}