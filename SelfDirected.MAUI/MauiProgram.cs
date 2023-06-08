using Microsoft.Extensions.Logging;
using SelfDirected.TimeKeeper.Databases;
using SelfDirected.TimeKeeper.Models;

namespace SelfDirected.MAUI;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
	

#if DEBUG
		builder.Logging.AddDebug();
#endif

        var app = builder.Build();

        // Run async code after the app is built
        Task.Run(async () =>
        {
            TaskModel model = new TaskModel {Title = "Task1", CreatedTimestamp = DateTime.Now };

            // Save the model to the database
            int rowsAffected = await SaveToDbAsync(model);

            // Get all tasks from the database
            List<TaskModel> items = await GetTasksFromDb();

            // Access the retrieved tasks
            if (items.Count > 0)
            {
                Console.WriteLine(items[0].Id);
            }
        });

        return app;
    }

    private static async Task<int> SaveToDbAsync(TaskModel model)
    {
        var db = new TaskDatabase();
        return await db.SaveItemAsync(model);
    }

    private static async Task<List<TaskModel>> GetTasksFromDb()
    {
        var db = new TaskDatabase();
        return await db.GetItemsAsync();
    }
}


