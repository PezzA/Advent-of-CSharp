namespace AdventOfCSharp.BlazorClient.Shared.Canvas;

public record CanvasProperties(int Width, int Height, WindowProperties Window)
{
    public int ScaledWidth => (int)Math.Ceiling((float)Width * Window.DevicePixelRatio);
    public int ScaledHeight => (int)Math.Ceiling((float)Height * Window.DevicePixelRatio);
}