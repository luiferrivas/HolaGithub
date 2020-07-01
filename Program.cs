using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebMartes
{
<<<<<<< HEAD
    public class Program //Cambio en ramal sprint2
=======
    public class Program //Sprint2 cambio conflictivo
>>>>>>> sprint2
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

<<<<<<< HEAD
        //Otro cambio en ramal sprint2
=======
//Sprint2 cambio conflictivo
>>>>>>> sprint2
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
