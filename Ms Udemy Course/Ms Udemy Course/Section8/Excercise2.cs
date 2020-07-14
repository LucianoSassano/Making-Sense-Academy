

using System;
using System.Collections.Generic;

namespace Ms_Udemy_Course.Section8
{
    public class hyphenListDuplicateCheck
    {
        public hyphenListDuplicateCheck() { }

        public void checkUserInput()
        {

            Console.WriteLine("Enter as much numbers as you like separated by a hyphen , Ex -> 1-2-3-4 ");
            var userInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.Clear();
                Environment.Exit(0);
            }

            var numberList = new List<int>();

            foreach (var number in userInput.Split('-'))
            {
                int stringToInt = Convert.ToInt32(number);
                numberList.Add(stringToInt);

            }

            var uniqueNumbers = new List<int>();

            foreach (int number in numberList)
            {

                if (!uniqueNumbers.Contains(number))
                {

                    uniqueNumbers.Add(number);
                }

                if (uniqueNumbers.Contains(number))
                {


                    Console.WriteLine("Duplicate");
                    break;


                }


            }


        }
    }
}
