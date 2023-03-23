
using System.IO.Pipes;

namespace AdventOfBlazor.Puzzles.Twenty22
{
    [PuzzleData(Year = 2022, Day = 4, Title = "Camp Cleanup", Stars = 2, ImplementedElsewhere = false)]
    public partial class Day4 : IBasicPuzzle
    {
        public class Range
        {
            public int Lower { get; set; }
            public int Upper { get; set; }
        }

        public class RangePair
        {
            public Range? First { get; set; }
            public Range? Second { get; set; }

            public bool WhollyOverLapped()
            {
                if (First == null || Second == null) return false;

                if (First.Lower <= Second.Lower && First.Upper >= Second.Upper ||
                    Second.Lower <= First.Lower && Second.Upper >= First.Upper)
                {

                    return true;
                }

                return false;
            }

            public bool PartiallyOverLapped()
            {
                if (First == null || Second == null) return false;

                if (First.Lower <= Second.Lower && First.Upper >= Second.Lower ||
                    Second.Lower <= First.Lower && Second.Upper >= First.Lower)
                {
                    return true;
                }

                return false;
            }
        }

        public List<RangePair> LoadData(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var pairs = new List<RangePair>();

            foreach (var line in lines)
            {
                var bits = line.Split(',');
                var first = bits[0].Split('-');
                var second = bits[1].Split('-');

                pairs.Add(new RangePair
                {
                    First = new Range { Lower = Convert.ToInt32(first[0]), Upper = Convert.ToInt32(first[1]) },
                    Second = new Range { Lower = Convert.ToInt32(second[0]), Upper = Convert.ToInt32(second[1]) }
                });
            }

            return pairs;
        }

        public string[] PartOne(string input)
        {
            var data = LoadData(input);
            var count = 0;
            foreach (var pair in data)
            {
                if (pair.WhollyOverLapped())
                {
                    count++;
                }
            }

            return new string[] { count.ToString() };
        }

        public string[] PartTwo(string input)
        {
            var data = LoadData(input);
            var count = 0;
            foreach (var pair in data)
            {
                if (pair.WhollyOverLapped() || pair.PartiallyOverLapped())
                {
                    count++;
                }
            }

            return new string[] { count.ToString() };
        }
    }
}