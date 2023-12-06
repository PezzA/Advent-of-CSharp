using System.Security.AccessControl;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day05;

[PuzzleData(Year = 2023, Day = 5, Title = "If You Give A Seed A Fertilizer", Stars = 1, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public record Range(long Start, long End, long Modifier);

    public record MapDef(long Destination, long Source, long Range);

    public record Almanac(
        long[] Seeds,
        MapDef[] Soil,
        MapDef[] Fertilizer,
        MapDef[] Water,
        MapDef[] Light,
        MapDef[] Temperature,
        MapDef[] Humidity,
        MapDef[] Location)
    {
        public AgroMap ToAgroMap() => new AgroMap(
            ToRanges(Soil),
            ToRanges(Fertilizer),
            ToRanges(Water),
            ToRanges(Light),
            ToRanges(Temperature),
            ToRanges(Humidity),
            ToRanges(Location));
    }

    public static long GetMappedDestination(long input, Range[] map)
    {
        var range = map.FirstOrDefault(m => m.Start <= input && m.End >= input);

        return range != null
            ? input + range.Modifier
            : input;
    }

    public static Range[] ToRanges(MapDef[] mapDef)
    {
        var ranges = new Range[mapDef.Length];

        for (var i = 0; i < mapDef.Length; i++)
        {
            var modifer = mapDef[i].Destination - mapDef[i].Source;

            ranges[i] = new Range(mapDef[i].Source, mapDef[i].Source + mapDef[i].Range, modifer);
        }

        return ranges;
    }

    public record AgroMap(Range[] Soil, Range[] Fertilizer, Range[] Water, Range[] Light, Range[] Temperature,
        Range[] Humidity, Range[] Location);

    public static long RunTheMap(long input, AgroMap agroMap)
    {
        input = GetMappedDestination(input, agroMap.Soil);
        input = GetMappedDestination(input, agroMap.Fertilizer);
        input = GetMappedDestination(input, agroMap.Water);
        input = GetMappedDestination(input, agroMap.Light);
        input = GetMappedDestination(input, agroMap.Temperature);
        input = GetMappedDestination(input, agroMap.Humidity);
        input = GetMappedDestination(input, agroMap.Location);

        return input;
    }

    public static Almanac LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse data");

        var seeds = new List<long>();
        var soil = new List<MapDef>();
        var fertilizer = new List<MapDef>();
        var water = new List<MapDef>();
        var light = new List<MapDef>();
        var temperature = new List<MapDef>();
        var humidity = new List<MapDef>();
        var location = new List<MapDef>();

        var iterator = new List<MapDef>();
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            if (line.StartsWith("seeds"))
            {
                string[]? bits = line.Split(":", StringSplitOptions.TrimEntries);
                seeds = bits[1].Split(' ').Select(long.Parse).ToList();
                continue;
            }

            if (line.Contains("map"))
            {
                iterator = line switch
                {
                    "seed-to-soil map:" => soil,
                    "soil-to-fertilizer map:" => fertilizer,
                    "fertilizer-to-water map:" => water,
                    "water-to-light map:" => light,
                    "light-to-temperature map:" => temperature,
                    "temperature-to-humidity map:" => humidity,
                    "humidity-to-location map:" => location,
                    _ => throw new ArgumentOutOfRangeException("Unrecognised map type", "input")
                };
                continue;
            }

            var defParts = line.Split(' ');

            iterator.Add(new MapDef(long.Parse(defParts[0]), long.Parse(defParts[1]), long.Parse(defParts[2])));
        }

        return new Almanac(
            seeds.ToArray(),
            soil.ToArray(),
            fertilizer.ToArray(),
            water.ToArray(),
            light.ToArray(),
            temperature.ToArray(),
            humidity.ToArray(),
            location.ToArray());
    }

    public string[] PartOne(string input)
    {
        var almanac  = LoadData(input);
        var agroMap = almanac.ToAgroMap();

        var lowest = long.MaxValue;

        foreach (var seed in almanac.Seeds)
        {
            var targetLocation = RunTheMap(seed, agroMap);

            if (targetLocation < lowest)
            {
                lowest = targetLocation;
            }
        }

        return new[] { lowest.ToString()};
    }

    public string[] PartTwo(string input)
    {
        var almanac  = LoadData(input);
        var agroMap = almanac.ToAgroMap();

        var lowest = long.MaxValue;

        for (int seedPair = 0; seedPair < almanac.Seeds.Length; seedPair += 2)
        {
            var start = almanac.Seeds[seedPair];
            var iterations = almanac.Seeds[seedPair + 1];

            Console.WriteLine($"{start} : {DateTime.Now.ToString()}");
            for(var seed = start; seed < start+iterations; seed++)
            {
                var targetLocation = RunTheMap(seed, agroMap);

                if (targetLocation < lowest)
                {
                    lowest = targetLocation;
                }
            }
        }
        
        return new[] { lowest.ToString()};
    }
}