using System;

namespace StaticClassesApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Trainee.GetNumberOfTrainees());
        var nishMan = new Trainee
        {
            Course = "Java Dev",
            Name = "Nish Mandal",
            Age = 30
        };

        var maDum = new Trainee
        {
            Course = "C# Dev",
            Name = "Marian Dumitriu",
            Age = 23
        };
        Console.WriteLine($"{maDum.Name} {maDum.Age} {maDum.Course}" );
        Console.WriteLine($"{nishMan.Name} {nishMan.Age} {nishMan.Course}");
        Console.WriteLine(maDum.SayHello());
        Console.WriteLine(Trainee.GetNumberOfTrainees());
    }
}

public class Trainee
{
    public string Course { get; set; } 
    public string Name { get; set; }    
    public int Age { get; set; }

    private static int _noOfTrainees = 0;

    public Trainee()
    {
        _noOfTrainees++;
    }

    public static int GetNumberOfTrainees()
    {
        return _noOfTrainees;
    }

    public string SayHello()
    {
        return "Hello";
    }
}

//static class can only contain static members and properties
public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}