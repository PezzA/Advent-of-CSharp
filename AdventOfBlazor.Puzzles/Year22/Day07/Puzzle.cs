namespace AdventOfBlazor.Puzzles.Year22.Day07;

[PuzzleData(Year = 22, Day = 7, Title = "No Space Left On Device")]
public partial class Puzzle : IBasicPuzzle
{
    public static Directory LoadData(string input)
    {
        var lines = input
            .Split(Environment.NewLine)
            .Select(l => l.Replace("\r", "").Trim())
            .ToArray();

        var rootDirectory = new Directory("/");

        var currentDirectory = rootDirectory;

        foreach (var line in lines)
        {
            var bits = line.Split(" ");

            if (bits[0] == "$")
            {
                switch (bits[1])
                {
                    case "cd":
                        switch (bits[2])
                        {
                            case "/":
                                currentDirectory = rootDirectory;
                                break;
                            case "..":
                                currentDirectory = currentDirectory.Parent;
                                break;
                            default:
                                var targetDirectory = currentDirectory.FindDirectory(bits[2]);

                                if (targetDirectory != null)
                                {
                                    currentDirectory = targetDirectory;
                                }
                                break;
                        }
                        break;
                    case "ls":
                    default:
                        break;

                }

                continue;
            }

            if (bits[0] == "dir")
            {
                currentDirectory.SubDirectories.Add(new Directory(bits[1], currentDirectory));
                continue;
            }

            currentDirectory.Files.Add(new File(bits[1], Convert.ToInt32(bits[0])));
        }

        return rootDirectory;
    }

    public int GetFoldersOfSize(Directory dir, int size) => dir
             .GetFoldersOfMaxSize(size)
             .Sum(d => d.TotalSize);

    public string[] PartOne(string input) =>
        new string[] { GetFoldersOfSize(LoadData(input), 100000).ToString() };
    
    public string[] PartTwo(string input)
    {
        var dirStructure = LoadData(input);
        var fileSystemSize = 70000000;
        var spaceNeeded = 30000000;

        var unusedSpace = fileSystemSize - dirStructure.TotalSize;
        var spaceToReclaim = spaceNeeded - unusedSpace;
;
        var dir = dirStructure
            .GetFoldersOfMaxSize(spaceNeeded)
            .Where(d => d.TotalSize > spaceToReclaim)
            .OrderBy(d => d.TotalSize)
            .First();

        return new string[] { dir.TotalSize.ToString() };
    }
}