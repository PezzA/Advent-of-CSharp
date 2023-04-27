using System.Diagnostics;

namespace AdventOfBlazor.Puzzles.Year22.Day07;

[DebuggerDisplay("{Name, nq} ({TotalSize})")]
public class Directory
{
    public string Name { get; set; } = string.Empty;
    public List<File> Files { get; set; } = new List<File>();

    private Directory? _parentDirectory = null;

    public List<Directory> SubDirectories { get; set; } = new List<Directory>();

    public Directory(string name, Directory? parent = null)
    {
        Name = name;
        _parentDirectory = parent;
    }

    public Directory FindDirectory(string name)
    {
        return SubDirectories.Single(d => d.Name == name);
    }

    public Directory Parent => _parentDirectory != null ? _parentDirectory : throw new InvalidOperationException("Cannot get parent of root");

    /// <summary>
    /// Recursive check!
    /// </summary>
    public int TotalSize => Files.Sum(f => f.Size) + SubDirectories.Sum(d => d.TotalSize);
}
