using MudBlazor;

namespace AdventOfCSharp.BlazorClient
{
    public class Themes
    {
        public static MudTheme AdventOfCode => new()
        {
            PaletteDark = new PaletteDark()
            {
                Primary = new MudBlazor.Utilities.MudColor(255, 255, 255, 255),
                Secondary = new MudBlazor.Utilities.MudColor(0, 204, 0, 255),
                Warning = Colors.Yellow.Default,
                AppbarBackground = new MudBlazor.Utilities.MudColor(60, 60, 70, 255),
                Background = new MudBlazor.Utilities.MudColor(15, 15, 35, 255),
                DrawerBackground = new MudBlazor.Utilities.MudColor(15, 15, 35, 255),
            },
            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Source Code Pro", "Helvetica", "Arial", "sans-serif" }
                }
            }
        };
    }
}
