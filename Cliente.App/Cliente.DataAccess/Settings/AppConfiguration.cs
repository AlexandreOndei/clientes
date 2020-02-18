using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Cliente.DataAccess.Settings
{
    public static class AppConfiguration
    {
        public static string GetConnectionString()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            return root.GetSection("ConnectionStrings").GetSection("ClientesConnection").Value;
        }
    }
}
