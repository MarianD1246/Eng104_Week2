namespace ControlFlowApp;

public class Program
{
    public static void Main(string[] args)
    {
        int mark = 82;
        var grade = NewMethod(mark);

        var nums = new List<int> { 10,6,22,-17,3};
        Console.WriteLine("Highest foreach: " + LoopTypes.HighestForEachLoop(nums));
        Console.WriteLine("Highest for loop: " + LoopTypes.HighestForLoop(nums));
        Console.WriteLine("Highest while loop: " + LoopTypes.HighestWhileLoop(nums));
        Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
        
    }

    public static string DrivingAge(int age)
    {
        switch (age)
        {
            case < 18:
                return "Cannot legally drive";
                
            case < 23:
                return "Can legally drive, but can't hire a car";

           default: return "Can legally drive and rend a car";

        }
    }

    public static string Priority(int level)
    {
        string priority = "Code ";
        switch (level)
        {
            case 3:
                priority += "Red";
                break;
            case 2:
            case 1:
                priority += "Amber";
                break;
            case 0:
                priority += "Green";
                break;

            default:
                priority = "Error";
                break; 
        }

        return priority;
    }

    private static string NewMethod(int mark)
    {
        //var grade = mark >= 65? "Pass" : "Fail";

        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }
}