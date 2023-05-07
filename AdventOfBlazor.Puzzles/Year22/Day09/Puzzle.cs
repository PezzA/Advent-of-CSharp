using AdventOfBlazor.Puzzles.Geometery;

namespace AdventOfBlazor.Puzzles.Year22.Day09;

[PuzzleData(Year = 2022, Day = 9, Title = "Rope Bridge", Stars = 0)]
public partial class Puzzle : IBasicPuzzle
{
    public class Instruction
    {
        public string Direction { get; set; } = string.Empty;
        public int Distance { get; set; }
    }

    public static Point2D MoveTail(Point2D Head, Point2D Tail)
    {
        // see if either head has moved too far from the tail
        var xDiff = Head.X - Tail.X;
        var yDiff = Head.Y - Tail.Y;

        var xEscape = Math.Abs(xDiff) < 2;
        var yEscape = Math.Abs(yDiff) < 2;

        if (!xEscape && !yEscape)
        {
            return Tail;
        }

        if (xEscape && !yEscape)
        {
            return new Point2D(Tail.X - (xDiff - 1), Tail.Y);
        }

    }

    public static Dictionary<Point2D, int> ProcessInstructions(List<Instruction> instructions)
    {
        var head = new Point2D(0, 0);
        var tail = new Point2D(0, 0);



        return new Dictionary<Point2D, int>();
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