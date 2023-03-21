using AdventOfBlazor.Puzzles.Twenty22;

namespace AdventOfBlazor.Puzzles.Tests
{
    public class Day3Tests
    {
        readonly Day3 puzzle;

        public Day3Tests()
        {
            puzzle = new Day3();
        }

        [Theory]
        [InlineData("abcdef", "abc", "def")]
        public void Test_SplitCompartment(string input, string firstActual, string secondActual)
        {
            var (first, second) = puzzle.SplitCompartments(input);

            Assert.Equal(firstActual, first);
            Assert.Equal(secondActual, second);
        }

        [Theory]
        [InlineData("abc", "def", ' ')]
        [InlineData("abc", "dec", 'c')]
        public void Test_GetSharedItem(string first, string second, char match)
        {
            var testMatch = puzzle.GetSharedItem(first, second);

            Assert.Equal(match, testMatch);
        }

        [Theory]
        [InlineData('a', 1)]
        [InlineData('z', 26)]
        [InlineData('A', 27)]
        [InlineData('Z', 52)]
        public void Test_GetItemValue(char input, int expected)
        {
            var result = puzzle.GetItemValue(input);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void TestPartOne()
        {
            var result = puzzle.PartOne(puzzle.PuzzleInput());
            Assert.Equal("8243", result[0]);
        }

        [Fact]
        public void TestPartTwo()
        {
            var result = puzzle.PartTwo(puzzle.PuzzleInput());
            Assert.Equal("2631", result[0]);
        }
    }
}