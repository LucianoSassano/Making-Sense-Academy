using System;

namespace Ms_Udemy_Course.Section8
{
    public class wordToPascalCase
    {

        public wordToPascalCase() { }


        public void changeWord()
        {

            Console.WriteLine("Enter a word or a sentence ");
            var userWord = Console.ReadLine();

            if(String.IsNullOrEmpty(userWord)  || String.IsNullOrWhiteSpace(userWord))
            {

                Console.WriteLine("Invalid input , exiting the program");
                return;

            }

            var variableName = "";
            foreach (var word in userWord.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);

        }
    }
}
