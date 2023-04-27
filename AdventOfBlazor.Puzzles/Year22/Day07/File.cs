using System.Diagnostics;

namespace AdventOfBlazor.Puzzles.Year22.Day07;

[DebuggerDisplay("{Name,nq} {Size}")]
public record File(string Name, int Size);
