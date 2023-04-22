using System.Diagnostics;

namespace AdventOfBlazor.Puzzles.Geometery
{
    [DebuggerDisplay("[{X},{Y}]")]
    public record Point2D(int X, int Y)
    {
        public Point2D Add(Point2D point) => new(X + point.X, Y + point.Y);
        public int Length => Math.Abs(X) + Math.Abs(Y);
    }
}
