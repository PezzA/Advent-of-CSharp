using AdventOfCSharp.Puzzles;
using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Year23.Day10;

namespace AdventOfCSharp.BlazorClient.Pages.Y23;

public class Y23D10
{
    public class Model
    {
        public int GridWidth => _grid[0].Length;
        public int GridHeight => _grid.Length;

        private readonly char[][] _grid;

        public Point2D Start => Puzzle.GetStart(_grid);
        
        private readonly Puzzle _puzzle = new();
        private readonly IBasicPuzzle _basicPuzzle = new Puzzle();

        public static PuzzleDataAttribute? MetaData => PuzzleManager.GetPuzzleMetaData(2023, 10);
 
        public Queue<Point2D> Queue => _puzzle.Queue;
        public Dictionary<Point2D, int> Points => _puzzle.Points;

        public int CellWidth => 7;
        
        public Model()
        {
            _grid = Puzzle.LoadData(_basicPuzzle.PuzzleInput());
        }

        public void Init()
        {
            _puzzle.Init(_grid);
        }

        public bool Update()
        {
            return _puzzle.NextLoop(_grid);
        }

        public char[][] Grid => _grid;
    }
}