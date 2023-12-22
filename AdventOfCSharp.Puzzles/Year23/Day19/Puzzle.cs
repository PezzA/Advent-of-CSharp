using System.Text.RegularExpressions;
using AdventOfCSharp.Puzzles.Parsing;
using Newtonsoft.Json;
using RegisterSet = System.Collections.Generic.Dictionary<string, int>;

namespace AdventOfCSharp.Puzzles.Year23.Day19;

[PuzzleData(Year = 2023, Day = 19, Title = "Aplenty", Stars = 1, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    [GeneratedRegex(@"(?<key>\w*){(?<ins>.*)}")]
    private static partial Regex ParseRegex();

    [GeneratedRegex(@"(?<Register>\w*)(?<Operator><|>)(?<Value>\d*)")]
    private static partial Regex OperationRegex();

    public record Item(int X, int M, int A, int S);

    public record Node(RegisterSet Low, RegisterSet High, bool Accept);

    public record Instruction(string Register, string Operator, int Value, string Destination);

    public static (Dictionary<string, Instruction[]>, RegisterSet[]) LoadData(string input)
    {
        var lines = input.ParseStringArray() ?? throw new Exception("could not parse input");

        var capturingItems = false;

        var processes = new Dictionary<string, Instruction[]>();
        var items = new List<RegisterSet>();

        foreach (var line in lines)
        {
            if (line == string.Empty)
            {
                capturingItems = true;
                continue;
            }

            if (capturingItems)
            {
                var item = JsonConvert.DeserializeObject<Item>(line.Replace('=', ':')) ??
                           throw new Exception("could not parse item");

                var dict = new RegisterSet
                {
                    ["x"] = item.X,
                    ["m"] = item.M,
                    ["a"] = item.A,
                    ["s"] = item.S
                };

                items.Add(dict);

                continue;
            }

            var match = ParseRegex().Match(line);

            if (match.Success == false)
            {
                throw new InvalidDataException("could not parse process list");
            }

            var processName = match.Groups["key"].Value;
            var rawInsList = match.Groups["ins"].Value.Split(',');

            var insList = new List<Instruction>();
            foreach (var ins in rawInsList)
            {
                var bits = ins.Split(':');

                if (bits.Length == 1)
                {
                    insList.Add(new Instruction(string.Empty, "Direct", 0, bits[0]));
                    continue;
                }

                var destination = bits[1];

                var operationMatch = OperationRegex().Match(bits[0]);

                if (!operationMatch.Success)
                {
                    throw new Exception("could not parse operation");
                }

                insList.Add(new Instruction(
                    operationMatch.Groups["Register"].Value,
                    operationMatch.Groups["Operator"].Value,
                    int.Parse(operationMatch.Groups["Value"].Value),
                    destination));
            }

            processes.Add(processName, insList.ToArray());
        }

        return (processes, items.ToArray());
    }

    public static bool IsAccepted(RegisterSet item, Dictionary<string, Instruction[]> processes)
    {
        var outcome = string.Empty;

        var firstIns = "in";

        var currentProcess = processes[firstIns];

        while (outcome is not ("A" or "R"))
        {
            foreach (var ins in currentProcess)
            {
                var hit = false;
                switch (ins.Operator)
                {
                    case "Direct":
                        outcome = ins.Destination;
                        hit = true;
                        break;
                    case "<" when item[ins.Register] < ins.Value:
                        outcome = ins.Destination;
                        hit = true;
                        break;
                    case ">" when item[ins.Register] > ins.Value:
                        outcome = ins.Destination;
                        hit = true;
                        break;
                }

                if (hit)
                {
                    break;
                }
            }

            if (outcome is not ("A" or "R"))
            {
                currentProcess = processes[outcome];
            }
        }

        return outcome == "A";
    }


    public List<Node> WalkPaths(Dictionary<string, Instruction[]> processes)
    {
        var queue = new Queue<(Instruction[], Node)>();

        var nodeList = new List<Node>();

        queue.Enqueue(
            (
                processes["in"],
                new Node(
                    new RegisterSet { ["x"] = 1, ["m"] = 1, ["a"] = 1, ["s"] = 1 },
                    new RegisterSet { ["x"] = 4000, ["m"] = 4000, ["a"] = 4000, ["s"] = 4000 },
                    false)
            ));


        while (queue.Count > 0)
        {
            var (currInsList, currNode) = queue.Dequeue();

            foreach (var ins in currInsList)
            {
                if (ins.Operator == "<")
                {
                    queue.Enqueue((processes[ins.Destination], currNode with {}));
                }
            }
        }

        return nodeList;
    }

    public string[] PartOne(string input)
    {
        var (processes, items) = LoadData(input);

        var total = items
            .Where(item => IsAccepted(item, processes))
            .Sum(item => item["x"] + item["m"] + item["a"] + item["s"]);

        return new[] { total.ToString() };
    }

    public string[] PartTwo(string input)
    {
        var (processes, _) = LoadData(input);

        var nodes = WalkPaths(processes);

        var total = nodes
            .Where(n => n.Accept)
            .Sum(n =>
                (long)(n.High["x"] - n.Low["x"] + 1) *
                (n.High["m"] - n.Low["m"] + 1) *
                (n.High["a"] - n.Low["a"] + 1) *
                (n.High["s"] - n.Low["s"] + 1));

        return new[] { total.ToString() };
    }
}