﻿using Microsoft.AspNetCore.Components.WebView.Maui;
using MAUICAL.Data;
using MAUICAL.Services;

namespace MAUICAL;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        builder.Services.AddScoped<PrioridadesServices>();
        builder.Services.AddScoped<TemasServices>();
        builder.Services.AddScoped<CitasServices>();
        builder.Services.AddScoped<ContactosServices>();
        builder.Services.AddScoped<TareasServices>();
        builder.Services.AddScoped<RepeticionesServices>();
        builder.Services.AddScoped<TipoRepeticionesServices>();
        builder.Services.AddScoped<TipoObjetosServices>();

        builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
