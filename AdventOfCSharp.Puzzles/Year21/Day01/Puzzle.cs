using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year21.Day01;

[PuzzleData(Year = 2021, Day = 1, Title = "Sonar Sweep", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    
    public static IEnumerable<int> LoadData(string input)
    {
        return (input.ParseStringArray() ?? Array.Empty<string>())
            .Select(int.Parse);
    }

    public string[] PartOne(string input)
    {
        var items = LoadData(input).ToList();

        var count = 0;
        for (var i = 1; i < items.Count; i++)
        {
            if (items[i] > items[i - 1])
            {
                count++;
            }
        }

        return new [] { count.ToString() };
    }

    public string[] PartTwo(string input)
    {
        var items = LoadData(input).ToList();

        var count = 0;
        for (var i = 3; i < items.Count; i++)
        {
            var cmp1 = items[i-1] + items[i - 2] + items[i - 3];
            var cmp2 = items[i] + items[i - 1] + items[i - 2];
            
            if (cmp2> cmp1)
            {
                count++;
            }
        }

        return new [] { count.ToString() };
    }
}