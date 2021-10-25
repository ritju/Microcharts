using Microsoft.Maui.Hosting;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace Microcharts.Maui
{
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder UseMicrocharts(this MauiAppBuilder builder, bool registerRenderers, bool replaceHandlers = false) =>
            builder.UseSkiaSharp(registerRenderers, replaceHandlers);
    }
}
