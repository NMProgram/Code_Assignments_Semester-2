// Old Code
class DatabaseManager
{
    public readonly string Connection = "Database connection";
    public DatabaseManager() => Connection = "Reassign in constructor";

    public void Reassign(string connection) => Connection = connection;
}

// New Code
class DatabaseManager
{
    public readonly string Connection = "Database connection";
    public DatabaseManager() => Connection = "Reassign in constructor";
}
