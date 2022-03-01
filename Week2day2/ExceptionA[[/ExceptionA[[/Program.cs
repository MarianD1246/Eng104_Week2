using System;

namespace ExceptionsApp;

public class Program
{
    public static void Main(string[] args)
    {
        //string text;
        //string fileName = "HelloWorld.txt";

        //try
        //{
        //    text = File.ReadAllText(fileName);
        //    Console.WriteLine(text);
        //}
        //catch (FileNotFoundException ex)
        //{
        //    Console.WriteLine("Sorry I can't find " + fileName);
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine("You gave me an empty file name");
        //}
        //finally
        //{
        //    Console.WriteLine("I'm always running whatvever happnes ");
        //}
        try
        {
            Console.WriteLine("MD's mark is 82 " + Grade(82));
            Console.WriteLine("Nish's mark is -23 " + Grade(-23));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Invalid data, please try again");
            Console.WriteLine(ex.Message);
        }
        int num1 = 5;
        int num2 = 0;
    }

    public static string Grade(int mark)
    {
        if (mark < 0 || mark > 100)
            throw new ArgumentOutOfRangeException($"Mark: {mark} Allowed range is 0-100" );
        return mark >= 65 ? (mark >= 85 ? "Disctinction" : "Pass") : "Fail";

    }
}
