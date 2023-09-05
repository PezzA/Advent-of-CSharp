using AdventOfCSharp.Puzzles.Geometery;
using Blazor.Extensions;
using Blazor.Extensions.Canvas.Canvas2D;
using MudBlazor;

namespace AdventOfCSharp.BlazorClient.UI
{
    public class Y22D12
    {
        public static async ValueTask RenderHeader(float delta, Canvas2DContext context, BECanvasComponent canvas)
        {
            var fps = Convert.ToInt32(1000 / delta);
            await context.ClearRectAsync(0, 0, canvas.Width , 20);
            await context.SetStrokeStyleAsync($"#FFFFFF");
            await context.StrokeTextAsync($"FPS: {fps}", 0, 10);
        }

        public static async ValueTask RenderMap(Dictionary<char, string> colors, Dictionary<Point2D, char> map, int cellWidth,  Canvas2DContext context, BECanvasComponent canvas)
        {
            await context.ClearRectAsync(0, 0, canvas.Width, canvas.Height);

            var prevCol = string.Empty;

            foreach (var item in map)
            {
                if (colors[item.Value] != prevCol) {
                    prevCol = (colors[item.Value]);
                    await context.SetFillStyleAsync(prevCol);
                }

                await DrawCell(item.Key, string.Empty, cellWidth, context);
            }
        }

        public static async ValueTask DrawCell(Point2D pos, string color, int cellWidth, Canvas2DContext context)
        {
            if (!string.IsNullOrEmpty(color)) {
                await context.SetFillStyleAsync(color);
            }
            
            await context.FillRectAsync((pos.X * cellWidth) + 1, (30 + (pos.Y * cellWidth)) + 1, cellWidth - 1, cellWidth - 1);
        }
    }
}
