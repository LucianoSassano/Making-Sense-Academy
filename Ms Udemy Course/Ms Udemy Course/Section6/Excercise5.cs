using System;
using System.Collections.Generic;


namespace Ms_Udemy_Course.Section6
{
    public class commaSeparatedIntList
    {
        public commaSeparatedIntList() { }


        public void displayThreeSmallest()
        {

            string[] elements;

            while (true)
            {
                Console.WriteLine("Enter a list of comma separated numbers.");
                var input = Console.ReadLine();
                elements = input.Split(',');
                if (!String.IsNullOrEmpty(input))
                {

                    if (elements.Length >= 5)

                        break;
                }
                if (elements.Length < 5)
                {
                    Console.WriteLine("Invalid List. Please try again.");
                }

            }

            var numbers = new List<int>();

            foreach (var number in elements)
            {
                numbers.Add(int.Parse(number));
            }

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }
            Console.WriteLine("Smallest Numbers:");
            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
        }

    }

}

