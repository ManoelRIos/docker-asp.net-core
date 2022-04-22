using livraria.Models;
using Microsoft.EntityFrameworkCore;

public static class DatabaseManagementServices
{
  public static void MigrationInitialisation(this IApplicationBuilder app)
  {
    using (var serviceScope = app.ApplicationServices.CreateScope())
    {
      var serviceDb = serviceScope.ServiceProvider.GetService<AppDbContext>();
      serviceDb.Database.Migrate();
    }
  }
}