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
        public Point2D TermNorth => new (X, Y - 1);
        public Point2D TermSouth => new (X, Y + 1);
        public Point2D TermEast => new (X + 1, Y );
        public Point2D TermWest=> new (X-1, Y );
    }
}

