using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year24.Day05;

[PuzzleData(Year = 2024, Day = 5, Title = "Print Queue", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public record Instruction(int Left, int Right);

    public static (List<Instruction>, List<List<int>>) LoadData(string input)
    {
        var insList = new List<Instruction>();
        var pagesList = new List<List<int>>();

        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse input");

        var processPages = false;

        foreach (var line in lines)
        {
            if (line == string.Empty)
            {
                processPages = true;
                continue;
            }

            if (!processPages)
            {
                var bits = line.Split("|");
                insList.Add(new Instruction(int.Parse(bits[0]), int.Parse(bits[1])));
                continue;
            }

            // process pages
            pagesList.Add(line.Split(",").Select(int.Parse).ToList());
        }

        return (insList, pagesList);
    }

    public static List<int> WeirdBubbleSort(List<int> pageList, List<Instruction> instructions)
    {
        for (int p = 0; p < pageList.Count; p++)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.Left != pageList[p] && instruction.Right != pageList[p]) continue;

                var indexOfValue = p;
                var pageValue = pageList[p];

                if (indexOfValue == -1) continue;

                if (instruction.Left == pageValue)
                {
                    var indexOfCompare = pageList.IndexOf(instruction.Right);
                    if (indexOfCompare == -1) continue;

                    if (indexOfCompare < indexOfValue)
                    {
                        pageList[indexOfValue] = instruction.Right;
                        pageList[indexOfCompare] = instruction.Left;
                        return pageList;
                    };
                }

                if (instruction.Right == pageValue)
                {
                    var indexOfCompare = pageList.IndexOf(instruction.Left);
                    if (indexOfCompare == -1) continue;

                    if (indexOfCompare > indexOfValue)
                    {
                        pageList[indexOfValue] = instruction.Left;
                        pageList[indexOfCompare] = instruction.Right;
                        return pageList;
                    }; 
                }
            }

        }

        return pageList;
    }

    public List<int> DoWeiredBubbleSort(List<int> pageList, List<Instruction> instructions) {

        while (!IsPageListInOrder(pageList, instructions))
        { 
            pageList = WeirdBubbleSort(pageList, instructions);
        }

        return pageList;
    
    }
    public static bool IsPageListInOrder(List<int> pageList, List<Instruction> instructions)
    {
        foreach (var page in pageList)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.Left != page && instruction.Right != page) continue;

                var indexOfValue = pageList.IndexOf(page);

                if (indexOfValue == -1) continue;

                if (instruction.Left == page)
                {
                    var indexOfCompare = pageList.IndexOf(instruction.Right);
                    if (indexOfCompare == -1) continue;

                    if (indexOfCompare < indexOfValue)
                    {
                        return false;
                    };
                }

                if (instruction.Right == page)
                {
                    var indexOfCompare = pageList.IndexOf(instruction.Left);
                    if (indexOfCompare == -1) continue;

                    if (indexOfCompare > indexOfValue)
                    {
                        return false;
                    }; ;
                }
            }
        }
        return true;
    }
    
    public static int GetMiddleNumber(List<int> pages)
    {
        if (pages.Count % 2 == 0) throw new Exception("Going to have to deal with 2 middle numbers");

        var half = pages.Count / 2;

        return pages[half];
    }

    public string[] PartOne(string input)
    {
        var (insList, pages) = LoadData(input);

        var sum = 0;

        foreach (var update in pages)
        {
            if (IsPageListInOrder(update, insList))
            {
                var middle = GetMiddleNumber(update);
                sum += middle;
            }
        }

        return [sum.ToString()];
    }

    public string[] PartTwo(string input)
    {
        var (insList, pages) = LoadData(input);

        var sum = 0;

        foreach (var update in pages)
        {
            if (!IsPageListInOrder(update, insList))
            {
                var sortedList = DoWeiredBubbleSort(update, insList);

                var middle = GetMiddleNumber(sortedList);
                sum += middle;
            }
        }

        return [sum.ToString()];
    }
}