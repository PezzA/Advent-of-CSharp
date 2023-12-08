using System.Text.RegularExpressions;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day08;

[PuzzleData(Year = 2023, Day = 8, Title = "Haunted Wasteland", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public record Instruction(string Left, string Right);

    public record Map(char[] Directions, Dictionary<string, Instruction> Instructions);

    [GeneratedRegex(@"(?<key>\w*) = \((?<left>\w*), (?<right>\w*)\)")]
    private static partial Regex InputParseRegex();

    public static Map LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("could not parse input");

        var directions = lines[0].Select(x => x).ToArray();
        var instructions = new Dictionary<string, Instruction>();

        for (var i = 2; i < lines.Length; i++)
        {
            var match = InputParseRegex().Match(lines[i]);

            if (!match.Success)
            {
                throw new Exception($"could not parse line {lines[i]}");
            }

            var key = match.Groups["key"].Value;

            instructions[key] = new Instruction(match.Groups["left"].Value, match.Groups["right"].Value);
        }

        return new Map(directions, instructions);
    }

    private static int GetNextDirection(char[] directions, int index)
    {
        index += 1;

        if (index == directions.Length)
        {
            index = 0;
        }

        return index;
    }

    private static int WalkMap(Map map, string start = "AAA", string end = "ZZZ", bool endWithZ = false)
    {
        var currPos = start;
        var counter = 0;

        var directionIndex = 0;

        while (currPos != (end) && !(endWithZ && currPos.EndsWith('Z')))
        {
            currPos =  map.Directions[directionIndex] == 'L'
                ? map.Instructions[currPos].Left
                : map.Instructions[currPos].Right;

            counter += 1;

            directionIndex = GetNextDirection(map.Directions, directionIndex);
        }

        return counter;
    }

    private static int WalkMapMulti(Map map, string start)
    {
        var currPos = start;
        var counter = 0;

        var directionIndex = 0;

        while (!currPos.EndsWith('Z'))
        {
            currPos =  map.Directions[directionIndex] == 'L'
                ? map.Instructions[currPos].Left
                : map.Instructions[currPos].Right;

            counter += 1;

            directionIndex = GetNextDirection(map.Directions, directionIndex);
        }

        return counter;
    }

    public string[] PartOne(string input)
    {
        var map = LoadData(input);
        var steps = WalkMap(map);

        return new[] { steps.ToString() };
    }

    public string[] PartTwo(string input)
    {
        var map = LoadData(input);
        
        var starts = map.Instructions
            .Where(i => i.Key.EndsWith('A'))
            .Select(i => i.Key)
            .ToArray();

        var values = starts
            .Select(i => (long)WalkMapMulti(map, i))
            .ToArray();
        
        var result = LcmOfArray(values, 0, values.Length - 1);
        
        return new[] { result.ToString() };
    }

    private static long Gcd(long a, long b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private static long Lcm(long a, long b)
    {
        return a / Gcd(a, b) * b;
    }

    private static long LcmOfArray(long[] numbers, long start, long end)
    {
        return start == end 
            ? numbers[start] 
            : Lcm(numbers[start], LcmOfArray(numbers, start + 1, end));
    }
}