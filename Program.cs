using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
// using Students;
// using csharppractice.Chefs;
// using ItalianChefs;
// using JapaneseChefs;
// using KoreanChefs;
// using csharppractice.UsefulTools;
// using System.Threading.Tasks;
// using Songs;
// using Movies;
// using csharppractice.Students;
// using csharppractice.Books;
// using csharppractice.ScaryBooks;
// using csharppractice.FunnyBooks;
// using csharppractice.ComicBooks;
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
      // Student student1 = new Student("Frank", "Dev", 3.7);
      // Student student2 = new Student("Mike", "Business", 3.4);

      // Console.WriteLine("Does student1 have honors? " + student1.HasHonors());
      // Console.WriteLine("Does student2 have honors? " + student2.HasHonors());

      //

      // Chef chef = new Chef();
      // chef.MakeChicken();

      // ItalianChef italianChef = new ItalianChef();
      // italianChef.MakePasta();

      // JapaneseChef japanaesChef = new JapaneseChef();
      // japanaesChef.MakeKimchi2();

      // KoreanChef koreanChef = new KoreanChef();
      // koreanChef.MakeKimchi();

      //

      // UsefulTool.SayHi("Frank");

      // Song halo = new Song("Halo", "Perfect Circle", 300);
      // Console.WriteLine(halo.artist);
      // Console.WriteLine(Song.songCount);
      // Song kashmir = new Song("Kashmir", "Led Zep", 500);
      // Console.WriteLine(kashmir.duration);
      // Console.WriteLine("This is song number " + Song.songCount + " created in the Songs program.");
      // Console.WriteLine(kashmir.getSongCount());
      // Song hungerStrike = new Song("Hunger Strike", "Pearl Jam", 700);
      // Console.WriteLine(hungerStrike.getSongCount());
      // Song myFavSong = new Song("My Favorite Song", "Frank Diaz", 600);
      // Console.WriteLine(Song.songCount);
      ///

      // Movie pulpFiction = new Movie("Pulp Fiction", "Quentin Tarantino", "G");
      // Movie abyss = new Movie("The Abyss", "James Cameron", "PG-13");

      // Console.WriteLine(pulpFiction.Rating);

      ///

      // Student student1 = new Student("Frank", "Development", 3.8);
      // Student student2 = new Student("Carla", "Accounting", 3.9);

      // Console.WriteLine("It is in fact " + student1.HasHonors() + " that student1 has honors");
      // Console.WriteLine("Because of a high gpa, it is " + student2.HasHonors() + " that student2 has honors");

      ///

      // Book book1 = new Book("Harry Potter", "JK Rowlings", 400);

      // Console.WriteLine(book1.title);
      // Console.WriteLine(book1.author);
      // Console.WriteLine(book1.pages);

      // Book book2 = new Book("LOTR", "Tolkien", 700);

      // Console.WriteLine(book2.title);
      // Console.WriteLine(book2.author);
      // Console.WriteLine(book2.pages);

      // Book is now a data type where you can create a data type (book1) object.
      // An object (book1) is an instance of a class.

      ///

      // ScaryBook scaryBook1 = new ScaryBook();
      // scaryBook1.title = "Carey";
      // scaryBook1.author = "Steven King";
      // scaryBook1.pages = 900;

      // Console.WriteLine(scaryBook1.title);
      // Console.WriteLine(scaryBook1.author);
      // Console.WriteLine(scaryBook1.pages);

      ///

      // FunnyBook funnyBook1 = new FunnyBook("", "", 0);
      // Console.WriteLine("Enter a funny book title: ");
      // funnyBook1.title = Console.ReadLine();
      // Console.WriteLine("Enter a funny book author: ");
      // funnyBook1.author = Console.ReadLine();
      // Console.WriteLine("Enter a funny book's number of pages: ");
      // funnyBook1.pages = Convert.ToInt32(Console.ReadLine());

      // Console.WriteLine(funnyBook1.title);
      // Console.WriteLine(funnyBook1.author);
      // Console.WriteLine(funnyBook1.pages);

      ///

      // Comic comic1 = new Comic("", 0);
      // Console.Write("Enter a comicbook title: ");
      // comic1.title = Console.ReadLine();
      // Console.Write("Enter an issue number: ");
      // comic1.issue = Convert.ToInt32(Console.ReadLine());

      // Console.WriteLine("The comic is " + comic1.title + ".  The issue is number " + comic1.issue + ".");

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

      // Console.Write(GetPow(3, 2));

      // Find the largest Element in an array.

      // int[] givenArray = { 2, 4, 6, 8, 20, 30, 23 };
      // Array.Sort(givenArray);
      // Console.WriteLine("The largest element is: \n" + givenArray[givenArray.Length - 1]);

      //

      // int[] givenArray = { 13, 2, 4, 6, 8, -9, 20, 30, 23 };
      // Array.Sort(givenArray);
      // Console.WriteLine("The smallest element is: \n" + givenArray[givenArray.Length - givenArray.Length]);

      //

      // int[] givenArray = { 2, 1, 5, 4, 7, 6 };
      // int largestElement = 0;
      // for (int i = 0; i < givenArray.Length; i++)
      // {
      //   if (givenArray[i] > largestElement)
      //   {
      //     largestElement = givenArray[i];
      //   }
      // }
      // Console.WriteLine("The largest element in the array is \n" + largestElement);

      //

      // int[] givenArray = { 2, 1, 5, 4, 7, 6 };
      // int smallestElement = 0;
      // for (int i = 0; i < givenArray.Length; i++)
      // {
      //   if (givenArray[i] > smallestElement)
      //   {
      //     smallestElement = givenArray[+1];
      //   }
      // }
      // Console.WriteLine("The smallest element in the array is \n" + smallestElement);

      // OR // ForLoop

      // int[] givenArray = { 30, 10, 40, 9, 60 };
      // int largestElement = 0;
      // for (int i = 0; i < givenArray.Length; i++)
      // {
      //   if (givenArray[i] > largestElement)
      //   {
      //     largestElement = givenArray[i];
      //   }
      //   return largestElement;
      // }
      // Console.WriteLine("The largest element in the array is: \n" + largestElement.ToString());

      // .Min(); 

      // int[] array = { 10, 6, 4, 12 };
      // Console.WriteLine(array.Min());

      // .Max();

      // int[] array = { 10, 6, 4, 12 };
      // Console.WriteLine(array.Max());

      // Summing an array //

      // int[] arr = new int[] { 1, 2, 3 };
      // int sum = 0;
      // for (int i = 0; i < arr.Length; i++)
      // {
      //   sum += arr[i];
      // }
      // Console.WriteLine(sum);


      Console.WriteLine(SumArray(new int[] { 3, 6, 8, 1, 9, 10, 2 }, 0));

      Console.WriteLine(SumArray2(new int[] { 1, 3, 5, 7, 40 }));

      Console.WriteLine(SumOddArray(new int[] { 2, 1, 4, 5, 7, 6 }, 0));

      // Console.WriteLine(SumOddArray2());

      Console.WriteLine(LargestInArray(new int[] { 1, 2, 3, 4, 5, 6, 7, -10 }, Int32.MinValue));

      Console.WriteLine(LargestInArray2(new int[] { 2, 6, 99 }));

      Console.WriteLine(SmallestInArray(new int[] { 30, 40, 20, 10, 10, 90 }, Int32.MaxValue));

      Console.WriteLine(SmallestInArray2(new int[] { 6, 3, 10, -19, 40, 4 }));

      Console.ReadLine();

    }
    ////////////////////////////////////// 

    ////////////////// WhiteBoard Question 3/4 SumArray
    static int SumArray(int[] arr, int sum)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        sum += arr[i];
      }
      return sum;
    }

    // or //
    static int SumArray2(int[] arr)
    {
      return arr.Sum();
    }

    /////////////////// WhiteBoard Question 3/4 SumOddArray

    static int SumOddArray(int[] arr, int sum)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] % 2 == 1)
        {
          sum += arr[i];
        }
      }
      return sum;
    }

    // or //

    // static int SumOddArray2(int[] array2)
    // {
    //   IEnumerable<int> odds = array2.Where(x => x % 2 != 0);

    //   foreach (int odd in odds)
    //   {
    //     return (odd);
    //   }
    // }

    /////////////////// WhiteBoard Question 3/4 LargestInArray

    static int LargestInArray(int[] arr, int largest)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] > largest)
        {
          largest = arr[i];
        }
      }
      return largest;
    }

    // or //

    static int LargestInArray2(int[] arr)
    {
      return arr.Max();
    }


    ///////////////////// WhiteBoard Question 3/4 SmallestInArray

    static int SmallestInArray(int[] arr, int smallest)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] < smallest)
        {
          smallest = arr[i];
        }
      }
      return smallest;
    }

    // or //

    static int SmallestInArray2(int[] arr)
    {
      return arr.Min();
    }

    ///////////////////////////////////////////////

    static int GetPow(int baseNum, int powNum)
    {
      int result = 1;
      for (int i = 0; i < powNum; i++)
      {
        result *= baseNum;
      }
      return result;
    }

    //////////////////////////////////////
    static void ForLoop()
    {
      int[] array = { 9, 18, 27, 36 };
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine(array[i]);
      }
    }
    // indexing variable i
    // looping guard or condition = keep looping as long as (array.Length)...
    // then increment i (index number) by 1 each loop

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

    // Implement a function that adds two numbers together and returns their sum in binary. 
    // The conversion can be done before, or after the addition.
    // The binary number returned should be a string.

    public static class Kata5
    {
      public static string AddBinary(int a, int b)
      {
        return Convert.ToString(a + b, 2);
      }
    }
    //////////////////////////////////////////////////////

    // In this kata you will create a function that takes a list of non-negative integers 
    // and strings and returns a new list with the strings filtered out.

    public class ListFilterer
    {
      public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
      {
        return listOfItems.OfType<int>();
      }
    }
    ///////////////////////////////////////////////////////

    //     Return an array containing the numbers from 1 to N, where N is the parametered value. 
    //     N will never be less than 1 (in C#, N might be less then 1).
    // * C# ONLY: If N is smaller then or equal to 0, throw an ArgumentOutOfRangeException!
    // Replace certain values however if any of the following conditions are met:
    // * If the value is a multiple of 3: use the value 'Fizz' instead
    // * If the value is a multiple of 5: use the value 'Buzz' instead
    // * If the value is a multiple of 3 & 5: use the value 'FizzBuzz' instead

    public class FizzBuzz
    {
      public static string[] GetFizzBuzzArray(int n)
      {
        if (n <= 0)
          throw new ArgumentOutOfRangeException("out of range");

        List<string> result = new List<string>();

        for (int i = 1; i <= n; i++)    /// or i <= 100;
        {
          string Value = i.ToString();

          if (i % 3 == 0)
            Value = "Fizz";

          if (i % 5 == 0)
            Value = "Buzz";

          if (i % 5 == 0 && i % 3 == 0)
            Value = "FizzBuzz";

          result.Add(Value);
        }

        return result.ToArray();
      }
    }
    ////////////////////////////////////////////

    // In this kata you get the start number and the end number of a region 
    // and should return the count of all numbers except numbers with a 5 in it. 
    // The start and the end number are both inclusive!

    public class Kata6
    {
      public static int DontGiveMeFive(int start, int end)
      {
        int count = 0;
        for (int i = start; i <= end; i++)
        {
          string temp = i.ToString();
          if (!temp.Contains("5")) count++;
        }
        return count;
      }
    }
    /////////////////////////////////////////////



    ////////////////////////////////////////////

  }
}







// Console.WriteLine("Hello World");
//     CreateWebHostBuilder(args).Build().Run();
//   }

//   public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
//       WebHost.CreateDefaultBuilder(args)
//           .UseStartup<Startup>();