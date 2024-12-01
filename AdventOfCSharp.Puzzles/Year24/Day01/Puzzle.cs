using AdventOfCSharp.Puzzles.Parsing;
using System.Text.RegularExpressions;

namespace AdventOfCSharp.Puzzles.Year24.Day01;

[PuzzleData(Year = 2024, Day = 1, Title = "Historian Hysteria", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{

    [GeneratedRegex(@"(?<first>\d*)   (?<second>\d*)")]
    private static partial Regex InputRegex();

    public static (List<int>, List<int>) LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse data");

        var firstList = new List<int>();
        var secondList = new List<int>();

        foreach (var line in lines)
        {
            var match = InputRegex().Match(line);

            if (!match.Success)
            {
                throw new InvalidDataException($"Could not parse line: {line}");
            }

            firstList.Add(int.Parse(match.Groups["first"].Value));
            secondList.Add(int.Parse(match.Groups["second"].Value));
        }

        return (firstList, secondList);
    }

    public string[] PartOne(string input)
    {
        var (fl, sl) = LoadData(input);

        fl.Sort();
        sl.Sort();

        var sum = 0;

        for (int i = 0; i < fl.Count; i++)
        {
            sum += Math.Abs(fl[i] - sl[i]);
        }

        return [sum.ToString()];
    }

    public string[] PartTwo(string input)
    {
        var (fl, sl) = LoadData(input);

        fl.Sort();
        sl.Sort();

        var sum = 0;

        for (int i = 0; i < fl.Count; i++)
        {
            var secondListHits = sl.Count(slItem => slItem == fl[i]);

            sum += fl[i] * secondListHits;
        }

        return [sum.ToString()];
    }


}