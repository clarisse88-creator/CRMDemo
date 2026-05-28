using MauiApp1.Services;
using Microsoft.Extensions.Logging;
using MauiApp1.Helpers;

namespace MauiApp1;

public static class MauiProgram
{
	// ── API settings ─────────────────────────────────────────────────────────
	// BaseUrl: matches ApiSettings:BaseUrl in CRMDemo/Web/appsettings.Development.json
	// ApiKey:  matches ApiSettings:ApiKey  in CRMDemo/API/appsettings.Development.json
	private const string ApiBaseUrl = "http://localhost:5138";
	private const string ApiKey = "sk_live_P55hdQ0DVjoItLuu7Ciu7C7tfgz7uvsQ";

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		
		builder.Services.AddHttpClient<ApiClient>(client =>
		{
			client.BaseAddress = new Uri(ApiBaseUrl);
			client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);
		});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}