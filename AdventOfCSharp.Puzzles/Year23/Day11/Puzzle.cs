using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Parsing;

namespace AdventOfCSharp.Puzzles.Year23.Day11;

[PuzzleData(Year = 2023, Day = 11, Title = "Cosmic Expansion", Stars = 0, ImplementedElsewhere = false)]
public partial class Puzzle : IBasicPuzzle
{
    public static Point2D[] LoadData(string input, int ageFactor)
    {
        //var explodedData = ExplodeUniverse(input, ageFactor);

        var lines = input.ParseStringArray() ?? throw new Exception("could not parse input");

        var stars = new List<Point2D>();

        for (var y = 0; y < lines.Length; y += 1)
        {
            for (var x = 0; x < lines[y].Length; x += 1)
            {
                if (lines[y][x] == '#')
                {
                    stars.Add(new Point2D(x, y));
                }
            }
        }


        var bumped = 0;
        for (var i = 0; i < lines.Length; i++)
        {
            if (!lines[i].Contains('#'))
            {
                
                for (var starIndex = 0; starIndex < stars.Count; starIndex++)
                {
                    var computeStar = stars[starIndex];
                    
                    if (computeStar.Y >= i + (bumped * ageFactor))
                    {
                        stars[starIndex] = computeStar with { Y = ageFactor + computeStar.Y };
                    }
                }

                bumped += 1;
            }
        }

        bumped = 0;
        for (var i = 0; i < lines[0].Length; i++)
        {
            var isBlankColumn = lines.All(line => line[i] == '.');

            if (isBlankColumn)
            {
                for (var starIndex = 0; starIndex < stars.Count; starIndex++)
                {
                    var computeStar = stars[starIndex];
                    
                    if (computeStar.X >= i + (bumped * ageFactor))
                    {
                        stars[starIndex] = computeStar with { X = computeStar.X + ageFactor };
                    }
                }

                bumped += 1;
            }
        }


        return stars.ToArray();
    }


    public record Pair(Point2D A, Point2D B);

    public string[] PartOne(string input)
    {
        var stars = LoadData(input, 1);
        var starMap = new Dictionary<Pair, int>();

        foreach (var starA in stars)
        {
            foreach (var starB in stars)
            {
                if (starA == starB ||
                    starMap.ContainsKey(new Pair(starA, starB)) ||
                    starMap.ContainsKey(new Pair(starB, starA))) continue;

                starMap[new Pair(starA, starB)] = starA.ManhattanDistance(starB);
            }
        }

        return new[] { starMap.Sum(p => p.Value).ToString() };
    }

    public long SolvePartTwo(string input, int ageFactor)
    {
        var stars = LoadData(input, ageFactor);
        var starMap = new Dictionary<Pair, int>();

        foreach (var starA in stars)
        {
            foreach (var starB in stars)
            {
                if (starA == starB ||
                    starMap.ContainsKey(new Pair(starA, starB)) ||
                    starMap.ContainsKey(new Pair(starB, starA))) continue;

                starMap[new Pair(starA, starB)] = starA.ManhattanDistance(starB);
            }
        }

        return starMap.Sum(p => (long)p.Value);

    }

    public string[] PartTwo(string input)
    {
        var stars = LoadData(input, 1000000);
        var starMap = new Dictionary<Pair, int>();

        foreach (var starA in stars)
        {
            foreach (var starB in stars)
            {
                if (starA == starB ||
                    starMap.ContainsKey(new Pair(starA, starB)) ||
                    starMap.ContainsKey(new Pair(starB, starA))) continue;

                starMap[new Pair(starA, starB)] = starA.ManhattanDistance(starB);
            }
        }

        return new[] { starMap.Sum(p => (long)p.Value).ToString() };
    }
}