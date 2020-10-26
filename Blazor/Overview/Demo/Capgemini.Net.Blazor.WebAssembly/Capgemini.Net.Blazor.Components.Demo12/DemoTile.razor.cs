﻿namespace Capgemini.Net.Blazor.Components.Demo12
{
    public partial class DemoTile
    {
        public const string Href = "demo12";

        public static TileIcon Icon => TileIcon.PAINT_BRUSH;

        public static string Title => "TypeScript Component";

        public static string Description => "Non-Blazor component using standard HTML event attributes to call JavaScript function on trigger.";
    }
}
