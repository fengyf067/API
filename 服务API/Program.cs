using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using 服务API.AppConfig;

namespace 服务API
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Program Start");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                    .UseUrls()// 这里默认是http://*:5000 .现在改成8003端口
                    .UseStartup<Startup>();
                });
    }
}
