
using System;

namespace Ms_Udemy_Course.Section5
{
    public class randomNumberSelection
    {

        private readonly Random _random = new Random();
        public randomNumberSelection() { }

        public int randomNumPicker()
        {

            int num = 0;
            int attempts = 1;

            num = _random.Next(1, 10);
            int iAttempts = 4;

            for (int i = 0; i < iAttempts; i++)
            {


                Console.WriteLine("Attempt N° " + attempts + " of 4 total ", Environment.NewLine);
                Console.WriteLine("Enter a number between 1 and 10");
                int userInput = int.Parse(Console.ReadLine());
                attempts++;

                if (userInput == num)
                {

                    Console.WriteLine("You Won!");
                    iAttempts = 0;

                }

                if (userInput != num)
                {

                    Console.WriteLine("You lost ,try again");

                }
            }

            return num;

        }


    }


}

