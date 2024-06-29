using DbDriver.Exceptions;

namespace DbDriver;

internal class ConfigBuilder
{
    public string GetConfig()
    {
        // return ReadConfigFile("config.json");


        try
        {
            return ReadConfigFile("config.json");
        }
        catch (ConnectionException ex)
        {
            //Console.WriteLine($"{ex.Message} was handled in ConfigBuilder.GetConfig()!!!");

            Console.WriteLine($"{ex.Message} was LOGGED in ConfigBuilder.GetConfig()!!!");

            throw;

            // throw new Exception("Extra exception");         // :-(((((((((((
        }
        finally
        {
            Console.WriteLine($"Finally: file stream closed");
        }

        return "Default config: 11111111";
    }

    private string ReadConfigFile(string path)
    {
        bool isFileExists = true;

        if (!isFileExists)
            throw new ConnectionException("Config file is not exists!");

        return "Valid config from file 0010001010010011";
    }
}
