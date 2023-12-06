using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day06;

[PuzzleData(Year = 2023, Day = 6, Title = "Wait For It", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public record Race(long Length, long Distance);

    public static Race[] LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("cannot parse");

        var times = lines[0]
            .Split(':', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[1]
            .Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();
        

        var distances = lines[1]
            .Split(':', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[1]
            .Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        var races = new Race[times.Length];

        for (var i = 0; i < times.Length; i++)
        {
            races[i] = new Race(times[i], distances[i]);
        }

        return races;
    }

    public static Race LoadData2(string input)
    {
        
        var lines = input.ParseStringArray() ?? throw new Exception("cannot parse");

        var time = long.Parse(lines[0].Replace(" ",string.Empty).Split(':')[1]);
        var distance = long.Parse(lines[1].Replace(" ",string.Empty).Split(':')[1]);

        return new Race(time, distance);
    }

    public static int GetWinCount(Race input)
    {
        var count = 0;

        for (var i = 1; i < input.Length; i++)
        {
            var timeToRun = input.Length - i;
            var distanceTravelled = i * timeToRun;

            if (distanceTravelled > input.Distance)
            {
                count += 1;
            }
        }

        return count;
    }

    public string[] PartOne(string input)
    {
        var races = LoadData(input);
        var total = 1;
        
        foreach (var race in races)
        {
            total *= GetWinCount(race);
        }

        return new[] { total.ToString()};
    }

    public string[] PartTwo(string input)
    {
        var race = LoadData2(input);
        
        return new[] { GetWinCount(race).ToString() };
    }
}