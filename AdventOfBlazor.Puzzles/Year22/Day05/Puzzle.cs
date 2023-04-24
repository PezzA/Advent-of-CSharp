namespace AdventOfBlazor.Puzzles.Year22.Day05;

[PuzzleData(Year = 2022, Day = 5, Title = "Supply Stacks", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public class Instruction
    {
        public int Amount { get; set; }
        public int Source { get; set; }
        public int Target { get; set; }
    }

    public (Dictionary<int, Stack<char>>, List<Instruction>) LoadData(string input)
    {
        var lines = input.Split(Environment.NewLine);
        var stackList = new Dictionary<int, Stack<char>>();
        var instructions = new List<Instruction>();
        var loadingInstructions = false;

        foreach (var line in lines)
        {
            if (line.Trim() == string.Empty)
            {
                loadingInstructions = true;
                continue;
            }

            if (loadingInstructions)
            {
                var bits = line.Split(' ');

                instructions.Add(new Instruction
                {
                    Amount = Convert.ToInt32(bits[1]),
                    Source = Convert.ToInt32(bits[3]),
                    Target = Convert.ToInt32(bits[5])
                });

                continue;
            }

            if (line[0] != '[') continue;

            for (var i = 0; i < line.Length; i += 4)
            {
                if (line[i] != '[') continue;

                // stackIndex has explicit conversion from zero based to 1 based numbering to tie up with instructions
                var stackIndex = (i / 4) + 1;

                if (!stackList.ContainsKey(stackIndex))
                {
                    stackList[stackIndex] = new Stack<char>();
                }

                stackList[stackIndex].Push(line[i + 1]);
            }

        }

        foreach (var (key, value) in stackList)
        {
            stackList[key] = new Stack<char>(value);
        }

        return (stackList, instructions);
    }

    public Dictionary<int, Stack<char>> ProcessInstruction(Dictionary<int, Stack<char>> stackList, Instruction instruction)
    {
        for (var i = 0; i < instruction.Amount; i++)
        {
            var movingChar = stackList[instruction.Source].Pop();
            stackList[instruction.Target].Push(movingChar);
        }

        return stackList;
    }

    public Dictionary<int, Stack<char>> ProcessInstructionPreservingOrder(Dictionary<int, Stack<char>> stackList, Instruction instruction)
    {
        var items = new Stack<char>();

        for (var i = 0; i < instruction.Amount; i++)
        {
            var movingChar = stackList[instruction.Source].Pop();
            items.Push(movingChar);
        }

        for (var i = 0; i < instruction.Amount; i++)
        {
            var movingChar = items.Pop();
            stackList[instruction.Target].Push(movingChar);
        }

        return stackList;
    }

    private static string GetStackString(Dictionary<int, Stack<char>> stacks)
    {
        var stackString = string.Empty;

        for (var i = 1; i <= stacks.Count; i++)
        {
            stackString += stacks[i].Peek();
        }

        return stackString;
    }

    public string[] PartOne(string input)
    {
        var (stacks, instructions) = LoadData(input);

        foreach (var instruction in instructions)
        {
            stacks = ProcessInstruction(stacks, instruction);
        }

        string stackString = GetStackString(stacks);

        return new string[] { stackString };
    }



    public string[] PartTwo(string input)
    {
        var (stacks, instructions) = LoadData(input);

        foreach (var instruction in instructions)
        {
            stacks = ProcessInstructionPreservingOrder(stacks, instruction);
        }

        string stackString = GetStackString(stacks);

        return new string[] { stackString };
    }
}