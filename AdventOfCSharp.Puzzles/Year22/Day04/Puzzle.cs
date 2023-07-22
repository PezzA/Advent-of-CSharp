namespace AdventOfCSharp.Puzzles.Year22.Day04;

[PuzzleData(Year = 2022, Day = 4, Title = "Camp Cleanup", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
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
                First = new Range(Convert.ToInt32(first[0]), Convert.ToInt32(first[1])),
                Second = new Range(Convert.ToInt32(second[0]), Convert.ToInt32(second[1]))
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