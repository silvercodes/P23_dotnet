namespace DbDriver.Exceptions;

public class DbDriverException: Exception
{
    public DbDriverException(string? message):
        base(message)
    { }
}
