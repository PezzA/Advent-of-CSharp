namespace AdventOfBlazor.Puzzles.Year22.Day09;

[PuzzleData(Year = 2022, Day = 9, Title = "Rope Bridge", Stars = 0)]
public partial class Puzzle : IBasicPuzzle
{
    public class Instruction
    {
        public string Direction { get; set; } = string.Empty;
        public int Distance { get; set; }
    }

    public List<Instruction> LoadData(string input)
    {
        return input
            .Split(Environment.NewLine)
            .Select(l => l.Replace("\r", ""))
            .Select((l) =>
            {
                var bits = l.Split(" ");
                return new Instruction() { Direction = bits[0], Distance = Convert.ToInt32(bits[1]) };
            })
            .ToList();
    }

    public string[] PartOne(string input)
    {
        return new string[] { Constants.NOT_YET_IMPLEMENTED };
    }

    public string[] PartTwo(string input)
    {
        return new string[] { Constants.NOT_YET_IMPLEMENTED };
    }
}