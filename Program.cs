using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;


namespace csharppractice
{
  public class Program
  {
    public static void Main(string[] args)
    {

      //Hit enter after each method to run each method

      bool isMale = false;
      bool isTall = false;

      if (isMale || isTall)
      {
        Console.WriteLine("You are male and you are tall.");
      }
      else
      {
        Console.WriteLine("You are not male nor are you tall.");
      }
      // int squaredAway1 = AlwaysSquaring(3);
      // Console.Write("Choose a number: ");
      // int squaredAway2 = AlwaysSquaring(Convert.ToInt32(Console.ReadLine()));
      // int cubedAgain1 = TryReturnCubeAgain(2);
      // Console.Write("Choose a number to cube again: ");
      // int cubedAgain2 = TryReturnCubeAgain(Convert.ToInt32(Console.ReadLine()));
      // double cubedNumber = ReturnStatementsCube(7);
      // double cubedNumber1 = ReturnStatementsCube(5);
      // Console.Write("Choose a number to cube: ");
      // double cubedNumber2 = ReturnStatementsCube(Convert.ToDouble(Console.ReadLine()));
      // Arrays();
      // Methods();
      // ThatSpecialNumber();
      // Parameters("Frank", 39, 39.75);

      // Console.WriteLine(cubedNumber);
      // Console.WriteLine(cubedNumber1);

      // Console.WriteLine(cubedNumber2);

      // Console.WriteLine(cubedAgain1);
      // Console.WriteLine(cubedAgain2);

      // Console.WriteLine(squaredAway1);
      // Console.WriteLine(squaredAway2);


      Console.ReadLine();

    }
    //////////////////////////////////////
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
    /////////////////////////////////////////
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
    //////////////////////////////////////////////////
    static void ThatSpecialNumber()
    {
      int specialNumber = 99;
      Console.WriteLine(specialNumber);

      Console.ReadLine();
    }
    /////////////////////////////////////////////////

    static void Parameters(string name, int age1, double age2)
    {
      Console.WriteLine("Hello " + name + ". You are " + age1 + " years old.");
      Console.Write("Well how old are you exactly: ");
      Console.WriteLine("Actually I am " + age2 + " years old to be exact.");

      Console.ReadLine();
    }
    /////////////////////////////////////////////////

    static double ReturnStatementsCube(double num)
    {
      double result = num * num * num;
      return result;

    }
    /////////////////////////////////////////////////

    static int TryReturnCubeAgain(int num)
    {
      int result = num * num * num;
      return result;
    }
    ////////////////////////////////////////////////
    static int AlwaysSquaring(int num)
    {
      int taco = num * num;
      return taco;
    }
    ////////////////////////////////////////////////



  }
}







// Console.WriteLine("Hello World");
//     CreateWebHostBuilder(args).Build().Run();
//   }

//   public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//       WebHost.CreateDefaultBuilder(args)
//           .UseStartup<Startup>();