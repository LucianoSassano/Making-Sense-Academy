using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ms_Udemy_Course.Section9
{
    public class readFileReturnLongestWord
    {
     public readFileReturnLongestWord() { }

        public void findLargest()
        {

            string path = @"c:\readTest\textFile.txt";


            if (File.Exists(path))
            {
                int fixedLength = 0;
                string largestWord = "";

                string fileContent = File.ReadAllText(path);
                string[] splitedContent = fileContent.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach(string word in splitedContent) {

                    if (word.Length > fixedLength) {
                        fixedLength = word.Length;
                        largestWord = word;
                    
                    }
                
                }

                Console.WriteLine("Largest word in file -> " + largestWord);


            }


        }
    }
}
