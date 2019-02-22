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
      //Hit enter to run each method
      Arrays();
      Methods();

    }
    static void Arrays()
    {
      int[] myNumbers = { 2, 4, 6, 7, 9, 11, 23 };
      string[] friends = new string[10];
      string[] girlfriends = new string[10];

      friends[0] = "Alex";
      friends[1] = "Ami";
      friends[2] = "Joe";

      girlfriends[0] = "Nikki";
      girlfriends[1] = "Hot Stripper";


      Console.WriteLine("Today " + friends[0] + " broke up with his girlfriend " + girlfriends[0] + ".");
      Console.WriteLine(friends[1] + " and " + friends[2] + " were very supportive of " + friends[0]
      + " and bought him " + myNumbers[0] + " " + girlfriends[1] + "s.");

      Console.ReadLine();
    }

    static void Methods()
    {

      double[] num = new double[20];
      string[] positions = new string[20];
      string[] employers = new string[20];
      int[] numberOfInterviews = new int[20];

      Console.Write("How many weeks ago did you graduate from your coding school: ");

      num[0] = 1.5;
      num[1] = 2.5;
      num[2] = 3.5;
      num[3] = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("I graduated " + num[3] + " weeks ago");

      Console.Write("What type of positions are you looking for: ");

      positions[0] = "Full Stack Developer";
      positions[1] = "Front-End Developer";
      positions[2] = "Back-End Developer";
      positions[3] = Console.ReadLine();

      Console.WriteLine("I am looking to fill a positions as a " + positions[3] + ".");

      Console.Write("Where have you applied: ");
      employers[0] = "Presence";
      employers[1] = "InComm";
      employers[2] = "Webstaurant";
      employers[3] = Console.ReadLine();

      Console.WriteLine("I have applied to many organizations including " + employers[3]);
      Console.WriteLine("I feel good about " + employers[3]);

      Console.Write("How many interviews have you done with them: ");

      numberOfInterviews[0] = 0;
      numberOfInterviews[1] = 1;
      numberOfInterviews[2] = 2;
      numberOfInterviews[3] = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("I have completed " + numberOfInterviews[3] + ".");
      Console.WriteLine("I have " + numberOfInterviews[3] + " interview to go with " + employers[3] + ". I'm pretty stoked and nervous at the same time.");

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