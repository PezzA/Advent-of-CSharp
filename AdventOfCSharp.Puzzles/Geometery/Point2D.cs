using System.Diagnostics;

namespace AdventOfCSharp.Puzzles.Geometery
{
    [DebuggerDisplay("[{X},{Y}]")]
    public record Point2D(int X, int Y)
    {
        public Point2D Add(Point2D point) => new(X + point.X, Y + point.Y);
        public int Length => Math.Abs(X) + Math.Abs(Y);

        /// <summary>
        /// TermNorth gets the 'Terminal Screen' north.  Which is descending y as 0 is the top row
        /// </summary>
        public Point2D TermNorth() => this with { Y = Y - 1 };

        public Point2D TermSouth() => this with { Y = Y + 1 };
        
        public Point2D TermEast() => this with { X = X + 1 };
        
        public Point2D TermWest() => this with { X = X - 1 };
    }
}