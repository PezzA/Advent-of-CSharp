namespace AdventOfCSharp.Puzzles.Geometery
{
    public static class OrdinalExtensions
    {
        public static Ordinal RotateLeft(this Ordinal ord) => ord switch
        {
            Ordinal.North => Ordinal.West,
            Ordinal.East => Ordinal.North,
            Ordinal.South => Ordinal.East,
            Ordinal.West => Ordinal.South,
            _ => throw new NotImplementedException(),
        };

        public static Ordinal RotateRight(this Ordinal ord) => ord switch
        {
            Ordinal.North => Ordinal.East,
            Ordinal.East => Ordinal.South,
            Ordinal.South => Ordinal.West,
            Ordinal.West => Ordinal.North,
            _ => throw new NotImplementedException(),
        };

        public static Ordinal RotateLeftOrRight(this Ordinal ord, Direction dir) => dir switch
        {
            Direction.Left => RotateLeft(ord),
            Direction.Right => RotateRight(ord),
            _ => throw new NotImplementedException(),
        };

        public static Point2D OrdinalTransform(this Ordinal direction) => direction switch
        {
            Ordinal.North => new Point2D(0, 1),
            Ordinal.East => new Point2D(1, 0),
            Ordinal.South => new Point2D(0, -1),
            Ordinal.West => new Point2D(-1, 0),
            _ => throw new NotImplementedException()
        };
    }
}
