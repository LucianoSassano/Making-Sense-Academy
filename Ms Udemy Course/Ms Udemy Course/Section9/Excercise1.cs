using System;
using System.IO;
using System.Linq;

namespace Ms_Udemy_Course.Section9
{
    public class fileTextCounter
    {

        public fileTextCounter() { }


        public void readAndReturnAmount() {

            string path = @"c:\readTest\textFile.txt";

            if (File.Exists(path)) {

                string fileContent = File.ReadAllText(path);
                string[] splitedContent = fileContent.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                int totalWords = splitedContent.Count();

                Console.WriteLine("Total words in file = " + totalWords);
            }
        }
    }
}
