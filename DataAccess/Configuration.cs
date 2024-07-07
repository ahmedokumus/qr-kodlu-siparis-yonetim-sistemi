using Microsoft.Extensions.Configuration;

namespace DataAccess;

static class Configuration
{
    static public string? ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebApi"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString("SqlServer");
        }
    }
}