using AdventOfCSharp.Puzzles.Year16.Day11;
namespace AdventOfCSharp.Puzzles.Tests.Year16.Day11;

public class Tests
{
    private readonly Puzzle puzzle;

    public Tests()
    {
        puzzle = new Puzzle();
    }

    [Fact]
    public void LoadTestData()
    {
        var facility = Puzzle.LoadData(puzzle.PuzzleInput());

        Assert.Equal(2, facility.Floors[0].Devices.Count);
        Assert.Contains(facility.Floors[0].Devices, d => d == new Device("promethium", DeviceType.Generator));
        Assert.Contains(facility.Floors[0].Devices, d => d == new Device("promethium", DeviceType.Microchip));

        Assert.Empty(facility.Floors[3].Devices);
        Assert.Equal(0, facility.ElevatorLevel);
    }

    [Fact]
    public void TestFacilityEquality()
    {
        var fac1 = Puzzle.LoadData(puzzle.PuzzleInput());
        var fac2 = Puzzle.LoadData(puzzle.PuzzleInput());

        // Equality is just based on items, not sequence equality
        fac2.Floors[0].Devices.Reverse();

        Assert.True(fac1.Equals(fac2));
    }

    [Fact]
    public void TestPartOne() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, puzzle.PartOne(puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, puzzle.PartTwo(puzzle.PuzzleInput())[0]);
}