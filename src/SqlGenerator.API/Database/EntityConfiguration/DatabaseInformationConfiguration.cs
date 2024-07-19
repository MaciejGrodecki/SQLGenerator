using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SqlGenerator.API.Entities;

namespace SqlGenerator.API.Database.EntityConfiguration;

public sealed class DatabaseInformationConfiguration : IEntityTypeConfiguration<DatabaseInformation>
{
    public void Configure(EntityTypeBuilder<DatabaseInformation> builder)
    {
        builder.HasKey(x => x.Id);
    }
}