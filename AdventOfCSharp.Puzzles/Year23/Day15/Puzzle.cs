
namespace AdventOfCSharp.Puzzles.Year23.Day15;

[PuzzleData(Year = 2023, Day = 15, Title = "Lens Library", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public record Lens(string Label, int Length, bool Remove);

    public string[] LoadData(string input)
    {
        return input.Split(',');
    }

    public int GetHash(string input)
    {
        var hash = 0;

        foreach (var hashChar in input)
        {
            hash += hashChar;
            hash *= 17;
            hash %= 256;
        }

        return hash;
    }

    public static Lens GetAddInstruction(string input)
    {
        var bits = input.Split('=');

        return new Lens(bits[0], int.Parse(bits[1]), false);
    }

    public static Lens GetRemoveInstruction(string input)
    {
        return new Lens(input.Substring(0, input.Length - 1), 0, true);
    }

    public Dictionary<int, LinkedList<Lens>> SetupLens(string[] input)
    {
        var hashMap = new Dictionary<int, LinkedList<Lens>>();

        for (var index = 0; index < 256; index++)
        {
            hashMap[index] = new LinkedList<Lens>();
        }

        foreach (var item in input)
        {
            var parsedItem = item.Contains('=')
                ? GetAddInstruction(item)
                : GetRemoveInstruction(item);

            var box = GetHash(parsedItem.Label);

            if (!parsedItem.Remove)
            {
                if (hashMap[box].Count == 0)
                {
                    hashMap[box].AddFirst(parsedItem);
                    continue;
                }

                var found = false;
                for (var node = hashMap[box].First; node != null; node = node.Next)
                {
                    if (node.Value.Label != parsedItem.Label) continue;

                    node.Value = parsedItem;
                    found = true;
                    break;
                }

                if (!found)
                {
                    hashMap[box].AddLast(parsedItem);
                }

                continue;
            }

            for (var node = hashMap[box].First; node != null; node = node.Next)
            {
                if (node.Value.Label == parsedItem.Label)
                {
                    hashMap[box].Remove(node);
                }
            }
        }

        return hashMap;
    }

    public string[] PartOne(string input)
    {
        var data = LoadData(input);

        return new[] { data.Sum(GetHash).ToString() };
    }

    public string[] PartTwo(string input)
    {
        var data = LoadData(input);

        var hashMap = SetupLens(data);
        var total = 0;
        foreach (var (key, value) in hashMap)
        {
            var index = 1;
            for (var node = value.First; node != null; node = node.Next)
            {
                total += (key + 1) * index * node.Value.Length;
                index += 1;
            }
        }

        return new[] { total.ToString()};
    }
}