
namespace AdventOfBlazor.Puzzles.Twenty22
{
    [PuzzleData(Year = 2022, Day = 2, Title = "Rock Paper Scissors", Stars = 2, ImplementedElsewhere = false)]
    public partial class Day2 : IBasicPuzzle
    {
        private readonly Dictionary<string, int> Scores = new()
        {
            { "AX", 3+1 },
            { "BX", 0+1 },
            { "CX", 6+1 },
            { "AY", 6+2 },
            { "BY", 3+2 },
            { "CY", 0+2 },
            { "AZ", 0+3 },
            { "BZ", 6+3 },
            { "CZ", 3+3 },
        };

        private readonly Dictionary<string, int> Scores_Second = new()
        {
            { "AX", 3+0 },
            { "BX", 1+0 },
            { "CX", 2+0 },
            { "AY", 1+3 },
            { "BY", 2+3 },
            { "CY", 3+3 },
            { "AZ", 2+6 },
            { "BZ", 3+6 },
            { "CZ", 1+6 },
        };

        public class Instruction
        {
            public string OpponentPlay { get; set; } = string.Empty;
            public string MyPlay { get; set; } = string.Empty;
            public string ToShortString()
            {
                return OpponentPlay + MyPlay;
            }
        }

        public List<Instruction> LoadData(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var instructions = new List<Instruction>();

            foreach (var line in lines)
            {
                var bits = line.Split(" ");
                if (bits.Length > 0)
                {
                    instructions.Add(new Instruction { OpponentPlay = bits[0].Trim(), MyPlay = bits[1].Trim() });
                }
            }
            return instructions;
        }

        public string[] PartOne(string input)
        {
            var instructions = LoadData(input);
            var count = 0;

            foreach (var instruction in instructions)
            {
                count += Scores[instruction.ToShortString()];
            }
            return new string[] { count.ToString() };
        }

        public string[] PartTwo(string input)
        {
            var instructions = LoadData(input);
            var count = 0;

            foreach (var instruction in instructions)
            {
                count += Scores_Second[instruction.ToShortString()];
            }
            return new string[] { count.ToString() };
        }
    }
}