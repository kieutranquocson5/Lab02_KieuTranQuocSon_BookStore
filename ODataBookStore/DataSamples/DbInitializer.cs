using Microsoft.EntityFrameworkCore;
using ODataBookStore.EDM;

namespace ODataBookStore.DataSamples
{
	public static class DbInitializer
	{
		public static async Task SeedDataAsync(this IServiceProvider serviceProvider)
		{
			using var scope = serviceProvider.CreateScope();
			var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
			var dataSources = scope.ServiceProvider.GetRequiredService<DataSources>();

			if (!await context.Books.AnyAsync())
			{
				await context.Books.AddRangeAsync(dataSources.Books);
				await context.SaveChangesAsync();
			}
		}
	}
}
