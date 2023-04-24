using AdventOfBlazor.Puzzles.Geometery;
using System.Diagnostics;

namespace AdventOfBlazor.Puzzles.Year16.Day01;

[PuzzleData(Year = 2016, Day = 1, Title = "No Time for a Taxicab", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    [DebuggerDisplay("{Direction},{Distance}")]
    public class Instruction
    {
        public Direction Direction { get; set; }
        public int Distance { get; set; }
    }

    public static List<Instruction> LoadData(string input) => input
        .Split(',')
        .Select(ParseInstruction)
        .ToList();

    public static Instruction ParseInstruction(string input)
    {
        input = input.Trim();

        return new Instruction
        {
            Direction = input[0] == 'L' ? Direction.Left : Direction.Right,
            Distance = Convert.ToInt32(input[1..])
        };
    }

    public static Point2D ProcessInstructions(List<Instruction> instructions, bool stopAtFirstCollision)
    {
        var direction = Ordinal.North;

        var position = new Point2D(0, 0);

        var visits = new Dictionary<Point2D, bool>();

        foreach (var instruction in instructions)
        {
            direction = direction.RotateLeftOrRight(instruction.Direction);

            for (var i = 0; i < instruction.Distance; i++)
            {
                position = position.Add(direction.OrdinalTransform());

                if (stopAtFirstCollision && visits.ContainsKey(position)) {
                    return position;
                }

                visits[position] = true;
            }
        }

        return position;
    }

    public string[] PartOne(string input)
    {
        var instructions = LoadData(input);

        var finalPosition = ProcessInstructions(instructions, false);

        return new string[] { finalPosition.Length.ToString() };
    }

    public string[] PartTwo(string input)
    {
        var instructions = LoadData(input);

        var finalPosition = ProcessInstructions(instructions, true);

        return new string[] { finalPosition.Length.ToString() };
    }
}