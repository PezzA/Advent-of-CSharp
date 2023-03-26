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
        public void Test_LoadData()
        {
            var (stacks, instructions) = puzzle.LoadData(puzzle.PuzzleInput());
           
            Assert.NotNull(stacks);
            Assert.Equal(9, stacks.Keys.Count);

            Assert.Equal('Q', stacks[1].Peek());
            Assert.Equal('G', stacks[2].Peek());
            Assert.Equal('B', stacks[3].Peek());
            Assert.Equal('N', stacks[4].Peek());
            Assert.Equal('F', stacks[5].Peek());
            Assert.Equal('J', stacks[6].Peek());
            Assert.Equal('V', stacks[7].Peek());
            Assert.Equal('N', stacks[8].Peek());
            Assert.Equal('M', stacks[9].Peek());

            Assert.NotNull(instructions);
        }

        [Fact]
        public void Test_Instruction()
        {
            var (stacks, instructions) = puzzle.LoadData(puzzle.PuzzleInput());

            stacks = puzzle.ProcessInstruction(stacks, instructions[0]);

            Assert.Equal(7, stacks[2].Count);
            Assert.Equal('F', stacks[2].Peek());
            Assert.Empty(stacks[6]);
        }

        [Fact]
        public void TestPartOne()
        {
            var result = puzzle.PartOne(puzzle.PuzzleInput());
            Assert.Equal("FJSRQCFTN", result[0]);
        }

        [Fact]
        public void TestPartTwo()
        {
            var result = puzzle.PartTwo(puzzle.PuzzleInput());
            Assert.Equal("CJVLJQPHS", result[0]);
        }
    }
}