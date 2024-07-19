namespace SqlGenerator.API.Entities;

public sealed class DatabaseInformation
{
    private DatabaseInformation(string name, string connectionString)
    {
        Id = Guid.NewGuid();
        Name = name;
        ConnectionString = connectionString;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string ConnectionString { get; private set; }

    public static DatabaseInformation Create(string name, string connectionString)
    {
        return new DatabaseInformation(name, connectionString);
    }
}