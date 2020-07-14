

using System;
using System.Linq;

namespace Ms_Udemy_Course.Section6
{
    public class nameCollectionNoDuplicates
    {

        public nameCollectionNoDuplicates() { }


        public void displayUniqueNumbers()
        {

            int uniqueCounter = 0;
            int[] numberArray = new int[5];

            while (uniqueCounter < 5)
            {

                Console.WriteLine("Enter a number");

                int number = Convert.ToInt32(Console.ReadLine());

                if (numberArray.Contains(number))
                {
                    Console.WriteLine("This number already exists");
                }

                if (!numberArray.Contains(number))
                {

                    numberArray[uniqueCounter] = number;
                    uniqueCounter += 1;

                }
            }

            foreach (int number in numberArray)
            {
                Console.WriteLine("Value in unique integers array° -> " + number );
            }

        }
    }
}
