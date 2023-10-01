using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year18.Day01;

[PuzzleData(Year = 2018, Day = 1, Title = "Chronal Calibration", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{

    public List<int> LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new InvalidDataException("bad input!");

        return lines
            .Select(int.Parse)
            .ToList();
    }

    public string[] PartOne(string input)
    {
        return new string[] { LoadData(input).Sum().ToString() };
    }

    public int FrequencyChange(int start, List<int> changes)
    {
        start += changes.Sum();

        return start;
    }

    public string[] PartTwo(string input)
    {
        var hits = new Dictionary<int, bool>();
        var vals = LoadData(input);
        var frequency = 0;
        hits[0] = true;

        while (true)
        {
            foreach (var val in vals)
            {
                frequency += val;
                if (hits.ContainsKey(frequency))
                {
                    return new string[] { frequency.ToString() };        
                }
                hits[frequency] = true;
            }
        }
    }
}