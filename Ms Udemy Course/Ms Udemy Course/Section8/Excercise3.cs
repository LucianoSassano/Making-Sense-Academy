using System;
using System.Collections.Generic;
using System.Text;

namespace Ms_Udemy_Course.Section8
{
    public class userTimeInput
    {

        public userTimeInput() { }

        public void checkTimeInput()
        {

            Console.WriteLine("Enter a 24 hour format time value, Ex -> 00:00 or 23:59");
            var timeInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(timeInput) || String.IsNullOrEmpty(timeInput))
            {

                Console.WriteLine("Invalid Time");
                return;
            }

            var numbers = timeInput.Split(':');
            if (numbers.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            int hours;
            var parseHourse = int.TryParse(numbers[0], out hours);

            int minutes;
            var parseMinutes = int.TryParse(numbers[0], out minutes);


            if (parseHourse == true && parseMinutes == true)
            {


                if (hours >= 00 || hours <= 23 && minutes >= 00 || minutes <= 59)
                {


                    Console.WriteLine("OK");


                }

                if (!(hours >= 00) || !(hours <= 23) && !(minutes >= 00) || !(minutes <= 59))
                {


                    Console.WriteLine("Invalid Time");


                }

            }


        }
    }
}
