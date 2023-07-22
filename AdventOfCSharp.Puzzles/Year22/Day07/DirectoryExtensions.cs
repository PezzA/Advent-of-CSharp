namespace AdventOfCSharp.Puzzles.Year22.Day07;

public static class DirectoryExtensions {

    /// <summary>
    /// Recursive check on directory return all folders (including the specified folder) which have a TotalSize of at most
    /// size
    /// </summary>
    /// <param name="dir"></param>
    /// <param name="size"></param>
    /// <returns></returns>
    public static List<Directory> GetFoldersOfMaxSize(this Directory dir, int size) {

        var dirs = new List<Directory>();
        if (dir.TotalSize <= size) { 
            dirs.Add(dir);
        }

        foreach (var subDir in dir.SubDirectories)
        {
            dirs.AddRange(subDir.GetFoldersOfMaxSize(size));
        }

        return dirs;
    }       
}
