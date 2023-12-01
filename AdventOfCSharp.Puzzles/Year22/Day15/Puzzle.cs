using System.Text.RegularExpressions;
using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Parsing;
namespace AdventOfCSharp.Puzzles.Year22.Day15;

[PuzzleData(Year = 2022, Day = 15, Title = "Beacon Exclusion Zone", Stars = 0, ImplementedElsewhere = false)]
        
public partial class Puzzle : IBasicPuzzle
{
    public record Sensor(Point2D Location, Point2D ClosestBeacon);

    public static IList<Sensor> LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse data");

        var data = new List<Sensor>();
                
        foreach (var line in lines)
        {
            var match = InputRegex().Match(line);

            if (!match.Success)
            {
                throw new InvalidDataException($"Could not parse line: {line}");
            }

            var location = new Point2D(int.Parse(match.Groups["locx"].Value), int.Parse(match.Groups["locy"].Value));
            var beacon = new Point2D(int.Parse(match.Groups["beax"].Value), int.Parse(match.Groups["beay"].Value));
            
            data.Add(new Sensor(location, beacon));
        }

        return data;
    }

    public string[] PartOne(string input)
    {
        return new[] { Constants.NOT_YET_IMPLEMENTED };
    }

    public string[] PartTwo(string input)
    {
        return new[] { Constants.NOT_YET_IMPLEMENTED };
    }
    
    [GeneratedRegex(@"Sensor at x=(?<locx>-?\d*), y=(?<locy>-?\d*): closest beacon is at x=(?<beax>-?\d*), y=(?<beay>-?\d*)")]
    private static partial Regex InputRegex();
}
