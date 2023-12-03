using System.Text.RegularExpressions;
using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day03;

[PuzzleData(Year = 2023, Day = 3, Title = "Gear Ratios", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public static string[] LoadData(string input)
    {
        return input.ParseStringArray() ?? throw new Exception("Could not parse input");
    }

    public record Part(int PartNumber, Point2D? GearIndex);
    
    public static Part[] GetParts(string[] input)
    {
        var parts = new List<Part>();
        for (var i = 0; i < input.Length; i++)
        {
            var matches = InputParser().Matches(input[i]).AsQueryable();

            foreach (var match in matches)
            {
                var matchFound = false;
                Point2D? gearPosition = null;
                
                // is it a part?
                for (var x = match.Index -1 ; x <= match.Index + match.Length; x++)
                {
                    for (var y = i - 1; y <= i + 1; y++)
                    {
                        if (x < 0 || y < 0 || x >= input[i].Length || y >= input.Length) continue;
                        
                        var testChar = input[y][x];

                        if ("0123456789.".Contains(testChar)) continue;
                        matchFound = true;

                        if (testChar == 42)
                        {
                            gearPosition = new Point2D(x, y);
                        }

                        break;
                    }

                    if (matchFound)
                    {
                        break;
                    }
                }

                if (matchFound)
                {
                    parts.Add(new Part(int.Parse(match.Value), gearPosition));
                }
            }
        }

        return parts.ToArray();
    }

    public string[] PartOne(string input)
    {
        var data = LoadData(input);
        var parts = GetParts(data);
        return new[] { parts.Sum(p => p.PartNumber).ToString()};
    }

    public string[] PartTwo(string input)
    {
        var data = LoadData(input);
        var parts = GetParts(data);

        var sum = parts
            .GroupBy(p => p.GearIndex)
            .Where(group => group.Count() == 2)
            .Sum(group => group.First().PartNumber * group.Last().PartNumber);

        return new[] { sum.ToString()};
    }
    
    [GeneratedRegex($@"(\d+)")]
    public static partial Regex InputParser();
}