using Puzzle = AdventOfCSharp.Puzzles.Year23.Day05.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day05;

public class Tests
{
    private readonly Puzzle _puzzle = new();

    private const string TestData
        = """
          seeds: 79 14 55 13

          seed-to-soil map:
          50 98 2
          52 50 48

          soil-to-fertilizer map:
          0 15 37
          37 52 2
          39 0 15

          fertilizer-to-water map:
          49 53 8
          0 11 42
          42 0 7
          57 7 4

          water-to-light map:
          88 18 7
          18 25 70

          light-to-temperature map:
          45 77 23
          81 45 19
          68 64 13

          temperature-to-humidity map:
          0 69 1
          1 0 69

          humidity-to-location map:
          60 56 37
          56 93 4
          """;

    [Fact]
    public void Loads_Data()
    {
        var almanac = Puzzle.LoadData(TestData);

        Assert.Equal(4, almanac.Seeds.Length);
        Assert.Equal(79, almanac.Seeds.First());
        Assert.Equal(13, almanac.Seeds.Last());

        Assert.Equal(2, almanac.Soil.Length);
        Assert.Equivalent(new Puzzle.MapDef(50, 98, 2), almanac.Soil[0]);
        Assert.Equivalent(new Puzzle.MapDef(52, 50, 48), almanac.Soil[^1]);

        Assert.Equal(3, almanac.Fertilizer.Length);
        Assert.Equivalent(new Puzzle.MapDef(49, 53, 8), almanac.Water[0]);
        Assert.Equivalent(new Puzzle.MapDef(57, 7, 4), almanac.Water[^1]);

        Assert.Equal(2, almanac.Location.Length);
        Assert.Equivalent(new Puzzle.MapDef(60, 56, 37), almanac.Location[0]);
        Assert.Equivalent(new Puzzle.MapDef(56, 93, 4), almanac.Location[^1]);
    }

    [Theory]
    [InlineData(79, 81)]
    [InlineData(14, 14)]
    [InlineData(55, 57)]
    [InlineData(13, 13)]
    public void Maps_To_Destination(long input, long expected)
    {
        var agroMap = Puzzle
            .LoadData(TestData)
            .ToAgroMap();

        Assert.Equal(expected, Puzzle.GetMappedDestination(input, agroMap.Soil));
    }

    [Theory]
    [InlineData(79, 82)]
    [InlineData(14, 43)]
    [InlineData(55, 86)]
    [InlineData(13, 35)]
    public void Runs_The_Map(long input, long expected)
    {
        var agroMap = Puzzle
            .LoadData(TestData)
            .ToAgroMap();

        Assert.Equal(expected, Puzzle.RunTheMap(input, agroMap));
    }
    
    [Fact]
    public void TestPartOne_TestData() => Assert.Equal("35", _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal("46", _puzzle.PartTwo(TestData)[0]);

    [Fact]
    public void TestPartOne() => Assert.Equal("3374647", _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact(Skip = "Only Takes about 2 hours to run as it is :)")]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}