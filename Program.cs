using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
// using csharppractice.Books;
// using csharppractice.ScaryBooks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;


namespace csharppractice
{
  public class Program
  {
    public static void Main(string[] args)
    {
      /// Hit enter in conole after each method to run each method

      ///

      // Book book1 = new Book("Harry Potter", "JK Rowlings", 400);

      // Book book2 = new Book("LOTR", "Tolkien", 700);

      // ScaryBook scaryBook1 = new ScaryBook();
      // scaryBook1.title = "Carey";
      // scaryBook1.author = "Steven King";
      // scaryBook1.pages = 900;

      // Console.WriteLine(book1.title);
      // Console.WriteLine(book1.author);
      // Console.WriteLine(book1.pages);

      // Console.WriteLine(book2.title);
      // Console.WriteLine(book2.author);
      // Console.WriteLine(book2.pages);

      // Console.WriteLine(scaryBook1.title);
      // Console.WriteLine(scaryBook1.author);
      // Console.WriteLine(scaryBook1.pages);

      // Book is now a data type where you can create a dat type (book1) object.
      // An object (book1) is an instance of a class.

      ///

      // try
      // {
      //   Console.Write("Enter first number: ");
      //   int num1 = Convert.ToInt32(Console.ReadLine());
      //   Console.Write("Enter second number: ");
      //   int num2 = Convert.ToInt32(Console.ReadLine());

      //   Console.WriteLine(num1 / num2);
      // }
      // catch (Exception e)
      // {
      //   Console.WriteLine(e.Message);
      // }

      ///

      // int[,] numberGrid = {
      //     { 1, 2},
      //     { 3, 4},
      //     { 5, 6},
      //     { 7, 8}

      // };
      // Console.WriteLine(numberGrid[3, 0]);

      ///

      // int[] stringArray = { 2, 4, 5, 7, 9, 10, 12 };
      // for (int i = 0; i < stringArray.Length; i++)
      // {
      //   Console.WriteLine(stringArray[i]);
      // }

      ///

      // int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

      // for (int i = 0; i < luckyNumbers.Length; i++)
      // {
      //   Console.WriteLine(luckyNumbers[i]);
      // }

      ///

      // string secretWord = "giraffe";
      // string guess = "";

      // while (guess != secretWord)
      // {
      //   Console.Write("Enter guess: ");
      //   guess = Console.ReadLine();
      // }
      // Console.Write("You win!");

      ///

      // int secretNum = 9;
      // int guess = 0;

      // while (guess != secretNum)
      // {
      //   Console.Write("Enter a guess number: ");
      //   guess = Convert.ToInt32(Console.ReadLine());
      // }
      // Console.WriteLine("You Win!");

      // int index = 1;
      // do
      // {
      //   Console.WriteLine(index);
      //   index++;
      // } while (index <= 5);

      ///

      // double taco = 1;
      // while (taco <= 10)
      // {
      //   Console.WriteLine(taco);
      //   taco++;
      // }

      ///
      // Console.Write("Please enter an airport number: ");
      // Console.WriteLine(GetAirport(Convert.ToInt32(Console.ReadLine())));

      ///

      // Console.Write("Enter a day of the week: ");
      // Console.WriteLine(GetAmount(Console.ReadLine()));

      ///

      // Console.WriteLine(GetDay(0));

      ///

      // Console.WriteLine(GetMax1(10, 20, 30));

      ///

      // Console.Write("Enter seventh number: ");
      // int num7 = Convert.ToInt32(Console.ReadLine());

      // Console.Write("Enter eighth number: ");
      // int num8 = Convert.ToInt32(Console.ReadLine());

      // Console.Write("Enter ninth number: ");
      // int num9 = Convert.ToInt32(Console.ReadLine());

      // Console.WriteLine(UserGetMin1(num7, num8, num9));

      ///

      // Console.Write("Enter first number: ");
      // double num4 = Convert.ToDouble(Console.ReadLine());

      // Console.Write("Enter second number: ");
      // double num5 = Convert.ToDouble(Console.ReadLine());

      // Console.Write("Enter third number: ");
      // double num6 = Convert.ToDouble(Console.ReadLine());

      // Console.WriteLine(UserGetMin(num4, num5, num6));

      ///

      // Console.Write("Enter a number: ");
      // double num1 = Convert.ToDouble(Console.ReadLine());

      // Console.Write("Enter a math operator: ");
      // string op = Console.ReadLine();

      // Console.Write("Enter a second number: ");
      // double num2 = Convert.ToDouble(Console.ReadLine());

      // if (op == "+")
      // {
      //   Console.WriteLine(num1 + num2);
      // }
      // else if (op == "-")
      // {
      //   Console.WriteLine(num1 - num2);
      // }
      // else if (op == "/")
      // {
      //   Console.WriteLine(num1 / num2);
      // }
      // else if (op == "*")
      // {
      //   Console.WriteLine(num1 * num2);
      // }
      // else
      // {
      //   Console.WriteLine("You've entered an incorrect operator: ");
      // }

      ///

      // Console.Write("Enter your first number: ");
      // int num1 = Convert.ToInt32(Console.ReadLine());

      // Console.Write("Enter a math operator: ");
      // string op = Console.ReadLine();

      // Console.Write("Enter your second number: ");
      // int num2 = Convert.ToInt32(Console.ReadLine());

      // if (op == "+")
      // {
      //   Console.WriteLine(num1 + num2);
      // }
      // else if (op == "-")
      // {
      //   Console.WriteLine(num1 - num2);
      // }
      // else if (op == "/")
      // {
      //   Console.WriteLine(num1 / num2);
      // }
      // else if (op == "*")
      // {
      //   Console.WriteLine(num1 * num2);
      // }
      // else
      // {
      //   Console.WriteLine("Youve entered an incorrect operator!");
      // }

      ///

      // bool traveling = true;
      // bool studying = true;

      // if (traveling && studying)
      // {
      //   Console.WriteLine("You are doing the right thing.");
      // }
      // else if (traveling && !studying)
      // {
      //   Console.WriteLine("You are traveling and not studying.");
      // }
      // else if (!traveling && studying)
      // {
      //   Console.WriteLine("You are just studying which is fine.");
      // }
      // else
      // {
      //   Console.WriteLine("You will need more training.");
      // }

      /// 

      // int squaredAway1 = AlwaysSquaring(3);
      // Console.Write("Choose a number: ");
      // int squaredAway2 = AlwaysSquaring(Convert.ToInt32(Console.ReadLine()));

      ///

      // int cubedAgain1 = TryReturnCubeAgain(2);
      // Console.Write("Choose a number to cube again: ");
      // int cubedAgain2 = TryReturnCubeAgain(Convert.ToInt32(Console.ReadLine()));

      ///

      // double cubedNumber = ReturnStatementsCube(7);
      // double cubedNumber1 = ReturnStatementsCube(5);
      // Console.Write("Choose a number to cube: ");
      // double cubedNumber2 = ReturnStatementsCube(Convert.ToDouble(Console.ReadLine()));

      ///

      // Arrays();

      ///

      // Methods();

      ///

      // ThatSpecialNumber();

      ///

      // Parameters("Frank", 39, 39.75);

      ///

      // Console.WriteLine(cubedNumber);
      // Console.WriteLine(cubedNumber1);
      // Console.WriteLine(cubedNumber2);

      ///

      // Console.WriteLine(cubedAgain1);
      // Console.WriteLine(cubedAgain2);

      ///

      // Console.WriteLine(squaredAway1);
      // Console.WriteLine(squaredAway2);

      ///

      // Calculator();

      ///

      // BoolTest();

      ///

      // Guessing();

      //

      // ForLoop();

      //

      // Console.Write(GetPow(3, 2));

      //

      Console.ReadLine();

    }
    //////////////////////////////////////



