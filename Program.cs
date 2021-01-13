using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CockTailBlazor.CustomAPI;

namespace CockTailBlazor
{
    public class Program
    {
        public static Fetch fetch = new Fetch();
        public static CockTails ctDetails;
        public static CockTails singleDrink;
        public static Categories categoryTypes;
        public static Glasses glassTypes;
        public static Ingredients ingredientNames;
        public static IngredientDescription ingredientDesc;
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static void MakeAllNull()
        {
            ctDetails = null;
            singleDrink = null;
            categoryTypes = null;
            glassTypes = null;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
