using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System.Util
{
    //internal class PropertyUtil
    //{
    //}

    public static class PropertyUtil
    {
        private static IConfiguration _iconfiguration;


        public static string GetConnectionString()
        {
            return _iconfiguration.GetConnectionString("LocalConnectionString");
        }


        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
            _iconfiguration = builder.Build();

        }

        static PropertyUtil()

        {
            GetAppSettingsFile();
        }

    }

}
