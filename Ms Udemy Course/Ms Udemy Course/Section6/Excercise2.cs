

using System;

namespace Ms_Udemy_Course.Section6
{
    public class nameInputReverse
    {

        public string nameReverse()
        {


            Console.WriteLine("Enter a name ");
            string optionInput = Console.ReadLine();

            char[] name = optionInput.ToCharArray();
            Array.Reverse(name);
            return new string(name);
        }
    }
}
