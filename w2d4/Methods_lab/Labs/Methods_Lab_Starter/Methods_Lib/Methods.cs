using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0) throw new ArgumentOutOfRangeException(String.Format("totalDays must not be negative"));
            return (weeks: totalDays / 7, days: totalDays % 7);
        }

        public static (int square, int cube, double root) PowersRoot(int userNumber)
        {
            return (square: Convert.ToInt32(Math.Pow(userNumber,2)), cube: Convert.ToInt32(Math.Pow(userNumber, 3)), root: Math.Sqrt(userNumber));
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}
