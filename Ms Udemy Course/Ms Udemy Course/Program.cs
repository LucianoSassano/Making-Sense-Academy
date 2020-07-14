using Ms_Udemy_Course.Section5;
using Ms_Udemy_Course.Section6;
using Ms_Udemy_Course.Section8;
using Ms_Udemy_Course.Section9;
using System;

namespace Ms_Udemy_Course
{
    class Program
    {
        static void Main(string[] args)
        {

            var option = 0;
            Console.WriteLine("Welcome", Environment.NewLine);
            Console.WriteLine("Enter a number corresponding to the displayed options: ", Environment.NewLine);
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Section N ° 5 Excercises");
            Console.WriteLine("2 - Section N ° 6 Excercises");
            Console.WriteLine("3 - Section N ° 8 Excercises");
            Console.WriteLine("4 - Section N ° 9 Excercises");




            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {

                case 0:
                    Console.WriteLine("Exiting the program");
                    Console.Clear();
                    Environment.Exit(0);
                    break;

                case 1:
                    Console.Clear();
                    MenuSection5 menuSection5 = new MenuSection5();
                    menuSection5.displayMenu();
                    break;

                case 2:
                    Console.Clear();
                    MenuSection6 menuSection6 = new MenuSection6();
                    menuSection6.displayMenu();
                    break;

                case 3:
                    Console.Clear();
                    MenuSection8 menuSection8 = new MenuSection8();
                    menuSection8.displayMenu();
                    break;

                case 4:
                    Console.Clear();
                    MenuSection9 menuSection9 = new MenuSection9();
                    menuSection9.displayMenu();
                    break;

                default:
                    Console.WriteLine("Invalid option ,exiting the program");
                    Console.Clear();
                    Environment.Exit(0);
                    break;

            }


        }
    }
}
