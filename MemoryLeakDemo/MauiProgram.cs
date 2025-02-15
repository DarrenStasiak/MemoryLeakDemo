﻿using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MemoryLeakDemo.Views;
using MemoryLeakDemo.ViewModels;
using Microsoft.Maui.Hosting;

namespace MemoryLeakDemo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            builder.Services.AddTransient<OtherPageViewModel>();
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddTransient<OtherPage>();
            builder.Services.AddTransient<MainPage>();




#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
