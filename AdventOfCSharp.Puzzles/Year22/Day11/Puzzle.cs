using System.Numerics;

namespace AdventOfCSharp.Puzzles.Year22.Day11;

[PuzzleData(Year = 2022, Day = 11, Title = "Monkey in the Middle", Stars = 1, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public enum WorryOperation
    {
        Add,
        Multiply
    }

    public class Monkey
    {
        public List<BigInteger> Items { get; set; } = new List<BigInteger>();
        public WorryOperation Operation { get; set; }
        public int OperationValue { get; set; }
        public int TestValue { get; set; }
        public int TestTrue { get; set; }
        public int TestFalse { get; set; }

        private int _inspectionCount = 0;

        public int Inspections => _inspectionCount;

        public BigInteger ProcessWorry(BigInteger value)
        {
            _inspectionCount++;
            var processingValue = OperationValue == -1 ? value : OperationValue;

            return Operation == WorryOperation.Add
                ? value + processingValue
                : value * processingValue;
        }
    }

    public static List<Monkey> LoadData(string input)
    {
        var lines = input
            .Split(Environment.NewLine)
            .Select(l => l.Replace("\r", "").Trim())
            .ToArray();

        var returnData = new List<Monkey>();

        for (int i = 0; i < lines.Length; i++)
        {
            if (!lines[i].StartsWith("Monkey"))
            {
                continue;
            }

            var heldItems = lines[i + 1]
                .Split(":")[1]
                .Trim()
                .Split(",")
                .Select(val => new BigInteger(Convert.ToInt32(val)))
                .ToList();

            var operationBits = lines[i + 2]
                 .Split("=")[1]
                 .Trim()
                 .Split(" ")
                 .ToList();

            var testValue = lines[i + 3]
                .Split("by")[1]
                .Trim();

            var testTrue = lines[i + 4]
                .Split("monkey")[1]
                .Trim();

            var testFalse = lines[i + 5]
                .Split("monkey")[1]
                .Trim();

            var monkey = new Monkey()
            {
                Items = heldItems,
                Operation = operationBits[1] == "+" ? WorryOperation.Add : WorryOperation.Multiply,
                OperationValue = operationBits[2] == "old" ? -1 : Convert.ToInt32(operationBits[2]),
                TestValue = Convert.ToInt32(testValue),
                TestTrue = Convert.ToInt32(testTrue),
                TestFalse = Convert.ToInt32(testFalse)
            };

            returnData.Add(monkey);
        }

        return returnData;
    }

    public static List<Monkey> RunRound(List<Monkey> monkeys, int divisor)
    {
        foreach (var m in monkeys)
        {
            foreach (var item in m.Items)
            {
                var newWorry = m.ProcessWorry(item);

                if (divisor != 0)
                {
                    newWorry /= divisor;
                }

                if (newWorry % m.TestValue == 0)
                {
                    newWorry -= 500 * m.TestValue;
                    monkeys[m.TestTrue].Items.Add(newWorry);
                }
                else {
                    monkeys[m.TestFalse].Items.Add(newWorry);
                }
            }
            m.Items = new List<BigInteger>();
        }
        return monkeys;
    }

    public string[] PartOne(string input)
    {
        var monkeys = LoadData(input);

        for (int i = 0; i < 20; i++)
        {
            monkeys = RunRound(monkeys, 3);
        }

        var items = monkeys.Select(x => new BigInteger(x.Inspections))
            .OrderDescending()
            .Take(2)
            .ToList();

        var monkeyBusiness = items[0] * items[1];

        return new string[] { monkeyBusiness.ToString() };
    }

    public string[] PartTwo(string input)
    {
        var monkeys = LoadData(input);

        for (int i = 0; i < 10000; i++)
        {
           
            monkeys = RunRound(monkeys, 0);

            var itemsInner = monkeys.Select(x => new BigInteger(x.Inspections))
                .OrderDescending()
                .Take(2)
                .ToList();

            if (i+1 == 1 || i + 1 == 20 || (i + 1) % 1000 == 0) {
                Console.WriteLine($"== After round {i+1} ==");
                for (int m = 0; m < monkeys.Count; m++) { 
                    Console.WriteLine($"Monkey {m} inspected items {monkeys[m].Inspections} times.");
                }
            }

            if ((i + 1) % 100 == 0)
            {
                Console.WriteLine($"== Ping round {i + 1} {DateTime.Now} ==");
            }
        }


        var items = monkeys.Select(x => new BigInteger(x.Inspections))
               .OrderDescending()
               .Take(2)
               .ToList();

        var monkeyBusiness = items[0] * items[1];


        return new string[] { monkeyBusiness.ToString() };
    }
}
