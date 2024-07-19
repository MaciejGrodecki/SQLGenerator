using Microsoft.EntityFrameworkCore;
using SqlGenerator.API.Database.EntityConfiguration;
using SqlGenerator.API.Entities;

namespace SqlGenerator.API.Database;

public sealed class SqlGeneratorDatabaseContext(DbContextOptions<SqlGeneratorDatabaseContext> options) : DbContext(options)
{
    public DbSet<DatabaseInformation> DatabaseInformations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseInformationConfiguration).Assembly);
    }
}