    /////////////////////////////////////

    static int GetPow(int baseNum, int powNum)
    {
      int result = 1;
      for (int i = 0; i < powNum; i++)
      {
        result *= baseNum;  // result = result * baseNUm;
      }
      return result;
    }

    //////////////////////////////////////
    static void ForLoop()
    {
      int[] array = { 2, 4, 8, 9, 11, 34 };
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine(array[i]);
      }
    }
    // indexing variable i
    // looping guard or condition = keep looping as long as (array.Length)...

    //////////////////////////////////////
    static void Guessing()
    {
      string secretWord = "grand cayman";
      string guess = "";
      int guessCount = 0;
      int guessLimit = 3;
      bool outOfGuesses = false;

      while (guess != secretWord && !outOfGuesses)
      {
        if (guessCount < guessLimit)
        {
          Console.Write("Enter your guess: ");
          guess = Console.ReadLine();
          guessCount++;
        }
        else
        {
          outOfGuesses = true;
        }
      }
      if (outOfGuesses)
      {
        Console.Write("Loser!");
      }
      else
      {
        Console.Write("Winner!");
      }

    }

    ////////////////////////////////////

    static void BoolTest()
    {
      bool working = false;
      bool havingFun = true;

      if (working && havingFun)
      {
        Console.WriteLine("Doing really well!");
      }
      else if (working && !havingFun)
      {
        Console.WriteLine("Carla will be dissappointed.");
      }
      else if (!working && havingFun)
      {
        Console.WriteLine("Are not doing well.");
      }
      else
      {
        Console.WriteLine("You are doing very poorly.");
      }
    }

    /////////////////////////////////////

