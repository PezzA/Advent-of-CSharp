namespace AdventOfCSharp.Puzzles
{
    public interface IBasicPuzzle
    {
        string[] PartOne(string input);
        string[] PartTwo(string input);
        string PuzzleInput();
    }
}
