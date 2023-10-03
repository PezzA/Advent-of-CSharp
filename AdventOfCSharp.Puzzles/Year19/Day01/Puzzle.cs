using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year19.Day01;

[PuzzleData(Year = 2019, Day = 01, Title = "The Tyranny of the Rocket Equation", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public static List<int> LoadData(string input)
    {
        return (input
                .ParseStringArray() ?? Array.Empty<string>())
            .Select(int.Parse)
            .ToList();
    }

    public static int CalculateFuel(int input)
    {
        return (input / 3) - 2;
    }

    public static int CalculateRecursiveFuel(int input)
    {
        var fuel = CalculateFuel(input);

        return fuel > 0
            ? fuel + CalculateRecursiveFuel(fuel)
            : 0;
    }

    public string[] PartOne(string input)
    {
        var items = LoadData(input);
        
        return new [] { items.Sum(CalculateFuel).ToString() };
    }

    public string[] PartTwo(string input)
    {
        var items = LoadData(input);
        
        return new [] { items.Sum(CalculateRecursiveFuel).ToString() };
    }
}