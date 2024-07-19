using Microsoft.EntityFrameworkCore;
using SqlGenerator.API.Database;

namespace SqlGenerator.API.DependencyInjection;

public static class DatabaseConfiguration
{
    private const string SqlPasswordField = "MSSQL_SA_PASSWORD";

    public static void AddDatabase(this IServiceCollection services, string connectionString)
    {
        var password = Environment.GetEnvironmentVariable(SqlPasswordField);
        var connectionStringWithPass = string.Format(connectionString, password);

        services.AddDbContext<SqlGeneratorDatabaseContext>(options => options.UseSqlServer(connectionStringWithPass));
    }

    public static void ApplyMigrations(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var db = scope.ServiceProvider.GetRequiredService<SqlGeneratorDatabaseContext>();
        db.Database.Migrate();
    }
}