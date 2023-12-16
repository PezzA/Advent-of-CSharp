﻿using Puzzle = AdventOfCSharp.Puzzles.Year23.Day17.Puzzle;

namespace AdventOfCSharp.Puzzles.Tests.Year23.Day17;

public class Tests
{
    private readonly Puzzle _puzzle = new();

    private const string TestData
        = """
          <insert test data here>
          """;

    [Fact]
    public void Loads_Data()
    {
    }

    [Fact]
    public void TestPartOne_TestData() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartOne(TestData)[0]);

    [Fact]
    public void TestPartTwo_TestData() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(TestData)[0]);
        
    [Fact]
    public void TestPartOne() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartOne(_puzzle.PuzzleInput())[0]);

    [Fact]
    public void TestPartTwo() => Assert.Equal(Constants.NOT_YET_IMPLEMENTED, _puzzle.PartTwo(_puzzle.PuzzleInput())[0]);
}