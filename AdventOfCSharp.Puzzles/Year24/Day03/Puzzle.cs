using System.Text.RegularExpressions;

namespace AdventOfCSharp.Puzzles.Year24.Day03;

[PuzzleData(Year = 2024, Day = 3, Title = "Mull It Over", Stars = 0, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{

    public record Instruction(InstructionType Instuction, int Left, int Right);

    [GeneratedRegex(@"(?<ins>mul)\((?<left>\d*),(?<right>\d*)\)|(?<ins>do)\(\)|(?<ins>don't)\(\)")]
    private static partial Regex InputRegex();

    public enum InstructionType
    {
        Mul,
        Do,
        Dont
    }

    public static List<Instruction> LoadData(string input)
    {
        var retval = new List<Instruction>();

        var matches = InputRegex().Matches(input);

        foreach (Match match in matches)
        {

            switch (match.Groups["ins"].Value)
            {
                case "mul":
                    retval.Add(new Instruction(InstructionType.Mul, int.Parse(match.Groups["left"].Value), int.Parse(match.Groups["right"].Value)));
                    break;
                case "do":
                    retval.Add(new Instruction(InstructionType.Do, 0, 0));
                    break;
                case "don't":
                    retval.Add(new Instruction(InstructionType.Dont, 0, 0));
                    break;
                default:
                    throw new Exception($"invalid instruction type {match.Groups["ins"].Value}");

            }

        }

        return retval;
    }


    public string[] PartOne(string input)
    {
        var instructions = LoadData(input);

        return [instructions.Sum(i => i.Left * i.Right).ToString()];
    }

    public string[] PartTwo(string input)
    {
        var instructions = LoadData(input);

        var sum = 0;

        var enabled = true;
        for (int i = 0; i < instructions.Count; i++)
        {
            if (enabled && instructions[i].Instuction == InstructionType.Mul)
            {
                sum += instructions[i].Left * instructions[i].Right;
                continue;
            }

            if (instructions[i].Instuction == InstructionType.Do)
            {
                enabled = true;
                continue;
            }

            // only other option.
            enabled = false;
        }

        return [sum.ToString()];
    }
}