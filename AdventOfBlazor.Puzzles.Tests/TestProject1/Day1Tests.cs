using AdventOfBlazor.Puzzles;

namespace TestProject1
{
    public class Day1Tests
    {
        [Fact]
        public void Test1()
        {
            var puzzleSpec = new Day1();

            var result = puzzleSpec.SolveDayOne(Day1.PUZZLE_INPUT);

            Assert.Equal("72017", result);
        }
    }
}