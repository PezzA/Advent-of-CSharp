using AdventOfBlazor.Puzzles.Twenty22;

namespace AdventOfBlazor.Puzzles.Tests
{
    public class Day1Tests
    {
        [Fact]
        public void Test1()
        {
            IBasicPuzzle puzz = new Day1();

            var result = puzz.PartOne(puzz.PuzzleInput());

            Assert.Equal("72017", result[0]);
        }
    }
}