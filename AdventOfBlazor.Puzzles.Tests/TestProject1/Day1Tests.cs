using AdventOfBlazor.Puzzles.Twenty22;

namespace AdventOfBlazor.Puzzles.Tests
{
    public class Day1Tests
    {
        [Fact]
        public void Test1()
        {
            var result = new Day1().PartOne(Day1.PUZZLE_INPUT);

            Assert.Equal("72017", result[0]);
        }
    }
}