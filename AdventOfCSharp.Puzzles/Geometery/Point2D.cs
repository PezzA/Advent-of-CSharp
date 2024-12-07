using System.Diagnostics;
using System.Drawing;

namespace AdventOfCSharp.Puzzles.Geometery
{
    [DebuggerDisplay("[{X},{Y}]")]
    public record Point2D(int X, int Y)
    {
        public static Point2D Origin = new(0, 0);

        public Point2D Add(Point2D point) => new(X + point.X, Y + point.Y);

        public static Point2D operator *(Point2D a, int b) => new Point2D(a.X * b, a.Y * b);

        public static Point2D operator +(Point2D a, Point2D b) => new Point2D(a.X + b.X, a.Y + b.Y);

        public int Length => Math.Abs(X) + Math.Abs(Y);

        public int ManhattanDistance(Point2D target)
           => Math.Abs(X - target.X) + Math.Abs(Y - target.Y);

        /// <summary>
        /// TermNorth gets the 'Terminal Screen' north.  Which is descending y as 0 is the top row
        /// </summary>
        /// 
        public Point2D TermNorth() => this with { Y = Y - 1 };

        public Point2D TermSouth() => this with { Y = Y + 1 };

        public Point2D TermEast() => this with { X = X + 1 };

        public Point2D TermWest() => this with { X = X - 1 };


        public static Point2D BearingNorth => new(0, -1);

        public static Point2D BearingSouth => new(0, 1);

        public static Point2D BearingEast => new(1, 0);

        public static Point2D BearingWest => new(-1, 0);

        public static Point2D TurnRight(Point2D input) => input switch
        {
            ( 0, -1) => BearingEast,
            ( 1,  0) => BearingSouth,
            ( 0,  1) => BearingWest,
            (-1,  0) => BearingNorth,
            _ => throw new ArgumentException("Input was not a valid bearing")
        };
    }
}