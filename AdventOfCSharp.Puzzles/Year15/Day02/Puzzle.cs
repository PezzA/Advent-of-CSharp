using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year15.Day02;

[PuzzleData(Year = 2015, Day = 2, Title = "I Was Told There Would Be No Math", Stars = 2, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public record Box(int Length, int Width, int Height)
    {
        public int SurfaceArea => (2 * Length * Width) + (2 * Width * Height) + (2 * Height * Length);

        public int SmallestSide
        {
            get
            {
                List<int> sides = [Length, Width, Height];

                sides.Sort();

                return sides[0] * sides[1];
            }
        }

        public int SmallestPerimeter
        {
            get
            {
                List<int> sides = [Length, Width, Height];

                sides.Sort();

                return (sides[0] * 2) + (sides[1] * 2);
            }
        }

        public int Volume => Length * Height * Width;
    }

    public static List<Box> LoadData(string input)
    {
        var retVal = new List<Box>();

        var lines = input.ParseStringArray() ?? throw new Exception("Could not parse data");

        return lines
            .Select(ParseBox)
            .ToList();
    }

    public static Box ParseBox(string input)
    {
        var bits = input.Split("x");

        return new Box(int.Parse(bits[0]), int.Parse(bits[1]), int.Parse(bits[2]));
    }

    public string[] PartOne(string input)
    {
        var boxes = LoadData(input);

        return [boxes.Sum(b => b.SurfaceArea + b.SmallestSide).ToString()];
    }

    public string[] PartTwo(string input)
    {
        var boxes = LoadData(input);

        return [boxes.Sum(b => b.SmallestPerimeter + b.Volume).ToString()];
    }
}