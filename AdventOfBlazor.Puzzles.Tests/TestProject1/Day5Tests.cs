using AdventOfBlazor.Puzzles.Twenty22;

namespace AdventOfBlazor.Puzzles.Tests
{
    public class Day5Tests
    {
        readonly Day5 puzzle;

        public Day5Tests()
        {
            puzzle = new Day5();
        }

        [Fact]
        public void TestPartOne()
        {
            var result = puzzle.PartOne(puzzle.PuzzleInput());
            Assert.Equal("", result[0]);
        }

        [Fact]
        public void TestPartTwo()
        {
            var result = puzzle.PartTwo(puzzle.PuzzleInput());
            Assert.Equal("", result[0]);
        }
    }
}