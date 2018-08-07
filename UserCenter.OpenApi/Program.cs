using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace UserCenter.OpenApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var parm = new ConfigurationBuilder().AddCommandLine(args).Build();
            //获取命令行输入的ip和端口,例：dotnet UserCenter.OpenApi.dll --ip 127.0.0.1 --port 5001
            string ip = parm["ip"];
            string port = parm["port"];


            return WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>()
               .ConfigureAppConfiguration((hostingContext, config) =>
               {
                   var env = hostingContext.HostingEnvironment;
                   config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                         .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                   config.AddEnvironmentVariables();
               })
               .ConfigureLogging((hostingContext, logging) =>
               {
                   logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                   logging.AddConsole();
                   logging.AddDebug();
               })
               .UseUrls($"http://{ip}:{port}")
               .Build();
        }           
    }
}
