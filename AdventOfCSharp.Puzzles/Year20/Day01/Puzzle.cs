using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year20.Day01;

[PuzzleData(Year = 2020, Day = 1, Title = "Report Repair", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public static List<int> LoadData(string input)
    {
        return (input.ParseStringArray() ?? Array.Empty<string>())
            .Select(int.Parse)
            .ToList();
    }

    public string[] PartOne(string input)
    {
        var vals = LoadData(input);

        foreach (var x in vals)
        {
            foreach (var y in vals)
            {
                if (x + y == 2020)
                {
                    return new[] { (x * y).ToString() };
                }
            }
        }

        throw new InvalidOperationException("Should not have got here");
    }

    public string[] PartTwo(string input)
    {
        var vals = LoadData(input);

        foreach (var x in vals)
        {
            foreach (var y in vals)
            {
                foreach (var z in vals)
                {
                    if (x + y + z == 2020)
                    {
                        return new[] { (x * y * z).ToString() };
                    }
                }
            }
        }

        throw new InvalidOperationException("Should not have got here");
    }
}