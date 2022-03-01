using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(int n)
        {
            //throw new NotImplementedException();
            if (n < 0)
            {
                throw new ArithmeticException("Yeah lets not open the can of worms that is negative factorial plz");
            }

            long sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            } 

            return sum;
        }

        //Float is low precision sugrsting to change to decimal like so
        //public static decimal Mult(float num1, float num2){ return (decimal) (num1* num2);}
        //if changed applied change test case back to 6.30000f
        public static float Mult(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
