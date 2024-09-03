using System;

namespace Exceptions_Adkisson_Damien
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0.0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                /// it is making the number other than zero.
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero.");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                try
                {
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e.Message);
                }
            }
            finally
            {
                /// calculations give u results.
                Console.WriteLine("Calculations completed with a result of " + result);
            }

            try
            {
                CheckAge(myInt);
            }
            catch (Exception e)
            {
                /// not old enough for certain games.
                Console.WriteLine($"You are {myInt}, not old enough!");
            }

            static float Divide(float x, float y)
            {
                if (y == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    return x / y;
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="x"></param>
            ///<param name="y"></param>
            /// <returns></returns>
            static void CheckAge(int age)
            {
                if (age >= 17)
                {
                    /// it allows u to play mature games.
                    Console.WriteLine($"Age {age}, you can play mature games!");
                }
                else
                {
                    throw new ArgumentException();
                }
            }










        }
    }
}