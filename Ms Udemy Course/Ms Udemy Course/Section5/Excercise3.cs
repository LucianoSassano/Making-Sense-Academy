
using System;

namespace Ms_Udemy_Course.Section5
{
    public class factorialOf
    {

        public factorialOf() { }

        public int getTheFactorialOf()
        {

            int result = 1, number;

            Console.WriteLine("Ingrese un numero:");

            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {

                result = result * i;

            }


            return result;
        }
    }
}
