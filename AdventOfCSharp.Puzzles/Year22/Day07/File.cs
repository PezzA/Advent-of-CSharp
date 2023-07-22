using System.Diagnostics;

namespace AdventOfCSharp.Puzzles.Year22.Day07;

[DebuggerDisplay("{Name,nq} {Size}")]
public record File(string Name, int Size);
