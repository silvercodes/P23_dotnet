namespace DbDriver;

public class ConnectionManager
{
    public void Connect()
    {
        string config = GenerateConfig();

        Console.WriteLine($"FROM ConnectionManager --> Connected with: {config}");
    }

    private string GenerateConfig()
    {
        ConfigBuilder cb = new ConfigBuilder();

        return cb.GetConfig();
    }
}
