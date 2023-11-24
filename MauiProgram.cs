namespace Planets;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montsserat-Medium.ttf", "RegularFont");
				fonts.AddFont("Montsserat-SemiBold.ttf", "MediumFont");
                fonts.AddFont("Montsserat-Bold.ttf", "BoldFont");
            });

		return builder.Build();
	}
}
