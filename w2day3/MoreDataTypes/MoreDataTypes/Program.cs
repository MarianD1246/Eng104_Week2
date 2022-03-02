using System;
using System.Diagnostics;
using System.Text;

namespace More_DataTypes;

//enums - enumerable types - safe type (type safety)
//disatvantagues when u don't know all the states/items
public enum suits
{
    HEARTS, CLUBS, DIAMONDS, SPADES
} //int value for index, can set hearts=3 to change index - this makes club -4 diamond - 5 spades -6

public enum Size
{
    SMALLV= 10, MEDIUM = 25, LARGE = 50
}

public class Trainee
{
    private readonly string _name; //read only value can't be chaned once declared

    public Trainee(string name) //constructor
    {
        _name = name;
    }
}

public class Program
{

    public static void Main(string[] args)
    {
        ///String stored in the heap - string pool - imutable (can't change when created
        ///we have to create a new sting when manipulating a string
        ///string are important as they display text
        //strings are character arrays
        //string md = "Marian Dumitriu";
        //md = "Marian Duke";

        //Setting up string and comparing 
        //String nish = "Nish Kumar";
        //String nish2 = new string("Nish Kumar");
        //string nish3 = "Nish Kumar";

        ///can use == on strings it is similar to using == on two ints 
        //if (nish == nish2)
        //    Console.WriteLine("Nish1 & 2 are equal");

        //if (nish == nish3)
        //    Console.WriteLine("Nish1 & 3 are equal");
        //// alternative to == is strName1.Equals(strName2)
        //if (nish2.Equals(nish3))
        //    Console.WriteLine("Nish2 & 3 are equal");

        //string Split  //regex expresion
        //string names = "Jab, James, Gurav, Goncalo";

        //spling a string when , is met , is ignored
        //string[] namesToArray = names.Split(',');
        //foreach (string name in namesToArray)
        //{
        //    Console.WriteLine(name);
        //}

        //var myString = " C# list fundamentals ";
        //Console.WriteLine(StrExercise(myString));
        //Console.WriteLine(StrBuilderExercise(myString);

        //var spartString = String.Concat(" C# list fundamentals ", " workshop @ sparta ");
        //Console.WriteLine(spartString);
        //string builder class

        //var num1 = 2;
        //var num2 = 3;
        //var fString = $"{num1} to the power of {num2} is {Math.Pow(num1,num2) }. ";
        //Console.WriteLine(fString);

        //var fString2 = $"That will be {num1 / 3.0:C2}, please"; //:c/c2 // :n :p/p2 as percentage
        //Console.WriteLine(fString2);
        //can use maths in interpolation

        ///parse convert string to ints/enums/dates/character etc..

        //ParshingString();

        ///array 
        //MultiDArray();
        //2D Arrays work like grids / or chess boards
        //2d array is [x,y] meaning the total space is x * y
        //char[,] gridTwo =
        //{
        //    {'a', 'b'}, //row 1 column 1 a , colum 2 b
        //    {'c', 'd'}, //row 2 column 1 c, column 2 d
        //    {'e', 'f'}, //row 3 column 1 e, column 2 f
        //    {'g', 'h'}  //row 4 column 1 g, column 2 h
        //};

        // jagged array of arrayies int[][][]

        //foreach (char c in gridTwo) //foreach flatens the 2d array into a 1d array and prints from a to h
        //{
        //    Console.WriteLine(c);
        //}
        //nested for loop to cycle throw each row 

        //string[] trainingGroup = { "Laura", "Steven", "James", "Jab", "Ned" };
        //string[][] spartaAcademy = new string[][]
        //{
        //    new string[]{ "Marian" , "Goncalo" , "seb" , "Stanni", "David", "Gaurav" },
        //    trainingGroup
        //};
        //foreach (string[] arr in spartaAcademy)
        //{
        //    Console.WriteLine();
        //    foreach (string s in arr)
        //    {
        //        Console.WriteLine(s);
        //    }
        //}

        //time is complicated to store and use - level of accuaricy
        //timezone calendrads, diffrent system have diffrent time systems/mesurements
        //uk - grigorian calendar // julian calendar was it's predecesor
        //Unix time stamp? 68 years from 1968~1967 to 2036 jan 19th // same as milenial problem
        //DataTimeMethods();

        //var bDay = new DateTime(1998, 08, 25);
        //diffrent way to output a date in year/m/d
        //Console.WriteLine(bDay);
        //Console.WriteLine(bDay.ToString("y-M-d"));
        //Console.WriteLine(bDay.ToString("yy/MM/dd"));
        //Console.WriteLine(bDay.ToString("ddd.MMM.yyy"));
        //Console.WriteLine(bDay.ToString("MMMM.yyyy ddd"));

        //TimeSpan is a time interval data type
        //TimeSpan myAge = DateTime.Now - bDay;
        //Console.WriteLine(myAge);
        //var myAgeInYears = myAge.Days / 365.25;
        //Console.WriteLine($"{myAgeInYears:N1} years old to one deciam point");
        //Console.WriteLine($"{myAgeInYears:N0} years old ");

        //DateOnly - just a date e.g just days or month or year
        //var myDate = new DateOnly(1998, 08, 25);
        //Console.WriteLine(myDate);
        //var today = DateTime.Now;
        //DateOnly now = DateOnly.FromDateTime(today);
        //Console.WriteLine(now);
        //Console.WriteLine(today);


        //stop watch //needs System.Diagnostics
        //var stopwatch = new Stopwatch();
        //stopwatch.Start();
        //long total = 0;
        //for (int i = 0; i < 100000; i++)
        //{
        //    total += i;
        //}
        //stopwatch.Stop();
        //Console.WriteLine(stopwatch.Elapsed);
        //Console.WriteLine(stopwatch.ElapsedMilliseconds);
        //Console.WriteLine(stopwatch.ElapsedTicks);

        //Enumz();
        //var medValue = (int)Size.MEDIUM;
        //var mySize = (Size)50;
        //var aSuit = Enum.Parse(typeof(suits), "CLUB"); throws excepton cuz CLUBS is defined not club we made a mistake
        var aSuit = Enum.Parse(typeof(suits), "CLUBS");

        char[] bob = { 'a', 'b', 'c' };
    }

