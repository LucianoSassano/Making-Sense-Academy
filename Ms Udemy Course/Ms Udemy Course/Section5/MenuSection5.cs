using System;

namespace Ms_Udemy_Course.Section5
{
    public class MenuSection5
    {
        public MenuSection5() { }

        public void displayMenu()
        {

            Console.WriteLine("Section N ° 5 ");
            Console.WriteLine("Enter a number corresponding to the displayed options: ", Environment.NewLine);
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Excercise N ° 1 - rangeDividerCount");
            Console.WriteLine("2 - Excercise N ° 2 - numberInputLoop");
            Console.WriteLine("3 - Excercise N ° 3 - factorialOfANumber");
            Console.WriteLine("4 - Excercise N ° 4 - randomNumberGuess");
            Console.WriteLine("5 - Excercise N ° 5 - getTheMaxOfIntArray");
            int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {

                case 0:
                    Console.WriteLine("Exiting the program");
                    Console.Clear();
                    Environment.Exit(0);
                    break;


                case 1:
                    Console.WriteLine("Excercise N° 1", Environment.NewLine);
                    rangeCounter rangeCounter = new rangeCounter();
                    int result = rangeCounter.count();
                    Console.WriteLine("Result -> " + result);
                    break;

                case 2:
                    Console.WriteLine("Excercise N° 2", Environment.NewLine);
                    ConsoleInputLoop consoleInput = new ConsoleInputLoop();
                    var result2 = consoleInput.userInputCounter();
                    Console.WriteLine("Result -> " +  result2);
                    break;

                case 3:
                    Console.WriteLine("Excercise N° 3");
                    factorialOf factorial = new factorialOf();
                    var result3 = factorial.getTheFactorialOf();
                    Console.WriteLine("Result -> " + result3);
                    break;

                case 4:
                    Console.WriteLine("Excercise N° 4");
                    randomNumberSelection randomNumber = new randomNumberSelection();
                    var result4 = randomNumber.randomNumPicker();
                    Console.WriteLine("Result -> " + result4);
                    break;

                case 5:
                    Console.WriteLine("Excercise N° 5");
                    userSeriesInput userSeries = new userSeriesInput();
                    var result5 = userSeries.returnBiggerNumberofSeries();
                    Console.WriteLine("Biggest number in series -> " + result5);
                    break;

                default:
                    Console.WriteLine("Invalid option, exiting the program");
                    Console.Clear();
                    Environment.Exit(0);
                    break;


            }



        }
    }
}