    static void Calculator()
    {
      Console.Write("Enter your first number: ");
      int num1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter a math operator: ");
      string op = Console.ReadLine();

      Console.Write("Enter your second number: ");
      int num2 = Convert.ToInt32(Console.ReadLine());

      if (op == "+")
      {
        Console.WriteLine(num1 + num2);
      }
      else if (op == "-")
      {
        Console.WriteLine(num1 - num2);
      }
      else if (op == "/")
      {
        Console.WriteLine(num1 / num2);
      }
      else if (op == "*")
      {
        Console.WriteLine(num1 * num2);
      }
      else
      {
        Console.WriteLine("Youve entered an incorrect operator!");
      }
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
      girlfriends[1] = "New girlfrined";


      Console.WriteLine("Today " + friends[0] + " broke up with his girlfriend " + girlfriends[0] + ".");
      Console.WriteLine(friends[1] + " and " + friends[2] + " were very supportive of " + friends[0]
      + " and introduced him to " + myNumbers[0] + " " + girlfriends[1] + "s.");

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
      employers[0] = "ABC";
      employers[1] = "CDE";
      employers[2] = "FGH";
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

    static int GetMax1(int num1, int num2, int num3)
    {
      int result;
      if (num1 >= num2 && num1 >= num3)
      {
        result = num1;
      }
      else if (num2 >= num1 && num2 >= num3)
      {
        result = num2;
      }
      else
      {
        result = num3;
      }
      return result;
    }
    ////////////////////////////////////////////////

    static double UserGetMin(double num4, double num5, double num6)
    {
      double result;
      if (num4 <= num5 && num4 <= num6)
      {
        result = num4;
      }
      else if (num5 <= num4 && num5 <= num6)
      {
        result = num5;
      }
      else
      {
        result = num6;
      }
      return result;
    }
    //////////////////////////////////////////////////

    static int UserGetMin1(int num7, int num8, int num9)
    {
      int result;
      if (num7 <= num8 && num7 <= num9)
      {
        result = num7;
      }
      else if (num8 <= num7 && num8 <= num9)
      {
        result = num8;
      }
      else
      {
        result = num9;
      }
      return result;
    }
    /////////////////////////////////////////////////
    static string GetDay(int dayNum)
    {
      string dayName;

      switch (dayNum)
      {
        case 0:
          dayName = "Sunday";
          break;
        case 1:
          dayName = "Monday";
          break;
        case 2:
          dayName = "Tuesday";
          break;
        case 3:
          dayName = "Wednesday";
          break;
        case 4:
          dayName = "Thursday";
          break;
        case 5:
          dayName = "Friday";
          break;
        case 6:
          dayName = "Saturday";
          break;
        default:
          dayName = "Invalid day number";
          break;
      }

      return dayName;
    }
    /////////////////////////////////////////////
    static int GetAmount(string depositDay)
    {
      int depositAmount;
      switch (depositDay)
      {
        case "sunday":
          depositAmount = 100;
          break;
        case "monday":
          depositAmount = 200;
          break;
        case "tuesday":
          depositAmount = 300;
          break;
        default:
          depositAmount = 0;
          break;
      }
      return depositAmount;
    }
    /////////////////////////////////////////////

    static string GetAirport(int airportNum)
    {
      string airportName;
      switch (airportNum)
      {
        case 0:
          airportName = "Atlanta";
          break;
        case 1:
          airportName = "Boston";
          break;
        case 2:
          airportName = "Calgary";
          break;
        default:
          airportName = "You've enter an incorrect airportNum.";
          break;
      }
      return airportName;
    }
    /////////////////////////////////////////////////////////
    /////////////     KATAS C#      /////////////////////////

    // Complete the square sum method so that it squares each number passed into it and then sums the results together.

    // For example: squareSum([1, 2, 2]) should return 9 because 1^2 + 2^2 + 2^2 = 9.
    public static int SquareSum(int[] n)
    {
      int squareSum = 0;
      for (int i = 0; i < n.Length; i++)
      {
        squareSum += n[i] * n[i];
      }
      return squareSum;
    }

    //
    public static int SquareSum2(int[] n)
    {
      return n.Sum(x => x * x);
    }
    /////////////////////////////////////////////////////////

    // We need a function that can transform a number into a string.

    // What ways of achieving this do you know?
    public class Kata
    {
      public static string NumberToString(int num)
      {
        return Convert.ToString(num);
      }
    }
    //
    public class Kata2
    {
      public static string NumberToString2(int num)
      {
        return num.ToString();
      }
    }
    ////////////////////////////////////////////////////////

    // Given an array of integers, remove the smallest value. Do not mutate the original array/list. 
    // If there are multiple elements with the same value, remove the one with a lower index. 
    // If you get an empty array/list, return an empty array/list.

    public class Remover
    {
      public static List<int> RemoveSmallest(List<int> numbers)
      {
        if (numbers.Count > 0)
        {
          numbers.Remove(numbers.Min());
        }
        return numbers;
      }
    }

    ///////////////////////////////////////////////////////

    // Your task is to write a function that takes a string and 
    // return a new string with all vowels removed.

    // For example, the string "This website is for losers LOL!" would become 
    // "Ths wbst s fr lsrs LL!".

    // Note: for this kata y isn't considered a vowel.

    public static class Kata3
    {
      public static string Disemvowel(string str)
      {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return string.Concat(str.Split(vowels));
      }
    }
    //
    public static class Kata4
    {
      public static string Disemvowel(string str)
      {
        string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
        for (int i = 0; i < vowels.Length; i++)
        {
          str = str.Replace(vowels[i], "");
        }
        return str;
      }
    }

    ///////////////////////////////////////////////////////

  }
}







// Console.WriteLine("Hello World");
//     CreateWebHostBuilder(args).Build().Run();
//   }

//   public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//       WebHost.CreateDefaultBuilder(args)
//           .UseStartup<Startup>();