    public static void Enumz()
    {
        suits theSuit = suits.HEARTS;
        //if (theSuit == suits.HEARTS)
        //{
        //    Console.WriteLine($"Suit is {suits.HEARTS}");
        //}
        //else Console.WriteLine($"Suit is {theSuit} not {suits.HEARTS}");
        switch (theSuit)
        {
            case suits.HEARTS:
                Console.WriteLine("Thank you");
                break;
            default:
                Console.WriteLine("No Thanks");
                break;


        }
    }



    public static void DataTimeMethods()
    {
        var now = DateTime.Now;
        Console.WriteLine($"The time now is {now}");
        //Console.WriteLine($"The time now is {now.Ticks}");
        //Console.WriteLine(DateTime.MinValue); //01/01/0001 00:00:00
        //Console.WriteLine(DateTime.MaxValue); //31/12/9999 23:59:59
        var tomorrow = now.AddDays(1);
        var deliverTime = now.AddDays(5); // after item bought deliver it in 5 days
        Console.WriteLine(tomorrow);
    }


    public static void JaggedArray()
    {
        int[][] intJArray = new int[2][];
        intJArray[0] = new int[4]; // array 1 is 4 item wide
        intJArray[1] = new int[2]; // array 2 is 2 item wide
        intJArray[0][2] = 3;
        intJArray[1][0] = 5;
        // |     |     |  3  |     | [0] [x] = 
        // |  5  |     |             [1] [x] = 
    }


    public static void MultiDArray()
    {
        int[,] grid = new int[2, 4]; //1 commer , means 2d separes the ds 2 commers means 3d so int[,,]
        grid[0, 1] = 6;
        grid[1, 0] = 8;
        grid[1, 3] = 10;
    }

    public static void OneDArray()
    {
        int[] newIntArray = { 12, 34, 12, 45, 56 };

        //newIntArray.OrderBy(x => x); //asceding
        //newIntArray.OrderByDescending(x => x); //desceding
        //Array.Reverse(newIntArray); //reverses the order
        //Array.ForEach (newIntArray, x => Console.WriteLine(x)); // pints all items
        //var traineeArray = new string[] { "David", "Marian", "Stanni" };
        //var traineeArray2 = new string[3];
        //traineeArray[0] = "Jab";
        //traineeArray[1] = "James";
        //traineeArray[2] = "Laura";
        //lines above replacing item 0 - david with jab, item 1 marian - james and item 2 - stanni with laura
        //traineeArray[3] = "bob" won't round //out of bounds exception

    }

    public static void ParshingString()
    {
        ///Parse
        //Console.WriteLine("How many apples");
        //string input = Console.ReadLine();
        //int apples = Int32.Parse(input);
        //Console.WriteLine($"{apples} apples");

        ///Try parse returns a bool, uses out int x to return the int if sucessful;
        bool isSuccess;
        ConsoleKeyInfo cki;
        do
        {
            Console.WriteLine("How many apples");
            string input = Console.ReadLine();
            isSuccess = Int32.TryParse(input, out int apples); //int apples can be declared in the previous line
            Console.WriteLine($"{apples} apples");
            if (!isSuccess)
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine($"Contiune(Enter) or leave(Esc). {apples}");
            cki = Console.ReadKey();
        } while (cki.Key != ConsoleKey.Escape);
        Console.WriteLine("You didn't enter a valid number");
    }

    public static void StrInterpolation(string str)
    {
        Console.WriteLine("My name is :" + str + " C# list fundamentals ");
        Console.WriteLine($"My name is {str} using interpelation");
    }


    /* Trim off any leading or trailing spaces from myString
    Turn all the characters to Upper Case
    Replace all occurrences of the letters 'L' and 'T' with '*'
    Find the index of the letter 'N', and delete all the characters after it
    Return the result */
    private static string StrExercise(string myString)
    {
        //while (myString.ToCharArray()[0] == ' ')
        //{
        //    myString.Remove(0, 1);
        //}
        //while (myString.ToCharArray()[myString.Length-1] == ' ')
        //{
        //    myString.Remove(myString.Length-1, 1);
        //}


        //myString = myString.Trim();
        //myString = myString.ToUpper();
        //myString = myString.Replace('L', '*');
        //myString = myString.Replace('T', '*');
        //int nPos = myString.IndexOf('N');
        //myString = myString.Remove(nPos + 1);

        // trim upper replace is creating a new string
        myString = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
        int nPos = myString.IndexOf('N');
        //will split the string
        myString = myString.Remove(nPos + 1);
        //thus making 
        //myString = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*').Remove(nPos + 1);
        //not run as we are creating a bunch of new string then  substring it so it is 2 diffrent operation in 1 line
        return myString;
    }

    //Alternative to above using stringbuilders
    private static string StrBuilderExercise(string myString)
    {
        myString = myString.Trim().ToUpper();
        var nPos = myString.IndexOf('N');
        StringBuilder sb = new StringBuilder(myString);
        sb.Replace('L', '*').Replace('T', '*');
        sb.Remove(nPos + 1, sb.Length - nPos - 1);
        sb.Append (" and is better than c++ & java");
        return sb.ToString();
    }
    //avoid creating multiple string objects
    


}