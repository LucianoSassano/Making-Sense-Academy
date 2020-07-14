using System;


namespace Ms_Udemy_Course.Section6
{
    public class MenuSection6
    {

        public MenuSection6() { }


        public void displayMenu()
        {

            Console.WriteLine("Section N ° 6 ");
            Console.WriteLine("Enter a number corresponding to the displayed options: ", Environment.NewLine);
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Excercise N ° 1 - facebookPost");
            Console.WriteLine("2 - Excercise N ° 2 - nameReverse");
            Console.WriteLine("3 - Excercise N ° 3 - numberListNoDuplicates ");
            Console.WriteLine("4 - Excercise N ° 4 - numberListDuplicateFilter");
            Console.WriteLine("5 - Excercise N ° 5 - commaSeparatedNumberList");
            int option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {


                case 0:
                    Console.WriteLine("Exiting the program");
                    Console.Clear();
                    Environment.Exit(0);
                    break;


                case 1:
                    Console.WriteLine("Excercise N° 1");
                    FacebookInteraction facebook = new FacebookInteraction();
                    facebook.PostNotification();
                    break;


                case 2:
                    Console.WriteLine("Excercise N ° 2");
                    nameInputReverse nameInputReverse = new nameInputReverse();
                    string result = nameInputReverse.nameReverse();
                    Console.WriteLine("resultados -> " + result);
                    break;

                case 3:
                    Console.WriteLine("Excercise N ° 3");
                    nameCollectionNoDuplicates nameCollection = new nameCollectionNoDuplicates();
                    nameCollection.displayUniqueNumbers();
                    break;

                case 4:
                    Console.WriteLine("Excercise N ° 4");
                    numberCollectionFilterDuplicates numberCollectionFilter = new numberCollectionFilterDuplicates();
                    numberCollectionFilter.listNumbers();
                    break;

                case 5:
                    Console.WriteLine("Excercise N ° 5");
                    commaSeparatedIntList commaSeparated = new commaSeparatedIntList();
                    commaSeparated.displayThreeSmallest();
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
