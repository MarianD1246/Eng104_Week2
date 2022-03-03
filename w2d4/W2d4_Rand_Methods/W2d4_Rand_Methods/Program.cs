using System;

namespace Methods;

public class Program
{
    public static void Main(string[] args)
    {
        //SEEDING RNG with current time in ticks
        //var rng = new Random();
        //var rngSeeded = new Random(42);
        //var between1And10 = rngSeeded.Next(1,11);
        //Console.WriteLine(between1And10);

        //var rollDice1 = rng.Next(1, 7);
        //var rollDice2 = rng.Next(1, 7);
        //var rollDice3 = rng.Next(1, 7);
        //Console.WriteLine($"r1:{rollDice1} r2:{rollDice2} r3:{rollDice3} total: {rollDice1 + rollDice2 + rollDice3}" );


        //int y = 10;
        //int[] arr = new int[] { 1, 2, 3 };
        //var result = DoThis(y, "Sad", arr);
        //int y is a copy
        //the array is reference, just like sharing a book
        //DoThis changed 1 to 30 but not y;
        //onsole.WriteLine(y);
        //Array.ForEach(arr, x => Console.WriteLine(x));
        //var result = DoThis(y, "Happy");
        //var r1 = DoThis(y);

        //var myPizza = OrderPizaa(true, false);
        //var myPizza = OrderPizaa(anchovies: true, pinnaple: false);//can use method parameter to know what we are refering to
        //Console.WriteLine(myPizza);

        //Console.WriteLine("Please enter your pizza number (1/0):");
        //string order = Console.ReadLine();
        //bool[] toopings = new bool[4];
        //int i = 0;
        //foreach (char c in order)
        //{
        //    string b = c.ToString();
        //    if (Int32.TryParse(b,out int a) == true)
        //    {
        //        toopings[i] = true;
        //    }
        //    i++;
        //}
        //var mypizza = MyOrderPizaa(toopings[0], toopings[1], toopings[2], toopings[3]);
        //Console.WriteLine(mypizza);

        //int yi = 10, zi = 10;
        //Add(yi);
        //Console.WriteLine(yi);
        //Add(ref zi);
        //ref keyword memory address of variable, not just a copy
        //ref is not a pointer
        //Console.WriteLine(zi);
        //bool islarge;
        //var result = DoThis(10, "Here's a string", out islarge);
        //ref in out give the value's memory location, by default a copy is passed to method;

        //tuple
        //light weight way of grouping objects,class,structs,interface
        //declating tuple
        //var myTuple = ( "Bob ", true, 21 );
        //Console.WriteLine(myTuple);
        //var myTupleNamed = (name: "Bob ", isMarried: true, age: 27);
        //Console.WriteLine(myTupleNamed); //same thing but is named so we know what each type represents
        //(string name, bool isMaried, int age) myTuple2 = ("Tim", false, 21);
        //var name = myTuple2.name;
        //var myTuple3 = ("Andrei", "Noel");

        var result = ConvertPtoS(99);
        Console.WriteLine(result);
        Console.WriteLine(result.stones);
    }

    public static (int stones, int pounds) ConvertPtoS(int pounds)
    {
        const int poundsInAStone = 14;
        var st = pounds / poundsInAStone;
        var lb = pounds % poundsInAStone;
        var result = (st, lb);
        //return (st,lb);
        return result;
    }

    public static int DoThis(int x, string y,out bool z) 
    {
        Console.WriteLine(y);
        z = (x > 10);
        return x * x;
    }

    public static void Add(int num)
    {
        num++;
    }

    public static void Add(ref int num)
    {
        num++;
    }


    public static string OrderPizaa(bool anchovies, bool pinnaple, bool mushrooms = false)
    {
        var pizza = "Pizza with tomato sauce chese ";
        if (anchovies) { pizza += " anchovies "; }
        if (pinnaple) { pizza += " pineaple "; }
        if (mushrooms) { pizza += " mushrooms "; }
        return pizza;
    }

    public static string MyOrderPizaa(bool anchovies,bool pinnaple, bool mushrooms, bool peperoni)
    {
        var pizza = "Pizza with tomato sauce chese ";
        if (anchovies) { pizza += " anchovies "; }
        if (pinnaple) { pizza += " pineaple "; }
        if (mushrooms) { pizza += " mushrooms "; }
        if (peperoni) { pizza += " peperoni "; }
        return pizza;
    }



    public static int DoThis(int x, string y, int[] arr)
    {
        Console.WriteLine($"I'm feeling {y} today.");
        arr[0] = 30; 
        x = 3;
        return x * x;
    }
    //by making string y = happy, y is a optional parameter, you don't need to proide
    // happy is default value of y;
    public static int DoThis(int x, string y = "Happy")
    {
        Console.WriteLine($"I'm feeling {y} today.");
        return x * x;
    }
}