using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace csharppractice
{
  public class Program
  {
    public static void Main(string[] args)
    {

      Arrays();

    }
    static void Arrays()
    {
      Console.WriteLine("testing");
      Console.ReadLine();
    }
  }
}
// Console.WriteLine("Hello World");
//     CreateWebHostBuilder(args).Build().Run();
//   }

//   public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//       WebHost.CreateDefaultBuilder(args)
//           .UseStartup<Startup>();