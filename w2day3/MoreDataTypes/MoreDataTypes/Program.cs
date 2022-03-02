using System;
using System.Text;

namespace More_DataTypes;

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

        ParshingString();
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