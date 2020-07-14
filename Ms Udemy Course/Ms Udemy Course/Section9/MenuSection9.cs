using System;


namespace Ms_Udemy_Course.Section9
{
    public class MenuSection9
    {

        public MenuSection9() { }

        public void displayMenu()
        {
            Console.WriteLine("Section N ° 9");
            Console.WriteLine("Enter a number corresponding to the displayed options: ", Environment.NewLine);
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - ReadFileReturnWordsAmount");
            Console.WriteLine("2 - ReadFileReturnLargestWord");

            int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {

                case 0:
                    Console.WriteLine("Exiting the program");
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                case 1:
                    Console.WriteLine("Excercise N ° 1");
                    fileTextCounter fileTextCounter = new fileTextCounter();
                    fileTextCounter.readAndReturnAmount();
                    break;

                case 2:
                    Console.WriteLine("Excercise N ° 2");
                    readFileReturnLongestWord readFileReturnLongest = new readFileReturnLongestWord();
                    readFileReturnLongest.findLargest();
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
