using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year24.Day02;

[PuzzleData(Year = 2024, Day = 2, Title = "Red-Nosed Reports", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{

    public static List<List<int>> LoadData(string input)
    {
        var lists = new List<List<int>>();

        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse data");

        foreach (var line in lines)
        {
            var list = line
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            lists.Add(list);
        }

        return lists;
    }

    public enum ListOrder
    {
        Ascending,
        Descending
    }

    public static bool IsSafe(List<int> input)
    {
        if (input == null || input.Count < 2) return false;

        var order = input[0] > input[1]
            ? ListOrder.Descending
            : ListOrder.Ascending;

        for (var i = 0; i < (input.Count - 1); i++)
        {
            var diff = Math.Abs(input[i] - input[i + 1]);

            if (diff > 3 || diff == 0) return false;

            if (order == ListOrder.Ascending && input[i] > input[i + 1]) return false;
            if (order == ListOrder.Descending && input[i] < input[i + 1]) return false;
        }

        return true;
    }

    public static List<int> StripIndex(List<int> input, int index) 
    {
        var retVal = new List<int>();

        for (var i = 0; i < input.Count; i++) 
        {
            if (i != index) { 
                retVal.Add(input[i]);
            }
        }

        return retVal;
    }

    public static bool IsSafeWithRemoval(List<int> input)
    {
        if (IsSafe(input)) return true;

        for (int i = 0; i < input.Count; i++)
        {
            if (IsSafe(StripIndex(input, i))) return true;
        }

        return false;
    }

    public string[] PartOne(string input)
    {
        var lists = LoadData(input);

        var sum = 0;

        foreach (var list in lists)
        {
            if (IsSafe(list))
            {
                sum++;
            }

        }

        return [sum.ToString()];
    }

    public string[] PartTwo(string input)
    {
        var lists = LoadData(input);

        var sum = 0;

        foreach (var list in lists)
        {
            if (IsSafeWithRemoval(list))
            {
                sum++;
            }

        }

        return [sum.ToString()];
    }
}