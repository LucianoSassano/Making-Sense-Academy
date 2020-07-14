using System;
using System.Collections.Generic;


namespace Ms_Udemy_Course.Section8
{
    public class consecutiveHyphenIntList
    {

        public consecutiveHyphenIntList() { }

        public void generateHyphenList()
        {

            Console.WriteLine("Enter as much numbers as you like separated by a hyphen , Ex -> 1-2-3-4 ");
            var userInput = Console.ReadLine();

            var numberList = new List<int>();

            foreach (var number in userInput.Split('-'))
            {
                int stringToInt = Convert.ToInt32(number);
                numberList.Add(stringToInt);


            }

            bool consecutiveFlag = true;

            for (int i = 1; i < numberList.Count; i++)
            {

                if (numberList[i - 1] + 1 != numberList[i])
                {

                    consecutiveFlag = false;
                    break;

                }

            }

            string result = consecutiveFlag ? "Consecutive " : "Not Consecutive";
            Console.WriteLine(result);


        }
    }
}
