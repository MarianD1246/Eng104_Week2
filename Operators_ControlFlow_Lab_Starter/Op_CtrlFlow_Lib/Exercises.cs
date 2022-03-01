using System;
using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
            //if the 2 numbers are diffrent check to see if num 2 is a factor of num 1
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;
            
            double sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            if (5 > age && age >= 0)
                return "Free";

            else if (13 > age && age >= 5)
                return "Child";

            else if (18 > age && age >= 13)
                return "Student";

            if (60 > age && age >= 18)
                return "Standard";

            else
                return "OAP";
        }


        /*  | 75 to 100 | "Pass with Distinction" |
            | --------: | ----------------------- |
            |  60 to 74 | "Pass with Merit"       |
            |  40 to 59 | "Pass"                  |
            |   0 to 39 | "Fail"                  |  */
        public static string Grade(int mark)
        {
            if (0 > mark || mark > 100)
                //return "Parameter out of bounds";
                throw new ArgumentOutOfRangeException();

            else if (75 <= mark)
                return "Pass with Distinction";

            else if (60 <= mark)
                return "Pass with Merit";

            else if (40 <= mark)
                return "Pass";

            else return "Fail";

            //return 0 > mark || mark > 100 ? "Pareneter out of bounds" :
            //    75 <= mark ? "Pass with Distinction" : 60 <= mark ? "Pass with Merit" :
            //    40 <= mark ? "Pass" : "Fail";
         }

        /*  | Level | Max attendees |
            | ----: | ------------- |
            |     4 | 20            |
            |     3 | 50            |
            |     2 | 50            |
            |     1 | 100           |
            |     0 | 200           |  */
        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            switch (covidLevel) 
            {
                case 4:
                    return 20;
                case 3:
                case 2:
                    return 50;
                case 1:
                    return 100;
                case 0:
                    return 200;
                default:
                    return 0;

                //4 => 20,
                //3 or 2 => 50,
                //1 => 100,
                //0 => 200,
                //_ => 0,
                //exresion body lambdas
            }
        }
    }
}
