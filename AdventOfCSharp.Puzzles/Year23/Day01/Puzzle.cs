using System.Text.RegularExpressions;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day01;

[PuzzleData(Year = 2023, Day = 01, Title = "Trebuchet?!", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public string[] LoadData(string input)
    {
        return input.ParseStringArray() ?? throw new Exception("Could not parse input string");
    }

    public string[] PartOne(string input)
    {
        var lines = LoadData(input);
        var count = 0;

        foreach (var line in lines)
        {
            var matches = InputRegex().Matches(line);

            var calibrationValue = int.Parse($"{matches.First().Value}{matches.Last().Value}");
            count += calibrationValue;
        }

        return new[] { count.ToString() };
    }

    public static int ConvertMatchToInt(string input)
    {
        if (int.TryParse(input, out var parseResult))
        {
            return parseResult;
        }

        return input switch
        {
            "one" => 1,
            "two" => 2,
            "three" => 3,
            "four" => 4,
            "five" => 5,
            "six" => 6,
            "seven" => 7,
            "eight" => 8,
            "nine" => 9,
            _ => throw new Exception("Did not find valid value")
        };
    }

    public string[] PartTwo(string input)
    {
        var lines = LoadData(input);
        var count = 0;

        foreach (var line in lines)
        {
            var first = InputRegexPartTwo().Match(line).Value;
            var last = InputRegexPartTwoReverse().Match(line).Value;

            var calibrationDigits = $"{ConvertMatchToInt(first)}{ConvertMatchToInt(last)}";

            var calibrationValue = int.Parse(calibrationDigits);

            count += calibrationValue;
        }

        return new[] { count.ToString() };
    }

    [GeneratedRegex(@"\d")]
    private static partial Regex InputRegex();

    [GeneratedRegex(@"\d|one|two|three|four|five|six|seven|eight|nine")]
    private static partial Regex InputRegexPartTwo();

    [GeneratedRegex(@"\d|one|two|three|four|five|six|seven|eight|nine", RegexOptions.RightToLeft)]
    private static partial Regex InputRegexPartTwoReverse();
}