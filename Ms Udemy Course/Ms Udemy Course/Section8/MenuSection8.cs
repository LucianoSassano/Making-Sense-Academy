using System;


namespace Ms_Udemy_Course.Section8
{
    public class MenuSection8
    {
        public MenuSection8() { }


        public void displayMenu()
        {

            Console.WriteLine("Section N ° 8");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - hyphenSeparatedIntList");
            Console.WriteLine("2 - hyphenListCheckDuplicate");
            Console.WriteLine("3 - userTimeInput");



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
                    consecutiveHyphenIntList consecutiveHyphen = new consecutiveHyphenIntList();
                    consecutiveHyphen.generateHyphenList();
                    break;

                case 2:
                    Console.WriteLine("Excercise N ° 2");
                    hyphenListDuplicateCheck hyphenListDuplicate = new hyphenListDuplicateCheck();
                    hyphenListDuplicate.checkUserInput();
                    break;

                case 3:
                    Console.WriteLine("Excercise N ° 3");
                    userTimeInput timeInput = new userTimeInput();
                    timeInput.checkTimeInput();
                    break;

                case 4:
                    Console.WriteLine("Excercise N ° 4");
                    wordToPascalCase wordToPascal = new wordToPascalCase();
                    wordToPascal.changeWord();
                    break;

                case 5:
                    Console.WriteLine("Excercise N ° 5");
                    countVowelsInWord countVowels = new countVowelsInWord();
                    countVowels.checkVowels();
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
