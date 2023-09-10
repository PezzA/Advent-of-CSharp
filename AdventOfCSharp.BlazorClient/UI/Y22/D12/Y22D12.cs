using AdventOfCSharp.Puzzles;
using AdventOfCSharp.Puzzles.Geometery;
using AdventOfCSharp.Puzzles.Parsing;
using AdventOfCSharp.Puzzles.Year22.Day12;
using Blazor.Extensions.Canvas.Canvas2D;

namespace AdventOfCSharp.BlazorClient.UI.Y22.D12
{
    public class Model
    {
        public Dictionary<Point2D, char> Map { get; set; } = new Dictionary<Point2D, char>();
        public Queue<Point2D> Queue { get; set; } = new Queue<Point2D>();
        public List<Point2D> DrawQueue { get; set; } = new List<Point2D>();
        public Dictionary<Point2D, int> Distances { get; set; } = new Dictionary<Point2D, int>();
        public bool Finished { get; set; }

        private Queue<Point2D> PrevQueue { get; set; } = new Queue<Point2D>();

        private readonly Puzzle _puzzle;

        public PuzzleDataAttribute? MetaData => PuzzleManager.GetPuzzleMetaData(2022, 12);

        private readonly string[] _lines;

        public Model()
        {

            _puzzle = new Puzzle();
            _lines = _puzzle.PuzzleInput().ParseStringArray() ?? Array.Empty<string>();
            Map = Puzzle.LoadData(_puzzle.PuzzleInput());
            Map.OrderBy(x => x.Value);
        }

        public int GridWidth => _lines[0].Length;

        public int GridHeight => _lines.Length;

        public void Init()
        {
            var start = Puzzle.GetStart(Map);
            Queue = new Queue<Point2D>();
            Queue.Enqueue(start);
            PrevQueue = new Queue<Point2D>();

            Distances = new Dictionary<Point2D, int>
            {
                [start] = 0
            };
            Finished = false;
        }

        public void Update()
        {
            Puzzle.RunQueue(Map, Distances, Queue);

            foreach (var item in Queue)
            {
                if (!PrevQueue.Contains(item))
                {
                    DrawQueue.Add(item);
                }
            }

            PrevQueue = new Queue<Point2D>();

            foreach (var item in Queue)
            {
                PrevQueue.Enqueue(item);
            }

            if (Queue.Count == 0)
            {
                Finished = true;
            }
        }
    }


    public class RenderExtensions
    {
        public static async ValueTask RenderMap(Model model, Dictionary<char, string> colors, int cellWidth, Canvas2DContext context)
        {
            await context.SetFillStyleAsync("black");
            await context.FillRectAsync(0, 0, model.GridWidth * cellWidth + 1, model.GridHeight * cellWidth + 1);

            var prevCol = string.Empty;

            foreach (var item in model.Map)
            {
                if (colors[item.Value] != prevCol)
                {
                    prevCol = colors[item.Value];
                    await context.SetFillStyleAsync(prevCol);
                }

                await DrawCell(item.Key, string.Empty, cellWidth, context);
            }
        }

        public static async ValueTask DrawCell(Point2D pos, string color, int cellWidth, Canvas2DContext context)
        {
            if (!string.IsNullOrEmpty(color))
            {
                await context.SetFillStyleAsync(color);
            }

            await context.FillRectAsync(pos.X * cellWidth + 1, pos.Y * cellWidth + 1, cellWidth - 1, cellWidth - 1);
        }
    }
}
