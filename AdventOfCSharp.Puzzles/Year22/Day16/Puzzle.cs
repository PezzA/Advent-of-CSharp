using System.Text.RegularExpressions;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year22.Day16;

[PuzzleData(Year = 2022, Day = 16, Title = "Proboscidea Volcanium", Stars = 0, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    [GeneratedRegex(@"Valve (?<id>\w*) has flow rate=(?<flow>\d*); (tunnels lead to valves|tunnel leads to valve) (?<tunnels>.*)")]
    private static partial Regex InputRegex();

    public record Valve(string Id, int FlowRate, string[] Tunnels);

    public static Dictionary<string, Valve> LoadData(string input)
    {
        var networkData = new Dictionary<string, Valve>();

        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse string to array");

        foreach (var line in lines)
        {
            var match = InputRegex().Match(line);

            if (!match.Success)
            {
                continue;
            }

            var valve = new Valve(
                match.Groups["id"].Value, 
                int.Parse(match.Groups["flow"].Value),
                match.Groups["tunnels"].Value
                    .Split(',')
                    .Select(x=> x.Trim())
                    .ToArray());
                
            networkData.Add(valve.Id, valve);
        }

        return networkData;
    }

    
    public string[] PartOne(string input)
    {
        return new[] { Constants.NOT_YET_IMPLEMENTED };
    }

    public string[] PartTwo(string input)
    {
        return new[] { Constants.NOT_YET_IMPLEMENTED };
    }
}