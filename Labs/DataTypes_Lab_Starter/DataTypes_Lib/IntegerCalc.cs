using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            checked
            {
                return  num1 + num2;
            }
        }

        public static int Subtract(int num1, int num2)
        {
            checked
            {
                return num1 - num2;
            }
        }

        public static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }


        //test case is whole number | realistcly data type should be decimal/double/float
        public static int Divide(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException)
            {
                //Handle the exception e.g throws a diffrent exception or fixed div by zero exception
                throw new ArgumentException("Can't divide by zero");
            }
        }

        public static int Modulus(int num1, int num2)
        {
            try
            {
                return num1 % num2;
            }
            catch (DivideByZeroException)
            {
                throw new ArgumentException("Can't modulo by zero");
            }
        }
    }
}
