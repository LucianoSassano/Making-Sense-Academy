using System;
using System.Collections.Generic;

namespace Ms_Udemy_Course.Section8
{
    public class countVowelsInWord
    {

        public countVowelsInWord() { }


        public void checkVowels()
        {

            Console.WriteLine("Enter a word");
            var userInput = Console.ReadLine();

            if(String.IsNullOrEmpty(userInput) || String.IsNullOrWhiteSpace(userInput))
            {

                Console.WriteLine("Invalid input");
                return;

            }

            //this can be done with a regex

            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
            var vowelsCount = 0;
            foreach (var character in userInput)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);

        }
    }
}
